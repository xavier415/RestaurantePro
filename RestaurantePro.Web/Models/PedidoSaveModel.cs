namespace RestaurantePro.Web.Models
{
    public class PedidoSaveModel 
    {
        public int modify_user { get; set; }
        public DateTime modify_date { get; set; }
        public int idCliente { get; set; }
        public DateTime? Fecha  { get; set; }
        public int userMod { get; set; }
        public int idPedido { get; set; }
        public int idMesa { get; set; }
        public int total { get; set; }
    }
}
