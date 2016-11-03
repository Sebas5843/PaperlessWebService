using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace webServiceClient2
{
    public static class WeatherApiClient
    {
        public static void GetWeatherForecast()
        {
            var url = "http://sinca.mma.gob.cl/index.php/json/listado/red/macam/";//servicio json api rest monitoreo del aire

            var syncClient = new WebClient();
            var content = syncClient.DownloadString(url);

        }
    }
}
