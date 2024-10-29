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
            EditPictureBox = new PictureBox();
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
            label1 = new Label();
            FlushWidthNumeric = new NumericUpDown();
            EditPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)EditPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PenWidthNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FlushWidthNumeric).BeginInit();
            EditPanel.SuspendLayout();
            SuspendLayout();
            // 
            // EditPictureBox
            // 
            EditPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EditPictureBox.BackColor = SystemColors.ControlLightLight;
            EditPictureBox.Location = new Point(0, 0);
            EditPictureBox.Name = "EditPictureBox";
            EditPictureBox.Size = new Size(1167, 740);
            EditPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            EditPictureBox.TabIndex = 0;
            EditPictureBox.TabStop = false;
            EditPictureBox.SizeChanged += EditPictureBox_SizeChanged;
            EditPictureBox.MouseDown += EditPictureBox_MouseDown;
            EditPictureBox.MouseEnter += EditPictureBox_MouseEnter;
            EditPictureBox.MouseLeave += EditPictureBox_MouseLeave;
            EditPictureBox.MouseMove += EditPictureBox_MouseMove;
            EditPictureBox.MouseUp += EditPictureBox_MouseUp;
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
            PenColorButton.Location = new Point(7, 50);
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
            PenWidthLabel.Location = new Point(7, 170);
            PenWidthLabel.Name = "PenWidthLabel";
            PenWidthLabel.Size = new Size(76, 40);
            PenWidthLabel.TabIndex = 7;
            PenWidthLabel.Text = "Толщина \r\nпера";
            // 
            // BackgroundColorButton
            // 
            BackgroundColorButton.BackColor = SystemColors.ControlLightLight;
            BackgroundColorButton.ForeColor = SystemColors.ButtonHighlight;
            BackgroundColorButton.Location = new Point(8, 118);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 261);
            label1.Name = "label1";
            label1.Size = new Size(76, 40);
            label1.TabIndex = 12;
            label1.Text = "Толщина \r\nстерки";
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
            EditPanel.Controls.Add(EditPictureBox);
            EditPanel.Location = new Point(115, 52);
            EditPanel.Name = "EditPanel";
            EditPanel.Size = new Size(1068, 699);
            EditPanel.TabIndex = 13;
            EditPanel.Scroll += EditPanel_Scroll;
            // 
            // EditImageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(EditPanel);
            Controls.Add(label1);
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
            MinimumSize = new Size(1200, 800);
            Name = "EditImageForm";
            Text = "Набросок";
            ((System.ComponentModel.ISupportInitialize)EditPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PenWidthNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)FlushWidthNumeric).EndInit();
            EditPanel.ResumeLayout(false);
            EditPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox EditPictureBox;
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
        private Label label1;
        private NumericUpDown FlushWidthNumeric;
        private Panel EditPanel;
    }
}