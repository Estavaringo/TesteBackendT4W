using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TesteBackendT4W.Models
{
    /// <summary>
    /// Hotel available for booking (obtained through API)
    /// </summary>
    public class HotelAvailable
    {

        [Display(Name = "Código do Hotel")]
        public int HotelId {get; set; }

        [Display(Name = "Recomendável?")]
        public bool IsRecommended { get; set; }
        
        public List<Room> Rooms { get; set; }

        [Display(Name = "Valor Minimo")]
        public double minPrice { get; set; }
    }
}