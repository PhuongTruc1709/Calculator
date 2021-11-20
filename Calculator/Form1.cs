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
            int a, b, kQ;
            if (txtSoThu1.Text != String.Empty && txtSoThu2.Text != String.Empty)
            {
                a = int.Parse(txtSoThu1.Text);
                b = int.Parse(txtSoThu2.Text);
                kQ = a + b;
                txtKQ.Text = kQ.ToString(); 
            }
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            int a, b, kQ;
            a = int.Parse(txtSoThu1.Text);
            b = int.Parse(txtSoThu2.Text);
            kQ = a - b;
            txtKQ.Text = kQ.ToString();
        }
    }
}
