using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10_714220035
{
    public partial class Form1 : Form
    {
        Koneksi koneksi =new Koneksi();

        public void Tampil()
        {
            //Query DB Get MGS
            DataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM t_mahasiswa");
            DataMahasiswa.Columns[0].HeaderText = "NPM";
            DataMahasiswa.Columns[0].HeaderText = "Nama";
            DataMahasiswa.Columns[0].HeaderText = "Angkaran";
            DataMahasiswa.Columns[0].HeaderText = "Alamat";
            DataMahasiswa.Columns[0].HeaderText = "Email";
            DataMahasiswa.Columns[0].HeaderText = "No Hp";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Memanggil method tampil
            Tampil();

        }
    }
}
