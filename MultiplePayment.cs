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
    public partial class MultiplePayment : Form
    {
        public MultiplePayment()
        {
            InitializeComponent();
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAll.Checked == true)
            {
                chkJan.Checked = true;
                chkFeb.Checked = true;
                chkMar.Checked = true;
                chkApr.Checked = true;
                chkMay.Checked = true;
                chkJun.Checked = true;
                chkJul.Checked = true;
                chkAug.Checked = true;
                chkSep.Checked = true;
                chkOct.Checked = true;
                chkNov.Checked = true;
                chkDec.Checked = true;
            }

            else 
            {
                chkJan.Checked = false;
                chkFeb.Checked = false;
                chkMar.Checked = false;
                chkApr.Checked = false;
                chkMay.Checked = false;
                chkJun.Checked = false;
                chkJul.Checked = false;
                chkAug.Checked = false;
                chkSep.Checked = false;
                chkOct.Checked = false;
                chkNov.Checked = false;
                chkDec.Checked = false;

            }



        }

        private void MultiplePayment_Load(object sender, EventArgs e)
        {
            comboBoxYear.SelectedIndex = 0;
        }
    }
}
