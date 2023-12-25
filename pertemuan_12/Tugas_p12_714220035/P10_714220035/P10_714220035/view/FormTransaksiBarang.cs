using MySql.Data.MySqlClient;
using P10_714220035.controller;
using P10_714220035.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10_714220035.view
{
    public partial class FormTransaksiBarang : Form
    {
        public FormTransaksiBarang()
        {
            InitializeComponent();
        }
        Koneksi koneksi = new Koneksi();
        M_transaksi_barang m_transaksi_barang = new M_transaksi_barang();
        string id_transaksi;

        public void Tampil()
        {

            //Query DB Get MGS
            DataTransaksi.DataSource = koneksi.ShowData("SELECT id_transaksi, g.id_barang, nama_barang, harga, qty, total FROM t_transaksi t JOIN t_barang g ON (t.id_barang = g.id_barang)");
            DataTransaksi.Columns[0].HeaderText = "ID";
            DataTransaksi.Columns[1].HeaderText = "ID Barang";
            DataTransaksi.Columns[2].HeaderText = "Nama Barang";
            DataTransaksi.Columns[3].HeaderText = "Harga Barang";
            DataTransaksi.Columns[4].HeaderText = "Quantity";
            DataTransaksi.Columns[5].HeaderText = "Total";

        }

        public void ResetForm()
        {
            cbIdBarang.Text = "";
            tbBarang.Text = "";
            tbHarga.Text = "";
            tbQuantity.Text = "";
            tbTotal.Text = "";
            tbCariData.Text = "";
        }
        private void FormTransaksiBarang_Load(object sender, EventArgs e)
        {
            Tampil();
            GetDataBarang();

        }

        public void GetDataBarang()
        {

            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_barang");
            while (reader.Read())
            {
                cbIdBarang.Items.Add(reader.GetString("id_barang"));
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        public void GetNamaHarga()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT nama_barang,harga FROM t_barang WHERE id_barang = '" + cbIdBarang.Text + "'");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    tbBarang.Text = reader.GetString(0);
                    tbHarga.Text = reader.GetString(1);
                }
            }
            reader.Close();
            koneksi.CloseConnection();
        }


        private void cbIdBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetNamaHarga();
        }

        private void tbCariData_TextChanged_1(object sender, EventArgs e)
        {
            DataTransaksi.DataSource = koneksi.ShowData("SELECT id_transaksi, g.id_barang, nama_barang, harga, qty, total FROM t_transaksi t JOIN t_barang g ON (t.id_barang = g.id_barang) WHERE id_transaksi LIKE '%' '" + tbCariData.Text + "' '%' OR t.id_barang LIKE '%' '" + tbCariData.Text + "' '%' OR g.id_barang LIKE '%' '" + tbCariData.Text + "' '%' OR nama_barang LIKE '%' '" + tbCariData.Text + "' '%' OR harga LIKE '%' '" + tbCariData.Text + "' '%' OR qty LIKE '%' '" + tbCariData.Text + "' '%' OR total LIKE '%' '" + tbCariData.Text + "' '%'");
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cbIdBarang.Text == "" || tbBarang.Text == "" || tbHarga.Text == "" || tbQuantity.Text == "" || tbTotal.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TransaksiBarang transaksi = new TransaksiBarang();
                m_transaksi_barang.Id_barang = cbIdBarang.Text;
                m_transaksi_barang.Qty = tbQuantity.Text;

                string formattedTotal = tbTotal.Text.Replace("Rp ", "").Replace(",", "");
                if (double.TryParse(formattedTotal, out double numericTotal))
                {
                    m_transaksi_barang.Total = numericTotal.ToString();
                }


                transaksi.Insert(m_transaksi_barang);

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

            if (cbIdBarang.Text == "" || tbBarang.Text == "" || tbHarga.Text == "" || tbQuantity.Text == "" || tbTotal.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TransaksiBarang transaksi = new TransaksiBarang();
                m_transaksi_barang.Id_barang = cbIdBarang.Text;
                m_transaksi_barang.Qty = tbQuantity.Text;

                string formattedTotal = tbTotal.Text.Replace("Rp ", "").Replace(",", "");
                if (double.TryParse(formattedTotal, out double numericTotal))
                {
                    m_transaksi_barang.Total = numericTotal.ToString();
                }


                transaksi.Update(m_transaksi_barang, id_transaksi);

                ResetForm();
                Tampil();
            }

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Apakah kamu yakin ingin menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                TransaksiBarang transaksi = new TransaksiBarang();
                transaksi.Delete(id_transaksi);
                Refresh();
                Tampil();
            }
        }

        private void DataTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_transaksi = DataTransaksi.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbIdBarang.Text = DataTransaksi.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbBarang.Text = DataTransaksi.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbHarga.Text = DataTransaksi.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbQuantity.Text = DataTransaksi.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbTotal.Text = DataTransaksi.Rows[e.RowIndex].Cells[5].Value.ToString();


            Refresh();
        }

        private void DataTransaksi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string[] rpColumns = { "harga", "total" };

            if (rpColumns.Contains(DataTransaksi.Columns[e.ColumnIndex].Name))
            {
                if (e.Value != null && double.TryParse(e.Value.ToString(), out double cellValue))
                {
                    e.Value = string.Format("Rp. {0:N0}", cellValue);
                    e.FormattingApplied = true;
                }
            }
        }


        public void totalharga()
        {
           
            if (double.TryParse(tbQuantity.Text, out double qty) && double.TryParse(tbHarga.Text, out double harga))
            {
                double total = qty * harga;        
                
                tbTotal.Text = total.ToString("N0");  
            }
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            totalharga();
        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {
            totalharga();
        }
    }
}
    


  

