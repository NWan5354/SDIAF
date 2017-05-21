using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseworkEx4_PartB_Section3_4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConvertCurrency_Click(object sender, EventArgs e)
        {
            if (DropDownList1.Text == "United States")
            {
                localhost.CurrencyExchange newConv = new localhost.CurrencyExchange();
                double britishPound = Convert.ToDouble(txtBritishPound.Text);
                double exchangeRate = newConv.CurrencyGBPtoUSDollar(britishPound);

                lblCurrencyResultReturned.Text = exchangeRate.ToString() + " US Dollar";
            }
            if (DropDownList1.Text == "South Africa")
            {
                localhost.CurrencyExchange newConv = new localhost.CurrencyExchange();
                double britishPound = Convert.ToDouble(txtBritishPound.Text);
                double exchangeRate = newConv.CurrencyGBPtoSouthAfrica(britishPound);

                lblCurrencyResultReturned.Text = exchangeRate.ToString() + " Rand";
            }
            if (DropDownList1.Text == "Singapore")
            {
                localhost.CurrencyExchange newConv = new localhost.CurrencyExchange();
                double britishPound = Convert.ToDouble(txtBritishPound.Text);
                double exchangeRate = newConv.CurrencyGBPtoSingaporeDollar(britishPound);

                lblCurrencyResultReturned.Text = exchangeRate.ToString() + " Singapore Dollar";
            }
            if (DropDownList1.Text == "Hong Kong")
            {
                localhost.CurrencyExchange newConv = new localhost.CurrencyExchange();
                double britishPound = Convert.ToDouble(txtBritishPound.Text);
                double exchangeRate = newConv.CurrencyGBPtoHongKongDollar(britishPound);

                lblCurrencyResultReturned.Text = exchangeRate.ToString() + " HKD";
            }
            if (DropDownList1.Text == "France")
            {
                localhost.CurrencyExchange newConv = new localhost.CurrencyExchange();
                double britishPound = Convert.ToDouble(txtBritishPound.Text);
                double exchangeRate = newConv.CurrencyGBPtoFranceEuro(britishPound);

                lblCurrencyResultReturned.Text = exchangeRate.ToString() + " Euro";
            }
            if (DropDownList1.Text == "Germany")
            {
                localhost.CurrencyExchange newConv = new localhost.CurrencyExchange();
                double britishPound = Convert.ToDouble(txtBritishPound.Text);
                double exchangeRate = newConv.CurrencyGBPtoGermanyEuro(britishPound);

                lblCurrencyResultReturned.Text = exchangeRate.ToString() + " Euro";
            }
            if (DropDownList1.Text == "India")
            {
                localhost.CurrencyExchange newConv = new localhost.CurrencyExchange();
                double britishPound = Convert.ToDouble(txtBritishPound.Text);
                double exchangeRate = newConv.CurrencyGBPtoIndiaRupee(britishPound);

                lblCurrencyResultReturned.Text = exchangeRate.ToString() + " Rupee";
            }
            if (DropDownList1.Text == "Denmark")
            {
                localhost.CurrencyExchange newConv = new localhost.CurrencyExchange();
                double britishPound = Convert.ToDouble(txtBritishPound.Text);
                double exchangeRate = newConv.CurrencyGBPtoDenmarkDanishKrone(britishPound);

                lblCurrencyResultReturned.Text = exchangeRate.ToString() + " Danish Krone";
            }
            
        }
    }
}