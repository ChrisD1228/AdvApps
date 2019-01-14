using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16.slide.puzzle.game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Gray;
            pictureBox2.BackColor = Color.Gray;
            pictureBox3.BackColor = Color.Gray;
            pictureBox4.BackColor = Color.Gray;
            pictureBox5.BackColor = Color.Gray;
            pictureBox6.BackColor = Color.Gray;
            pictureBox7.BackColor = Color.Gray;
            pictureBox8.BackColor = Color.Gray;
            pictureBox9.BackColor = Color.Gray;
            pictureBox10.BackColor = Color.Gray;
            pictureBox11.BackColor = Color.Gray;
            pictureBox12.BackColor = Color.Gray;
            pictureBox13.BackColor = Color.Gray;
            pictureBox14.BackColor = Color.Gray;
            pictureBox15.BackColor = Color.Gray;
            pictureBox16.BackColor = Color.White;

            pictureBox1.Image = Properties.Resources.jay_crtich_did_it_again_fashion_interview__1__01;
            pictureBox2.Image = Properties.Resources.jay_crtich_did_it_again_fashion_interview__1__12;
            pictureBox3.Image = Properties.Resources.jay_crtich_did_it_again_fashion_interview__1__14;
            pictureBox4.Image = Properties.Resources.jay_crtich_did_it_again_fashion_interview__1__15;
            pictureBox5.Image = Properties.Resources.blankslide;
            pictureBox6.Image = Properties.Resources.jay_crtich_did_it_again_fashion_interview__1__13;
            pictureBox7.Image = Properties.Resources.jay_crtich_did_it_again_fashion_interview__1__11;
            pictureBox8.Image = Properties.Resources.jay_crtich_did_it_again_fashion_interview__1__10;
            pictureBox9.Image = Properties.Resources.jay_crtich_did_it_again_fashion_interview__1__09;
            pictureBox10.Image = Properties.Resources.jay_crtich_did_it_again_fashion_interview__1__05;
            pictureBox11.Image = Properties.Resources.jay_crtich_did_it_again_fashion_interview__1__06;
            pictureBox12.Image = Properties.Resources.jay_crtich_did_it_again_fashion_interview__1__07;
            pictureBox13.Image = Properties.Resources.jay_crtich_did_it_again_fashion_interview__1__08;
            pictureBox14.Image = Properties.Resources.jay_crtich_did_it_again_fashion_interview__1__04;
            pictureBox15.Image = Properties.Resources.jay_crtich_did_it_again_fashion_interview__1__03;
            pictureBox16.Image = Properties.Resources.jay_crtich_did_it_again_fashion_interview__1__02;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox16.BackColor == Color.White)
            {
                    pictureBox16.Image = pictureBox1.Image;
                    pictureBox16.BackColor = Color.Gray;
                    pictureBox1.Image = Properties.Resources.blankslide;
                    pictureBox1.BackColor = Color.White;
            }

            if (pictureBox10.BackColor == Color.White)
            {
                pictureBox10.Image = pictureBox1.Image;
                pictureBox10.BackColor = Color.Gray;
                pictureBox1.Image = Properties.Resources.blankslide;
                pictureBox1.BackColor = Color.White;
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.White)
            {
                pictureBox1.Image = pictureBox1.Image;
                pictureBox1.BackColor = Color.Gray;
                pictureBox16.Image = Properties.Resources.blankslide;
                pictureBox16.BackColor = Color.White;
            }

            if (pictureBox15.BackColor == Color.White)
            {
                pictureBox15.Image = pictureBox1.Image;
                pictureBox15.BackColor = Color.Gray;
                pictureBox16.Image = Properties.Resources.blankslide;
                pictureBox16.BackColor = Color.White;
            }

            if (pictureBox11.BackColor == Color.White)
            {
                pictureBox11.Image = pictureBox1.Image;
                pictureBox11.BackColor = Color.Gray;
                pictureBox16.Image = Properties.Resources.blankslide;
                pictureBox16.BackColor = Color.White;
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (pictureBox16.BackColor == Color.White)
            {
                pictureBox16.Image = pictureBox1.Image;
                pictureBox16.BackColor = Color.Gray;
                pictureBox15.Image = Properties.Resources.blankslide;
                pictureBox15.BackColor = Color.White;
            }

            if (pictureBox12.BackColor == Color.White)
            {
                pictureBox12.Image = pictureBox1.Image;
                pictureBox12.BackColor = Color.Gray;
                pictureBox15.Image = Properties.Resources.blankslide;
                pictureBox15.BackColor = Color.White;
            }

            if (pictureBox14.BackColor == Color.White)
            {
                pictureBox14.Image = pictureBox1.Image;
                pictureBox14.BackColor = Color.Gray;
                pictureBox15.Image = Properties.Resources.blankslide;
                pictureBox15.BackColor = Color.White;
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (pictureBox15.BackColor == Color.White)
            {
                pictureBox15.Image = pictureBox1.Image;
                pictureBox15.BackColor = Color.Gray;
                pictureBox14.Image = Properties.Resources.blankslide;
                pictureBox14.BackColor = Color.White;
            }

            if (pictureBox13.BackColor == Color.White)
            {
                pictureBox13.Image = pictureBox1.Image;
                pictureBox13.BackColor = Color.Gray;
                pictureBox14.Image = Properties.Resources.blankslide;
                pictureBox14.BackColor = Color.White;
            }

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
                if (pictureBox1.BackColor == Color.White)
                {
                    pictureBox1.Image = pictureBox1.Image;
                    pictureBox1.BackColor = Color.Gray;
                    pictureBox10.Image = Properties.Resources.blankslide;
                    pictureBox10.BackColor = Color.White;
                }

                if (pictureBox15.BackColor == Color.White)
                {
                    pictureBox15.Image = pictureBox1.Image;
                    pictureBox15.BackColor = Color.Gray;
                    pictureBox10.Image = Properties.Resources.blankslide;
                    pictureBox10.BackColor = Color.White;
                }

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (pictureBox10.BackColor == Color.White)
            {
                pictureBox10.Image = pictureBox1.Image;
                pictureBox10.BackColor = Color.Gray;
                pictureBox11.Image = Properties.Resources.blankslide;
                pictureBox11.BackColor = Color.White;
            }

            if (pictureBox16.BackColor == Color.White)
            {
                pictureBox16.Image = pictureBox1.Image;
                pictureBox16.BackColor = Color.Gray;
                pictureBox11.Image = Properties.Resources.blankslide;
                pictureBox11.BackColor = Color.White;
            }

            if (pictureBox8.BackColor == Color.White)
            {
                pictureBox8.Image = pictureBox1.Image;
                pictureBox8.BackColor = Color.Gray;
                pictureBox11.Image = Properties.Resources.blankslide;
                pictureBox11.BackColor = Color.White;
            }

            if (pictureBox12.BackColor == Color.White)
            {
                pictureBox12.Image = pictureBox1.Image;
                pictureBox12.BackColor = Color.Gray;
                pictureBox11.Image = Properties.Resources.blankslide;
                pictureBox11.BackColor = Color.White;
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (pictureBox15.BackColor == Color.White)
            {
                pictureBox15.Image = pictureBox1.Image;
                pictureBox15.BackColor = Color.Gray;
                pictureBox12.Image = Properties.Resources.blankslide;
                pictureBox12.BackColor = Color.White;
            }

            if (pictureBox7.BackColor == Color.White)
            {
                pictureBox7.Image = pictureBox1.Image;
                pictureBox7.BackColor = Color.Gray;
                pictureBox12.Image = Properties.Resources.blankslide;
                pictureBox12.BackColor = Color.White;
            }

            if (pictureBox11.BackColor == Color.White)
            {
                pictureBox11.Image = pictureBox1.Image;
                pictureBox11.BackColor = Color.Gray;
                pictureBox12.Image = Properties.Resources.blankslide;
                pictureBox12.BackColor = Color.White;
            }

            if (pictureBox13.BackColor == Color.White)
            {
                pictureBox13.Image = pictureBox1.Image;
                pictureBox13.BackColor = Color.Gray;
                pictureBox12.Image = Properties.Resources.blankslide;
                pictureBox12.BackColor = Color.White;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (pictureBox14.BackColor == Color.White)
            {
                pictureBox14.Image = pictureBox1.Image;
                pictureBox14.BackColor = Color.Gray;
                pictureBox13.Image = Properties.Resources.blankslide;
                pictureBox13.BackColor = Color.White;
            }

            if (pictureBox12.BackColor == Color.White)
            {
                pictureBox12.Image = pictureBox1.Image;
                pictureBox12.BackColor = Color.Gray;
                pictureBox13.Image = Properties.Resources.blankslide;
                pictureBox13.BackColor = Color.White;
            }

            if (pictureBox2.BackColor == Color.White)
            {
                pictureBox2.Image = pictureBox1.Image;
                pictureBox2.BackColor = Color.Gray;
                pictureBox13.Image = Properties.Resources.blankslide;
                pictureBox13.BackColor = Color.White;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox10.BackColor == Color.White)
            {
                pictureBox10.Image = pictureBox1.Image;
                pictureBox10.BackColor = Color.Gray;
                pictureBox9.Image = Properties.Resources.blankslide;
                pictureBox9.BackColor = Color.White;
            }

            if (pictureBox8.BackColor == Color.White)
            {
                pictureBox8.Image = pictureBox1.Image;
                pictureBox8.BackColor = Color.Gray;
                pictureBox9.Image = Properties.Resources.blankslide;
                pictureBox9.BackColor = Color.White;
            }

            if (pictureBox6.BackColor == Color.White)
            {
                pictureBox6.Image = pictureBox1.Image;
                pictureBox6.BackColor = Color.Gray;
                pictureBox9.Image = Properties.Resources.blankslide;
                pictureBox9.BackColor = Color.White;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox9.BackColor == Color.White)
            {
                pictureBox9.Image = pictureBox1.Image;
                pictureBox9.BackColor = Color.Gray;
                pictureBox8.Image = Properties.Resources.blankslide;
                pictureBox8.BackColor = Color.White;
            }

            if (pictureBox11.BackColor == Color.White)
            {
                pictureBox11.Image = pictureBox1.Image;
                pictureBox11.BackColor = Color.Gray;
                pictureBox8.Image = Properties.Resources.blankslide;
                pictureBox8.BackColor = Color.White;
            }

            if (pictureBox3.BackColor == Color.White)
            {
                pictureBox3.Image = pictureBox1.Image;
                pictureBox3.BackColor = Color.Gray;
                pictureBox8.Image = Properties.Resources.blankslide;
                pictureBox8.BackColor = Color.White;
            }

            if (pictureBox7.BackColor == Color.White)
            {
                pictureBox7.Image = pictureBox1.Image;
                pictureBox7.BackColor = Color.Gray;
                pictureBox8.Image = Properties.Resources.blankslide;
                pictureBox8.BackColor = Color.White;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox8.BackColor == Color.White)
            {
                pictureBox8.Image = pictureBox1.Image;
                pictureBox8.BackColor = Color.Gray;
                pictureBox7.Image = Properties.Resources.blankslide;
                pictureBox7.BackColor = Color.White;
            }

            if (pictureBox12.BackColor == Color.White)
            {
                pictureBox12.Image = pictureBox1.Image;
                pictureBox12.BackColor = Color.Gray;
                pictureBox7.Image = Properties.Resources.blankslide;
                pictureBox7.BackColor = Color.White;
            }

            if (pictureBox4.BackColor == Color.White)
            {
                pictureBox4.Image = pictureBox1.Image;
                pictureBox4.BackColor = Color.Gray;
                pictureBox7.Image = Properties.Resources.blankslide;
                pictureBox7.BackColor = Color.White;
            }

            if (pictureBox2.BackColor == Color.White)
            {
                pictureBox2.Image = pictureBox1.Image;
                pictureBox2.BackColor = Color.Gray;
                pictureBox7.Image = Properties.Resources.blankslide;
                pictureBox7.BackColor = Color.White;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox7.BackColor == Color.White)
            {
                pictureBox7.Image = pictureBox1.Image;
                pictureBox7.BackColor = Color.Gray;
                pictureBox2.Image = Properties.Resources.blankslide;
                pictureBox2.BackColor = Color.White;
            }

            if (pictureBox13.BackColor == Color.White)
            {
                pictureBox13.Image = pictureBox1.Image;
                pictureBox13.BackColor = Color.Gray;
                pictureBox2.Image = Properties.Resources.blankslide;
                pictureBox2.BackColor = Color.White;
            }

            if (pictureBox5.BackColor == Color.White)
            {
                pictureBox5.Image = pictureBox1.Image;
                pictureBox5.BackColor = Color.Gray;
                pictureBox2.Image = Properties.Resources.blankslide;
                pictureBox2.BackColor = Color.White;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox9.BackColor == Color.White)
            {
                pictureBox9.Image = pictureBox1.Image;
                pictureBox9.BackColor = Color.Gray;
                pictureBox6.Image = Properties.Resources.blankslide;
                pictureBox6.BackColor = Color.White;
            }

            if (pictureBox3.BackColor == Color.White)
            {
                pictureBox3.Image = pictureBox1.Image;
                pictureBox3.BackColor = Color.Gray;
                pictureBox6.Image = Properties.Resources.blankslide;
                pictureBox6.BackColor = Color.White;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox6.BackColor == Color.White)
            {
                pictureBox6.Image = pictureBox1.Image;
                pictureBox6.BackColor = Color.Gray;
                pictureBox3.Image = Properties.Resources.blankslide;
                pictureBox3.BackColor = Color.White;
            }

            if (pictureBox4.BackColor == Color.White)
            {
                pictureBox4.Image = pictureBox1.Image;
                pictureBox4.BackColor = Color.Gray;
                pictureBox3.Image = Properties.Resources.blankslide;
                pictureBox3.BackColor = Color.White;
            }

            if (pictureBox8.BackColor == Color.White)
            {
                pictureBox8.Image = pictureBox1.Image;
                pictureBox8.BackColor = Color.Gray;
                pictureBox3.Image = Properties.Resources.blankslide;
                pictureBox3.BackColor = Color.White;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox3.BackColor == Color.White)
            {
                pictureBox3.Image = pictureBox1.Image;
                pictureBox3.BackColor = Color.Gray;
                pictureBox4.Image = Properties.Resources.blankslide;
                pictureBox4.BackColor = Color.White;
            }

            if (pictureBox7.BackColor == Color.White)
            {
                pictureBox7.Image = pictureBox1.Image;
                pictureBox7.BackColor = Color.Gray;
                pictureBox4.Image = Properties.Resources.blankslide;
                pictureBox4.BackColor = Color.White;
            }

            if (pictureBox5.BackColor == Color.White)
            {
                pictureBox5.Image = pictureBox1.Image;
                pictureBox5.BackColor = Color.Gray;
                pictureBox4.Image = Properties.Resources.blankslide;
                pictureBox4.BackColor = Color.White;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox4.BackColor == Color.White)
            {
                pictureBox4.Image = pictureBox1.Image;
                pictureBox4.BackColor = Color.Gray;
                pictureBox5.Image = Properties.Resources.blankslide;
                pictureBox5.BackColor = Color.White;
            }

            if (pictureBox2.BackColor == Color.White)
            {
                pictureBox2.Image = pictureBox1.Image;
                pictureBox2.BackColor = Color.Gray;
                pictureBox5.Image = Properties.Resources.blankslide;
                pictureBox5.BackColor = Color.White;
            }
        }
    }
}
