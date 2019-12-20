using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using QRCoder;
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

namespace CoursCsharpFranckJubin
{
    public partial class Form1 : Form
    {
        string cheminPDF = Directory.GetCurrentDirectory();
        string cheminQR = Directory.GetCurrentDirectory();
        PictureBox maPictureBox = new PictureBox();
        char[] car = { '.'};
        string erreur = "erreur";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbQRCode.Text == "")
            {
                MessageBox.Show("Veuillez entrer un site internet !", erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("http://.www" + tbQRCode.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap codeimage = qrCode.GetGraphic(10, Color.White, Color.Black, true);
            maPictureBox.Width = 500;
            maPictureBox.Height = 500;
            maPictureBox.Image = codeimage;
            this.Controls.Add(maPictureBox);
            var result = MessageBox.Show("Le QR code a bien été généré. Voullez vous l'enregistrer sous forme d'image ?", erreur,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string cheminImage = cheminQR + @"\qr" + tbQRCode.Text.Replace(".", string.Empty) + ".png";
                if(File.Exists(cheminImage))
                {
                    result= MessageBox.Show("L'image existe déjà, voulez vous l'écraser ?", "Ecraser",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                        return;   
                }
                maPictureBox.Image.Save(cheminImage, ImageFormat.Png);
            }
            else
                return; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string img = cheminQR + @"\qr" + tbQRCode.Text.Replace(".", string.Empty) + ".png";
            if (tbQRCode.Text == "")
            {
                MessageBox.Show("Veuillez entrer un site internet !", erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (File.Exists(img))
            {
                File.Delete(img);
                MessageBox.Show("Le fichier qr" + tbQRCode.Text.Replace(".", string.Empty) + ".png a bien été supprimé !");
            }
            else
                MessageBox.Show("Le fichier " + tbQRCode.Text.Replace(".", string.Empty) + ".png n'existe pas !", erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);
            tbQRCode.Text = null;
            maPictureBox.Image = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nomPDF = cheminPDF + @"\"+ tbNomPDF.Text+".PDF";
            if (tbNomPDF.Text == "")
            {
                MessageBox.Show("Veuillez entrer un nom de fichier !", erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbTextPdf.Text == "")
            {
                MessageBox.Show("Veuillez entrer du texte !", erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (File.Exists(nomPDF))
            {
                var result = MessageBox.Show("Le fichier " + tbNomPDF.Text + " existe déja ! Voulez vous l'écraser?", erreur,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
                if (result  == DialogResult.No)
                {
                    return;
                }
            }
            string monTexte = tbTextPdf.Text;

            PdfWriter pdfWriter = new PdfWriter(nomPDF);
            PdfDocument pdfDocument = new PdfDocument(pdfWriter);
            Document document = new Document(pdfDocument);

            document.Add(new Paragraph(monTexte));
            document.Close();
            tbTextPdf.Text = null;
            MessageBox.Show("Le fichier " + tbNomPDF.Text + " a bien été créé !", "Fichier créé", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string pdf = cheminPDF + @"\" + tbNomPDF.Text + ".pdf";
            if(tbNomPDF.Text==null)
            {
                MessageBox.Show("Veuillez entrer un nom de fichier !", erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (File.Exists(pdf))
            {
                System.Diagnostics.Process.Start("explorer.exe", pdf);
            }
            else
                MessageBox.Show("Le fichier " + tbNomPDF.Text + " n'existe pas !", erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string pdf = cheminPDF + @"\" + tbNomPDF.Text + ".pdf";
            if (tbNomPDF.Text == null)
            {
                MessageBox.Show("Veuillez entrer un nom de fichier !", erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (File.Exists(pdf))
            {
                File.Delete(pdf);
                MessageBox.Show("Le fichier "+tbNomPDF.Text+" a bien été supprimé !");
            }
            else
                MessageBox.Show("Le fichier " + tbNomPDF.Text+ " n'existe pas !", erreur, MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPdf_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            browser.Description = "Selectionnez un dossier pour enregistrer les .PDF : ";
            
            if (browser.ShowDialog()== DialogResult.OK)
            {
                MessageBox.Show("Les .PDF seront dès a présent enregistrés ici : " +browser.SelectedPath);
                cheminPDF = browser.SelectedPath;
            }


        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string img = cheminQR + @"\qr" + tbQRCode.Text.Replace(".", string.Empty) + ".png";
            if (tbQRCode.Text == "")
            {
                MessageBox.Show("Veuillez entrer un site internet !", erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (File.Exists(img))
            {
                System.Diagnostics.Process.Start("explorer.exe", img);
            }
            else
                MessageBox.Show("Le fichier " + tbQRCode.Text.Replace(".", string.Empty) + ".png n'existe pas !", erreur, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            browser.Description = "Selectionnez un dossier pour enregistrer les .PDF : ";

            if (browser.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Les images seront dès a présent enregistrés ici : " + browser.SelectedPath);
                cheminQR = browser.SelectedPath;
            }
        }
    }
}
