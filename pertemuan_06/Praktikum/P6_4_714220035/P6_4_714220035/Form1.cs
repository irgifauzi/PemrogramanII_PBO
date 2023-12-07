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

namespace P6_4_714220035
{
    public partial class txtKodeTiket : Form
    {
        public txtKodeTiket()
        {
            InitializeComponent();
        }

        private void txtNama_Leave(object sender, EventArgs e)
        {
            if (txtNama.Text =="")
            {

                epWarning.SetError(txtNama, "Nama tidak boleh kosong !");
                epWrong.SetError(txtNama, "");
                epCorrect.SetError(txtNama, "");
            }
            else
            {
                if ((txtNama.Text).All(Char.IsUpper))
                {
                    epWarning.SetError(txtNama, "");
                    epWrong.SetError(txtNama, "");
                    epCorrect.SetError(txtNama, "Betul");

                }
                else if ((txtNama.Text).Any(char.IsLower))
                {
                    epWarning.SetError(txtNama, "");
                    epWrong.SetError(txtNama, "Harus menggunakan huruf besar");                    
                    epCorrect.SetError(txtNama, "");
                }
            }
        }

        private void txtTelpon_Leave(object sender, EventArgs e)
        {
            if (txtTelpon.Text == "")
            {
                epWarning.SetError(txtTelpon, "");
                epWrong.SetError(txtTelpon, "nomor Tidak Boleh Kosong");
                epCorrect.SetError(txtTelpon, "");
            }
            else if (txtTelpon.Text.Length <8 || !txtTelpon.Text.All(Char.IsDigit))
            {
                epWarning.SetError(txtTelpon, "panjang angka harus lebih dari 8 digit angka");
                epWrong.SetError(txtTelpon, "");
                epCorrect.SetError(txtTelpon, "");
            }
            else
            {
                epWarning.SetError(txtTelpon, "");
                epWrong.SetError(txtTelpon, "");
                epCorrect.SetError(txtTelpon, "Betul");
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                epWarning.SetError(txtNama, "Email tidak boleh kosong!");
                epWrong.SetError(txtNama, "");
                epCorrect.SetError(txtNama, "");
            }
            else
            {
                if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epWarning.SetError(txtEmail, "");
                    epWrong.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtEmail, "Format email salah!\nContoh: a@b.c ");
                    epWarning.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label5_Leave(object sender, EventArgs e)
        {
        }
        private void txtKelamin_Leave(object sender, EventArgs e)
        {
            if (txtKelamin.Text == "")
            {
                epWarning.SetError(txtKelamin, "");
                epWrong.SetError(txtKelamin, "Jenis kelamin Tidak Boleh Kosong");
                epCorrect.SetError(txtKelamin, "");
            }
            else if (txtKelamin.SelectedIndex != -1)
            {
                epWarning.SetError(txtKelamin, "");
                epWrong.SetError(txtKelamin, "");
                epCorrect.SetError(txtKelamin, "Betul");
            }
            else
            {
                epWarning.SetError(txtKelamin, "Pilih Jenis Kelamin!");
                epWrong.SetError(txtKelamin, "");
                epCorrect.SetError(txtKelamin, "");
            }
        }

        private void txtUmur_Leave(object sender, EventArgs e)
        {

            if (txtUmur.Text == "")

            {
                epWarning.SetError(txtUmur, "");
                epWrong.SetError(txtUmur, "Umur Tidak Boleh Kosong");
                epCorrect.SetError(txtUmur, "");
            }
            else if (txtUmur.Text.Length != 2 || !txtUmur.Text.All(Char.IsDigit))
            {
                epWarning.SetError(txtUmur, "umur hanya 2 digit angka");
                epWrong.SetError(txtUmur, "");
                epCorrect.SetError(txtUmur, "");
            }
            else
            {
                epWarning.SetError(txtUmur, "");
                epWrong.SetError(txtUmur, "");
                epCorrect.SetError(txtUmur, "Betul");
            }
            int umur = int.Parse(txtUmur.Text);

            if (umur >= 15)
            {
                epWarning.SetError(txtUmur, "");
                epWrong.SetError(txtUmur, "");
                epCorrect.SetError(txtUmur, "Umur Lebih dari 15");
            }
            else
            {
                epWarning.SetError(txtUmur, "");
                epWrong.SetError(txtUmur, "Umur tidak boleh kurang dari 15");
                epCorrect.SetError(txtUmur, "");
            }
        }

        private void txtKirim_Click(object sender, EventArgs e)
        {
            string Tujuan_Keberangkatan = "";

            if (bJakarta.Checked == true)
            {
                Tujuan_Keberangkatan += "Bandung-Jakarta, 07.00 - 11.00, ";
            }
            else if (bSemarang.Checked == true)
            {
                Tujuan_Keberangkatan += "Bandung-Semarang, 08.00 - 12.00, ";
            }
            else if (bBekasi.Checked == true)
            {
                Tujuan_Keberangkatan += "Bandung-Bekasi, 09.00 - 13.00, ";
            }
            else if (bKuningan.Checked == true)
            {
                Tujuan_Keberangkatan += "Bandung-Kuningan, 10.00 - 14.00";
            }


            if (Tujuan_Keberangkatan != "")
            {
                string pesan = "Nama: " + txtNama.Text + "\n" +
                           "Jumlah Tiket: " + txtJumlahTiket.Text + "\n" +
                           "Nomor Telepon: " + txtTelpon.Text + "\n" +
                           "Jenis Kelamin: " + txtKelamin.Text + "\n" +
                           "Email: " + txtEmail.Text + "\n" +
                           "Umur: " + txtUmur.Text + "\n" +
                           "Kode Tiket: " + txtLower.Text + "\n"+
                           "Tujuan Keberangkatan; " + Tujuan_Keberangkatan;

                MessageBox.Show(pesan, "Pendaftaran Pemesanan Bus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (string.IsNullOrWhiteSpace(txtNama.Text) || !txtNama.Text.All(Char.IsUpper))
            {
                MessageBox.Show("Nama harus diisi dan hanya boleh huruf besar.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTelpon.Text) || txtTelpon.Text.Length <8|| !txtTelpon.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Nomor minimal di isi dengan 8 digit angka.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtKelamin.Text) && txtKelamin.SelectedIndex != 1)
            {
                MessageBox.Show("Jenis Kelamin harus dipilih.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                MessageBox.Show("Email harus diisi .", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtUmur.Text) || txtUmur.Text.Length != 2 || !txtUmur.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Umur harus diisi dengan 2 digit angka.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int Umur;
            if (int.TryParse(txtUmur.Text, out Umur))
            {

            }
            if (Umur >15)
            {
                MessageBox.Show("Berhasil Mendaftar", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tidak Boleh Mendaftar, Umur Anda Belum 15 Tahun atau Lebih", "Maaf!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrWhiteSpace(txtLower.Text) || !txtLower.Text.All(Char.IsLower))
            {
                MessageBox.Show("Kode tiket harus memakai huruf kecil.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Tujuan_Keberangkatan == "")
            {
                MessageBox.Show("Pilih Tujuan Keberangkatan, tidak boleh kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
         }

        private void txtLower_TextChanged(object sender, EventArgs e)
        {
            if (txtLower.Text == "")
            {
                epWarning.SetError(txtLower, "Kode Tiket Tidak boleh kosong");
                epWrong.SetError(txtLower, "");
                epCorrect.SetError(txtLower, "");
            }
            else
            {
                if ((txtLower.Text).All(char.IsUpper))
                {
                    epWarning.SetError(txtLower, "");
                    epWrong.SetError(txtLower, "Harus menggunakan huruf kecil");
                    epCorrect.SetError(txtLower, "");
                }
                else if ((txtLower.Text).Any(char.IsLower))
                {
                    epWarning.SetError(txtLower, "");
                    epWrong.SetError(txtLower, "");
                    epCorrect.SetError(txtLower, "Betul");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
