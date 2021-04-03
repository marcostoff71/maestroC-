using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _000_NumberForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show(numericUpDown1.Value.ToString(),"ss",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            MessageBox.Show(a.ToString());
        }
    }
}
