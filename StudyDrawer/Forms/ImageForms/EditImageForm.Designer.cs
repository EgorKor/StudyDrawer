namespace StudyDrawer.Forms
{
    partial class EditImageForm
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
            BackButton = new Button();
            ForwardButton = new Button();
            PenColorButton = new Button();
            PenButton = new Button();
            FlushButton = new Button();
            PenWidthNumeric = new NumericUpDown();
            PenWidthLabel = new Label();
            PenColorDialog = new ColorDialog();
            BackgroundColorButton = new Button();
            PenColorLabel = new Label();
            BackgroundColorLabel = new Label();
            colorDialog1 = new ColorDialog();
            BackgroundColorDialog = new ColorDialog();
            FlushWidthLabel = new Label();
            FlushWidthNumeric = new NumericUpDown();
            EditPanel = new Panel();
            EditPictureBox = new PictureBox();
            ClearButton = new Button();
            SaveButton = new Button();
            CancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PenWidthNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FlushWidthNumeric).BeginInit();
            EditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EditPictureBox).BeginInit();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Location = new Point(100, 10);
            BackButton.Margin = new Padding(3, 2, 3, 2);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(82, 22);
            BackButton.TabIndex = 1;
            BackButton.Text = "←";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // ForwardButton
            // 
            ForwardButton.Location = new Point(187, 10);
            ForwardButton.Margin = new Padding(3, 2, 3, 2);
            ForwardButton.Name = "ForwardButton";
            ForwardButton.Size = new Size(82, 22);
            ForwardButton.TabIndex = 2;
            ForwardButton.Text = "→";
            ForwardButton.UseVisualStyleBackColor = true;
            ForwardButton.Click += ForwardButton_Click;
            // 
            // PenColorButton
            // 
            PenColorButton.BackColor = SystemColors.ActiveCaptionText;
            PenColorButton.Location = new Point(6, 38);
            PenColorButton.Margin = new Padding(3, 2, 3, 2);
            PenColorButton.Name = "PenColorButton";
            PenColorButton.Size = new Size(82, 22);
            PenColorButton.TabIndex = 3;
            PenColorButton.UseVisualStyleBackColor = false;
            PenColorButton.Click += PenColorButton_Click;
            // 
            // PenButton
            // 
            PenButton.Location = new Point(6, 280);
            PenButton.Margin = new Padding(3, 2, 3, 2);
            PenButton.Name = "PenButton";
            PenButton.Size = new Size(82, 22);
            PenButton.TabIndex = 4;
            PenButton.Text = "Перо";
            PenButton.UseVisualStyleBackColor = true;
            PenButton.Click += PenButton_Click;
            // 
            // FlushButton
            // 
            FlushButton.Location = new Point(6, 306);
            FlushButton.Margin = new Padding(3, 2, 3, 2);
            FlushButton.Name = "FlushButton";
            FlushButton.Size = new Size(82, 22);
            FlushButton.TabIndex = 5;
            FlushButton.Text = "Стерка";
            FlushButton.UseVisualStyleBackColor = true;
            FlushButton.Click += FlushButton_Click;
            // 
            // PenWidthNumeric
            // 
            PenWidthNumeric.Location = new Point(6, 160);
            PenWidthNumeric.Margin = new Padding(3, 2, 3, 2);
            PenWidthNumeric.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            PenWidthNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            PenWidthNumeric.Name = "PenWidthNumeric";
            PenWidthNumeric.Size = new Size(82, 23);
            PenWidthNumeric.TabIndex = 6;
            PenWidthNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            PenWidthNumeric.ValueChanged += PenWidthNumeric_ValueChanged;
            // 
            // PenWidthLabel
            // 
            PenWidthLabel.AutoSize = true;
            PenWidthLabel.Location = new Point(6, 128);
            PenWidthLabel.Name = "PenWidthLabel";
            PenWidthLabel.Size = new Size(62, 30);
            PenWidthLabel.TabIndex = 7;
            PenWidthLabel.Text = "Толщина \r\nпера";
            // 
            // BackgroundColorButton
            // 
            BackgroundColorButton.BackColor = SystemColors.ControlLightLight;
            BackgroundColorButton.ForeColor = SystemColors.ButtonHighlight;
            BackgroundColorButton.Location = new Point(7, 88);
            BackgroundColorButton.Margin = new Padding(3, 2, 3, 2);
            BackgroundColorButton.Name = "BackgroundColorButton";
            BackgroundColorButton.Size = new Size(82, 22);
            BackgroundColorButton.TabIndex = 8;
            BackgroundColorButton.UseVisualStyleBackColor = false;
            BackgroundColorButton.Click += BackgroundColorButton_Click;
            // 
            // PenColorLabel
            // 
            PenColorLabel.AutoSize = true;
            PenColorLabel.Location = new Point(11, 13);
            PenColorLabel.Name = "PenColorLabel";
            PenColorLabel.Size = new Size(62, 15);
            PenColorLabel.TabIndex = 9;
            PenColorLabel.Text = "Цвет пера";
            // 
            // BackgroundColorLabel
            // 
            BackgroundColorLabel.AutoSize = true;
            BackgroundColorLabel.Location = new Point(11, 71);
            BackgroundColorLabel.Name = "BackgroundColorLabel";
            BackgroundColorLabel.Size = new Size(75, 15);
            BackgroundColorLabel.TabIndex = 10;
            BackgroundColorLabel.Text = "Цвет Стерки";
            // 
            // FlushWidthLabel
            // 
            FlushWidthLabel.AutoSize = true;
            FlushWidthLabel.Location = new Point(7, 196);
            FlushWidthLabel.Name = "FlushWidthLabel";
            FlushWidthLabel.Size = new Size(62, 30);
            FlushWidthLabel.TabIndex = 12;
            FlushWidthLabel.Text = "Толщина \r\nстерки";
            // 
            // FlushWidthNumeric
            // 
            FlushWidthNumeric.Location = new Point(7, 228);
            FlushWidthNumeric.Margin = new Padding(3, 2, 3, 2);
            FlushWidthNumeric.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            FlushWidthNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            FlushWidthNumeric.Name = "FlushWidthNumeric";
            FlushWidthNumeric.Size = new Size(82, 23);
            FlushWidthNumeric.TabIndex = 11;
            FlushWidthNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            FlushWidthNumeric.ValueChanged += FlushWidthNumeric_ValueChanged;
            // 
            // EditPanel
            // 
            EditPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EditPanel.AutoScroll = true;
            EditPanel.Controls.Add(EditPictureBox);
            EditPanel.Location = new Point(101, 39);
            EditPanel.Margin = new Padding(3, 2, 3, 2);
            EditPanel.Name = "EditPanel";
            EditPanel.Size = new Size(934, 524);
            EditPanel.TabIndex = 13;
            // 
            // EditPictureBox
            // 
            EditPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EditPictureBox.BackColor = SystemColors.ControlLightLight;
            EditPictureBox.Location = new Point(0, 2);
            EditPictureBox.Margin = new Padding(3, 2, 3, 2);
            EditPictureBox.Name = "EditPictureBox";
            EditPictureBox.Size = new Size(934, 740);
            EditPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            EditPictureBox.TabIndex = 0;
            EditPictureBox.TabStop = false;
            EditPictureBox.MouseDown += EditPictureBox_MouseDown;
            EditPictureBox.MouseEnter += EditPictureBox_MouseEnter;
            EditPictureBox.MouseLeave += EditPictureBox_MouseLeave;
            EditPictureBox.MouseMove += EditPictureBox_MouseMove;
            EditPictureBox.MouseUp += EditPictureBox_MouseUp;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(7, 333);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(81, 23);
            ClearButton.TabIndex = 14;
            ClearButton.Text = "Очистить";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SaveButton.Location = new Point(859, 11);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 18;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CancelButton.Location = new Point(940, 10);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 19;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // EditImageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 571);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(ClearButton);
            Controls.Add(EditPanel);
            Controls.Add(FlushWidthLabel);
            Controls.Add(FlushWidthNumeric);
            Controls.Add(BackgroundColorLabel);
            Controls.Add(PenColorLabel);
            Controls.Add(BackgroundColorButton);
            Controls.Add(PenWidthLabel);
            Controls.Add(PenWidthNumeric);
            Controls.Add(FlushButton);
            Controls.Add(PenButton);
            Controls.Add(PenColorButton);
            Controls.Add(ForwardButton);
            Controls.Add(BackButton);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1052, 606);
            Name = "EditImageForm";
            Text = "Редактирование изображений";
            FormClosing += EditImageForm_FormClosing;
            Load += EditImageForm_Load;
            ((System.ComponentModel.ISupportInitialize)PenWidthNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)FlushWidthNumeric).EndInit();
            EditPanel.ResumeLayout(false);
            EditPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EditPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BackButton;
        private Button ForwardButton;
        private Button PenColorButton;
        private Button PenButton;
        private Button FlushButton;
        private NumericUpDown PenWidthNumeric;
        private Label PenWidthLabel;
        private ColorDialog PenColorDialog;
        private Button BackgroundColorButton;
        private Label PenColorLabel;
        private Label BackgroundColorLabel;
        private ColorDialog colorDialog1;
        private ColorDialog BackgroundColorDialog;
        private Label FlushWidthLabel;
        private NumericUpDown FlushWidthNumeric;
        private Panel EditPanel;
        private Button ClearButton;
        private Button SaveButton;
        private Button CancelButton;
        private PictureBox EditPictureBox;
    }
}