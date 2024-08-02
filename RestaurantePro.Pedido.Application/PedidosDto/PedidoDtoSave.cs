

namespace RestaurantePro.Pedido.Application.PedidosDto
{
    public class PedidoDtoSave : DtoBasePedido
    {
        public int IdPedido { get; set; }

        public int IdMesa { get; set; }

        public decimal Total { get; set; }
    }
}
