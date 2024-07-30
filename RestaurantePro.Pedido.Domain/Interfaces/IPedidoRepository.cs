

using RestaurantePro.Common.Data.Repository;
using RestaurantePro.Pedido.Domain.Entites;

namespace RestaurantePro.Pedido.Domain.Interfaces
{
    public interface IPedidoRepository : IBaseRepository<Pedido.Domain.Entites.Pedido, int>
    {
        List<Pedido.Domain.Entites.Pedido> GetPedidosByPedidoId(int IdPedido);
    }
}
