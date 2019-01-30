using System.ComponentModel.DataAnnotations;

namespace TesteBackendT4W.Models
{
    /// <summary>
    /// Room Attribute (obtained through API)  
    /// </summary>
    public class TotalSellingPrice
    {
        [Display(Name = "Moeda")]
        public string Currency { get; set; }

        [Display(Name = "Valor")]
        public double Value { get; set; }
    }
}