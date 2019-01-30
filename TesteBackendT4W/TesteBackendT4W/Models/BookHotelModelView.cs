using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using TesteBackendT4W.Validation;

namespace TesteBackendT4W.Models
{


    /// <summary>
    /// Model of the object that will be obtained through the form
    /// <para>Is used to create the API request</para>
    /// </summary>
    public class BookHotelModelView
    {

        [Display(Name = "Destino"), Required(AllowEmptyStrings = false, ErrorMessage = "Campo Obrigatório")]
        public int DestinationId { get; set; }

        [Display(Name = "Quantidade de Noites"), Required(AllowEmptyStrings = false, ErrorMessage = "Campo Obrigatório"), Range(1, 100, ErrorMessage = "Valor deve estar entre 1 e 100")]
        public int NumNights { get; set; }

        [Display(Name = "Data do Checkin"), Required(AllowEmptyStrings = false, ErrorMessage = "Campo Obrigatório"), DataType(DataType.Date), DisplayFormat(DataFormatString = "dd/mm/yyyy"), MyDate(ErrorMessage = "Favor inserir uma data futura")]
        public DateTime CheckinDate { get; set; }
        
        public string MainPaxCountryCodeNationality { get; set; }

        [Display(Name = "Adultos"), Required(AllowEmptyStrings = false, ErrorMessage = "Campo Obrigatório"), Range(1, 20, ErrorMessage = "Valor deve estar entre 1 e 20")]
        public int NumAdults { get; set; }

        [Display(Name = "Quantidade de Crianças"), Range(0, 20, ErrorMessage = "Valor deve estar entre 0 e 20")]
        public int NumChildren { get; set; }

        [Display(Name = "Idade das Crianças"), Range(1, 12, ErrorMessage = "Valor deve estar entre 1 e 12")]
        public List<int> ChildAges { get; set; }

        [Display(Name = "Quantidade de Quartos"), Required(AllowEmptyStrings = false, ErrorMessage = "Campo Obrigatório"), Range(1, 20, ErrorMessage = "Valor deve estar entre 1 e 20")]
        public int Quantity { get; set; }
    }
}