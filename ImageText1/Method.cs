using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageText
{
    internal class Method
    {
        public Method()
        {

        }

        public static bool ConvertToGray(Bitmap b)
        {

            for (int i = 0; i < b.Width; i++)
                for (int j = 0; j < b.Height; j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;
                    int gray = (byte)(.299 * r1 + .587 * g1 + .114 * b1);
                    r1 = gray;
                    g1 = gray;
                    b1 = gray;
                    b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            return true;
        }

        public static bool ConvertToNegative(Bitmap b)
        {
            for (int i = 0; i < b.Width; i++)
                for (int j = 0; j < b.Height; j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    int a = c1.A;
                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;
                    r1 = 255 - r1;
                    g1 = 255 - g1;
                    b1 = 255 - b1;
                    b.SetPixel(i, j, Color.FromArgb(a, r1, g1, b1));
                }
            return true;
        }

        /*private int[] mask = new int[9];
        public void ConvertToNoises(object sender, EventArgs e)
        {
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
                }
            }
        }*/
    }
}