

namespace RestaurantePro.Pedido.Persistance.Models.DetallePedido
{
    public class DetallePedidoRemove
    {
        public int IdDetallePedido { get; set; }

        public int? delete_user { get; set; }

        public DateTime? delete_date { get; set; }

        public bool deleted { get; set; }
    }
}
