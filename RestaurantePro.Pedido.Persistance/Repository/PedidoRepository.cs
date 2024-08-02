

using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Logging;
using RestaurantePro.Pedido.Domain.Interfaces;
using RestaurantePro.Pedido.Persistance.Context;
using RestaurantePro.Pedido.Persistance.Exceptions;
using System.Linq.Expressions;

namespace RestaurantePro.Pedido.Persistance.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly RestauranteContext _restauranteContext;

        private readonly ILogger<PedidoRepository> _logger;

        public PedidoRepository(RestauranteContext context, ILogger<PedidoRepository> logger)
        {
          _restauranteContext = context;
            _logger = logger;
        }
        public bool Exists(Expression<Func<Domain.Entites.Pedido, bool>> filter)
        {
            return this._restauranteContext.Pedido.Any(filter);
        }

        public List<Domain.Entites.Pedido> GetAll()
        {
            return this._restauranteContext.Pedido.ToList();
        }

        public Domain.Entites.Pedido GetEntityBy(int Id)
        {
            Domain.Entites.Pedido? pedido = null;
            try 
            {
                pedido = this._restauranteContext.Pedido.Find(Id);

                if (pedido is null)
                    throw new PedidoDbExceptions("El pedido no se encuentra registrado.");

                return pedido;
            }
            catch (Exception ex)
            {
                this._logger.LogError("Error obtenido el curso.", ex.ToString());
            }
            return pedido;
        }

        public List<Domain.Entites.Pedido> GetPedidosByPedidoId(int IdPedido)
        {
            return this._restauranteContext.Pedido.ToList();
        }

        public void Remove(Domain.Entites.Pedido entity)
        {
            try
            {
                if (entity is null)
                    throw new ArgumentNullException("La entidad curso no puede nulo.");


                Domain.Entites.Pedido? pedidoToRemove = this._restauranteContext.Pedido.Find(entity.Id);

                if (pedidoToRemove is null)
                    throw new PedidoDbExceptions("El curso que desea eliminar no se encuentra registrado.");

                pedidoToRemove.delete_user = entity.delete_user;
                pedidoToRemove.deleted = entity.deleted;
                pedidoToRemove.delete_date = entity.delete_date;
               
                _restauranteContext.Pedido.Update(pedidoToRemove);
                this._restauranteContext.SaveChanges();
            }
            catch (Exception ex)
            {
                this._logger.LogError("Error removiendo el curso", ex.ToString());
            }
        }

        public void Save(Domain.Entites.Pedido entity)
        {
            try 
            {
                if (entity is null)
                    throw new ArgumentNullException("La entidad pedido no puede ser nulo");

                if (Exists(co => co.IdCliente == (entity.IdCliente)))
                        throw new PedidoDbExceptions("El pedido no se encuentra registrado.");

                _restauranteContext.Pedido.Add(entity);
                _restauranteContext.SaveChanges();
            }
            catch (Exception ex) 
            {
                this._logger.LogError("Error agregando el pedido.", ex.ToString());
            }
        }

        public void Update(Domain.Entites.Pedido entity)
        {
            try 
            {
                if (entity is null)
                    throw new ArgumentNullException("La entidad pedido no puede ser nulo");

                Domain.Entites.Pedido? pedidoToUpdate = this._restauranteContext.Pedido.Find(entity.Id);

                if (pedidoToUpdate is null)
                    throw new PedidoDbExceptions("el pedido que desea actualizar no se encuentra registrado");

                pedidoToUpdate.modify_date = entity.modify_date;
                pedidoToUpdate.Fecha = entity.Fecha;
                pedidoToUpdate.Total = entity.Total;

                _restauranteContext.Pedido.Update(pedidoToUpdate);
                _restauranteContext.SaveChanges();
            }
            catch (Exception ex)
            {
                this._logger.LogError("Error actualizando el curso.", ex.ToString());
            } 
        }
    }
}
