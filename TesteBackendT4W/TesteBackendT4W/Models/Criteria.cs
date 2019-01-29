namespace TesteBackendT4W.Models
{
    public class Criteria
    {
        public int DestinationId { get; set; }
      
        public int NumNights { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime CheckinDate { get; set; }
        
        public const string MainPaxCountryCodeNationality { get; set; }
        
        public System.Collections.Generic.IList<SearchRoom> SearchRooms { get; set; }
        
        
        
        public Criteria(BookHotelModelView bookHotelModelView){
            
            this.DestinationId = bookHotelModelView.Destination.SelectedValue;
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
