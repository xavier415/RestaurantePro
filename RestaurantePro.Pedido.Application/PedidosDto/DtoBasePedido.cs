

namespace RestaurantePro.Pedido.Application.PedidosDto
{
    public abstract class DtoBasePedido : DtoBase
    {
       
        public int IdPedido {  get; set; }
        public int? IdCliente { get; set; }
        public int IdMesa { get; set; }

        public DateOnly? Fecha { get; set; }

        public decimal Total { get; set; }

        public int UserMod { get; set; }
    }
}
