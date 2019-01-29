using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using TesteBackendT4W.Models;

namespace TesteBackendT4W
{
    public class DataStarter
    {
        public static void Start()
        {

            List<Hotel> hotelsMiami;
            List<Hotel> hotelsOrlando;

            using (StreamReader r = new StreamReader("C:\\Users\\gabri\\source\\repos\\TesteBackendT4W\\TesteBackendT4W\\TesteBackendT4W\\Data\\1003944_hotels_static_data.json"))
            {
                string json = r.ReadToEnd();
                hotelsMiami = JsonConvert.DeserializeObject<List<Hotel>>(json);
            }

            using (StreamReader r = new StreamReader("C:\\Users\\gabri\\source\\repos\\TesteBackendT4W\\TesteBackendT4W\\TesteBackendT4W\\Data\\1010106_hotels_static_data.json"))
            {
                string json = r.ReadToEnd();
                hotelsOrlando = JsonConvert.DeserializeObject<List<Hotel>>(json);
            }

            HttpContext.Current.Session.Add("MIAMI", hotelsMiami);
            HttpContext.Current.Session.Add("ORLANDO", hotelsOrlando);

        }

        

    }
}

