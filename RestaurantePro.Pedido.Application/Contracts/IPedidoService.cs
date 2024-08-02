

using RestaurantePro.Pedido.Application.Base;
using RestaurantePro.Pedido.Application.PedidosDto;

namespace RestaurantePro.Pedido.Application.Contracts
{
    public interface IPedidoService
    {

        ServicesResult GetPedidos();
        ServicesResult GetPedidoById(int id);

        ServicesResult UpdatePedido(PedidoDtoUpdate pedidoDtoUpdate);

        ServicesResult RemovePedido(PedidoDtoRemove pedidoDtoRemove);

        ServicesResult SavePedido(PedidoDtoSave pedidoDtoSave);
    }
}
