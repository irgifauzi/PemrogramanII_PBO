using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_3_714220035
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Merk HP: " + txtMerkHP.Text,
                "Informasi Service HP",
                MessageBoxButtons.OK, MessageBoxIcon.Question);

            string os = "";
            string status = "";

            if (rb_android.Checked == true)
            {
                os = "Android";
            }
            else if (rb_ios.Checked == true)
            {
                os = "iOS";
            }
            if (cbYa.Checked == true)
            {
                status = "Ya, sudah diperbaiki";
            }
                      
            MessageBox.Show(
                 "Merk HP: " + txtMerkHP.Text +
                "\nSistem Operasi : " + os + 
                "\nStatus perbaikan : " + status,
                "Informasi Service HP",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {           
            this.Close();
        }
    }
}
