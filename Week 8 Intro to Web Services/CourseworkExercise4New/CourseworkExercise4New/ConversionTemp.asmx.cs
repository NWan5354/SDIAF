using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CourseworkExercise4New
{
    /// <summary>
    /// Summary description for ConversionTemp
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ConversionTemp : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public double CelsiusToFarenheit(double temp1)
        {
            return temp1 = temp1 * 9 / 5 + 32;
        }

        [WebMethod]
        public double FarenheitToCelsius(double temp2)
        {
            return temp2 = (temp2 - 32) * 5 / 9;
        }

    }
}
