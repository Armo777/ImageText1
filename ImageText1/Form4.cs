using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageText
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog Opfile = new OpenFileDialog();
            Opfile.Filter = "Image File (*.bmp,*.png,*.jpg)| *.bmp;*.png;*.jpg";
            if (DialogResult.OK == Opfile.ShowDialog())
            {
                this.pictureBox1.Image = new Bitmap(Opfile.FileName);
            }
        }

        private void Gray_Click(object sender, EventArgs e)
        {
            Bitmap coppy = new Bitmap((Bitmap)this.pictureBox1.Image);
            Method.ConvertToGray(coppy);
            this.pictureBox2.Image = coppy;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap coppy = new Bitmap((Bitmap)this.pictureBox1.Image);
            Method.ConvertToNegative(coppy);
            this.pictureBox2.Image = coppy;
        }

        private int[] mask = new int[9];
        private void button2_Click(object sender, EventArgs e)
        {
            //Bitmap coppy = new Bitmap((Bitmap)this.pictureBox1.Image);
            //Method.ConvertToNegative(coppy);
            //this.pictureBox2.Image = coppy;
            Bitmap img = new Bitmap(pictureBox1.Image);
            Color c;
            for (int ii = 0; ii < img.Width; ii++)
            {
                for (int jj = 0; jj < img.Height; jj++)
                {

                    if (ii - 1 >= 0 && jj - 1 >= 0)
                    {
                        c = img.GetPixel(ii - 1, jj - 1);
                        mask[0] = Convert.ToInt16(c.R);
                    }
                    else
                    {
                        mask[0] = 0;
                    }

                    if (jj - 1 >= 0 && ii + 1 < img.Width)
                    {
                        c = img.GetPixel(ii + 1, jj - 1);
                        mask[1] = Convert.ToInt16(c.R);
                    }
                    else
                        mask[1] = 0;

                    if (jj - 1 >= 0)
                    {
                        c = img.GetPixel(ii, jj - 1);
                        mask[2] = Convert.ToInt16(c.R);
                    }
                    else
                        mask[2] = 0;

                    if (ii + 1 < img.Width)
                    {
                        c = img.GetPixel(ii + 1, jj);
                        mask[3] = Convert.ToInt16(c.R);
                    }
                    else
                        mask[3] = 0;

                    if (ii - 1 >= 0)
                    {
                        c = img.GetPixel(ii - 1, jj);
                        mask[4] = Convert.ToInt16(c.R);
                    }
                    else
                        mask[4] = 0;

                    if (ii - 1 >= 0 && jj + 1 < img.Height)
                    {
                        c = img.GetPixel(ii - 1, jj + 1);
                        mask[5] = Convert.ToInt16(c.R);
                    }
                    else
                        mask[5] = 0;

                    if (jj + 1 < img.Height)
                    {
                        c = img.GetPixel(ii, jj + 1);
                        mask[6] = Convert.ToInt16(c.R);
                    }
                    else
                        mask[6] = 0;


                    if (ii + 1 < img.Width && jj + 1 < img.Height)
                    {
                        c = img.GetPixel(ii + 1, jj + 1);
                        mask[7] = Convert.ToInt16(c.R);
                    }
                    else
                        mask[7] = 0;
                    c = img.GetPixel(ii, jj);
                    mask[8] = Convert.ToInt16(c.R);
                    Array.Sort(mask);
                    int mid = mask[4];
                    img.SetPixel(ii, jj, Color.FromArgb(mid, mid, mid));
                }
            }
            pictureBox2.Image = img;
            //MessageBox.Show("Complete");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 imageText = new Form2();
            imageText.Show();
        }
    }
}