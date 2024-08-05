namespace RestaurantePro.Web.Models
{
    public class PedidoGetModel
    {
    
        public int IdPedido { get; set; }
        public string? fecha { get; set; }
        public double? total { get; set; }
        public int? idCliente { get; set; }
        public int? idMesa { get; set; }
        public int creation_user { get; set; }
        public DateTime creation_date { get; set; }
        public DateTime? modify_date { get; set; }
        public int? modify_user { get; set; }
        public int? delete_user { get; set; }
        public DateTime? delete_date { get; set; }
        public bool deleted { get; set; }
    }
}
