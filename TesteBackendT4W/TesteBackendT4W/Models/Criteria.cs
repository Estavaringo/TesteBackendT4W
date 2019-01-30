using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TesteBackendT4W.Validation;

namespace TesteBackendT4W.Models
{
    /// <summary>
    /// Criteria used in the API request
    /// </summary>
    public class Criteria
    {
        public int DestinationId { get; set; }
      
        public int NumNights { get; set; }
        
        //specify date format
        [DataType(DataType.Date), JsonConverter(typeof(DateFormatConverter), "yyyy-MM-dd")]
        public DateTime CheckinDate { get; set; }
        
        public string MainPaxCountryCodeNationality { get; set; }
        
        public List<SearchRoom> SearchRooms { get; set; }
        

        //constructor
        public Criteria(BookHotelModelView bookHotelModelView){

            this.DestinationId = bookHotelModelView.DestinationId;
            this.NumNights = bookHotelModelView.NumNights;
            this.CheckinDate = bookHotelModelView.CheckinDate;
            this.MainPaxCountryCodeNationality = bookHotelModelView.MainPaxCountryCodeNationality;
            
            this.SearchRooms = new List<SearchRoom>
            {
                new SearchRoom() 
                {NumAdults = bookHotelModelView.NumAdults, 
                 ChildAges = bookHotelModelView.ChildAges,
                 Quantity = bookHotelModelView.Quantity}
            };
            
        }




    }
}
