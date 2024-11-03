namespace StudyDrawer.Forms
{
    partial class NotebookAdditionForm
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
            NotebookNameInput = new RichTextBox();
            InputNameLabel = new Label();
            NotebookDescriptionLabel = new Label();
            NotebookDescriptionInput = new RichTextBox();
            CreateButton = new Button();
            SuspendLayout();
            // 
            // NotebookNameInput
            // 
            NotebookNameInput.Font = new Font("Segoe UI", 14.25F);
            NotebookNameInput.Location = new Point(12, 38);
            NotebookNameInput.Name = "NotebookNameInput";
            NotebookNameInput.Size = new Size(324, 41);
            NotebookNameInput.TabIndex = 0;
            NotebookNameInput.Text = "";
            // 
            // InputNameLabel
            // 
            InputNameLabel.AutoSize = true;
            InputNameLabel.Font = new Font("Segoe UI", 14.25F);
            InputNameLabel.Location = new Point(12, 3);
            InputNameLabel.Name = "InputNameLabel";
            InputNameLabel.Size = new Size(95, 25);
            InputNameLabel.TabIndex = 1;
            InputNameLabel.Text = "Название";
            // 
            // NotebookDescriptionLabel
            // 
            NotebookDescriptionLabel.AutoSize = true;
            NotebookDescriptionLabel.Font = new Font("Segoe UI", 14.25F);
            NotebookDescriptionLabel.Location = new Point(12, 82);
            NotebookDescriptionLabel.Name = "NotebookDescriptionLabel";
            NotebookDescriptionLabel.Size = new Size(99, 25);
            NotebookDescriptionLabel.TabIndex = 3;
            NotebookDescriptionLabel.Text = "Описание";
            // 
            // NotebookDescriptionInput
            // 
            NotebookDescriptionInput.Font = new Font("Segoe UI", 14.25F);
            NotebookDescriptionInput.Location = new Point(12, 126);
            NotebookDescriptionInput.Name = "NotebookDescriptionInput";
            NotebookDescriptionInput.Size = new Size(324, 126);
            NotebookDescriptionInput.TabIndex = 2;
            NotebookDescriptionInput.Text = "";
            // 
            // CreateButton
            // 
            CreateButton.Font = new Font("Segoe UI", 14.25F);
            CreateButton.Location = new Point(12, 280);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(324, 79);
            CreateButton.TabIndex = 4;
            CreateButton.Text = "Создать блокнот";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // NotebookAdditionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 373);
            Controls.Add(CreateButton);
            Controls.Add(NotebookDescriptionLabel);
            Controls.Add(NotebookDescriptionInput);
            Controls.Add(InputNameLabel);
            Controls.Add(NotebookNameInput);
            Name = "NotebookAdditionForm";
            Text = "Создание нового блокнота";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox NotebookNameInput;
        private Label InputNameLabel;
        private Label NotebookDescriptionLabel;
        private RichTextBox NotebookDescriptionInput;
        private Button CreateButton;
    }
}