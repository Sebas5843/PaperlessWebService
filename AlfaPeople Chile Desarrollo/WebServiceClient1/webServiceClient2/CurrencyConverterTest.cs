using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webServiceClient2.BorlandWS;
using webServiceClient2.ServiceReference1;
using webServiceClient2.CurrencyConvertorService;
using webServiceClient2.PaperlessService;

namespace webServiceClient2
{
    public static class CurrencyConverterTest
    {
        public static void CurrencyConverterMain()
        {
            CurrencyConvertorSoapClient clientCC = new CurrencyConvertorSoapClient("CurrencyConvertorSoap12");

            /*Service1SoapClient clientWS = new BorlandWS.Service1SoapClient();

            string divisa;

            var divisa2 = Currency.USD;*/

            divisa = clientCC.ConversionRate(Currency.USD, Currency.CLP).ToString();

            //Console.WriteLine("La conversión es {1}", a, clientWS1.FahrenheitToCelsius(a.ToString()));
            Console.WriteLine("La conversión es");
        }

    }
}
