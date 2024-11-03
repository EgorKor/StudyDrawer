using StudyDrawer.DomainCode.Graphic;
using StudyDrawer.DomainCode.Notes;
using StudyDrawer.Forms.ImageForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyDrawer.Forms
{
    public partial class EditImageForm : Form
    {
        private Graphics _graphics;
        private Pen _pen;
        private Boolean _isDrawing;
        private Point _lastPoint;
        private Cursor _flushCursor;
        private Cursor _currentEditCursor;
        private Node<IFigure> _figuresHead;
        private Node<IFigure> _figuresTail;
        private GrapicsOperation _currentOperation;
        private Color _backgroundColor;
        private int _flushWidth;
        private List<Point> _splinePoints;
        private List<Rectangle> _flushRectangles;
        private int _imageWidth;
        private int _imageHeight;
        private Image _buffer;
        private bool _isSaved;
        private bool _isCanceled;
        private Image _basicImage,_basicImageCopy;
        private bool _isCleared;


        public EditImageForm(Image basicImage)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;


            _currentEditCursor = Cursors.Cross;
            _pen = new Pen(Color.Black, 5.0f);
            _flushCursor = new Cursor(@"../../../Resources/Eraser.cur");
            EditPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            _currentOperation = GrapicsOperation.OP_DRAW_SPLINE;
            _splinePoints = new List<Point>();
            _backgroundColor = EditPictureBox.BackColor;
            _flushWidth = 10;
            _flushRectangles = new List<Rectangle>();
            _basicImage = basicImage;
        }

        private void EditImageForm_Load(object sender, EventArgs e)
        {
            MinimumSize = Size;
            MaximumSize = Size;
            EditPictureBox.Image = _basicImage;
            _imageHeight = EditPictureBox.Height;
            _imageWidth = EditPictureBox.Width;
            _buffer = new Bitmap(_basicImage,_imageWidth, _imageHeight);
            _graphics = Graphics.FromImage(_buffer);
            _graphics.SmoothingMode =
                System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        public Image ShowEditImageFormDialog()
        {
            ShowDialog();
            if (_isCanceled)
            {
                return _basicImage;
            }
            return _buffer;
        }

        private void ClearAndDrawFigures()
        {
            if (_isCleared)
            {
                _graphics.Clear(Color.White);
            }
            else
            {
                _buffer = new Bitmap(_basicImage, _imageWidth, _imageHeight);
                EditPictureBox.Image = _buffer;
                ReinitGraphics(EditPictureBox.Image);
            }
            if (_figuresTail == null)
            {
                EditPictureBox.Image = _buffer;
                return;
            }
            Node<IFigure> pointer = _figuresHead;
            while (pointer != _figuresTail)
            {
                if (pointer.Data is Flush)
                {
                    pointer.Data.Draw(_graphics, _backgroundColor);
                }
                else
                {
                    pointer.Data.Draw(_graphics);
                }
                pointer = pointer.Next;
            }
            if (_figuresTail != null)
            {
                if (pointer.Data is Flush)
                {
                    pointer.Data.Draw(_graphics, _backgroundColor);
                }
                else
                {
                    pointer.Data.Draw(_graphics);
                }
            }
            EditPictureBox.Image = _buffer;
            GC.Collect();
        }

        private void EditPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (_currentOperation != GrapicsOperation.OP_FLUSH)
                {
                    Cursor.Hide();
                }
                _isDrawing = true;
            }
        }

        private void EditPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDrawing)
            {
                switch (_currentOperation)
                {
                    case GrapicsOperation.OP_DRAW_SPLINE:
                        {
                            if (_lastPoint.X != 0 && _lastPoint.Y != 0)
                            {
                                _graphics.DrawLine(_pen, _lastPoint, e.Location);

                            }
                            _graphics.FillEllipse(new SolidBrush(_pen.Color), e.X - _pen.Width / 2, e.Y - _pen.Width / 2, _pen.Width - 1, _pen.Width - 1);
                            _lastPoint = e.Location;
                            EditPictureBox.Image = _buffer;
                            _splinePoints.Add(e.Location);
                            break;
                        }
                    case GrapicsOperation.OP_FLUSH:
                        {
                            if (e.Location.X != 0 && e.Location.Y != 0)
                            {
                                Rectangle flushRect = new Rectangle(e.Location.X - _flushWidth, e.Location.Y - _flushWidth, _flushWidth, _flushWidth);
                                _graphics.FillRectangle(new SolidBrush(_backgroundColor), flushRect);
                                EditPictureBox.Image = _buffer;
                                _flushRectangles.Add(flushRect);
                            }
                            break;
                        }
                }

            }
        }

        private void EditPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            _isDrawing = false;
            _lastPoint.X = 0;
            _lastPoint.Y = 0;
            if (_currentOperation != GrapicsOperation.OP_FLUSH)
            {
                Cursor.Show();
            }
            if (_currentOperation == GrapicsOperation.OP_DRAW_SPLINE)
            {
                AddFigure(new Spline(_pen, _splinePoints));
                _splinePoints.Clear();
            }
            if (_currentOperation == GrapicsOperation.OP_FLUSH)
            {
                AddFigure(new Flush(_flushRectangles, _backgroundColor));
                _flushRectangles.Clear();
            }
        }

        private void AddFigure(IFigure figure)
        {
            if (_figuresTail == null)
            {
                _figuresHead = new Node<IFigure>()
                {
                    Data = figure
                };
                _figuresTail = _figuresHead;
            }
            else
            {
                Node<IFigure> newNode = new Node<IFigure>()
                {
                    Data = figure,
                    Prev = _figuresTail
                };

                if (_figuresTail.Next != null)
                {
                    DeleteNextNodes(_figuresTail);
                }
                _figuresTail.Next = newNode;
                _figuresTail = newNode;
            }
        }

        private void DeleteNextNodes(Node<IFigure> current)
        {
            if (current == null)
            {
                return;
            }
            Node<IFigure> next = current.Next;
            while (next != null)
            {
                next.Prev = null;
                current = next;
                next = next.Next;
                current.Next = null;
            }
            GC.Collect();

        }

        private void StepBack()
        {
            if (_figuresTail == null)
            {
                return;
            }
            if (_figuresTail.Prev != null)
            {
                _figuresTail = _figuresTail.Prev;
                ClearAndDrawFigures();
            }
            else
            {
                _figuresTail = null;
                ClearAndDrawFigures();
            }
        }

        private void StepForward()
        {
            if (_figuresTail == null)
            {
                if (_figuresHead != null)
                    _figuresTail = _figuresHead;
                ClearAndDrawFigures();
                return;
            }
            if (_figuresTail.Next != null)
            {
                _figuresTail = _figuresTail.Next;
                ClearAndDrawFigures();
            }
            else
            {
                return;
            }
        }

        private void ReinitGraphics(Image image)
        {
            _graphics.Dispose();
            _graphics = Graphics.FromImage(image);
            _graphics.SmoothingMode =
            System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        private void PenColorButton_Click(object sender, EventArgs e)
        {
            PenColorDialog.ShowDialog();
            PenColorButton.BackColor = PenColorDialog.Color;
            _pen.Color = PenColorDialog.Color;
        }

        private void BackgroundColorButton_Click(object sender, EventArgs e)
        {
            BackgroundColorDialog.ShowDialog();
            BackgroundColorButton.BackColor = BackgroundColorDialog.Color;
            _backgroundColor = BackgroundColorDialog.Color;
            ClearAndDrawFigures();
        }

        private void EditPictureBox_MouseEnter(object sender, EventArgs e)
        {
            Cursor = _currentEditCursor;
        }

        private void EditPictureBox_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void FlushButton_Click(object sender, EventArgs e)
        {
            _currentEditCursor = _flushCursor;
            _currentOperation = GrapicsOperation.OP_FLUSH;
        }

        private void PenButton_Click(object sender, EventArgs e)
        {
            _currentEditCursor = Cursors.Cross;
            _currentOperation = GrapicsOperation.OP_DRAW_SPLINE;
        }


        private void PenWidthNumeric_ValueChanged(object sender, EventArgs e)
        {
            _pen.Width = (int)PenWidthNumeric.Value * 5;
        }

        private void FlushWidthNumeric_ValueChanged(object sender, EventArgs e)
        {
            _flushWidth = (int)FlushWidthNumeric.Value * 10;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            StepBack();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            StepForward();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DeleteNextNodes(_figuresHead);
            _figuresHead = null;
            _figuresTail = null;
            _isCleared = true;
            ClearAndDrawFigures();
        }


        private void EditImageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isSaved && !_isCanceled)
            {
                DialogResult result = MessageBox.Show("Сохранить результат работы?", "Предупреждение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);
                switch (result)
                {
                    case DialogResult.Yes:
                        {
                            _isSaved = true;
                            break;
                        }

                    case DialogResult.No:
                        {
                            _isCanceled = true;
                            break;
                        }
                    case DialogResult.Cancel:
                        {
                            e.Cancel = true;
                            break;
                        }
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _isSaved = true;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _isCanceled = true;
            Close();
        }
    }
}
