﻿using P10_714220035.controller;
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

namespace P10_714220035
{
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();
        M_mahasiswa m_mhs = new M_mahasiswa();

        public void Tampil()
        {
            //Query DB Get MGS
            DataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM t_mahasiswa");

            //Query DB Get MGS
            DataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM t_mahasiswa");
            DataMahasiswa.Columns[0].HeaderText = "NPM";
            DataMahasiswa.Columns[1].HeaderText = "Nama";
            DataMahasiswa.Columns[2].HeaderText = "Angkaran";
            DataMahasiswa.Columns[3].HeaderText = "Alamat";
            DataMahasiswa.Columns[4].HeaderText = "Email";
            DataMahasiswa.Columns[5].HeaderText = "No Hp";

        }
        public Form1()
        {
            InitializeComponent();
        }
        public void ResetForm()
        {
            npm.Text = "";
            nama.Text = "";
            angkatan.SelectedIndex = -1;
            alamat.Text = "";
            email.Text = "";
            nohp.Text = "";
            tbCariData.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Memanggil method tampil
            Tampil();
            //Memanggil method Tampil
            Tampil();
            DataMahasiswa.Columns[0].HeaderText = "NPM";
            DataMahasiswa.Columns[1].HeaderText = "Nama";
            DataMahasiswa.Columns[2].HeaderText = "Angkatan";
            DataMahasiswa.Columns[3].HeaderText = "Alamat";
            DataMahasiswa.Columns[4].HeaderText = "Email";
            DataMahasiswa.Columns[5].HeaderText = "No HP";

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (npm.Text == "" || nama.Text == "" || angkatan.SelectedIndex == -1 ||
             alamat.Text == "" || email.Text == "" || nohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Mahasiswa mhs = new Mahasiswa();
                m_mhs.Npm = npm.Text;
                m_mhs.Nama = nama.Text;
                m_mhs.Angkatan = angkatan.Text;
                m_mhs.Alamat = alamat.Text;
                m_mhs.Email = email.Text;
                m_mhs.Nohp = nohp.Text;

                mhs.insert(m_mhs);

                ResetForm();
                Tampil();
            }
        }
        private void btnUbah_Click_1(object sender, EventArgs e)
        {
            {
                if (npm.Text == "" || nama.Text == "" || angkatan.SelectedIndex == -1 ||
            alamat.Text == "" || email.Text == "" || nohp.Text == "")
                {
                    MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Mahasiswa mhs = new Mahasiswa();
                    m_mhs.Npm = npm.Text;
                    m_mhs.Nama = nama.Text;
                    m_mhs.Angkatan = angkatan.Text;
                    m_mhs.Alamat = alamat.Text;
                    m_mhs.Email = email.Text;
                    m_mhs.Nohp = nohp.Text;

                    mhs.Update(m_mhs,npm.Text);

                    ResetForm();
                    Tampil();
                }
            }
        }
        private void btnRefresh_Click_1(object sender, EventArgs e)
        {

            ResetForm();
            Tampil();


        }
        private void btnHapus_Click_1(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show(
                "Apakah yakin akan menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Mahasiswa mhs = new Mahasiswa();
                mhs.Delete(npm.Text);
                ResetForm();
                Tampil();
            }
        }   

        private void DataMahasiswa_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            npm.Text = DataMahasiswa.Rows[e.RowIndex].Cells[0].Value.ToString();
            nama.Text = DataMahasiswa.Rows[e.RowIndex].Cells[1].Value.ToString();
            angkatan.Text = DataMahasiswa.Rows[e.RowIndex].Cells[2].Value.ToString();
            alamat.Text = DataMahasiswa.Rows[e.RowIndex].Cells[3].Value.ToString();
            email.Text = DataMahasiswa.Rows[e.RowIndex].Cells[4].Value.ToString();
            nohp.Text = DataMahasiswa.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            DataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM t_mahasiswa WHERE npm LIKE '%' '" + tbCariData.Text + "' '%' OR nama LIKE '%' '" + tbCariData.Text + "' '%'");
        }
        
        

        
    }
}

        
           
        

        
    
    
