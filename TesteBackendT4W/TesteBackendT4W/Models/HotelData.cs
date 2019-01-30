using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;


namespace TesteBackendT4W.Models
{

    /// <summary>
    /// Static details about a hotel
    /// </summary>
    public class HotelData
    {

        [JsonProperty("id"), Display(Name = "Códido")]
        public int Id { get; set; }

        [JsonProperty("name"), Display(Name = "Nome")]
        public string Name { get; set; }

        [JsonProperty("chainName"), Display(Name = "Chain Name")]
        public string ChainName { get; set; }

        [JsonProperty("chainId"), Display(Name = "Chain Code")]
        public int ChainId { get; set; }

        [JsonProperty("category"), Display(Name = "Categoria")]
        public double Category { get; set; }

        [JsonProperty("urlThumb"), Display(Name = "Foto")]
        public string UrlThumb { get; set; }

        [JsonProperty("cityNamePT"), Display(Name = "Cidade")]
        public string CityNamePT { get; set; }

        [JsonProperty("cityNameEN"), Display(Name = "Cidade")]
        public string CityNameEN { get; set; }

        [JsonProperty("cityNameES"), Display(Name = "CidadeES")]
        public string CityNameES { get; set; }

        [JsonProperty("cityId"), Display(Name = "Código da Cidade")]
        public int CityId { get; set; }

        [JsonProperty("latitude"), Display(Name = "Latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude"), Display(Name = "Longitude")]
        public double Longitude { get; set; }

        [JsonProperty("taRatingImageUrl"), Display(Name = "Trip Advisor")]
        public string TaRatingImageUrl { get; set; }

        [JsonProperty("taRating"), Display(Name = "Nota")]
        public double TaRating { get; set; }

        [JsonProperty("taNumReviews"), Display(Name = "Avaliações")]
        public int TaNumReviews { get; set; }

        [JsonProperty("percentRecommended"), Display(Name = "Recomendação (%)")]
        public double PercentRecommended { get; set; }

        [JsonProperty("localizations"), Display(Name = "Localizações")]
        public IList<object> Localizations { get; set; }

        [JsonProperty("address"), Display(Name = "Endereço")]
        public string Address { get; set; }

        [JsonProperty("website"), Display(Name = "Site")]
        public string Website { get; set; }

        [JsonProperty("typePT"), Display(Name = "Tipo")]
        public string TypePT { get; set; }

        [JsonProperty("typeEN"), Display(Name = "TipoEN")]
        public string TypeEN { get; set; }

        [JsonProperty("typeES"), Display(Name = "TipoES")]
        public string TypeES { get; set; }

        
        
    }
}