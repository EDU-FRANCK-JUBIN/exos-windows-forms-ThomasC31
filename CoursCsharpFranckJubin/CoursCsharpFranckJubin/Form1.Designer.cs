namespace CoursCsharpFranckJubin
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btChoixDossier = new System.Windows.Forms.Button();
            this.lbNomPDF = new System.Windows.Forms.Label();
            this.tbNomPDF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btDelPDF = new System.Windows.Forms.Button();
            this.btOuvrirPDF = new System.Windows.Forms.Button();
            this.tbTextPdf = new System.Windows.Forms.TextBox();
            this.btGenererPDF = new System.Windows.Forms.Button();
            this.lbTextPDF = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btCleanQR = new System.Windows.Forms.Button();
            this.lbSite = new System.Windows.Forms.Label();
            this.tbQRCode = new System.Windows.Forms.TextBox();
            this.btGenQR = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btChoixDossier);
            this.groupBox1.Controls.Add(this.lbNomPDF);
            this.groupBox1.Controls.Add(this.tbNomPDF);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btDelPDF);
            this.groupBox1.Controls.Add(this.btOuvrirPDF);
            this.groupBox1.Controls.Add(this.tbTextPdf);
            this.groupBox1.Controls.Add(this.btGenererPDF);
            this.groupBox1.Controls.Add(this.lbTextPDF);
            this.groupBox1.Location = new System.Drawing.Point(418, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 187);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PDF";
            // 
            // btChoixDossier
            // 
            this.btChoixDossier.Location = new System.Drawing.Point(164, 143);
            this.btChoixDossier.Name = "btChoixDossier";
            this.btChoixDossier.Size = new System.Drawing.Size(115, 23);
            this.btChoixDossier.TabIndex = 7;
            this.btChoixDossier.Text = "Changer Repertoire";
            this.btChoixDossier.UseVisualStyleBackColor = true;
            this.btChoixDossier.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbNomPDF
            // 
            this.lbNomPDF.AutoSize = true;
            this.lbNomPDF.Location = new System.Drawing.Point(226, 14);
            this.lbNomPDF.Name = "lbNomPDF";
            this.lbNomPDF.Size = new System.Drawing.Size(53, 13);
            this.lbNomPDF.TabIndex = 6;
            this.lbNomPDF.Text = "Nom PDF";
            // 
            // tbNomPDF
            // 
            this.tbNomPDF.Location = new System.Drawing.Point(18, 30);
            this.tbNomPDF.Name = "tbNomPDF";
            this.tbNomPDF.Size = new System.Drawing.Size(261, 20);
            this.tbNomPDF.TabIndex = 4;
            this.tbNomPDF.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // btDelPDF
            // 
            this.btDelPDF.Location = new System.Drawing.Point(18, 143);
            this.btDelPDF.Name = "btDelPDF";
            this.btDelPDF.Size = new System.Drawing.Size(115, 23);
            this.btDelPDF.TabIndex = 3;
            this.btDelPDF.Text = "Effacer PDF";
            this.btDelPDF.UseVisualStyleBackColor = true;
            this.btDelPDF.Click += new System.EventHandler(this.button5_Click);
            // 
            // btOuvrirPDF
            // 
            this.btOuvrirPDF.Location = new System.Drawing.Point(164, 114);
            this.btOuvrirPDF.Name = "btOuvrirPDF";
            this.btOuvrirPDF.Size = new System.Drawing.Size(115, 23);
            this.btOuvrirPDF.TabIndex = 2;
            this.btOuvrirPDF.Text = "Ouvrir PDF";
            this.btOuvrirPDF.UseVisualStyleBackColor = true;
            this.btOuvrirPDF.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbTextPdf
            // 
            this.tbTextPdf.Location = new System.Drawing.Point(18, 69);
            this.tbTextPdf.Multiline = true;
            this.tbTextPdf.Name = "tbTextPdf";
            this.tbTextPdf.Size = new System.Drawing.Size(261, 39);
            this.tbTextPdf.TabIndex = 0;
            this.tbTextPdf.TextChanged += new System.EventHandler(this.tbPdf_TextChanged);
            // 
            // btGenererPDF
            // 
            this.btGenererPDF.Location = new System.Drawing.Point(18, 114);
            this.btGenererPDF.Name = "btGenererPDF";
            this.btGenererPDF.Size = new System.Drawing.Size(115, 23);
            this.btGenererPDF.TabIndex = 1;
            this.btGenererPDF.Text = "Generer PDF";
            this.btGenererPDF.UseVisualStyleBackColor = true;
            this.btGenererPDF.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbTextPDF
            // 
            this.lbTextPDF.AutoSize = true;
            this.lbTextPDF.Location = new System.Drawing.Point(221, 53);
            this.lbTextPDF.Name = "lbTextPDF";
            this.lbTextPDF.Size = new System.Drawing.Size(58, 13);
            this.lbTextPDF.TabIndex = 1;
            this.lbTextPDF.Text = "Texte PDF";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btCleanQR);
            this.groupBox2.Controls.Add(this.lbSite);
            this.groupBox2.Controls.Add(this.tbQRCode);
            this.groupBox2.Controls.Add(this.btGenQR);
            this.groupBox2.Location = new System.Drawing.Point(418, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 140);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "QR Code";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Changer Repertoire";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ouvrir image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btCleanQR
            // 
            this.btCleanQR.Location = new System.Drawing.Point(18, 89);
            this.btCleanQR.Name = "btCleanQR";
            this.btCleanQR.Size = new System.Drawing.Size(115, 23);
            this.btCleanQR.TabIndex = 2;
            this.btCleanQR.Text = "Effacer QRCode";
            this.btCleanQR.UseVisualStyleBackColor = true;
            this.btCleanQR.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbSite
            // 
            this.lbSite.AutoSize = true;
            this.lbSite.Location = new System.Drawing.Point(18, 20);
            this.lbSite.Name = "lbSite";
            this.lbSite.Size = new System.Drawing.Size(107, 13);
            this.lbSite.TabIndex = 3;
            this.lbSite.Text = "de la forme : site.com";
            // 
            // tbQRCode
            // 
            this.tbQRCode.Location = new System.Drawing.Point(18, 35);
            this.tbQRCode.Name = "tbQRCode";
            this.tbQRCode.Size = new System.Drawing.Size(261, 20);
            this.tbQRCode.TabIndex = 1;
            // 
            // btGenQR
            // 
            this.btGenQR.Location = new System.Drawing.Point(18, 61);
            this.btGenQR.Name = "btGenQR";
            this.btGenQR.Size = new System.Drawing.Size(115, 23);
            this.btGenQR.TabIndex = 0;
            this.btGenQR.Text = "Générer QR CODE";
            this.btGenQR.UseVisualStyleBackColor = true;
            this.btGenQR.Click += new System.EventHandler(this.button1_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btOuvrirPDF;
        private System.Windows.Forms.TextBox tbTextPdf;
        private System.Windows.Forms.Button btGenererPDF;
        private System.Windows.Forms.Label lbTextPDF;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbSite;
        private System.Windows.Forms.Button btCleanQR;
        private System.Windows.Forms.TextBox tbQRCode;
        private System.Windows.Forms.Button btGenQR;
        private System.Windows.Forms.Button btDelPDF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNomPDF;
        private System.Windows.Forms.TextBox tbNomPDF;
        private System.Windows.Forms.Button btChoixDossier;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

