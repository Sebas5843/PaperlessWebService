using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaperlessWebService.PaperlessService;

namespace PaperlessWebService
{
    class Program
    {
        static void Main(string[] args)
        {
            OnlinePortTypeClient cliente = new OnlinePortTypeClient("OnlineHttpSoap11Endpoint");

            string text = System.IO.File.ReadAllText(@"C:\Users\slazo\TestFolder\WriteText.txt");

            string respuesta = cliente.OnlineGeneration(94623000, "gen_sodexo", "abc123", text, 1, 0);
            Console.WriteLine(1);
        }
    }
}
