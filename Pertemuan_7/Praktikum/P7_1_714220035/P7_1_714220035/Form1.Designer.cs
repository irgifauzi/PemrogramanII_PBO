namespace P7_1_714220035
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
            this.buttonCek = new System.Windows.Forms.Button();
            this.buttonTutup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxProdi = new System.Windows.Forms.TextBox();
            this.textBoxKelas = new System.Windows.Forms.TextBox();
            this.lbKegiatan = new System.Windows.Forms.Label();
            this.cbKuliah = new System.Windows.Forms.CheckBox();
            this.cbTraveling = new System.Windows.Forms.CheckBox();
            this.cbTidur = new System.Windows.Forms.CheckBox();
            this.rbSenin = new System.Windows.Forms.RadioButton();
            this.rbMinggu = new System.Windows.Forms.RadioButton();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCek
            // 
            this.buttonCek.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCek.Location = new System.Drawing.Point(175, 190);
            this.buttonCek.Name = "buttonCek";
            this.buttonCek.Size = new System.Drawing.Size(127, 39);
            this.buttonCek.TabIndex = 0;
            this.buttonCek.Text = "Cek";
            this.buttonCek.UseVisualStyleBackColor = true;
            this.buttonCek.Click += new System.EventHandler(this.buttonCek_Click);
            // 
            // buttonTutup
            // 
            this.buttonTutup.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTutup.Location = new System.Drawing.Point(325, 190);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(174, 39);
            this.buttonTutup.TabIndex = 1;
            this.buttonTutup.Text = "Tutup Form";
            this.buttonTutup.UseVisualStyleBackColor = true;
            this.buttonTutup.Click += new System.EventHandler(this.buttonTutup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prodi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kelas";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(175, 36);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(251, 26);
            this.textBoxNama.TabIndex = 5;
            // 
            // textBoxProdi
            // 
            this.textBoxProdi.Location = new System.Drawing.Point(175, 92);
            this.textBoxProdi.Name = "textBoxProdi";
            this.textBoxProdi.Size = new System.Drawing.Size(251, 26);
            this.textBoxProdi.TabIndex = 6;
            // 
            // textBoxKelas
            // 
            this.textBoxKelas.Location = new System.Drawing.Point(175, 146);
            this.textBoxKelas.Name = "textBoxKelas";
            this.textBoxKelas.Size = new System.Drawing.Size(251, 26);
            this.textBoxKelas.TabIndex = 7;
            // 
            // lbKegiatan
            // 
            this.lbKegiatan.AutoSize = true;
            this.lbKegiatan.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKegiatan.Location = new System.Drawing.Point(201, 273);
            this.lbKegiatan.Name = "lbKegiatan";
            this.lbKegiatan.Size = new System.Drawing.Size(202, 36);
            this.lbKegiatan.TabIndex = 8;
            this.lbKegiatan.Text = "LIST KEGIATAN";
            // 
            // cbKuliah
            // 
            this.cbKuliah.AutoSize = true;
            this.cbKuliah.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKuliah.Location = new System.Drawing.Point(102, 436);
            this.cbKuliah.Name = "cbKuliah";
            this.cbKuliah.Size = new System.Drawing.Size(97, 30);
            this.cbKuliah.TabIndex = 9;
            this.cbKuliah.Text = "Kuliah";
            this.cbKuliah.UseVisualStyleBackColor = true;
            // 
            // cbTraveling
            // 
            this.cbTraveling.AutoSize = true;
            this.cbTraveling.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTraveling.Location = new System.Drawing.Point(102, 488);
            this.cbTraveling.Name = "cbTraveling";
            this.cbTraveling.Size = new System.Drawing.Size(124, 30);
            this.cbTraveling.TabIndex = 10;
            this.cbTraveling.Text = "Traveling";
            this.cbTraveling.UseVisualStyleBackColor = true;
            // 
            // cbTidur
            // 
            this.cbTidur.AutoSize = true;
            this.cbTidur.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTidur.Location = new System.Drawing.Point(102, 538);
            this.cbTidur.Name = "cbTidur";
            this.cbTidur.Size = new System.Drawing.Size(88, 30);
            this.cbTidur.TabIndex = 11;
            this.cbTidur.Text = "Tidur";
            this.cbTidur.UseVisualStyleBackColor = true;
            // 
            // rbSenin
            // 
            this.rbSenin.AutoSize = true;
            this.rbSenin.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSenin.Location = new System.Drawing.Point(107, 318);
            this.rbSenin.Name = "rbSenin";
            this.rbSenin.Size = new System.Drawing.Size(89, 30);
            this.rbSenin.TabIndex = 12;
            this.rbSenin.TabStop = true;
            this.rbSenin.Text = "Senin";
            this.rbSenin.UseVisualStyleBackColor = true;
            this.rbSenin.CheckedChanged += new System.EventHandler(this.rbSenin_CheckedChanged);
            // 
            // rbMinggu
            // 
            this.rbMinggu.AutoSize = true;
            this.rbMinggu.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMinggu.Location = new System.Drawing.Point(102, 369);
            this.rbMinggu.Name = "rbMinggu";
            this.rbMinggu.Size = new System.Drawing.Size(102, 30);
            this.rbMinggu.TabIndex = 13;
            this.rbMinggu.TabStop = true;
            this.rbMinggu.Text = "Minggu";
            this.rbMinggu.UseVisualStyleBackColor = true;
            this.rbMinggu.CheckedChanged += new System.EventHandler(this.rbMinggu_CheckedChanged);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(224, 549);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(105, 34);
            this.buttonPrint.TabIndex = 14;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(351, 549);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(166, 34);
            this.buttonReset.TabIndex = 15;
            this.buttonReset.Text = "Reset Form";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 600);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.rbMinggu);
            this.Controls.Add(this.rbSenin);
            this.Controls.Add(this.cbTidur);
            this.Controls.Add(this.cbTraveling);
            this.Controls.Add(this.cbKuliah);
            this.Controls.Add(this.lbKegiatan);
            this.Controls.Add(this.textBoxKelas);
            this.Controls.Add(this.textBoxProdi);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTutup);
            this.Controls.Add(this.buttonCek);
            this.Name = "Form1";
            this.Text = "\'";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCek;
        private System.Windows.Forms.Button buttonTutup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxProdi;
        private System.Windows.Forms.TextBox textBoxKelas;
        private System.Windows.Forms.Label lbKegiatan;
        private System.Windows.Forms.CheckBox cbKuliah;
        private System.Windows.Forms.CheckBox cbTraveling;
        private System.Windows.Forms.CheckBox cbTidur;
        private System.Windows.Forms.RadioButton rbSenin;
        private System.Windows.Forms.RadioButton rbMinggu;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonReset;
    }
}

