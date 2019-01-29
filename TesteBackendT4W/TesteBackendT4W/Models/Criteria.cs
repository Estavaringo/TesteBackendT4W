namespace TesteBackendT4W.Models
{
    public class Criteria
    {
        public int DestinationId { get; set; }
        public int NumNights { get; set; }
        public string CheckinDate { get; set; }
        public const string MainPaxCountryCodeNationality = "BR";
        public System.Collections.Generic.IList<SearchRoom> SearchRooms { get; set; }
    }
}