

namespace RestaurantePro.Pedido.Persistance.Models.Pedido
{
    public class PedidoGetModel
    {
       
        public int IdPedido { get; set; }
        public int? IdCliente { get; set; }

        public int? IdMesa { get; set; }

        public DateOnly? Fecha { get; set; }

        public decimal? Total { get; set; }

        public DateTime? modify_date { get; set; }

        public int UserMod { get; set; }
    }
}
