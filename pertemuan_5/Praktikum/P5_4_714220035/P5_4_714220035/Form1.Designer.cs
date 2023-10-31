namespace P5_4_714220035
{
    partial class form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtKelamin = new System.Windows.Forms.ComboBox();
            this.txtTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.KelasGroupBox = new System.Windows.Forms.GroupBox();
            this.cbKomposer = new System.Windows.Forms.CheckBox();
            this.cbVokal = new System.Windows.Forms.CheckBox();
            this.cbDrum = new System.Windows.Forms.CheckBox();
            this.cbBiola = new System.Windows.Forms.CheckBox();
            this.cbGitar = new System.Windows.Forms.CheckBox();
            this.cbSaxophone = new System.Windows.Forms.CheckBox();
            this.cbKonduktor = new System.Windows.Forms.CheckBox();
            this.cbPiano = new System.Windows.Forms.CheckBox();
            this.JadwalGroupBox = new System.Windows.Forms.GroupBox();
            this.rb_Minggu = new System.Windows.Forms.RadioButton();
            this.rb_Sabtu = new System.Windows.Forms.RadioButton();
            this.rb_Selasa = new System.Windows.Forms.RadioButton();
            this.rb_Senin = new System.Windows.Forms.RadioButton();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.KelasGroupBox.SuspendLayout();
            this.JadwalGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tanggal Lahir";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(428, 78);
            this.txtNama.Margin = new System.Windows.Forms.Padding(4);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(236, 31);
            this.txtNama.TabIndex = 3;
            // 
            // txtKelamin
            // 
            this.txtKelamin.FormattingEnabled = true;
            this.txtKelamin.Items.AddRange(new object[] {
            "Pria",
            "Wanita"});
            this.txtKelamin.Location = new System.Drawing.Point(428, 142);
            this.txtKelamin.Margin = new System.Windows.Forms.Padding(4);
            this.txtKelamin.Name = "txtKelamin";
            this.txtKelamin.Size = new System.Drawing.Size(236, 34);
            this.txtKelamin.TabIndex = 4;
            this.txtKelamin.Text = "--Pilih Jenis Kelamin--";
            // 
            // txtTanggalLahir
            // 
            this.txtTanggalLahir.Location = new System.Drawing.Point(428, 212);
            this.txtTanggalLahir.Margin = new System.Windows.Forms.Padding(4);
            this.txtTanggalLahir.Name = "txtTanggalLahir";
            this.txtTanggalLahir.Size = new System.Drawing.Size(265, 31);
            this.txtTanggalLahir.TabIndex = 5;
            // 
            // KelasGroupBox
            // 
            this.KelasGroupBox.Controls.Add(this.cbKomposer);
            this.KelasGroupBox.Controls.Add(this.cbVokal);
            this.KelasGroupBox.Controls.Add(this.cbDrum);
            this.KelasGroupBox.Controls.Add(this.cbBiola);
            this.KelasGroupBox.Controls.Add(this.cbGitar);
            this.KelasGroupBox.Controls.Add(this.cbSaxophone);
            this.KelasGroupBox.Controls.Add(this.cbKonduktor);
            this.KelasGroupBox.Controls.Add(this.cbPiano);
            this.KelasGroupBox.Location = new System.Drawing.Point(49, 274);
            this.KelasGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.KelasGroupBox.Name = "KelasGroupBox";
            this.KelasGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.KelasGroupBox.Size = new System.Drawing.Size(426, 320);
            this.KelasGroupBox.TabIndex = 6;
            this.KelasGroupBox.TabStop = false;
            this.KelasGroupBox.Text = "Pilihan Kelas";
            // 
            // cbKomposer
            // 
            this.cbKomposer.AutoSize = true;
            this.cbKomposer.Location = new System.Drawing.Point(228, 260);
            this.cbKomposer.Margin = new System.Windows.Forms.Padding(4);
            this.cbKomposer.Name = "cbKomposer";
            this.cbKomposer.Size = new System.Drawing.Size(131, 30);
            this.cbKomposer.TabIndex = 14;
            this.cbKomposer.Text = "Komposer";
            this.cbKomposer.UseVisualStyleBackColor = true;
            // 
            // cbVokal
            // 
            this.cbVokal.AutoSize = true;
            this.cbVokal.Location = new System.Drawing.Point(228, 195);
            this.cbVokal.Margin = new System.Windows.Forms.Padding(4);
            this.cbVokal.Name = "cbVokal";
            this.cbVokal.Size = new System.Drawing.Size(87, 30);
            this.cbVokal.TabIndex = 13;
            this.cbVokal.Text = "Vokal";
            this.cbVokal.UseVisualStyleBackColor = true;
            // 
            // cbDrum
            // 
            this.cbDrum.AutoSize = true;
            this.cbDrum.Location = new System.Drawing.Point(228, 126);
            this.cbDrum.Margin = new System.Windows.Forms.Padding(4);
            this.cbDrum.Name = "cbDrum";
            this.cbDrum.Size = new System.Drawing.Size(89, 30);
            this.cbDrum.TabIndex = 12;
            this.cbDrum.Text = "Drum";
            this.cbDrum.UseVisualStyleBackColor = true;
            // 
            // cbBiola
            // 
            this.cbBiola.AutoSize = true;
            this.cbBiola.Location = new System.Drawing.Point(0, 53);
            this.cbBiola.Margin = new System.Windows.Forms.Padding(4);
            this.cbBiola.Name = "cbBiola";
            this.cbBiola.Size = new System.Drawing.Size(84, 30);
            this.cbBiola.TabIndex = 7;
            this.cbBiola.Text = "Biola";
            this.cbBiola.UseVisualStyleBackColor = true;
            // 
            // cbGitar
            // 
            this.cbGitar.AutoSize = true;
            this.cbGitar.Location = new System.Drawing.Point(0, 126);
            this.cbGitar.Margin = new System.Windows.Forms.Padding(4);
            this.cbGitar.Name = "cbGitar";
            this.cbGitar.Size = new System.Drawing.Size(85, 30);
            this.cbGitar.TabIndex = 8;
            this.cbGitar.Text = "Gitar";
            this.cbGitar.UseVisualStyleBackColor = true;
            // 
            // cbSaxophone
            // 
            this.cbSaxophone.AutoSize = true;
            this.cbSaxophone.Location = new System.Drawing.Point(0, 195);
            this.cbSaxophone.Margin = new System.Windows.Forms.Padding(4);
            this.cbSaxophone.Name = "cbSaxophone";
            this.cbSaxophone.Size = new System.Drawing.Size(140, 30);
            this.cbSaxophone.TabIndex = 9;
            this.cbSaxophone.Text = "Saxophone";
            this.cbSaxophone.UseVisualStyleBackColor = true;
            // 
            // cbKonduktor
            // 
            this.cbKonduktor.AutoSize = true;
            this.cbKonduktor.Location = new System.Drawing.Point(0, 260);
            this.cbKonduktor.Margin = new System.Windows.Forms.Padding(4);
            this.cbKonduktor.Name = "cbKonduktor";
            this.cbKonduktor.Size = new System.Drawing.Size(136, 30);
            this.cbKonduktor.TabIndex = 10;
            this.cbKonduktor.Text = "Konduktor";
            this.cbKonduktor.UseVisualStyleBackColor = true;
            // 
            // cbPiano
            // 
            this.cbPiano.AutoSize = true;
            this.cbPiano.Location = new System.Drawing.Point(228, 53);
            this.cbPiano.Margin = new System.Windows.Forms.Padding(4);
            this.cbPiano.Name = "cbPiano";
            this.cbPiano.Size = new System.Drawing.Size(90, 30);
            this.cbPiano.TabIndex = 11;
            this.cbPiano.Text = "Piano";
            this.cbPiano.UseVisualStyleBackColor = true;
            // 
            // JadwalGroupBox
            // 
            this.JadwalGroupBox.Controls.Add(this.rb_Minggu);
            this.JadwalGroupBox.Controls.Add(this.rb_Sabtu);
            this.JadwalGroupBox.Controls.Add(this.rb_Selasa);
            this.JadwalGroupBox.Controls.Add(this.rb_Senin);
            this.JadwalGroupBox.Location = new System.Drawing.Point(563, 274);
            this.JadwalGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.JadwalGroupBox.Name = "JadwalGroupBox";
            this.JadwalGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.JadwalGroupBox.Size = new System.Drawing.Size(435, 320);
            this.JadwalGroupBox.TabIndex = 15;
            this.JadwalGroupBox.TabStop = false;
            this.JadwalGroupBox.Text = "Pilihan Jadwal";
            // 
            // rb_Minggu
            // 
            this.rb_Minggu.AutoSize = true;
            this.rb_Minggu.Location = new System.Drawing.Point(25, 224);
            this.rb_Minggu.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Minggu.Name = "rb_Minggu";
            this.rb_Minggu.Size = new System.Drawing.Size(232, 30);
            this.rb_Minggu.TabIndex = 19;
            this.rb_Minggu.TabStop = true;
            this.rb_Minggu.Text = "Minggu, 13.00-17.00";
            this.rb_Minggu.UseVisualStyleBackColor = true;
            // 
            // rb_Sabtu
            // 
            this.rb_Sabtu.AutoSize = true;
            this.rb_Sabtu.Location = new System.Drawing.Point(25, 163);
            this.rb_Sabtu.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Sabtu.Name = "rb_Sabtu";
            this.rb_Sabtu.Size = new System.Drawing.Size(303, 30);
            this.rb_Sabtu.TabIndex = 18;
            this.rb_Sabtu.TabStop = true;
            this.rb_Sabtu.Text = "Sabtu & Minggu, 09.00-11.00 ";
            this.rb_Sabtu.UseVisualStyleBackColor = true;
            // 
            // rb_Selasa
            // 
            this.rb_Selasa.AutoSize = true;
            this.rb_Selasa.Location = new System.Drawing.Point(25, 105);
            this.rb_Selasa.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Selasa.Name = "rb_Selasa";
            this.rb_Selasa.Size = new System.Drawing.Size(293, 30);
            this.rb_Selasa.TabIndex = 17;
            this.rb_Selasa.TabStop = true;
            this.rb_Selasa.Text = "Selasa & Kamis, 14.00-16.00";
            this.rb_Selasa.UseVisualStyleBackColor = true;
            // 
            // rb_Senin
            // 
            this.rb_Senin.AutoSize = true;
            this.rb_Senin.Location = new System.Drawing.Point(25, 52);
            this.rb_Senin.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Senin.Name = "rb_Senin";
            this.rb_Senin.Size = new System.Drawing.Size(278, 30);
            this.rb_Senin.TabIndex = 16;
            this.rb_Senin.TabStop = true;
            this.rb_Senin.Text = "Senin & Rabu, 14.00-16.00";
            this.rb_Senin.UseVisualStyleBackColor = true;
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Location = new System.Drawing.Point(327, 602);
            this.btnTampilkan.Margin = new System.Windows.Forms.Padding(4);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(148, 57);
            this.btnTampilkan.TabIndex = 20;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(563, 602);
            this.btnSelesai.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(140, 57);
            this.btnSelesai.TabIndex = 21;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1028, 664);
            this.Controls.Add(this.JadwalGroupBox);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.KelasGroupBox);
            this.Controls.Add(this.txtTanggalLahir);
            this.Controls.Add(this.txtKelamin);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form1";
            this.Text = "FORM PENDAFTARAN";
            this.KelasGroupBox.ResumeLayout(false);
            this.KelasGroupBox.PerformLayout();
            this.JadwalGroupBox.ResumeLayout(false);
            this.JadwalGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox txtKelamin;
        private System.Windows.Forms.DateTimePicker txtTanggalLahir;
        private System.Windows.Forms.GroupBox KelasGroupBox;
        private System.Windows.Forms.GroupBox JadwalGroupBox;
        private System.Windows.Forms.RadioButton rb_Minggu;
        private System.Windows.Forms.RadioButton rb_Sabtu;
        private System.Windows.Forms.RadioButton rb_Selasa;
        private System.Windows.Forms.RadioButton rb_Senin;
        private System.Windows.Forms.CheckBox cbBiola;
        private System.Windows.Forms.CheckBox cbGitar;
        private System.Windows.Forms.CheckBox cbSaxophone;
        private System.Windows.Forms.CheckBox cbKonduktor;
        private System.Windows.Forms.CheckBox cbPiano;
        private System.Windows.Forms.CheckBox cbDrum;
        private System.Windows.Forms.CheckBox cbVokal;
        private System.Windows.Forms.CheckBox cbKomposer;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Button btnSelesai;
    }
}

