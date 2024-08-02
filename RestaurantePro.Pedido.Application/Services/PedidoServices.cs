using Microsoft.Extensions.Logging;
using RestaurantePro.Pedido.Domain.Interfaces;
using RestaurantePro.Pedido.Application.Base;
using RestaurantePro.Pedido.Application.Contracts;
using RestaurantePro.Pedido.Application.PedidosDto;
using RestaurantePro.Pedido.Application.Extentions;

namespace RestaurantePro.Pedido.Application.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository pedidoRepository;
        private readonly IDetallePedidoRepository detallePedidoRepository;
        private readonly ILogger<PedidoService> logger;

        public PedidoService(IPedidoRepository pedidoRepository,IDetallePedidoRepository detallePedidoRepository, ILogger<PedidoService> logger)
        {
            this.pedidoRepository = pedidoRepository;
            this.logger = logger;
        }
        public ServicesResult GetPedidoById(int id)
        {
            ServicesResult result = new ServicesResult();

            try
            {
                result.Data = this.pedidoRepository.GetPedidosByPedidoId(id);
               
            }
            catch (Exception ex) 
            {
                result.Success = false;
                result.Message = "Ocurrio un error obteniendo los datos";
                this.logger.LogError(result.Message, ex.ToString());

            }

            return result;
        }

        public ServicesResult GetPedidos()
        {
            ServicesResult result = new ServicesResult();
            try
            {
                result.Data = pedidoRepository.GetAll();
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error obteniendo los departamentos";
                this.logger.LogError(result.Message, ex.ToString());

            }
            return result;

        }

        public ServicesResult RemovePedido(PedidoDtoRemove pedidoDtoRemove)
        {
            ServicesResult result = new ServicesResult();

            try
            {
                if (pedidoDtoRemove is null)
                {
                    result.Success = false;
                    result.Message = $"El objeto{nameof(pedidoDtoRemove)} es requerido.";
                    return result;
                }


                Domain.Entites.Pedido pedido = new Domain.Entites.Pedido()
                {
                    deleted = pedidoDtoRemove.deleted,
                    Id = pedidoDtoRemove.Id,
                    delete_date = pedidoDtoRemove.delete_date,
                    delete_user = pedidoDtoRemove.delete_user,
                };

                this.pedidoRepository.Remove(pedido);
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Error removiendo el pedido.";
                this.logger.LogError(message: result.Message, ex.ToString());
            }

            return result;
        }

        public ServicesResult SavePedido(PedidoDtoSave pedidoDtoSave)
        {
            ServicesResult result = new ServicesResult();


            if(pedidoDtoSave is null)
            {
                result.Success = false;
                result.Message = "No puede ser null";
                return result;
            }    

            try
            {

                result = pedidoDtoSave.IsValidPedido();

                if (!result.Success)
                    return result;


                Domain.Entites.Pedido pedido = new Domain.Entites.Pedido()
                {
                    IdMesa = pedidoDtoSave.IdMesa,
                    Total = pedidoDtoSave.Total,
                    
                    


                };

                this.pedidoRepository.Save(pedido);


            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Error guardando el pedido.";
                this.logger.LogError(message: result.Message, ex.ToString());
            }


            return result;
        }

        public ServicesResult UpdatePedido(PedidoDtoUpdate pedidoDtoUpdate)
        {
            ServicesResult result = new ServicesResult();

            try
            {

                result = pedidoDtoUpdate.IsValidPedido();

                if (!result.Success)
                    return result;


                Domain.Entites.Pedido pedido = new Domain.Entites.Pedido()
                {
                    IdMesa = pedidoDtoUpdate.IdMesa,
                    Total = pedidoDtoUpdate.Total,
                    modify_date = pedidoDtoUpdate.modify_date,
                    modify_user = pedidoDtoUpdate.modify_user,
                    
                };

                this.pedidoRepository.Update(pedido);

            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Error actualizando el pedido.";
                this.logger.LogError(message: result.Message, ex.ToString());
            }


            return result;
        }
    }
}
