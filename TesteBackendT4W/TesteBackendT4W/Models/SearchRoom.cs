namespace TesteBackendT4W.Models
{

    
    /// <summary>
    /// Rooms that will be searched (used in API request)
    /// </summary>
    public class SearchRoom
    {
        public int NumAdults { get; set; }
        public System.Collections.Generic.IList<int> ChildAges { get; set; }
        public int Quantity { get; set; }
    }
}