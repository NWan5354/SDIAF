using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebServiceForm.Webref1;

namespace WebServiceForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtConvert_Click(object sender, EventArgs e)
        {
            Webref1.lengthUnit ref1 = new Webref1.lengthUnit();
            double convValue = Convert.ToDouble(txtValue.Text);
            double answer = ref1.ChangeLengthUnit(convValue, Lengths.Centimeters, Lengths.Inches);
            txtAnswer.Text = "Answer: " + answer;
        }
    }
}
