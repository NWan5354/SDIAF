using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CourseworkEx4_PartB_Section3_4
{
    /// <summary>
    /// Summary description for CurrencyExchange
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CurrencyExchange : System.Web.Services.WebService
    {

        //[WebMethod]
        //public string HelloWorld()
        //{
        //    return "Hello World";
        //}

        [WebMethod]
        public double CurrencyGBPtoUSDollar(double exchange)
        {
            return exchange = exchange * 1.25;
        }

        [WebMethod]
        public double CurrencyGBPtoSouthAfrica(double exchange)
        {
            return exchange = exchange * 15.54;
        }

        [WebMethod]
        public double CurrencyGBPtoSingaporeDollar(double exchange)
        {
            return exchange = exchange * 1.75;
        }

        [WebMethod]
        public double CurrencyGBPtoHongKongDollar(double exchange)
        {
            return exchange = exchange * 9.70;
        }

        [WebMethod]
        public double CurrencyGBPtoFranceEuro(double exchange)
        {
            return exchange = exchange * 1.15;
        }

        [WebMethod]
        public double CurrencyGBPtoGermanyEuro(double exchange)
        {
            return exchange = exchange * 1.15;
        }

        [WebMethod]
        public double CurrencyGBPtoIndiaRupee(double exchange)
        {
            return exchange = exchange * 81.68;
        }

        [WebMethod]
        public double CurrencyGBPtoDenmarkDanishKrone(double exchange)
        {
            return exchange = exchange * 8.58;
        }



    }
}
