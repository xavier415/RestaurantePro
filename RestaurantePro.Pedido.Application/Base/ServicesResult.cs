

namespace RestaurantePro.Pedido.Application.Base
{
    public class ServicesResult
    {
        public ServicesResult()
        {
            this.Success = true;
        }


        public bool Success { get; set; }
        public string? Message { get; set; }

        public dynamic? Result { get; set; }

        public dynamic? Data { get; set; }
    }
}

