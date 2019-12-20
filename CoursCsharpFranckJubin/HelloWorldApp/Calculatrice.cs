using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldApp
{
    public partial class Calculatrice : Form
    {
        public Calculatrice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string calcul = tbEcran.Text;
            tbEcran.Text = calcul + "1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEgal_Click(object sender, EventArgs e)
        {
            string calcul = tbEcran.Text;
            double cal = double.Parse(calcul);

            tbEcran.Text =  cal.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            
            string calcul = tbEcran.Text;
            tbEcran.Text = calcul + "3";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string calcul = tbEcran.Text;
            tbEcran.Text = calcul + "2";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            string calcul = tbEcran.Text;
            tbEcran.Text = calcul + "0";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string calcul = tbEcran.Text;
            tbEcran.Text = calcul + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string calcul = tbEcran.Text;
            tbEcran.Text = calcul + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string calcul = tbEcran.Text;
            tbEcran.Text = calcul + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            string calcul = tbEcran.Text;
            tbEcran.Text = calcul + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            string calcul = tbEcran.Text;
            tbEcran.Text = calcul + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            string calcul = tbEcran.Text;
            tbEcran.Text = calcul + "9";
        }

        private void btnVirg_Click(object sender, EventArgs e)
        {
            string calcul = tbEcran.Text;
            tbEcran.Text = calcul + ",";
        }

        private void btnPlusMoins_Click(object sender, EventArgs e)
        {
            string calcul = tbEcran.Text;
            double cal = double.Parse(calcul);
            cal = cal * -1;
            
            tbEcran.Text = cal.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            string calcul = tbEcran.Text;
            tbEcran.Text = calcul + "+";
        }

        private void btnMoins_Click(object sender, EventArgs e)
        {
            string calcul = tbEcran.Text;
            tbEcran.Text = calcul + "-";
        }

        private void btnEtoile_Click(object sender, EventArgs e)
        {
            string calcul = tbEcran.Text;
            tbEcran.Text = calcul + "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {

            string bufferChiffre1 = tbEcran.Text;
            tbEcranResult.Text = bufferChiffre1;
            operateur = "/";
            textBox1.Text += " / ";
            textBox2.Text += " / ";
            textBox1.Clear();
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            
            string calcul = tbEcran.Text;
            if (calcul == "")
                tbEcran.Text = "";
            else
            {
                calcul = calcul.Substring(0, calcul.Length - 1);
                tbEcran.Text = calcul;
                    }
        }
    }
}
