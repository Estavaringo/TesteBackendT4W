using System.ComponentModel.DataAnnotations;

namespace TesteBackendT4W.Models
{
    /// <summary>
    /// Room details (obtained through API)
    /// </summary>
    public class Room
    {

        [Display(Name = "Pacote")]
        public string BoardDescription { get; set; }
        
        public object CancellationPolicies { get; set; }
        
        public System.Collections.Generic.IList<int> ChildAges { get; set; }
        
        public object CustomFields { get; set; }

        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Disponível?")]
        public bool IsAvailable { get; set; }

        [Display(Name = "Pagamento Antecipado?")]
        public bool IsPrePayment { get; set; }

        [Display(Name = "Informações Adicionais")]
        public string MoreInformation { get; set; }

        [Display(Name = "Quantidade de Adultos")]
        public int NumAdults { get; set; }

        [Display(Name = "Pagamento Direto com o Hotel?")]
        public bool PayDirectToHotel { get; set; }

        [Display(Name = "Quantidade de Quartos")]
        public int Quantity { get; set; }

        [Display(Name = "Descrição do Quarto")]
        public string RoomDescription { get; set; }
        
        public SellingPricePerRoom SellingPricePerRoom { get; set; }

        public TotalSellingPrice TotalSellingPrice { get; set; }
    }
}