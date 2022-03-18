namespace YazarEser_EntityFramework
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
            this.tabtab = new System.Windows.Forms.TabControl();
            this.tabAnasayfa = new System.Windows.Forms.TabPage();
            this.tabYazar = new System.Windows.Forms.TabPage();
            this.tabEser = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboYazarlarEserler = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnEkleEser = new System.Windows.Forms.Button();
            this.btnIptalEser = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstEserEserler = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTamAdYazarlar = new System.Windows.Forms.TextBox();
            this.txtResimYoluYazarlar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEkleYazar = new System.Windows.Forms.Button();
            this.btnIptalYazar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lstYazarlarYazarlar = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboTamAd = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lstEserAnasayfa = new System.Windows.Forms.ListBox();
            this.pboYazar = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEserAnasayfa = new System.Windows.Forms.TextBox();
            this.tabtab.SuspendLayout();
            this.tabAnasayfa.SuspendLayout();
            this.tabYazar.SuspendLayout();
            this.tabEser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboYazar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabtab
            // 
            this.tabtab.Controls.Add(this.tabAnasayfa);
            this.tabtab.Controls.Add(this.tabYazar);
            this.tabtab.Controls.Add(this.tabEser);
            this.tabtab.Location = new System.Drawing.Point(12, 12);
            this.tabtab.MinimumSize = new System.Drawing.Size(774, 492);
            this.tabtab.Name = "tabtab";
            this.tabtab.SelectedIndex = 0;
            this.tabtab.Size = new System.Drawing.Size(774, 492);
            this.tabtab.TabIndex = 0;
            // 
            // tabAnasayfa
            // 
            this.tabAnasayfa.Controls.Add(this.txtEserAnasayfa);
            this.tabAnasayfa.Controls.Add(this.label10);
            this.tabAnasayfa.Controls.Add(this.pboYazar);
            this.tabAnasayfa.Controls.Add(this.lstEserAnasayfa);
            this.tabAnasayfa.Controls.Add(this.label9);
            this.tabAnasayfa.Controls.Add(this.cboTamAd);
            this.tabAnasayfa.Controls.Add(this.label8);
            this.tabAnasayfa.Location = new System.Drawing.Point(4, 27);
            this.tabAnasayfa.Name = "tabAnasayfa";
            this.tabAnasayfa.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnasayfa.Size = new System.Drawing.Size(766, 461);
            this.tabAnasayfa.TabIndex = 0;
            this.tabAnasayfa.Text = "Anasayfa";
            this.tabAnasayfa.UseVisualStyleBackColor = true;
            // 
            // tabYazar
            // 
            this.tabYazar.Controls.Add(this.lstYazarlarYazarlar);
            this.tabYazar.Controls.Add(this.label7);
            this.tabYazar.Controls.Add(this.groupBox2);
            this.tabYazar.Location = new System.Drawing.Point(4, 27);
            this.tabYazar.Name = "tabYazar";
            this.tabYazar.Padding = new System.Windows.Forms.Padding(3);
            this.tabYazar.Size = new System.Drawing.Size(766, 461);
            this.tabYazar.TabIndex = 1;
            this.tabYazar.Text = "Yazarlar";
            this.tabYazar.UseVisualStyleBackColor = true;
            // 
            // tabEser
            // 
            this.tabEser.Controls.Add(this.lstEserEserler);
            this.tabEser.Controls.Add(this.label4);
            this.tabEser.Controls.Add(this.groupBox1);
            this.tabEser.Location = new System.Drawing.Point(4, 27);
            this.tabEser.Name = "tabEser";
            this.tabEser.Padding = new System.Windows.Forms.Padding(3);
            this.tabEser.Size = new System.Drawing.Size(766, 461);
            this.tabEser.TabIndex = 2;
            this.tabEser.Text = "Eserler";
            this.tabEser.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIptalEser);
            this.groupBox1.Controls.Add(this.btnEkleEser);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboYazarlarEserler);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 444);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eser Ekle";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 24);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eser Başlık :";
            // 
            // cboYazarlarEserler
            // 
            this.cboYazarlarEserler.DisplayMember = "TamAd";
            this.cboYazarlarEserler.FormattingEnabled = true;
            this.cboYazarlarEserler.Location = new System.Drawing.Point(101, 59);
            this.cboYazarlarEserler.Name = "cboYazarlarEserler";
            this.cboYazarlarEserler.Size = new System.Drawing.Size(226, 26);
            this.cboYazarlarEserler.TabIndex = 2;
            this.cboYazarlarEserler.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yazar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Eser İçerik :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 113);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(318, 283);
            this.textBox2.TabIndex = 5;
            // 
            // btnEkleEser
            // 
            this.btnEkleEser.Location = new System.Drawing.Point(252, 402);
            this.btnEkleEser.Name = "btnEkleEser";
            this.btnEkleEser.Size = new System.Drawing.Size(75, 36);
            this.btnEkleEser.TabIndex = 6;
            this.btnEkleEser.Text = "Ekle";
            this.btnEkleEser.UseVisualStyleBackColor = true;
            // 
            // btnIptalEser
            // 
            this.btnIptalEser.Location = new System.Drawing.Point(159, 402);
            this.btnIptalEser.Name = "btnIptalEser";
            this.btnIptalEser.Size = new System.Drawing.Size(75, 36);
            this.btnIptalEser.TabIndex = 7;
            this.btnIptalEser.Text = "İptal";
            this.btnIptalEser.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Eserler : ";
            // 
            // lstEserEserler
            // 
            this.lstEserEserler.FormattingEnabled = true;
            this.lstEserEserler.ItemHeight = 18;
            this.lstEserEserler.Location = new System.Drawing.Point(348, 29);
            this.lstEserEserler.Name = "lstEserEserler";
            this.lstEserEserler.Size = new System.Drawing.Size(412, 418);
            this.lstEserEserler.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIptalYazar);
            this.groupBox2.Controls.Add(this.btnEkleYazar);
            this.groupBox2.Controls.Add(this.txtResimYoluYazarlar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTamAdYazarlar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(11, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 148);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "YazarEkle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tam Ad :";
            // 
            // txtTamAdYazarlar
            // 
            this.txtTamAdYazarlar.Location = new System.Drawing.Point(109, 25);
            this.txtTamAdYazarlar.Name = "txtTamAdYazarlar";
            this.txtTamAdYazarlar.Size = new System.Drawing.Size(221, 24);
            this.txtTamAdYazarlar.TabIndex = 1;
            // 
            // txtResimYoluYazarlar
            // 
            this.txtResimYoluYazarlar.Location = new System.Drawing.Point(109, 73);
            this.txtResimYoluYazarlar.Name = "txtResimYoluYazarlar";
            this.txtResimYoluYazarlar.Size = new System.Drawing.Size(221, 24);
            this.txtResimYoluYazarlar.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Resim Yolu :";
            // 
            // btnEkleYazar
            // 
            this.btnEkleYazar.Location = new System.Drawing.Point(255, 110);
            this.btnEkleYazar.Name = "btnEkleYazar";
            this.btnEkleYazar.Size = new System.Drawing.Size(75, 32);
            this.btnEkleYazar.TabIndex = 4;
            this.btnEkleYazar.Text = "Ekle";
            this.btnEkleYazar.UseVisualStyleBackColor = true;
            this.btnEkleYazar.Click += new System.EventHandler(this.btnEkleYazar_Click);
            // 
            // btnIptalYazar
            // 
            this.btnIptalYazar.Location = new System.Drawing.Point(165, 110);
            this.btnIptalYazar.Name = "btnIptalYazar";
            this.btnIptalYazar.Size = new System.Drawing.Size(75, 32);
            this.btnIptalYazar.TabIndex = 5;
            this.btnIptalYazar.Text = "İptal";
            this.btnIptalYazar.UseVisualStyleBackColor = true;
            this.btnIptalYazar.Click += new System.EventHandler(this.btnIptalYazar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Yazarlar :";
            // 
            // lstYazarlarYazarlar
            // 
            this.lstYazarlarYazarlar.DisplayMember = "TamAd";
            this.lstYazarlarYazarlar.FormattingEnabled = true;
            this.lstYazarlarYazarlar.ItemHeight = 18;
            this.lstYazarlarYazarlar.Location = new System.Drawing.Point(9, 196);
            this.lstYazarlarYazarlar.Name = "lstYazarlarYazarlar";
            this.lstYazarlarYazarlar.Size = new System.Drawing.Size(746, 256);
            this.lstYazarlarYazarlar.TabIndex = 7;
            this.lstYazarlarYazarlar.ValueMember = "Id";
            this.lstYazarlarYazarlar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstYazarlarYazarlar_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tam Ad :";
            // 
            // cboTamAd
            // 
            this.cboTamAd.DisplayMember = "TamAd";
            this.cboTamAd.FormattingEnabled = true;
            this.cboTamAd.Location = new System.Drawing.Point(97, 18);
            this.cboTamAd.Name = "cboTamAd";
            this.cboTamAd.Size = new System.Drawing.Size(252, 26);
            this.cboTamAd.TabIndex = 2;
            this.cboTamAd.ValueMember = "Id";
            this.cboTamAd.SelectedIndexChanged += new System.EventHandler(this.cboTamAd_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(373, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "Eserler :";
            // 
            // lstEserAnasayfa
            // 
            this.lstEserAnasayfa.DisplayMember = "Baslik";
            this.lstEserAnasayfa.FormattingEnabled = true;
            this.lstEserAnasayfa.ItemHeight = 18;
            this.lstEserAnasayfa.Location = new System.Drawing.Point(376, 60);
            this.lstEserAnasayfa.Name = "lstEserAnasayfa";
            this.lstEserAnasayfa.Size = new System.Drawing.Size(366, 94);
            this.lstEserAnasayfa.TabIndex = 5;
            this.lstEserAnasayfa.ValueMember = "Id";
            this.lstEserAnasayfa.SelectedIndexChanged += new System.EventHandler(this.lstEserAnasayfa_SelectedIndexChanged);
            // 
            // pboYazar
            // 
            this.pboYazar.Location = new System.Drawing.Point(18, 60);
            this.pboYazar.Name = "pboYazar";
            this.pboYazar.Size = new System.Drawing.Size(331, 381);
            this.pboYazar.TabIndex = 6;
            this.pboYazar.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(373, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "Eser :";
            // 
            // txtEserAnasayfa
            // 
            this.txtEserAnasayfa.Location = new System.Drawing.Point(376, 195);
            this.txtEserAnasayfa.Multiline = true;
            this.txtEserAnasayfa.Name = "txtEserAnasayfa";
            this.txtEserAnasayfa.ReadOnly = true;
            this.txtEserAnasayfa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEserAnasayfa.Size = new System.Drawing.Size(366, 246);
            this.txtEserAnasayfa.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 516);
            this.Controls.Add(this.tabtab);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(814, 555);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabtab.ResumeLayout(false);
            this.tabAnasayfa.ResumeLayout(false);
            this.tabAnasayfa.PerformLayout();
            this.tabYazar.ResumeLayout(false);
            this.tabYazar.PerformLayout();
            this.tabEser.ResumeLayout(false);
            this.tabEser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboYazar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabtab;
        private System.Windows.Forms.TabPage tabAnasayfa;
        private System.Windows.Forms.TabPage tabYazar;
        private System.Windows.Forms.TabPage tabEser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIptalEser;
        private System.Windows.Forms.Button btnEkleEser;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboYazarlarEserler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lstEserEserler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIptalYazar;
        private System.Windows.Forms.Button btnEkleYazar;
        private System.Windows.Forms.TextBox txtResimYoluYazarlar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTamAdYazarlar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstEserAnasayfa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboTamAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstYazarlarYazarlar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEserAnasayfa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pboYazar;
    }
}

