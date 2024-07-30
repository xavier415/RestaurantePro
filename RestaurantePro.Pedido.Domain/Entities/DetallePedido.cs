using RestaurantePro.Common.Data.Base;

using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantePro.Pedido.Domain.Entities
{
    public class DetallePedido : AuditEntity<int>
    {
        [Column("IdDetallePedido")]
        public override int Id { get ; set ; }
    }
}
