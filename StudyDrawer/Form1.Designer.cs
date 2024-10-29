namespace StudyDrawer
{
    partial class Form1
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
            TreeNode treeNode9 = new TreeNode("Узел3");
            TreeNode treeNode10 = new TreeNode("блокнот 1", new TreeNode[] { treeNode9 });
            TreeNode treeNode11 = new TreeNode("Узел1");
            TreeNode treeNode12 = new TreeNode("Узел2");
            OpenEdit = new Button();
            NotebookTreeView = new TreeView();
            SuspendLayout();
            // 
            // OpenEdit
            // 
            OpenEdit.Location = new Point(779, 37);
            OpenEdit.Name = "OpenEdit";
            OpenEdit.Size = new Size(94, 29);
            OpenEdit.TabIndex = 1;
            OpenEdit.Text = "edit";
            OpenEdit.UseVisualStyleBackColor = true;
            OpenEdit.Click += OpenEdit_Click;
            // 
            // NotebookTreeView
            // 
            NotebookTreeView.Location = new Point(9, 37);
            NotebookTreeView.Name = "NotebookTreeView";
            treeNode9.Name = "Узел3";
            treeNode9.Text = "Узел3";
            treeNode10.Name = "note0";
            treeNode10.Text = "блокнот 1";
            treeNode11.Name = "Узел1";
            treeNode11.Text = "Узел1";
            treeNode12.Name = "Узел2";
            treeNode12.Text = "Узел2";
            NotebookTreeView.Nodes.AddRange(new TreeNode[] { treeNode10, treeNode11, treeNode12 });
            NotebookTreeView.Size = new Size(194, 354);
            NotebookTreeView.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 547);
            Controls.Add(NotebookTreeView);
            Controls.Add(OpenEdit);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button OpenEdit;
        private TreeView NotebookTreeView;
    }
}
