

using Microsoft.EntityFrameworkCore;
using RestaurantePro.Pedido.Domain.Entities;


namespace RestaurantePro.Pedido.Persistance.Context
{
    public  class RestauranteContext :DbContext
    {
        #region"Constructor"
        public RestauranteContext(DbContextOptions<RestauranteContext> options) : base(options)
        {
        }
        #endregion


        #region"Db Sets"

        public DbSet<Domain.Entites.Pedido> Pedido { get; set; }
        public DbSet<DetallePedido> DetallePedido { get; set; }
        #endregion
    }
}
