using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuDuTaquin
{
    public partial class Form1 : Form
    {
        List<Bitmap> images = new List<Bitmap>();
        int j;
        int nullSlice;
        public Form1()
        {
            InitializeComponent();
            Shuffle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void Shuffle()
        {
            do
            {
                Random aleatoire = new Random();

                List<int> indx = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 9 });


                images.AddRange(new List<Bitmap> {Properties.Resources._36_01,
                Properties.Resources._36_02,
                Properties.Resources._36_03,
                Properties.Resources._36_04,
                Properties.Resources._36_05,
                Properties.Resources._36_06,
                Properties.Resources._36_07,
                Properties.Resources._36_08,
                Properties.Resources._36_09,
                Properties.Resources.carré_noir});

                for (int i = 0; i < 9; i++)
                {
                    if (indx.Count != 0)
                    {
                        indx.Remove((j = indx[aleatoire.Next(0, indx.Count)]));
                        if (j == 9)
                        {
                            ((PictureBox)groupBox1.Controls[i]).Image = Properties.Resources.carré_noir;
                            nullSlice = i;
                        }
                        else
                            ((PictureBox)groupBox1.Controls[i]).Image = images[j];
                    }
                }


            } while (CheckWin());
        }

        bool CheckWin()
        {
            int i;
            for (i = 0; i < 8; i++)
            {
                if ((groupBox1.Controls[i] as PictureBox).Image != images[i]) break;
            }
            if (i == 8) return true;
            else return false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shuffle();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }
    }
}
