namespace Test
{
    public partial class Form1 : Form
    {
        private FlowLayoutPanel flowLayout;

        public Form1()
        {
            InitializeComponent();
            InitializeCustomEditor();
        }

        private void InitializeCustomEditor()
        {
            // Настройка FlowLayoutPanel
            flowLayout = new FlowLayoutPanel
            {
                AutoScroll = true,
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown
            };
            this.Controls.Add(flowLayout);

            // Добавление кнопки для вставки изображения
            Button btnInsertImage = new Button
            {
                Text = "Вставить изображение",
                Dock = DockStyle.Top
            };
            btnInsertImage.Click += (sender, e) => InsertImage();
            this.Controls.Add(btnInsertImage);

            // Добавление TextBox для ввода текста
            AddTextBox();
        }

        private void AddTextBox(string initialText = "")
        {
            TextBox textBox = new TextBox
            {
                Multiline = true,
                Width = flowLayout.Width - 40,
                Height = 100,
                ScrollBars = ScrollBars.Vertical
            };

            textBox.Text = initialText;
            flowLayout.Controls.Add(textBox);
        }

        private void InsertImage()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Создание PictureBox для изображения
                    PictureBox pictureBox = new PictureBox
                    {
                        Image = Image.FromFile(openFileDialog.FileName),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Height = 200, // Установите желаемую высоту для изображения
                        Width = flowLayout.Width - 40,
                        Margin = new Padding(0, 10, 0, 10) // Отступы для визуального разделения
                    };
                    flowLayout.Controls.Add(pictureBox);

                    // Добавление нового TextBox после изображения, чтобы пользователь мог продолжить ввод
                    AddTextBox();
                }
            }
        }
    }
}
