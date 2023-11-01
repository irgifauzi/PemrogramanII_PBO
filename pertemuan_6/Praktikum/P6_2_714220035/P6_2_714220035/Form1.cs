using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_2_714220035
{
    public partial class Form1 : Form
    {
        private string filePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFIleButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Show the OpenFileDialog and check DialogResult
                DialogResult userResponse = openFileDialog1.ShowDialog();
                if (userResponse == DialogResult.OK)
                {
                    filePath = openFileDialog1.FileName; ToString();
                    MessageBox.Show("you succesfully opened: '" + filePath + "'", "Succes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("you cancel the file operation.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
