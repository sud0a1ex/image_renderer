namespace image_renderer
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
            BoxScript = new TextBox();
            PicturePixels = new PictureBox();
            ButtonDraw = new Button();
            NumericSize = new NumericUpDown();
            NumericPixelSize = new NumericUpDown();
            ButtonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)PicturePixels).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericPixelSize).BeginInit();
            SuspendLayout();
            // 
            // BoxScript
            // 
            BoxScript.Dock = DockStyle.Left;
            BoxScript.Location = new Point(0, 0);
            BoxScript.Multiline = true;
            BoxScript.Name = "BoxScript";
            BoxScript.Size = new Size(310, 450);
            BoxScript.TabIndex = 2;
            // 
            // PicturePixels
            // 
            PicturePixels.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PicturePixels.BackColor = Color.Transparent;
            PicturePixels.BorderStyle = BorderStyle.FixedSingle;
            PicturePixels.Location = new Point(432, 101);
            PicturePixels.Name = "PicturePixels";
            PicturePixels.Size = new Size(260, 260);
            PicturePixels.TabIndex = 1;
            PicturePixels.TabStop = false;
            PicturePixels.Paint += PicturePixels_Paint;
            // 
            // ButtonDraw
            // 
            ButtonDraw.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonDraw.BackColor = Color.DarkCyan;
            ButtonDraw.FlatStyle = FlatStyle.Popup;
            ButtonDraw.Location = new Point(529, 397);
            ButtonDraw.Name = "ButtonDraw";
            ButtonDraw.Size = new Size(126, 41);
            ButtonDraw.TabIndex = 3;
            ButtonDraw.Text = "Draw";
            ButtonDraw.UseVisualStyleBackColor = false;
            ButtonDraw.Click += ButtonDraw_Click;
            // 
            // NumericSize
            // 
            NumericSize.Location = new Point(316, 12);
            NumericSize.Maximum = new decimal(new int[] { 64, 0, 0, 0 });
            NumericSize.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            NumericSize.Name = "NumericSize";
            NumericSize.Size = new Size(150, 27);
            NumericSize.TabIndex = 0;
            NumericSize.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // NumericPixelSize
            // 
            NumericPixelSize.Location = new Point(316, 45);
            NumericPixelSize.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            NumericPixelSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumericPixelSize.Name = "NumericPixelSize";
            NumericPixelSize.Size = new Size(150, 27);
            NumericPixelSize.TabIndex = 1;
            NumericPixelSize.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ButtonSave
            // 
            ButtonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonSave.BackColor = Color.DarkGoldenrod;
            ButtonSave.FlatStyle = FlatStyle.Popup;
            ButtonSave.Location = new Point(662, 397);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(126, 41);
            ButtonSave.TabIndex = 4;
            ButtonSave.Text = "Save";
            ButtonSave.UseVisualStyleBackColor = false;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonSave);
            Controls.Add(NumericPixelSize);
            Controls.Add(NumericSize);
            Controls.Add(ButtonDraw);
            Controls.Add(PicturePixels);
            Controls.Add(BoxScript);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(818, 497);
            MinimumSize = new Size(818, 497);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Image Renderer";
            ((System.ComponentModel.ISupportInitialize)PicturePixels).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericPixelSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox BoxScript;
        private Button ButtonDraw;
        private NumericUpDown NumericSize;
        private NumericUpDown NumericPixelSize;
        private Button ButtonSave;
        private PictureBox PicturePixels;
    }
}
