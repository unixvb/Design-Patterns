using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    
    public partial class Form1 : Form
    {
        IM image1 = new IM();
        IM image2 = new IM();
        IM image3 = new IM();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = ".jpg files (*.jpg)|*.jpg";
            
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    image1.image1 = new Bitmap(dlg.FileName);

                    pictureBox1.Image = image1.image1;
                    pictureBox2.Image = image2.image1;
                    pictureBox3.Image = image3.image1;
                }
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            image2 = image1.ShallowCopy();
            pictureBox2.Image = image2.image1;
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            image3 = image1.DeepCopy();
            pictureBox3.Image = image3.image1;
        }

        class IM
        {
            public Image image1;
            public Image image2;
            public Image image3;
            public virtual IM ShallowCopy()
            {
                return this;
            }
            public virtual IM DeepCopy()
            {
                var copy = (IM)this.MemberwiseClone();
                var copyImage1 = (Image)this.image1.Clone();
                var copyImage2 = (Image)this.image2.Clone();
                var copyImage3 = (Image)this.image3.Clone();
                copy.image1 = copyImage1;
                copy.image2 = copyImage2;
                copy.image3 = copyImage3;
                return copy;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = ".jpg files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    image1.image2 = new Bitmap(dlg.FileName);

                    pictureBox4.Image = image1.image2;
                    pictureBox5.Image = image2.image2;
                    pictureBox6.Image = image3.image2;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = ".jpg files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    image1.image3 = new Bitmap(dlg.FileName);

                    pictureBox7.Image = image1.image3;
                    pictureBox8.Image = image2.image3;
                    pictureBox9.Image = image3.image3;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            image2 = image1.ShallowCopy();
            pictureBox5.Image = image2.image2;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            image2 = image1.ShallowCopy();
            pictureBox8.Image = image2.image3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            image3 = image1.DeepCopy();
            pictureBox6.Image = image3.image2;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            image3 = image1.DeepCopy();
            pictureBox9.Image = image3.image3;
        }
    }
}
