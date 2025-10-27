namespace image_renderer
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
            bmp = new(PicturePixels.Width, PicturePixels.Height);
            PicturePixels.Image = bmp;
        }

        private void DrawGrid(PaintEventArgs e)
        {
            // X axis(X = 0; WIDTH): (HEIGHT / ROWS) * i = Y
            for (int i = 1; i < int.Parse(NumericSize.Text); i++)
            {
                int y = PicturePixels.Height / int.Parse(NumericSize.Text) * i;
                e.Graphics.DrawLine(Pens.LightGray, 0, y, PicturePixels.Width, y);
            }
            // Y axis(Y = 0; HEIGHT): (WIDTH / COLUMNS) * i = X
            for (int i = 1; i < int.Parse(NumericSize.Text); i++)
            {
                int x = PicturePixels.Width / int.Parse(NumericSize.Text) * i;
                e.Graphics.DrawLine(Pens.LightGray, x, 0, x, PicturePixels.Height);
            }
        }

        private void PicturePixels_Paint(object sender, PaintEventArgs e)
        {
            DrawGrid(e);
        }

        private void ButtonDraw_Click(object sender, EventArgs e)
        {
            PicturePixels.CreateGraphics().Clear(BackColor);
            DrawGrid(new PaintEventArgs(PicturePixels.CreateGraphics(), PicturePixels.ClientRectangle));
            try
            {
                string[] pixels = BoxScript.Text.Split(',', StringSplitOptions.TrimEntries);
                int i, x, y, col;
                i = x = y = col = 0;
                int width = PicturePixels.Width / int.Parse(NumericSize.Text) * int.Parse(NumericPixelSize.Text);
                int height = PicturePixels.Height / int.Parse(NumericSize.Text) * int.Parse(NumericPixelSize.Text);
                while (i < pixels.Length)
                {
                    if (col >= int.Parse(NumericSize.Text))
                    {
                        x = col = 0;
                        y++;
                    }
                    PicturePixels.CreateGraphics().FillRectangle(new SolidBrush(Color.FromName(pixels[i])), new Rectangle(x * width, y * height, width, height));
                    using(Graphics g = Graphics.FromImage(bmp))
                    {
                        g.FillRectangle(new SolidBrush(Color.FromName(pixels[i])), new Rectangle(x * width, y * height, width, height));
                    }
                    col += int.Parse(NumericPixelSize.Text);
                    x++;
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog SavePicture = new();
            SavePicture.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
            SavePicture.ShowDialog();
            if (SavePicture.FileName != "")
            {
                PicturePixels.DrawToBitmap(bmp, new Rectangle(0, 0, PicturePixels.Width, PicturePixels.Height));
                switch (Path.GetExtension(SavePicture.FileName).ToLower())
                {
                    case ".png":
                        bmp.Save(SavePicture.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    case ".jpg":
                        bmp.Save(SavePicture.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case ".bmp":
                        bmp.Save(SavePicture.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    default:
                        MessageBox.Show("Unsupported file format.");
                        break;
                }
            }
        }
    }
}
