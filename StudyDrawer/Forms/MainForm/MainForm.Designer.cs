namespace StudyDrawer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NotebookTreeView = new TreeView();
            AddNotebookButton = new Button();
            ContentLayoutPanel = new FlowLayoutPanel();
            OpenFileDialog = new OpenFileDialog();
            NoteAddButton = new Button();
            SuspendLayout();
            // 
            // NotebookTreeView
            // 
            NotebookTreeView.Location = new Point(14, 157);
            NotebookTreeView.Margin = new Padding(3, 2, 3, 2);
            NotebookTreeView.Name = "NotebookTreeView";
            NotebookTreeView.Size = new Size(170, 266);
            NotebookTreeView.TabIndex = 2;
            NotebookTreeView.NodeMouseClick += NotebookTreeView_NodeMouseClick;
            NotebookTreeView.NodeMouseDoubleClick += NotebookTreeView_NodeMouseDoubleClick;
            // 
            // AddNotebookButton
            // 
            AddNotebookButton.Location = new Point(12, 76);
            AddNotebookButton.Name = "AddNotebookButton";
            AddNotebookButton.Size = new Size(172, 35);
            AddNotebookButton.TabIndex = 3;
            AddNotebookButton.Text = "Добавить блокнот";
            AddNotebookButton.UseVisualStyleBackColor = true;
            AddNotebookButton.Click += AddNotebookButton_Click;
            // 
            // ContentLayoutPanel
            // 
            ContentLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ContentLayoutPanel.AutoScroll = true;
            ContentLayoutPanel.Location = new Point(193, 76);
            ContentLayoutPanel.Name = "ContentLayoutPanel";
            ContentLayoutPanel.Size = new Size(999, 504);
            ContentLayoutPanel.TabIndex = 4;
            ContentLayoutPanel.SizeChanged += ContentLayoutPanel_SizeChanged;
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.FileName = "openFileDialog1";
            OpenFileDialog.Filter = "\"Изоборажения|\"";
            // 
            // NoteAddButton
            // 
            NoteAddButton.Location = new Point(12, 117);
            NoteAddButton.Name = "NoteAddButton";
            NoteAddButton.Size = new Size(172, 35);
            NoteAddButton.TabIndex = 5;
            NoteAddButton.Text = "Добавить заметку";
            NoteAddButton.UseVisualStyleBackColor = true;
            NoteAddButton.Click += NoteAddButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 592);
            Controls.Add(NoteAddButton);
            Controls.Add(ContentLayoutPanel);
            Controls.Add(AddNotebookButton);
            Controls.Add(NotebookTreeView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "StudyDrawer";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private TreeView NotebookTreeView;
        private Button AddNotebookButton;
        private FlowLayoutPanel ContentLayoutPanel;
        private OpenFileDialog OpenFileDialog;
        private Button NoteAddButton;
    }
}
