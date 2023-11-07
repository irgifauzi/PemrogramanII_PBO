namespace P6_4_714220035
{
    partial class txtKodeTiket
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(txtKodeTiket));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtJumlahTiket = new System.Windows.Forms.NumericUpDown();
            this.txtTelpon = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bKuningan = new System.Windows.Forms.RadioButton();
            this.bBekasi = new System.Windows.Forms.RadioButton();
            this.bSemarang = new System.Windows.Forms.RadioButton();
            this.bJakarta = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKelamin = new System.Windows.Forms.ComboBox();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtKirim = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUmur = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLower = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtJumlahTiket)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "PENDAFTARAN PEMESANAN BUS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Jumlah Tiket";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nomor Telepon";
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(337, 116);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(120, 31);
            this.txtNama.TabIndex = 4;
            this.txtNama.Leave += new System.EventHandler(this.txtNama_Leave);
            // 
            // txtJumlahTiket
            // 
            this.txtJumlahTiket.Location = new System.Drawing.Point(337, 171);
            this.txtJumlahTiket.Name = "txtJumlahTiket";
            this.txtJumlahTiket.Size = new System.Drawing.Size(120, 26);
            this.txtJumlahTiket.TabIndex = 5;
            // 
            // txtTelpon
            // 
            this.txtTelpon.Location = new System.Drawing.Point(336, 238);
            this.txtTelpon.Name = "txtTelpon";
            this.txtTelpon.Size = new System.Drawing.Size(121, 26);
            this.txtTelpon.TabIndex = 6;
            this.txtTelpon.Leave += new System.EventHandler(this.txtTelpon_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::P6_4_714220035.Properties.Resources.IMG_20220602_WA0017_1_768x576;
            this.groupBox1.Controls.Add(this.bKuningan);
            this.groupBox1.Controls.Add(this.bBekasi);
            this.groupBox1.Controls.Add(this.bSemarang);
            this.groupBox1.Controls.Add(this.bJakarta);
            this.groupBox1.Location = new System.Drawing.Point(530, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 228);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tujuan Keberangkatan";
            // 
            // bKuningan
            // 
            this.bKuningan.AutoSize = true;
            this.bKuningan.Location = new System.Drawing.Point(16, 189);
            this.bKuningan.Name = "bKuningan";
            this.bKuningan.Size = new System.Drawing.Size(272, 24);
            this.bKuningan.TabIndex = 3;
            this.bKuningan.TabStop = true;
            this.bKuningan.Text = "Bandung-Kuningan, 10.00 - 14.00";
            this.bKuningan.UseVisualStyleBackColor = true;
            // 
            // bBekasi
            // 
            this.bBekasi.AutoSize = true;
            this.bBekasi.Location = new System.Drawing.Point(16, 138);
            this.bBekasi.Name = "bBekasi";
            this.bBekasi.Size = new System.Drawing.Size(253, 24);
            this.bBekasi.TabIndex = 2;
            this.bBekasi.TabStop = true;
            this.bBekasi.Text = "Bandung-Bekasi, 09.00 - 13.00";
            this.bBekasi.UseVisualStyleBackColor = true;
            // 
            // bSemarang
            // 
            this.bSemarang.AutoSize = true;
            this.bSemarang.Location = new System.Drawing.Point(16, 91);
            this.bSemarang.Name = "bSemarang";
            this.bSemarang.Size = new System.Drawing.Size(279, 24);
            this.bSemarang.TabIndex = 1;
            this.bSemarang.TabStop = true;
            this.bSemarang.Text = "Bandung-Semarang, 08.00 - 12.00";
            this.bSemarang.UseVisualStyleBackColor = true;
            // 
            // bJakarta
            // 
            this.bJakarta.AutoSize = true;
            this.bJakarta.Location = new System.Drawing.Point(19, 43);
            this.bJakarta.Name = "bJakarta";
            this.bJakarta.Size = new System.Drawing.Size(262, 24);
            this.bJakarta.TabIndex = 0;
            this.bJakarta.TabStop = true;
            this.bJakarta.Text = "Bandung-Jakarta, 07.00 - 11.00 ";
            this.bJakarta.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Jenis Kelamin";
            this.label5.Leave += new System.EventHandler(this.label5_Leave);
            // 
            // txtKelamin
            // 
            this.txtKelamin.FormattingEnabled = true;
            this.txtKelamin.Items.AddRange(new object[] {
            "Pria",
            "Wanita"});
            this.txtKelamin.Location = new System.Drawing.Point(337, 296);
            this.txtKelamin.Name = "txtKelamin";
            this.txtKelamin.Size = new System.Drawing.Size(121, 28);
            this.txtKelamin.TabIndex = 9;
            this.txtKelamin.Leave += new System.EventHandler(this.txtKelamin_Leave);
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(145, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(338, 360);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(120, 26);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtKirim
            // 
            this.txtKirim.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKirim.Location = new System.Drawing.Point(336, 460);
            this.txtKirim.Name = "txtKirim";
            this.txtKirim.Size = new System.Drawing.Size(88, 37);
            this.txtKirim.TabIndex = 12;
            this.txtKirim.Text = "Kirim";
            this.txtKirim.UseVisualStyleBackColor = true;
            this.txtKirim.Click += new System.EventHandler(this.txtKirim_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(496, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 13;
            this.button2.Text = "Batal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(147, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "Umur";
            // 
            // txtUmur
            // 
            this.txtUmur.Location = new System.Drawing.Point(338, 410);
            this.txtUmur.Name = "txtUmur";
            this.txtUmur.Size = new System.Drawing.Size(120, 26);
            this.txtUmur.TabIndex = 15;
            this.txtUmur.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtUmur.Leave += new System.EventHandler(this.txtUmur_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(855, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 26);
            this.label8.TabIndex = 16;
            this.label8.Text = "Kode Tiket";
            // 
            // txtLower
            // 
            this.txtLower.Location = new System.Drawing.Point(974, 140);
            this.txtLower.Name = "txtLower";
            this.txtLower.Size = new System.Drawing.Size(100, 26);
            this.txtLower.TabIndex = 17;
            this.txtLower.TextChanged += new System.EventHandler(this.txtLower_TextChanged);
            // 
            // txtKodeTiket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::P6_4_714220035.Properties.Resources.IMG_20220602_WA0017_1_768x576;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1190, 544);
            this.Controls.Add(this.txtLower);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUmur);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtKirim);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKelamin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTelpon);
            this.Controls.Add(this.txtJumlahTiket);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "txtKodeTiket";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txtJumlahTiket)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.NumericUpDown txtJumlahTiket;
        private System.Windows.Forms.TextBox txtTelpon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton bKuningan;
        private System.Windows.Forms.RadioButton bBekasi;
        private System.Windows.Forms.RadioButton bSemarang;
        private System.Windows.Forms.RadioButton bJakarta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtKelamin;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button txtKirim;
        private System.Windows.Forms.TextBox txtUmur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLower;
    }
}

