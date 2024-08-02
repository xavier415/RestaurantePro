

using Microsoft.Extensions.DependencyInjection;
using RestaurantePro.Pedido.Application.Contracts;
using RestaurantePro.Pedido.Application.Services;
using RestaurantePro.Pedido.Domain.Interfaces;
using RestaurantePro.Pedido.Persistance.Repositories;
using RestaurantePro.Pedido.Persistance.Repository;

namespace RestaurantePro.Pedido.IOC.Dependencies
{
    public static class PedidoDependecy
    {
        public static void AddPedidoDependency(this IServiceCollection service) 
        {
            #region"Repositorios"
            service.AddScoped<IPedidoRepository, PedidoRepository>();
             service.AddScoped<IDetallePedidoRepository, DetallePedidoRepository>();
            #endregion

            #region"Servicios"
            service.AddTransient<IPedidoService, PedidoService>();
            #endregion
        }
    }
}
