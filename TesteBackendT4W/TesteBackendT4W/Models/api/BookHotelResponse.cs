using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TesteBackendT4W.Models.api
{
    /// <summary>
    /// Model of room availability search service response
    /// <para>Represents the response that will be received from the API</para>
    /// </summary>
    public class BookHotelResponse
    {

        public object Error { get; set; }

        public string TimeSpan { get; set; }
        public string Token { get; set; }

        [Display(Name = "Tempo da Requisição")]
        public double TotalTime { get; set; }

        //List of all available hotels that was found
        public List<HotelAvailable> Hotels { get; set; }


        [Display(Name = "Hotéis Encontrados:")]
        public int TotalHotelResults { get; set; }
    }
}