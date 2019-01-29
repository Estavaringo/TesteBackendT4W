namespace TesteBackendT4W.Models
{
    public class Room
    {
        public string BoardDescription { get; set; }
        public object CancellationPolicies { get; set; }
        public System.Collections.Generic.IList<int> ChildAges { get; set; }
        public object CustomFields { get; set; }
        public int Id { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsPrePayment { get; set; }
        public string MoreInformation { get; set; }
        public int NumAdults { get; set; }
        public bool PayDirectToHotel { get; set; }
        public int Quantity { get; set; }
        public string RoomDescription { get; set; }
        public SellingPricePerRoom SellingPricePerRoom { get; set; }
        public TotalSellingPrice TotalSellingPrice { get; set; }
    }
}