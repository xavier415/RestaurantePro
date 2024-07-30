

using RestaurantePro.Pedido.Domain.Interfaces;
using System.Linq.Expressions;

namespace RestaurantePro.Pedido.Persistance.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        public bool Exists(Expression<Func<Domain.Entites.Pedido, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Entites.Pedido> GetAll()
        {
            throw new NotImplementedException();
        }

        public Domain.Entites.Pedido GetEntityBy(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Entites.Pedido> GetPedidosByPedidoId(int IdPedido)
        {
            throw new NotImplementedException();
        }

        public void Remove(Domain.Entites.Pedido entity)
        {
            throw new NotImplementedException();
        }

        public void Save(Domain.Entites.Pedido entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Domain.Entites.Pedido entity)
        {
            throw new NotImplementedException();
        }
    }
}
