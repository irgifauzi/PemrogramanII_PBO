using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_1_714220035
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(400, 220);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCek_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(textBoxNama.Text))
            {
                errorMessage += "Nama Belum Di isi\n";
            }
            if (string.IsNullOrWhiteSpace(textBoxProdi.Text))
            {
                errorMessage += "Prodi Belum Di isi\n";
            }
            else if (!Regex.IsMatch(textBoxProdi.Text, @"^^[A-Za-z0-9]+-[A-Za-z0-9]+$"))
            {
                errorMessage += "Prodi hapus berformat [Strata]-[prodi]\n";

            }
            if (string.IsNullOrWhiteSpace(textBoxKelas.Text))
            {
                errorMessage += "Kelas Belum Di isi\n";
            }

            if (string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show("Lengkap", "Informasi Data Submit",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Size = new Size(400, 500);
            }
            else
            {
                MessageBox.Show(errorMessage, "Informasi Data Submit",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rbSenin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSenin.Checked == false)
            {
                cbKuliah.Enabled = true; cbKuliah.Checked = true;
                cbTraveling.Enabled = false; cbTraveling.Checked = false;
                cbTidur.Enabled = true; cbTidur.Checked = false;

            }
        }

        private void rbMinggu_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMinggu.Checked)
            {
                cbKuliah.Enabled = false;
                cbTraveling.Enabled = true;
                cbTidur.Enabled = true;


            }
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {


            foreach (Control control in Controls)
            {
                if (control is TextBox)

                    ((TextBox)control).Text = string.Empty;
                else if (control is RadioButton)
                    ((RadioButton)control).Checked = false;
                else if (control is CheckBox)
                    ((CheckBox)control).Checked = false;
                /*else if (control is ComboBox)
                    ((ComboBox)control).SelectedIndex = -1;*/
            }
            this.Size = new Size(404, 263);


        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            string checkbox1 = "";

            if (!rbSenin.Checked && !rbMinggu.Checked)
            {
                errorMessage += "Pilih hari\n";
            }

            if (!cbKuliah.Checked && !cbTraveling.Checked && !cbTidur.Checked)
            {
                errorMessage += "Harus memilih setidaknya satu kegiatan\n";
            }

            if (cbKuliah.Checked)
            {
                checkbox1 += "Kuliah ";
            }
            if (cbTraveling.Checked)
            {
                checkbox1 += "Traveling ";
            }
            if (cbTidur.Checked)
            {
                checkbox1 += "Tidur ";
            }

            if (string.IsNullOrEmpty(errorMessage))
            {
                string pesan = "Nama: " + textBoxNama.Text + "\n" +
                               "Prodi: " + textBoxProdi.Text + "\n" +
                               "Kelas: " + textBoxKelas.Text + "\n" +
                               "==============\n" +
                               "Hari: " + (rbSenin.Checked ? "Senin" : (rbMinggu.Checked ? "Minggu" : "")) + "\n" +
                               "Kegiatan: " + checkbox1 + "\n";

                MessageBox.Show(pesan, "Informasi Pendaftaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(errorMessage, "Informasi Data Kuliah",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}

