using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace P5_4_714220035
{
    public partial class form1 : Form
    {
        

        public form1()
        {
            InitializeComponent();
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {



            string Pilihan_Kelas = "";
            string Pilihan_Jadwal = "";


            if (cbBiola.Checked == true )
            {
                Pilihan_Kelas += "Biola, ";
            }
            if (cbGitar.Checked == true) 
            {
                Pilihan_Kelas += "Gitar,";
            }
            if (cbPiano.Checked == true)
            {
                Pilihan_Kelas += "Piano,";
            }
            if (cbDrum.Checked == true)
            {
                Pilihan_Kelas += "Drum,";
            }
            if (cbVokal.Checked == true)
            {
                Pilihan_Kelas += "Vokal,";
            }
            if (cbKomposer.Checked == true)
            {
                Pilihan_Kelas += "Komposer,";
            }
            if (cbKonduktor.Checked == true)
            {
                Pilihan_Kelas += "Konduktor,";
            }
            if (cbSaxophone.Checked == true)
            {
                Pilihan_Kelas += "Saxophone,";
            }
           
            


            if (rb_Senin.Checked)
            {
                Pilihan_Jadwal += "Senin & Rabu, 14.00-16.00";
            }
            else if (rb_Selasa.Checked)
            {
                Pilihan_Jadwal += "Selasa & Kamis, 14.00-16.00";
            }
            else if (rb_Sabtu.Checked)
            {
                Pilihan_Jadwal += "Sabtu & Minggu, 09.00-11.00 ";
            }

            else if (rb_Minggu.Checked)
            {
                Pilihan_Jadwal += "Minggu, 13.00-17.00";
            }

           

            if (Pilihan_Kelas != "" && Pilihan_Jadwal != "")
            {
                string pesan = "Nama: " + txtNama.Text + "\n" +
                           "Jenis Kelamin: " + txtKelamin.Text + "\n" +
                           "Tanggal Lahir: " + txtTanggalLahir.Text + "\n" +
                           "Pilihan Kelas: " + Pilihan_Kelas + "\n" +
                           "Pilihan Jadwal; " + Pilihan_Jadwal;
                MessageBox.Show(pesan, "Informasi Pendaftaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtNama.Text == "")
            {
                MessageBox.Show("Masukkan Nama anda, tidak boleh kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtKelamin.Text == "")
            {
                MessageBox.Show("Masukkan Kelamin anda, tidak boleh kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Pilihan_Kelas == "")
            {
                MessageBox.Show("Masukkan Kelas anda, tidak boleh kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Pilihan_Jadwal == "")
            {
                MessageBox.Show("Masukkan Jadwal anda, tidak boleh kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

         


        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
