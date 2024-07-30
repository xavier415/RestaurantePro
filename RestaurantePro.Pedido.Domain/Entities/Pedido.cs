

using RestaurantePro.Common.Data.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantePro.Pedido.Domain.Entites
{
    public class Pedido : AuditEntity<int>
    {
        [Column("IdPedido")]
        public override int Id { get; set; }
    }
}
