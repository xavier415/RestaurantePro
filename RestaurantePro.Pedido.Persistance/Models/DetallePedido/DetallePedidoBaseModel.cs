

namespace RestaurantePro.Pedido.Persistance.Models.DetallePedido
{
    public abstract class DetallePedidoBaseModel :ModelBase
    {
        public int IdDetallePedido { get; set; }

        public int? IdPedido { get; set; }

        public int? IdPlato { get; set; }

        public int? Cantidad { get; set; }

        public bool? Subtotal { get; set; }

        public DateTime creation_date { get; set; }

        public int? creation_user { get; set; }

        public DateTime modify_date { get; set; }
    }
}
