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
            TreeNode treeNode1 = new TreeNode("Узел3");
            TreeNode treeNode2 = new TreeNode("блокнот 1", new TreeNode[] { treeNode1 });
            TreeNode treeNode3 = new TreeNode("Узел1");
            TreeNode treeNode4 = new TreeNode("Узел2");
            NotebookTreeView = new TreeView();
            AddNotebookButton = new Button();
            ContentLayoutPanel = new FlowLayoutPanel();
            OpenFileDialog = new OpenFileDialog();
            SuspendLayout();
            // 
            // NotebookTreeView
            // 
            NotebookTreeView.Location = new Point(12, 76);
            NotebookTreeView.Margin = new Padding(3, 2, 3, 2);
            NotebookTreeView.Name = "NotebookTreeView";
            treeNode1.Name = "Узел3";
            treeNode1.Text = "Узел3";
            treeNode2.Name = "note0";
            treeNode2.Text = "блокнот 1";
            treeNode3.Name = "Узел1";
            treeNode3.Text = "Узел1";
            treeNode4.Name = "Узел2";
            treeNode4.Text = "Узел2";
            NotebookTreeView.Nodes.AddRange(new TreeNode[] { treeNode2, treeNode3, treeNode4 });
            NotebookTreeView.Size = new Size(170, 266);
            NotebookTreeView.TabIndex = 2;
            // 
            // AddNotebookButton
            // 
            AddNotebookButton.Location = new Point(10, 36);
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 592);
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
    }
}
