namespace Banka_Kuyruk
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDairesel = new System.Windows.Forms.Button();
            this.lblOrtSure = new System.Windows.Forms.Label();
            this.lblOrtSonuc = new System.Windows.Forms.Label();
            this.btnOncelik = new System.Windows.Forms.Button();
            this.lblBaslık = new System.Windows.Forms.Label();
            this.lblDaireselBaslık = new System.Windows.Forms.Label();
            this.LstBoxSure = new System.Windows.Forms.ListBox();
            this.lstBoxSure2 = new System.Windows.Forms.ListBox();
            this.btnOncelik2 = new System.Windows.Forms.Button();
            this.lstBoxDaireselSure = new System.Windows.Forms.ListBox();
            this.lblBuyükten = new System.Windows.Forms.Label();
            this.lblKazanc = new System.Windows.Forms.Label();
            this.btnKazanc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDairesel
            // 
            this.btnDairesel.Location = new System.Drawing.Point(34, 12);
            this.btnDairesel.Name = "btnDairesel";
            this.btnDairesel.Size = new System.Drawing.Size(134, 40);
            this.btnDairesel.TabIndex = 0;
            this.btnDairesel.Text = "DaireselKuyruk Testi";
            this.btnDairesel.UseVisualStyleBackColor = true;
            this.btnDairesel.Click += new System.EventHandler(this.btnDairesel_Click);
            // 
            // lblOrtSure
            // 
            this.lblOrtSure.AutoSize = true;
            this.lblOrtSure.Location = new System.Drawing.Point(476, 315);
            this.lblOrtSure.Name = "lblOrtSure";
            this.lblOrtSure.Size = new System.Drawing.Size(183, 13);
            this.lblOrtSure.TabIndex = 2;
            this.lblOrtSure.Text = "Ortalama İslem Tamamlanma Süresi =";
            // 
            // lblOrtSonuc
            // 
            this.lblOrtSonuc.AutoSize = true;
            this.lblOrtSonuc.Location = new System.Drawing.Point(665, 315);
            this.lblOrtSonuc.Name = "lblOrtSonuc";
            this.lblOrtSonuc.Size = new System.Drawing.Size(13, 13);
            this.lblOrtSonuc.TabIndex = 3;
            this.lblOrtSonuc.Text = "0";
            // 
            // btnOncelik
            // 
            this.btnOncelik.Location = new System.Drawing.Point(34, 68);
            this.btnOncelik.Name = "btnOncelik";
            this.btnOncelik.Size = new System.Drawing.Size(134, 46);
            this.btnOncelik.TabIndex = 4;
            this.btnOncelik.Text = "OncelikKuyruk Testi(Küçükten Büyüğe)";
            this.btnOncelik.UseVisualStyleBackColor = true;
            this.btnOncelik.Click += new System.EventHandler(this.btnOncelik_Click);
            // 
            // lblBaslık
            // 
            this.lblBaslık.AutoSize = true;
            this.lblBaslık.Location = new System.Drawing.Point(476, 9);
            this.lblBaslık.Name = "lblBaslık";
            this.lblBaslık.Size = new System.Drawing.Size(242, 13);
            this.lblBaslık.TabIndex = 5;
            this.lblBaslık.Text = "MüşteriNo---IslemTamamlanmaSuresi---IslemSuresi";
            this.lblBaslık.Visible = false;
            // 
            // lblDaireselBaslık
            // 
            this.lblDaireselBaslık.AutoSize = true;
            this.lblDaireselBaslık.Location = new System.Drawing.Point(228, 9);
            this.lblDaireselBaslık.Name = "lblDaireselBaslık";
            this.lblDaireselBaslık.Size = new System.Drawing.Size(180, 13);
            this.lblDaireselBaslık.TabIndex = 6;
            this.lblDaireselBaslık.Text = "MüşteriNo---IslemTamamlanmaSuresi";
            this.lblDaireselBaslık.Visible = false;
            // 
            // LstBoxSure
            // 
            this.LstBoxSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LstBoxSure.FormattingEnabled = true;
            this.LstBoxSure.Location = new System.Drawing.Point(479, 28);
            this.LstBoxSure.Name = "LstBoxSure";
            this.LstBoxSure.Size = new System.Drawing.Size(235, 277);
            this.LstBoxSure.TabIndex = 1;
            // 
            // lstBoxSure2
            // 
            this.lstBoxSure2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstBoxSure2.FormattingEnabled = true;
            this.lstBoxSure2.Location = new System.Drawing.Point(735, 28);
            this.lstBoxSure2.Name = "lstBoxSure2";
            this.lstBoxSure2.Size = new System.Drawing.Size(235, 277);
            this.lstBoxSure2.TabIndex = 7;
            // 
            // btnOncelik2
            // 
            this.btnOncelik2.Location = new System.Drawing.Point(34, 141);
            this.btnOncelik2.Name = "btnOncelik2";
            this.btnOncelik2.Size = new System.Drawing.Size(134, 46);
            this.btnOncelik2.TabIndex = 8;
            this.btnOncelik2.Text = "OncelikKuyruk Testi(Büyükten Küçüğe)";
            this.btnOncelik2.UseVisualStyleBackColor = true;
            this.btnOncelik2.Click += new System.EventHandler(this.btnOncelik2_Click);
            // 
            // lstBoxDaireselSure
            // 
            this.lstBoxDaireselSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstBoxDaireselSure.FormattingEnabled = true;
            this.lstBoxDaireselSure.Location = new System.Drawing.Point(216, 28);
            this.lstBoxDaireselSure.Name = "lstBoxDaireselSure";
            this.lstBoxDaireselSure.Size = new System.Drawing.Size(235, 277);
            this.lstBoxDaireselSure.TabIndex = 9;
            // 
            // lblBuyükten
            // 
            this.lblBuyükten.AutoSize = true;
            this.lblBuyükten.Location = new System.Drawing.Point(732, 9);
            this.lblBuyükten.Name = "lblBuyükten";
            this.lblBuyükten.Size = new System.Drawing.Size(242, 13);
            this.lblBuyükten.TabIndex = 10;
            this.lblBuyükten.Text = "MüşteriNo---IslemTamamlanmaSuresi---IslemSuresi";
            this.lblBuyükten.Visible = false;
            // 
            // lblKazanc
            // 
            this.lblKazanc.AutoSize = true;
            this.lblKazanc.Location = new System.Drawing.Point(12, 315);
            this.lblKazanc.Name = "lblKazanc";
            this.lblKazanc.Size = new System.Drawing.Size(200, 13);
            this.lblKazanc.TabIndex = 11;
            this.lblKazanc.Text = "Kazanç yoktur(Degerler aynı gelmektedir)";
            this.lblKazanc.Visible = false;
            // 
            // btnKazanc
            // 
            this.btnKazanc.Location = new System.Drawing.Point(34, 130);
            this.btnKazanc.Name = "btnKazanc";
            this.btnKazanc.Size = new System.Drawing.Size(134, 46);
            this.btnKazanc.TabIndex = 12;
            this.btnKazanc.Text = "Kazanc Hesapla";
            this.btnKazanc.UseVisualStyleBackColor = true;
            this.btnKazanc.Click += new System.EventHandler(this.btnKazanc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 337);
            this.Controls.Add(this.btnKazanc);
            this.Controls.Add(this.lblKazanc);
            this.Controls.Add(this.lblBuyükten);
            this.Controls.Add(this.lstBoxDaireselSure);
            this.Controls.Add(this.lstBoxSure2);
            this.Controls.Add(this.lblDaireselBaslık);
            this.Controls.Add(this.lblBaslık);
            this.Controls.Add(this.btnOncelik);
            this.Controls.Add(this.lblOrtSonuc);
            this.Controls.Add(this.lblOrtSure);
            this.Controls.Add(this.LstBoxSure);
            this.Controls.Add(this.btnDairesel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnDairesel;
        private System.Windows.Forms.Label lblOrtSure;
        private System.Windows.Forms.Label lblOrtSonuc;
        public System.Windows.Forms.Button btnOncelik;
        private System.Windows.Forms.Label lblBaslık;
        private System.Windows.Forms.Label lblDaireselBaslık;
        private System.Windows.Forms.ListBox LstBoxSure;
        private System.Windows.Forms.ListBox lstBoxSure2;
        public System.Windows.Forms.Button btnOncelik2;
        private System.Windows.Forms.ListBox lstBoxDaireselSure;
        private System.Windows.Forms.Label lblBuyükten;
        private System.Windows.Forms.Label lblKazanc;
        public System.Windows.Forms.Button btnKazanc;
    }
}

