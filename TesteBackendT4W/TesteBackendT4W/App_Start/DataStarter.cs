using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using TesteBackendT4W.Models;

namespace TesteBackendT4W
{

    /// <summary>
    /// Loads all the hotels data from the server files and add into the current session
    /// </summary>
    public class DataStarter
    {
        public static void Start(String rootPath)
        {
            List<HotelData> hotels;

            //reads file and deserialize content
            using (StreamReader r = new StreamReader(rootPath + "Data\\1003944_hotels_static_data.json"))
            {
                string json = r.ReadToEnd();
                hotels = JsonConvert.DeserializeObject<List<HotelData>>(json);
            }

            using (StreamReader r = new StreamReader(rootPath + "Data\\1010106_hotels_static_data.json"))
            {
                string json = r.ReadToEnd();
                hotels.AddRange(JsonConvert.DeserializeObject<List<HotelData>>(json));
            }

            //add list to the current session
            HttpContext.Current.Session.Add("HOTELS", hotels);

        }

        

    }
}

