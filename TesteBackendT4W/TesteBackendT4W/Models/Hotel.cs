using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteBackendT4W.Models
{
    public class Hotel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string chainName { get; set; }
        public int chainId { get; set; }
        public double category { get; set; }
        public string urlThumb { get; set; }
        public string cityNamePT { get; set; }
        public string cityNameEN { get; set; }
        public string cityNameES { get; set; }
        public int cityId { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string taRatingImageUrl { get; set; }
        public double taRating { get; set; }
        public int taNumReviews { get; set; }
        public double percentRecommended { get; set; }
        public IList<object> localizations { get; set; }
        public string address { get; set; }
        public string website { get; set; }
        public string typePT { get; set; }
        public string typeEN { get; set; }
        public string typeES { get; set; }
    }
}