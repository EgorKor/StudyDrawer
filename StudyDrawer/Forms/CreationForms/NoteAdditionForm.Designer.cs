namespace StudyDrawer.Forms.CreationForms
{
    partial class NoteAdditionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NoteNameLabel = new Label();
            NoteNameInput = new RichTextBox();
            NotebookComboBox = new ComboBox();
            SaveButton = new Button();
            NotebookLabel = new Label();
            SuspendLayout();
            // 
            // NoteNameLabel
            // 
            NoteNameLabel.AutoSize = true;
            NoteNameLabel.Font = new Font("Segoe UI", 12F);
            NoteNameLabel.Location = new Point(18, 9);
            NoteNameLabel.Name = "NoteNameLabel";
            NoteNameLabel.Size = new Size(140, 21);
            NoteNameLabel.TabIndex = 0;
            NoteNameLabel.Text = "Название заметки";
            // 
            // NoteNameInput
            // 
            NoteNameInput.Font = new Font("Segoe UI", 12F);
            NoteNameInput.Location = new Point(18, 40);
            NoteNameInput.Name = "NoteNameInput";
            NoteNameInput.Size = new Size(265, 42);
            NoteNameInput.TabIndex = 1;
            NoteNameInput.Text = "";
            // 
            // NotebookComboBox
            // 
            NotebookComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            NotebookComboBox.Font = new Font("Segoe UI", 12F);
            NotebookComboBox.FormattingEnabled = true;
            NotebookComboBox.Location = new Point(18, 128);
            NotebookComboBox.Name = "NotebookComboBox";
            NotebookComboBox.Size = new Size(265, 29);
            NotebookComboBox.TabIndex = 2;
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Segoe UI", 12F);
            SaveButton.Location = new Point(18, 173);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(140, 33);
            SaveButton.TabIndex = 3;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // NotebookLabel
            // 
            NotebookLabel.AutoSize = true;
            NotebookLabel.Font = new Font("Segoe UI", 12F);
            NotebookLabel.Location = new Point(18, 98);
            NotebookLabel.Name = "NotebookLabel";
            NotebookLabel.Size = new Size(69, 21);
            NotebookLabel.TabIndex = 4;
            NotebookLabel.Text = "Блокнот";
            // 
            // NoteAdditionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 227);
            Controls.Add(NotebookLabel);
            Controls.Add(SaveButton);
            Controls.Add(NotebookComboBox);
            Controls.Add(NoteNameInput);
            Controls.Add(NoteNameLabel);
            Name = "NoteAdditionForm";
            Text = "Добавление заметки";
            Load += NoteAdditionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NoteNameLabel;
        private RichTextBox NoteNameInput;
        private ComboBox NotebookComboBox;
        private Button SaveButton;
        private Label NotebookLabel;
    }
}