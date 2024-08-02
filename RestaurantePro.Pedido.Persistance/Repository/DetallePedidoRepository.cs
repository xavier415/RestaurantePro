

using Microsoft.Extensions.Logging;
using RestaurantePro.Pedido.Domain.Entities;
using RestaurantePro.Pedido.Domain.Interfaces;
using RestaurantePro.Pedido.Persistance.Context;
using System.Linq.Expressions;

namespace RestaurantePro.Pedido.Persistance.Repository
{
    public class DetallePedidoRepository : IDetallePedidoRepository
    {
        private readonly RestauranteContext context;
        private readonly ILogger<DetallePedidoRepository> logger;

        public DetallePedidoRepository(RestauranteContext context, ILogger<DetallePedidoRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }
        public bool Exists(Expression<Func<DetallePedido, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<DetallePedido> GetAll()
        {
            return this.context.DetallePedido.ToList();
        }

        public DetallePedido GetEntityBy(int Id)
        {
            return this.context.DetallePedido.Find(Id);
        }

        public void Remove(DetallePedido entity)
        {
            throw new NotImplementedException();
        }

        public void Save(DetallePedido entity)
        {
            throw new NotImplementedException();
        }

        public void Update(DetallePedido entity)
        {
            throw new NotImplementedException();
        }
    }
}
