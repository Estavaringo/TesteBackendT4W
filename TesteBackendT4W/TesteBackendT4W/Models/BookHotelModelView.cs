using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TesteBackendT4W.Models
{
    public class BookHotelModelView
    {

        [Display(Name = "Destino"), Required(AllowEmptyStrings = false)]
        public IList<SelectListItem> Destination { get; set; }

        [Display(Name = "Quantidade de Noites"), Required(AllowEmptyStrings = false), Range(1, 100)]
        public int NumNights { get; set; }

        [Display(Name = "Data do Checkin"), Required(AllowEmptyStrings = false), DataType(DataType.Date), DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime CheckinDate { get; set; }
        
        public string MainPaxCountryCodeNationality { get; set; }

        [Display(Name = "Adultos"), Required(AllowEmptyStrings = false), Range(1, 20)]
        public int NumAdults { get; set; }

        [Display(Name = "Quantidade de Crianças"), Range(1, 20)]
        public int numChildren { get; set; }

        [Display(Name = "Idade das Crianças"), Range(1, 12)]
        public IList<int> ChildAges { get; set; }

        [Display(Name = "Quantidade de Quartos"), Required(AllowEmptyStrings = false), Range(1, 20)]
        public int Quantity { get; set; }
    }
}