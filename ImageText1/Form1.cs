using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.OCR;
using Emgu.CV.Structure;
using Emgu.Util;

namespace ImageText
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 imageText = new Form1();
            imageText.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 imageText = new Form3();
            imageText.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
