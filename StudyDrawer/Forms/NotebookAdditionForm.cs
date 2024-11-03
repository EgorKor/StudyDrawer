using StudyDrawer.DomainCode.Notes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyDrawer.Forms
{
    public partial class NotebookAdditionForm : Form
    {
        private IEnumerable<string> _existingNotebooks;
        private bool _isSaved;


        public NotebookAdditionForm(IEnumerable<string> notebookNames)
        {
            InitializeComponent();
            _existingNotebooks = notebookNames;
        }

        public Notebook ShowNotebookAddtionDialog()
        {
            ShowDialog();
            if (!_isSaved)
            {
                return null;
            }
            string notebookName = NotebookNameInput.Text;
            string description = NotebookDescriptionInput.Text;
            DateTime creationTime = DateTime.Now;
            DateTime updateTime = DateTime.Now;
            return new Notebook()
            {
                Name = notebookName,
                Description = description,
                CreatedAt = creationTime,
                UpdatedAt = updateTime,
                Notes = new List<Note>()
            };
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateForm();
                _isSaved = true;
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка валидации",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidateForm()
        {
            string name = NotebookNameInput.Text;
            if(name.Length < 5 || name.Length > 30)
            {
                throw new Exception("Название должно быть от 5 до 30 символов");
            }
            if (_existingNotebooks.Contains(name))
            {
                throw new Exception("Блокнот с таким названием уже существует");
            }
        }

        
    }
}
