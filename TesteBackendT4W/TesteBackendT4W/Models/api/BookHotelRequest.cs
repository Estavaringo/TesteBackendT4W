namespace TesteBackendT4W.Models.api
{
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
