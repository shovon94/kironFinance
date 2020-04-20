using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiron
{
    public partial class PaymentPage : Form
    {
        public PaymentPage()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MultiplePayment mp = new MultiplePayment();
            mp.Show();
        }

        private void PaymentPage_Load(object sender, EventArgs e)
        {
            comboBoxMonth.SelectedIndex = 0;
        }
    }
}
