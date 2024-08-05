namespace RestaurantePro.Web.Models
{
    public class BaseResult<TModel>
    {
        public string? message  { get; set; }

        public bool success { get; set; }

        public TModel? Result { get; set; }

    }

    //public class PedidoGetResult : BaseResult
    //{
    //    public List<Pedido>
    //}
}
