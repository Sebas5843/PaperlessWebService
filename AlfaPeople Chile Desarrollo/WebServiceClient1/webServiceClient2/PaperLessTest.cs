using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webServiceClient2.PaperlessService;

namespace webServiceClient2
{
    class PaperLessTest
    {
        public static void PaperlessMain()
        {
            OnlinePortTypeClient clientCC = new OnlinePortTypeClient("OnlineHttpSoap11Endpoint", "http://google.cl");
            OnlineResponse response = new OnlineResponse();

            string respuesta;
            int devolucion;

            System.ServiceModel.EndpointAddress direcc;

            direcc = clientCC.Endpoint.Address;

            //direcc.Uri = new Uri("http://google.cl");
            //divisa = 

            respuesta = clientCC.OnlineGenerationDte( 94623000-6, "opt_sodexo", "abc456", "xml2", 1, 0);
            respuesta = clientCC.OnlineRecoveryRecList(94623000, "opt_sodexo", "abc456", "2010-03-03"); //OnlineGeneration(94623000, "opt_sodexo", "abc456", "xml2", 1, 0);
            //.ClientCredentials.UserName.UserName.;

            //Console.WriteLine("La conversión es {1}", a, clientWS1.FahrenheitToCelsius(a.ToString()));
            Console.WriteLine("La respuesta es " + respuesta);
        }
    }
}
