namespace TesteBackendT4W.Models.api
{
    public class BookHotelResponse
    {
        public object Error { get; set; }
        public string TimeSpan { get; set; }
        public string Token { get; set; }
        public double TotalTime { get; set; }
        public System.Collections.Generic.IList<HotelAvailable> Hotels { get; set; }
        public int TotalHotelResults { get; set; }
    }
}