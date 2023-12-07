using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_2_714220035
{
    public partial class ChildForm : Form
    {
        public string OutputText { get; private set; }

        public ChildForm()
        {
            InitializeComponent();
        }

        private void OutputGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            OutputLabel.Text = OutputText;
        }

        private void DateOption_Click(object sender, EventArgs e)
        {
            OutputText = DateTime.Now.ToString("d");
        }

        private void TimeOption_Click(object sender, EventArgs e)
        {
            OutputText = DateTime.Now.ToString("t");
        }
    }
}
