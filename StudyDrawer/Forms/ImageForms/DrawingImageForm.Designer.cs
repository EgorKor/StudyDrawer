namespace StudyDrawer.Forms
{
    partial class DrawingImageForm
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
            UpButton = new Button();
            DownButton = new Button();
            ImageIndexLabel = new Label();
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
            BackButton.Location = new Point(114, 13);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(94, 29);
            BackButton.TabIndex = 1;
            BackButton.Text = "←";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // ForwardButton
            // 
            ForwardButton.Location = new Point(214, 13);
            ForwardButton.Name = "ForwardButton";
            ForwardButton.Size = new Size(94, 29);
            ForwardButton.TabIndex = 2;
            ForwardButton.Text = "→";
            ForwardButton.UseVisualStyleBackColor = true;
            ForwardButton.Click += ForwardButton_Click;
            // 
            // PenColorButton
            // 
            PenColorButton.BackColor = SystemColors.ActiveCaptionText;
            PenColorButton.Location = new Point(7, 51);
            PenColorButton.Name = "PenColorButton";
            PenColorButton.Size = new Size(94, 29);
            PenColorButton.TabIndex = 3;
            PenColorButton.UseVisualStyleBackColor = false;
            PenColorButton.Click += PenColorButton_Click;
            // 
            // PenButton
            // 
            PenButton.Location = new Point(7, 373);
            PenButton.Name = "PenButton";
            PenButton.Size = new Size(94, 29);
            PenButton.TabIndex = 4;
            PenButton.Text = "Перо";
            PenButton.UseVisualStyleBackColor = true;
            PenButton.Click += PenButton_Click;
            // 
            // FlushButton
            // 
            FlushButton.Location = new Point(7, 408);
            FlushButton.Name = "FlushButton";
            FlushButton.Size = new Size(94, 29);
            FlushButton.TabIndex = 5;
            FlushButton.Text = "Стерка";
            FlushButton.UseVisualStyleBackColor = true;
            FlushButton.Click += FlushButton_Click;
            // 
            // PenWidthNumeric
            // 
            PenWidthNumeric.Location = new Point(7, 213);
            PenWidthNumeric.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            PenWidthNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            PenWidthNumeric.Name = "PenWidthNumeric";
            PenWidthNumeric.Size = new Size(94, 27);
            PenWidthNumeric.TabIndex = 6;
            PenWidthNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            PenWidthNumeric.ValueChanged += PenWidthNumeric_ValueChanged;
            // 
            // PenWidthLabel
            // 
            PenWidthLabel.AutoSize = true;
            PenWidthLabel.Location = new Point(7, 171);
            PenWidthLabel.Name = "PenWidthLabel";
            PenWidthLabel.Size = new Size(76, 40);
            PenWidthLabel.TabIndex = 7;
            PenWidthLabel.Text = "Толщина \r\nпера";
            // 
            // BackgroundColorButton
            // 
            BackgroundColorButton.BackColor = SystemColors.ControlLightLight;
            BackgroundColorButton.ForeColor = SystemColors.ButtonHighlight;
            BackgroundColorButton.Location = new Point(8, 117);
            BackgroundColorButton.Name = "BackgroundColorButton";
            BackgroundColorButton.Size = new Size(94, 29);
            BackgroundColorButton.TabIndex = 8;
            BackgroundColorButton.UseVisualStyleBackColor = false;
            BackgroundColorButton.Click += BackgroundColorButton_Click;
            // 
            // PenColorLabel
            // 
            PenColorLabel.AutoSize = true;
            PenColorLabel.Location = new Point(13, 17);
            PenColorLabel.Name = "PenColorLabel";
            PenColorLabel.Size = new Size(80, 20);
            PenColorLabel.TabIndex = 9;
            PenColorLabel.Text = "Цвет пера";
            // 
            // BackgroundColorLabel
            // 
            BackgroundColorLabel.AutoSize = true;
            BackgroundColorLabel.Location = new Point(13, 95);
            BackgroundColorLabel.Name = "BackgroundColorLabel";
            BackgroundColorLabel.Size = new Size(82, 20);
            BackgroundColorLabel.TabIndex = 10;
            BackgroundColorLabel.Text = "Цвет фона";
            // 
            // FlushWidthLabel
            // 
            FlushWidthLabel.AutoSize = true;
            FlushWidthLabel.Location = new Point(8, 261);
            FlushWidthLabel.Name = "FlushWidthLabel";
            FlushWidthLabel.Size = new Size(76, 40);
            FlushWidthLabel.TabIndex = 12;
            FlushWidthLabel.Text = "Толщина \r\nстерки";
            // 
            // FlushWidthNumeric
            // 
            FlushWidthNumeric.Location = new Point(8, 304);
            FlushWidthNumeric.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            FlushWidthNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            FlushWidthNumeric.Name = "FlushWidthNumeric";
            FlushWidthNumeric.Size = new Size(94, 27);
            FlushWidthNumeric.TabIndex = 11;
            FlushWidthNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            FlushWidthNumeric.ValueChanged += FlushWidthNumeric_ValueChanged;
            // 
            // EditPanel
            // 
            EditPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EditPanel.AutoScroll = true;
            EditPanel.Controls.Add(EditPictureBox);
            EditPanel.Location = new Point(115, 52);
            EditPanel.Name = "EditPanel";
            EditPanel.Size = new Size(1067, 699);
            EditPanel.TabIndex = 13;
            // 
            // EditPictureBox
            // 
            EditPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EditPictureBox.BackColor = SystemColors.ControlLightLight;
            EditPictureBox.Location = new Point(0, 3);
            EditPictureBox.Name = "EditPictureBox";
            EditPictureBox.Size = new Size(1167, 740);
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
            ClearButton.Location = new Point(8, 444);
            ClearButton.Margin = new Padding(3, 4, 3, 4);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(93, 31);
            ClearButton.TabIndex = 14;
            ClearButton.Text = "Очистить";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // UpButton
            // 
            UpButton.Location = new Point(7, 581);
            UpButton.Margin = new Padding(3, 4, 3, 4);
            UpButton.Name = "UpButton";
            UpButton.Size = new Size(87, 41);
            UpButton.TabIndex = 15;
            UpButton.Text = "↑";
            UpButton.UseVisualStyleBackColor = true;
            UpButton.Click += UpButton_Click;
            // 
            // DownButton
            // 
            DownButton.Location = new Point(8, 651);
            DownButton.Margin = new Padding(3, 4, 3, 4);
            DownButton.Name = "DownButton";
            DownButton.Size = new Size(86, 37);
            DownButton.TabIndex = 16;
            DownButton.Text = "↓";
            DownButton.UseVisualStyleBackColor = true;
            DownButton.Click += DownButton_Click;
            // 
            // ImageIndexLabel
            // 
            ImageIndexLabel.AutoSize = true;
            ImageIndexLabel.Location = new Point(8, 627);
            ImageIndexLabel.Name = "ImageIndexLabel";
            ImageIndexLabel.Size = new Size(60, 20);
            ImageIndexLabel.TabIndex = 17;
            ImageIndexLabel.Text = "Часть 1";
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SaveButton.Location = new Point(974, 15);
            SaveButton.Margin = new Padding(3, 4, 3, 4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 31);
            SaveButton.TabIndex = 18;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CancelButton.Location = new Point(1074, 13);
            CancelButton.Margin = new Padding(3, 4, 3, 4);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(86, 31);
            CancelButton.TabIndex = 19;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // DrawingImageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(ImageIndexLabel);
            Controls.Add(DownButton);
            Controls.Add(UpButton);
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
            MinimumSize = new Size(1200, 795);
            Name = "DrawingImageForm";
            Text = "Набросок";
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
        private Button UpButton;
        private Button DownButton;
        private Label ImageIndexLabel;
        private Button SaveButton;
        private Button CancelButton;
        private PictureBox EditPictureBox;
    }
}