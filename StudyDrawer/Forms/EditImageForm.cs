using StudyDrawer.DomainCode.Graphic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        private Node<IFigure>[] _figuresHead;
        private Node<IFigure>[] _figuresTail;
        private GrapicsOperation _currentOperation;
        private Color _backgroundColor;
        private int _flushWidth;
        private List<Point> _splinePoints;
        private List<Rectangle> _flushRectangles;
        private int _figureCount;
        private int _imageWidth;
        private int _imageHeight;
        private List<Image> _images;
        private int _imageIndex;

        public EditImageForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;


            _currentEditCursor = Cursors.Cross;
            _pen = new Pen(Color.Black, 5.0f);
            _flushCursor = new Cursor(@"../../../Resources/Eraser.cur");

            _currentOperation = GrapicsOperation.OP_DRAW_SPLINE;
            _splinePoints = new List<Point>();
            _backgroundColor = EditPictureBox.BackColor;
            _flushWidth = 10;
            _flushRectangles = new List<Rectangle>();
        }

        private void EditImageForm_Load(object sender, EventArgs e)
        {
            MinimumSize = new Size(Size.Width, Size.Height);
            MaximumSize = new Size(Size.Width, Size.Height);
            _imageIndex = 0;
            _images = new List<Image>();
            _imageHeight = EditPictureBox.Height;
            _imageWidth = EditPictureBox.Width;
            _figuresHead = new Node<IFigure>[10];
            _figuresTail = new Node<IFigure>[10];  
            for (int i = 0; i < 10; i++)
            {
                _images.Add(new Bitmap(_imageWidth, _imageHeight));
            }
            _graphics = Graphics.FromImage(_images[0]);
            _graphics.SmoothingMode =
                System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            
            
            
        }

        private void ClearAndDrawFigures()
        {
            _graphics.Clear(_backgroundColor);
            if (_figuresTail[_imageIndex] == null)
            {
                EditPictureBox.Image = _images[_imageIndex];
                return;
            }
            Node<IFigure> pointer = _figuresHead[_imageIndex];
            while (pointer != _figuresTail[_imageIndex])
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
            if (_figuresTail[_imageIndex] != null)
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
            EditPictureBox.Image = _images[_imageIndex];
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
                            EditPictureBox.Image = _images[_imageIndex];
                            _splinePoints.Add(e.Location);
                            break;
                        }
                    case GrapicsOperation.OP_FLUSH:
                        {
                            if (e.Location.X != 0 && e.Location.Y != 0)
                            {
                                Rectangle flushRect = new Rectangle(e.Location.X - _flushWidth, e.Location.Y - _flushWidth, _flushWidth, _flushWidth);
                                _graphics.FillRectangle(new SolidBrush(_backgroundColor), flushRect);
                                EditPictureBox.Image = _images[_imageIndex];
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
            _figureCount++;
        }

        private void AddFigure(IFigure figure)
        {
            if (_figuresTail[_imageIndex] == null)
            {
                _figuresHead[_imageIndex] = new Node<IFigure>()
                {
                    Data = figure
                };
                _figuresTail[_imageIndex] = _figuresHead[_imageIndex];
            }
            else
            {
                Node<IFigure> newNode = new Node<IFigure>()
                {
                    Data = figure,
                    Prev = _figuresTail[_imageIndex]
                };

                if (_figuresTail[_imageIndex].Next != null)
                {
                    DeleteNextNodes(_figuresTail[_imageIndex]);
                }
                _figuresTail[_imageIndex].Next = newNode;
                _figuresTail[_imageIndex] = newNode;
            }
        }

        private void DeleteNextNodes(Node<IFigure> current)
        {
            if(current == null)
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
            if (_figuresTail[_imageIndex] == null)
            {
                return;
            }
            if (_figuresTail[_imageIndex].Prev != null)
            {
                _figuresTail[_imageIndex] = _figuresTail[_imageIndex].Prev;
                ClearAndDrawFigures();
            }
            else
            {
                _figuresTail[_imageIndex] = null;
                ClearAndDrawFigures();
            }
        }

        private void StepForward()
        {
            if (_figuresTail[_imageIndex] == null)
            {
                if (_figuresHead[_imageIndex] != null)
                    _figuresTail[_imageIndex] = _figuresHead[_imageIndex];
                ClearAndDrawFigures();
                return;
            }
            if (_figuresTail[_imageIndex].Next != null)
            {
                _figuresTail[_imageIndex] = _figuresTail[_imageIndex].Next;
                ClearAndDrawFigures();
            }
            else
            {
                return;
            }
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
            int currentIndex = _imageIndex;
            for(int i = 0; i < 10; i++)
            {
                _imageIndex = i;
                ClearAndDrawFigures();
            }
            _imageIndex = currentIndex;
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

        private void EditPanel_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void EditPictureBox_SizeChanged(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DeleteNextNodes(_figuresHead[_imageIndex]);
            _figuresHead[_imageIndex] = null;
            _figuresTail[_imageIndex] = null;
            ClearAndDrawFigures();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            if (_imageIndex != 0)
            {
                _imageIndex--;
                ImageIndexLabel.Text = $"Часть - {_imageIndex + 1}";
                ReinitGraphics();
                ClearAndDrawFigures();
            }

        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            if (_imageIndex != 9)
            {
                _imageIndex++;
                ImageIndexLabel.Text = $"Часть - {_imageIndex + 1}";
                ReinitGraphics();
                ClearAndDrawFigures();
            }
        }

        private void ReinitGraphics()
        {
            _graphics.Dispose();
            _graphics = Graphics.FromImage(_images[_imageIndex]);
            _graphics.SmoothingMode =
            System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }
    }
}
