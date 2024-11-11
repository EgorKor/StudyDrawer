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

namespace StudyDrawer.Forms.CreationForms
{
    public partial class NoteAdditionForm : Form
    {
        private bool _isSaved;
        private List<Notebook> _notebooks;
        public NoteAdditionForm(List<Notebook> notebooks)
        {
            InitializeComponent();
            _notebooks = notebooks;
            foreach (Notebook notebook in notebooks)
            {
                NotebookComboBox.Items.Add(notebook.Name);
            }
            NotebookComboBox.SelectedIndex = 0;

        }

        private void NoteAdditionForm_Load(object sender, EventArgs e)
        {
            MinimumSize = Size;
            MaximumSize = Size;
        }

        public (Notebook, Note) ShowNoteCreationDialog()
        {
            ShowDialog();
            if (!_isSaved)
            {
                return (null, null);
            }
            Note createdNote = new Note()
            {
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Name = NoteNameInput.Text,
                Content = new List<INoteContent>()
            };
            return (_notebooks[NotebookComboBox.SelectedIndex], createdNote);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateForm();
                _isSaved = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка валидации", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void ValidateForm()
        {
            string name = NoteNameInput.Text;
            if (name.Length < 5 || name.Length > 30)
            {
                throw new Exception("Название заметки должно быть от 5 до 30 символов");
            }
        }

    }
}
