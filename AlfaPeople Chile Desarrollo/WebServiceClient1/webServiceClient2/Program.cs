using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webServiceClient2.BorlandWS;
using webServiceClient2.ServiceReference1;


namespace webServiceClient2
{
    class Program
    {
        static void Main(string[] args)
        {
            //testing currencyConvertor web service
            //PaperLessTest.PaperlessMain();

            //testing currencyConvertor web service
            CurrencyConverterTest.CurrencyConverterMain();

            //testing JSON API REST
            WeatherApiClient.GetWeatherForecast();

            Service1SoapClient clientWS = new BorlandWS.Service1SoapClient();
            TempConvertSoapClient clientWS1 = new TempConvertSoapClient("TempConvertSoap12");
            //clientWS.GetNowAsDate();
            double a, b;

            Console.WriteLine("Escriba un valor en Farenheit");
            if (double.TryParse(Console.ReadLine(), out a))
            {
                b = a * Math.PI;
                //Console.WriteLine("Sonuç " + b);
            }
            else
            {
                //user gave an illegal input. Handle it here.
                Console.WriteLine("Error: valor ingresado no válido");
                //throw("Error");     
            }
            
            Console.WriteLine("{0} grados FarenHeit a Celsius es {1}", a, clientWS1.FahrenheitToCelsius(a.ToString()));
            
            Console.WriteLine("Presione ESC para salir");
            do
            {
                /*while (!Console.KeyAvailable)
                {
                    // Do something
                }*/
                Console.WriteLine("esperando...");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
