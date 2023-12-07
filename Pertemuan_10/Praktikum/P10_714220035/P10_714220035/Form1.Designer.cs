namespace P10_714220035
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Npm = new System.Windows.Forms.Label();
            this.Nama = new System.Windows.Forms.Label();
            this.Angkatan = new System.Windows.Forms.Label();
            this.Alamat = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.NoHp = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DataMahasiswa = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataMahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataMahasiswa);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table Data Mahasiswa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.Alamat);
            this.groupBox2.Controls.Add(this.Angkatan);
            this.groupBox2.Controls.Add(this.Npm);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.NoHp);
            this.groupBox2.Controls.Add(this.Nama);
            this.groupBox2.Controls.Add(this.Email);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(27, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(714, 355);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Data Mahasiswa";
            // 
            // Npm
            // 
            this.Npm.AutoSize = true;
            this.Npm.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Npm.Location = new System.Drawing.Point(6, 39);
            this.Npm.Name = "Npm";
            this.Npm.Size = new System.Drawing.Size(52, 26);
            this.Npm.TabIndex = 0;
            this.Npm.Text = "NPM";
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nama.Location = new System.Drawing.Point(6, 86);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(64, 26);
            this.Nama.TabIndex = 1;
            this.Nama.Text = "Nama";
            // 
            // Angkatan
            // 
            this.Angkatan.AutoSize = true;
            this.Angkatan.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Angkatan.Location = new System.Drawing.Point(6, 127);
            this.Angkatan.Name = "Angkatan";
            this.Angkatan.Size = new System.Drawing.Size(99, 26);
            this.Angkatan.TabIndex = 2;
            this.Angkatan.Text = "Angkatan";
            // 
            // Alamat
            // 
            this.Alamat.AutoSize = true;
            this.Alamat.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alamat.Location = new System.Drawing.Point(6, 170);
            this.Alamat.Name = "Alamat";
            this.Alamat.Size = new System.Drawing.Size(78, 26);
            this.Alamat.TabIndex = 3;
            this.Alamat.Text = "Alamat";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(11, 251);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(63, 26);
            this.Email.TabIndex = 4;
            this.Email.Text = "Email";
            // 
            // NoHp
            // 
            this.NoHp.AutoSize = true;
            this.NoHp.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoHp.Location = new System.Drawing.Point(6, 295);
            this.NoHp.Name = "NoHp";
            this.NoHp.Size = new System.Drawing.Size(68, 26);
            this.NoHp.TabIndex = 5;
            this.NoHp.Text = "No Hp";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 170);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(465, 62);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(188, 295);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(465, 31);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(188, 251);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(465, 31);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(188, 39);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(465, 31);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(188, 86);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(465, 31);
            this.textBox5.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(188, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(465, 34);
            this.comboBox1.TabIndex = 11;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(6, 43);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(160, 34);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Location = new System.Drawing.Point(6, 83);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(160, 33);
            this.btnSimpan.TabIndex = 13;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnUbah
            // 
            this.btnUbah.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbah.Location = new System.Drawing.Point(6, 122);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(160, 38);
            this.btnUbah.TabIndex = 14;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.Location = new System.Drawing.Point(6, 166);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(160, 36);
            this.btnHapus.TabIndex = 15;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.btnHapus);
            this.groupBox3.Controls.Add(this.btnUbah);
            this.groupBox3.Controls.Add(this.btnSimpan);
            this.groupBox3.Location = new System.Drawing.Point(784, 386);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 218);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tombol Action";
            // 
            // DataMahasiswa
            // 
            this.DataMahasiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataMahasiswa.Location = new System.Drawing.Point(0, 30);
            this.DataMahasiswa.Name = "DataMahasiswa";
            this.DataMahasiswa.RowHeadersWidth = 62;
            this.DataMahasiswa.RowTemplate.Height = 28;
            this.DataMahasiswa.Size = new System.Drawing.Size(1004, 182);
            this.DataMahasiswa.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 644);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataMahasiswa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Npm;
        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.Label Angkatan;
        private System.Windows.Forms.Label Alamat;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label NoHp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DataMahasiswa;
    }
}

