
namespace PazarProjesi
{
    partial class SaticiKurFormu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblusd = new System.Windows.Forms.Label();
            this.lbleuro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblsterlin = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtKur = new System.Windows.Forms.TextBox();
            this.btnUsd = new System.Windows.Forms.Button();
            this.btnEUR = new System.Windows.Forms.Button();
            this.btnGBP = new System.Windows.Forms.Button();
            this.lblTarih = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 4);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "1 USD =";
            // 
            // lblusd
            // 
            this.lblusd.AutoSize = true;
            this.lblusd.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblusd.Location = new System.Drawing.Point(221, 9);
            this.lblusd.Name = "lblusd";
            this.lblusd.Size = new System.Drawing.Size(61, 23);
            this.lblusd.TabIndex = 2;
            this.lblusd.Text = "1 Dolar =";
            // 
            // lbleuro
            // 
            this.lbleuro.AutoSize = true;
            this.lbleuro.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbleuro.Location = new System.Drawing.Point(376, 9);
            this.lbleuro.Name = "lbleuro";
            this.lbleuro.Size = new System.Drawing.Size(61, 23);
            this.lbleuro.TabIndex = 4;
            this.lbleuro.Text = "1 Dolar =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(325, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "1 Euro =";
            // 
            // lblsterlin
            // 
            this.lblsterlin.AutoSize = true;
            this.lblsterlin.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsterlin.Location = new System.Drawing.Point(554, 9);
            this.lblsterlin.Name = "lblsterlin";
            this.lblsterlin.Size = new System.Drawing.Size(61, 23);
            this.lblsterlin.TabIndex = 6;
            this.lblsterlin.Text = "1 Dolar =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(491, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "1 Sterlin =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Sabit Kur Fiyatları:";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(935, 362);
            this.webBrowser1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.webBrowser1);
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(935, 362);
            this.panel2.TabIndex = 9;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(856, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(67, 23);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "GERİ DÖN";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // txtKur
            // 
            this.txtKur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.txtKur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKur.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.txtKur.Location = new System.Drawing.Point(101, 426);
            this.txtKur.Margin = new System.Windows.Forms.Padding(4);
            this.txtKur.Name = "txtKur";
            this.txtKur.Size = new System.Drawing.Size(179, 30);
            this.txtKur.TabIndex = 11;
            // 
            // btnUsd
            // 
            this.btnUsd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnUsd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsd.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUsd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnUsd.Location = new System.Drawing.Point(287, 426);
            this.btnUsd.Name = "btnUsd";
            this.btnUsd.Size = new System.Drawing.Size(173, 31);
            this.btnUsd.TabIndex = 12;
            this.btnUsd.Text = "USD";
            this.btnUsd.UseVisualStyleBackColor = false;
            this.btnUsd.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnEUR
            // 
            this.btnEUR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnEUR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEUR.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEUR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnEUR.Location = new System.Drawing.Point(466, 426);
            this.btnEUR.Name = "btnEUR";
            this.btnEUR.Size = new System.Drawing.Size(173, 31);
            this.btnEUR.TabIndex = 13;
            this.btnEUR.Text = "EUR";
            this.btnEUR.UseVisualStyleBackColor = false;
            this.btnEUR.Click += new System.EventHandler(this.btnEUR_Click);
            // 
            // btnGBP
            // 
            this.btnGBP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.btnGBP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGBP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGBP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnGBP.Location = new System.Drawing.Point(645, 426);
            this.btnGBP.Name = "btnGBP";
            this.btnGBP.Size = new System.Drawing.Size(173, 31);
            this.btnGBP.TabIndex = 14;
            this.btnGBP.Text = "GBP";
            this.btnGBP.UseVisualStyleBackColor = false;
            this.btnGBP.Click += new System.EventHandler(this.btnGBP_Click);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(687, 9);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(61, 23);
            this.lblTarih.TabIndex = 15;
            this.lblTarih.Text = "1 Dolar =";
            // 
            // SaticiKurFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(935, 469);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.btnGBP);
            this.Controls.Add(this.btnEUR);
            this.Controls.Add(this.btnUsd);
            this.Controls.Add(this.txtKur);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblsterlin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbleuro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblusd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaticiKurFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciKurFormu";
            this.Load += new System.EventHandler(this.KullaniciKurFormu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KullaniciKurFormu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KullaniciKurFormu_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.KullaniciKurFormu_MouseUp);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblusd;
        private System.Windows.Forms.Label lbleuro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblsterlin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtKur;
        private System.Windows.Forms.Button btnUsd;
        private System.Windows.Forms.Button btnEUR;
        private System.Windows.Forms.Button btnGBP;
        private System.Windows.Forms.Label lblTarih;
    }
}