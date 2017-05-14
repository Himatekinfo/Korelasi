using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Korelasi
{
    public partial class frmAdd : Form
    {
        Form1 frm = null;
        
        public frmAdd(Form1 f)
        {
            InitializeComponent();
            frm = f;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frm.insertData(int.Parse(txtXValue.Text), int.Parse(txtYValue.Text));
            frm.refreshDgv();
            DialogResult = System.Windows.Forms.DialogResult.Yes;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = System.Windows.Forms.DialogResult.No;
        }
    }
}
