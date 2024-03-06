using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alturos.Yolo;
using Alturos.Yolo.Model;

namespace ImageText
{
    public partial class ImageText : Form
    {
        private string fileName = string.Empty;
        public ImageText()
        {
            InitializeComponent();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(fileName);
            }
            else
            {
                MessageBox.Show("Картинка не выбрана!", "Необходимо выбрать картинку!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            YoloWrapper yolo = new YoloWrapper("yolov3.cfg", "yolov3.weights", "coco.NAMES");
            MemoryStream memoryStream = new MemoryStream();
            pictureBox1.Image.Save(memoryStream, ImageFormat.Jpeg);
            //List<YoloItem> items = yolo.Detect(memoryStream.ToArray).ToList<YoloItem>();
            Image finalImage = pictureBox1.Image;
            Graphics graph = Graphics.FromImage(finalImage);
            Font font = new Font("Consolas", 10, FontStyle.Bold);
            SolidBrush brush = new SolidBrush(Color.White);
            /*foreach (YoloItem item in items)
            {
                Point rectPoint = Point(item.X, item.Y);
                Size rectSize = new Size(item.Width, item.Height);
                Rectangle rect = new Rectangle(rectPoint, rectSize);
                Pen pen = new Pen(Color.Yellow, 2);
                graph.DrawRectangle(pen, rect);
                graph.DrawString(item.Type, font, brush, rectPoint);
            }
            pictureBox1.Image = finalImage;*/
        }

        private Point Point(int x, int y)
        {
            throw new NotImplementedException();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


    }
}
