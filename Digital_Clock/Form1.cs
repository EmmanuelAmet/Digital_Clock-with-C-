using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x00000020;
        //        return cp;// base.CreateParams;
        //    }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.White;
            //panel1.BackColor = Color.FromArgb(0, Color.Black);
            //panel1.BackColor = Color.FromArgb(100, 88, 44, 55);

            //panel1 = new TransparentPanel();
            //panel1.BackColor = System.Drawing.Color.Transparent;
            //panel1.Controls.Add(panel1);
            //panel1.BringToFront();
        }
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    //base.OnPaint(e);
        //    //e.Graphics.DrawLine(Pens.Yellow, 0, 0, 100, 100);
        //    e.Graphics.FillRectangle(new SolidBrush(this.BackColor), this.ClientRectangle);
        //}

        private int imageNumber = 1;

        private void LoadNextImage()
        {
            if (imageNumber == 31)
            {
                imageNumber = 1;

            }
            sliderphoto.ImageLocation = string.Format(@"images\{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void lbltime_Click(object sender, EventArgs e)
        {

        }
    }
}
