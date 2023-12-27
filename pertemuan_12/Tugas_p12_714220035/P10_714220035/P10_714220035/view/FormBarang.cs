using MySql.Data.MySqlClient;
using P10_714220035.controller;
using P10_714220035.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace P10_714220035.view
{
    public partial class FormBarang : Form
    {
        Koneksi koneksi = new Koneksi();
        M_barang m_barang = new M_barang();
        string id_barang;
        
        public void Tampil()
        {
            //Query DB Get MGS
            DataBarang.DataSource = koneksi.ShowData("SELECT * FROM t_barang");

            //Query DB Get MGS
            DataBarang.DataSource = koneksi.ShowData("SELECT * FROM t_barang");
            DataBarang.Columns[0].HeaderText = "ID";
            DataBarang.Columns[1].HeaderText = "Nama_Barang";
            DataBarang.Columns[2].HeaderText = "Haga";


        }
        public FormBarang()
        {
            InitializeComponent();
        }
        public void ResetForm()
        {
            tbbarang.Text = "";
            tbharga.Text = "";
            tbCariData.Text = "";
        }
        private void FormBarang_Load_1(object sender, EventArgs e)
        {
            Tampil();


            DataBarang.Columns[0].HeaderText = "ID";
            DataBarang.Columns[1].HeaderText = "Nama_Barang";
            DataBarang.Columns[2].HeaderText = "Harga";


        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            DataBarang.DataSource = koneksi.ShowData("SELECT * FROM t_barang WHERE nama_barang LIKE '%' '" + tbCariData.Text + "' '%' OR harga LIKE '%' '" + tbCariData.Text + "' '%'");
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbbarang.Text) || (tbbarang.Text).All(Char.IsNumber) || string.IsNullOrEmpty(tbharga.Text) || (tbharga.Text).All(Char.IsLetter))
            {
                MessageBox.Show("Data tidak boleh kosong dan salah", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Barang barang = new Barang();
                m_barang.Nama_barang = tbbarang.Text;
                m_barang.Harga = tbharga.Text;
               

                barang.Insert(m_barang);

                ResetForm();
                Tampil();
            }
              
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
            Tampil();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbbarang.Text) || (tbbarang.Text).All(Char.IsNumber) || string.IsNullOrEmpty(tbharga.Text) || (tbharga.Text).All(Char.IsLetter))
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Barang barang = new Barang();
                m_barang.Nama_barang = tbbarang.Text;
                m_barang.Harga = tbharga.Text; 
                barang.Update(m_barang, id_barang);

                ResetForm();
                Tampil();
            }


        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show(
             "Apakah yakin akan menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Barang barang = new Barang();
                barang.Delete(id_barang);
                ResetForm();
                Tampil();
            }

        }

        private void DataBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_barang = DataBarang.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbbarang.Text = DataBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbharga.Text = DataBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
            
        }

        private void DataBarang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            if (DataBarang.Columns[e.ColumnIndex].Name == "harga" )
            {
               
                if (e.Value != null && double.TryParse(e.Value.ToString(), out double cellValue))
                {
                 
                    e.Value = string.Format("Rp. {0:N0}", cellValue);
                    e.FormattingApplied = true; 
                }
            }
        }
    




    }
}

