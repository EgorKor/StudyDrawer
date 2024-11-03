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
            // ��������� FlowLayoutPanel
            flowLayout = new FlowLayoutPanel
            {
                AutoScroll = true,
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown
            };
            this.Controls.Add(flowLayout);

            // ���������� ������ ��� ������� �����������
            Button btnInsertImage = new Button
            {
                Text = "�������� �����������",
                Dock = DockStyle.Top
            };
            btnInsertImage.Click += (sender, e) => InsertImage();
            this.Controls.Add(btnInsertImage);

            // ���������� TextBox ��� ����� ������
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
                    // �������� PictureBox ��� �����������
                    PictureBox pictureBox = new PictureBox
                    {
                        Image = Image.FromFile(openFileDialog.FileName),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Height = 200, // ���������� �������� ������ ��� �����������
                        Width = flowLayout.Width - 40,
                        Margin = new Padding(0, 10, 0, 10) // ������� ��� ����������� ����������
                    };
                    flowLayout.Controls.Add(pictureBox);

                    // ���������� ������ TextBox ����� �����������, ����� ������������ ��� ���������� ����
                    AddTextBox();
                }
            }
        }
    }
}
