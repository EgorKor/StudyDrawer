using StudyDrawer.DomainCode.Notes;
using StudyDrawer.DomainCode.Util;
using StudyDrawer.Forms;
using StudyDrawer.Forms.CreationForms;
using StudyDrawer.Forms.ImageForms;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace StudyDrawer
{
    public partial class MainForm : Form
    {
        private int _contentWidth;
        private ListObserver<Notebook> _notebooks;

        public MainForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            _contentWidth = ContentLayoutPanel.Width;
            OpenFileDialog.Filter = "*.jpg;*.jpeg;*.png;*.bmp;*.gif|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
            OpenFileDialog.Title = "Select an Image";
            NoteAddButton.Enabled = false;
            _notebooks = NotebookSerializer.LoadNotebooks();
            _notebooks.OnSizeChanged += (count) =>
            {
                if (count == 0)
                {
                    NoteAddButton.Enabled = false;
                }
                else
                {
                    NoteAddButton.Enabled = true;
                }
            };
        }

        private ListObserver<Notebook> LoadNotebooks()
        {
            ListObserver<Notebook> notebooks = new ListObserver<Notebook>();
            //TODO - сделать загрузку блокнотов из файла
            //по сути десериализацию
            return notebooks;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MaximumSize = Size;
            MinimumSize = Size;
            ContentLayoutPanel.Controls.Add(CreateNewAdditionPanel());
        }

        private Panel CreateNewAdditionPanel()
        {
            Panel panel = new Panel();
            panel.BackColor = Color.White;
            panel.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            panel.Size = new Size(ContentLayoutPanel.Width - 50, 50);

            Button createImageButton = new Button();
            createImageButton.Size = new Size(130, 25);
            createImageButton.Text = "+ Изображение";
            panel.Controls.Add(createImageButton);

            createImageButton.Location = new Point(panel.Width / 2 - createImageButton.Width, panel.Height / 4);
            createImageButton.Click += AddImageClick;

            Button createDrawingButton = new Button();
            createDrawingButton.Size = new Size(130, 25);
            createDrawingButton.Text = "+ Набросок";
            panel.Controls.Add(createDrawingButton);
            createDrawingButton.Location = new Point(createImageButton.Location.X - createImageButton.Width * 2, panel.Height / 4);
            createDrawingButton.Click += AddDrawingClick;

            Button createTextButton = new Button();
            createTextButton.Size = new Size(130, 25);
            createTextButton.Text = "+ Текст";
            panel.Controls.Add(createTextButton);
            createTextButton.Location = new Point(createImageButton.Location.X + createImageButton.Width * 2, panel.Height / 4);
            createTextButton.Click += AddTextClick;
            return panel;
        }


        private void AddNotebookButton_Click(object sender, EventArgs e)
        {
            //TODO - заменить на реальный список блокнотов
            NotebookAdditionForm form = new NotebookAdditionForm(_notebooks);
            Notebook notebook = form.ShowNotebookAddtionDialog();
            if (notebook != null)
            {
                _notebooks.Add(notebook);
                TreeNode notebookNode = new TreeNode(notebook.Name);
                NotebookTreeView.Nodes.Add(notebookNode);
            }
        }

        private void AddTextClick(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            int index = ContentLayoutPanel.Controls.IndexOf(senderButton.Parent);
            RichTextBox richTextBox = new RichTextBox();
            richTextBox.TextChanged += ContentTextChanged;
            float fontSize = 12; // Размер шрифта в пунктах
            richTextBox.Font = new Font(richTextBox.Font.FontFamily, fontSize);
            richTextBox.Size = new Size(ContentLayoutPanel.Width - 50, TextRenderer.MeasureText("s", richTextBox.Font).Height + 15);
            ContentLayoutPanel.Controls.Add(richTextBox);
            ContentLayoutPanel.Controls.SetChildIndex(richTextBox, index + 1);
            Panel newAdditionPanel = CreateNewAdditionPanel();
            ContentLayoutPanel.Controls.Add(newAdditionPanel);
            ContentLayoutPanel.Controls.SetChildIndex(newAdditionPanel, index + 2);
        }

        private void ContentTextChanged(object sender, EventArgs e)
        {
            RichTextBox richTextBox = (RichTextBox)sender;
            if (richTextBox.Text.Length == 0)
            {
                richTextBox.Height = TextRenderer.MeasureText("s", richTextBox.Font).Height + 15;
            }
            else
            {
                Size size = TextRenderer.MeasureText(richTextBox.Text, richTextBox.Font);
                richTextBox.Height = size.Height + 15;
            }
        }

        private void AddImageClick(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            int index = ContentLayoutPanel.Controls.IndexOf(senderButton.Parent);
            DialogResult res = OpenFileDialog.ShowDialog();
            if (res != DialogResult.OK)
            {
                return;
            }
            Image image = Image.FromFile(OpenFileDialog.FileName);
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = ResizeImageProportionally(image, ContentLayoutPanel.Width - 50);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = new Size(pictureBox.Image.Width, pictureBox.Image.Height);
            pictureBox.DoubleClick += OnImageDoubleClick;
            pictureBox.MouseDown += OnImageMouseDown;
            ContentLayoutPanel.Controls.Add(pictureBox);
            ContentLayoutPanel.Controls.SetChildIndex(pictureBox, index + 1);
            Panel newAdditionPanel = CreateNewAdditionPanel();
            ContentLayoutPanel.Controls.Add(newAdditionPanel);
            ContentLayoutPanel.Controls.SetChildIndex(newAdditionPanel, index + 2);
        }

        private void AddDrawingClick(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            int index = ContentLayoutPanel.Controls.IndexOf(senderButton.Parent);
            DrawingImageForm form = new DrawingImageForm();
            NoteDrawingContent content = form.ShowDrawingImageFormDialog();
            if (content != null && content.Images != null && content.Images.Count > 0)
            {
                int i = index + 1;
                foreach (Image image in content.Images)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = ResizeImageProportionally(image, ContentLayoutPanel.Width - 50);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Size = new Size(pictureBox.Image.Width, pictureBox.Image.Height);
                    pictureBox.DoubleClick += OnImageDoubleClick;
                    pictureBox.MouseDown += OnImageMouseDown;
                    ContentLayoutPanel.Controls.Add(pictureBox);
                    ContentLayoutPanel.Controls.SetChildIndex(pictureBox, i);
                    i++;
                }
                Panel newAdditionPanel = CreateNewAdditionPanel();
                ContentLayoutPanel.Controls.Add(newAdditionPanel);
                ContentLayoutPanel.Controls.SetChildIndex(newAdditionPanel, i);
            }
            GC.Collect();
        }


        private void OnImageDoubleClick(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            Image editResult = new EditImageForm(pictureBox.Image).ShowEditImageFormDialog();
            pictureBox.Width = editResult.Width;
            pictureBox.Height = editResult.Height;
            pictureBox.Image = editResult;
        }

        private void OnImageMouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                DialogResult res = MessageBox.Show("Вы уверены что хотите удалить рисунок", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    PictureBox senderPictureBox = (PictureBox)sender;
                    int index = ContentLayoutPanel.Controls.IndexOf(senderPictureBox);
                    DeleteElement(index);
                }
            }
        }

        private void DeleteElement(int index)
        {
            Control beforeControl = ContentLayoutPanel.Controls[index - 1];
            Control currentControl = ContentLayoutPanel.Controls[index];
            Control afterControl = ContentLayoutPanel.Controls[index + 1];
            if (beforeControl is Panel && afterControl is Panel)
            {
                ContentLayoutPanel.Controls.Remove(currentControl);
                ContentLayoutPanel.Controls.Remove(afterControl);
            }
            else
            {
                ContentLayoutPanel.Controls.Remove(currentControl);
            }
        }

        public Image ResizeImageProportionally(Image originalImage, int targetWidth)
        {
            float scaleFactor = (float)targetWidth / originalImage.Width;
            int targetHeight = (int)(originalImage.Height * scaleFactor);
            Bitmap newImage = new Bitmap(targetWidth, targetHeight);
            using (Graphics g = Graphics.FromImage(newImage))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(originalImage, 0, 0, targetWidth, targetHeight);
            }
            return newImage;
        }

        private void ContentLayoutPanel_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control control in ContentLayoutPanel.Controls)
            {
                control.Size = new Size(ContentLayoutPanel.Width - 50, control.Height);
                if (control is Panel)
                {
                    CenterAllControls(control.Controls);
                }
            }
        }

        private void CenterAllControls(Control.ControlCollection controls)
        {
            float ratio = (float)ContentLayoutPanel.Width / _contentWidth;
            if (ratio > 0)
            {
                return;
            }
            foreach (Control control in controls)
            {
                control.Location = new Point((int)((float)control.Location.X * ratio), control.Location.Y);
            }
        }

        private void NotebookTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //TODO - сделать рендер
        }

        private void NoteAddButton_Click(object sender, EventArgs e)
        {
            if (_notebooks.Count == 0)
            {
                MessageBox.Show("Для того чтобы добавить заметку - добавьте хотя-бы один блокнот", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            NoteAdditionForm form = new NoteAdditionForm(_notebooks);
            (Notebook, Note) note = form.ShowNoteCreationDialog();
            if (note.Item1 != null && note.Item2 != null)
            {
                note.Item1.Notes.Add(note.Item2);
                RenderTreeView();
            }
        }


        private void RenderTreeView()
        {
            NotebookTreeView.Nodes.Clear();
            foreach (Notebook notebook in _notebooks)
            {
                TreeNode treeNode = new TreeNode(notebook.Name);
                foreach (Note note in notebook.Notes)
                {
                    TreeNode noteNode = new TreeNode(note.Name);
                    treeNode.Nodes.Add(noteNode);
                }
                NotebookTreeView.Nodes.Add(treeNode);
            }
        }

        private void NotebookTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Вы уверены что хотите удалить этот элемент?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Information); ;
                //TODO - добавить реальное удаление
            }
        }
    }
}
