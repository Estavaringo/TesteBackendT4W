namespace TesteBackendT4W.Models
{
    public class HotelAvailable
    {
        public int HotelId { get; set; }
        public bool IsRecommended { get; set; }
        public System.Collections.Generic.IList<Room> Rooms { get; set; }
    }
}