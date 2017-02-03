using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_1_Encryption_Exercise__Win_Forms_
{
    public partial class Form1 : Form
    {
        private encryption enc = new encryption();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            lblEncrypted.Text = enc.rot13(txtData.Text);
        }
    }
}
