using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int a, b, ketQua;
            if (txtSoA.Text != string.Empty)
            {
                a = int.Parse(txtSoA.Text);
                b = int.Parse(txtSoB.Text);
                ketQua = a + b;
                txtKQ.Text = ketQua.ToString(); 
            }
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            int a, b, ketQua;
            a = int.Parse(txtSoA.Text);
            b = int.Parse(txtSoB.Text);
            ketQua = a - b;
            txtKQ.Text = ketQua.ToString();
        }
    }
}
