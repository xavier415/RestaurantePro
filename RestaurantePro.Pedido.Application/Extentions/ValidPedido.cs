

using RestaurantePro.Pedido.Application.Base;
using RestaurantePro.Pedido.Application.PedidosDto;

namespace RestaurantePro.Pedido.Application.Extentions
{
    public static class ValidPedido
    {
        public static ServicesResult IsValidPedido(this DtoBasePedido basePedido) 
        {
            ServicesResult result = new ServicesResult();

            /*if (basePedido is null) 
            {
                result.Success = false;
                result.Message = $"El objeto{nameof(basePedido)} es requerido.";
                return result;
         
            }*/
            if (basePedido?.IdMesa == 0)
            {
                result.Success = false;
                result.Message = $"El IdMesa es requerido.";
                return result;
            }

       
            if (basePedido?.IdCliente == 0)
            {
                result.Success = false;
                result.Message = $"Debe seleccionar el ID al que pertenece .";
                return result;
            }




            return result;
        }
    }
}
