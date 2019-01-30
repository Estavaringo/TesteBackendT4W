namespace TesteBackendT4W.Models.api
{


    /// <summary>
    /// Model of room availability search service request
    /// <para>Represents the request that has to be sent to the API</para>
    /// </summary>
    public class BookHotelRequest
    {
        
        public Credential Credential { get; set; }
        public Criteria Criteria { get; set; }
        
        public BookHotelRequest(BookHotelModelView bookHotelModelView){
            
            this.Credential = new Credential();
            this.Criteria = new Criteria(bookHotelModelView);
        
        }
        
    }
}
