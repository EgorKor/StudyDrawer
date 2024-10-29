using System.Drawing.Drawing2D;

namespace StudyDrawer
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

       

        private void OpenEdit_Click(object sender, EventArgs e)
        {
            Form form = new Forms.EditImageForm();
            form.ShowDialog();
        }
    }
}
