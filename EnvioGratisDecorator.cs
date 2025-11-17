using System;
using Producto;

namespace Decoradores
{
    public class EnvioGratisDecorator : ProductoDecorator
    {
        private readonly decimal _precioMinimo;

        public EnvioGratisDecorator(IProductoComponent producto, decimal precioMinimo = 500m) : base(producto)
        {
            _precioMinimo = precioMinimo;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            
            if (GetPrecio() >= _precioMinimo)
            {
                Console.WriteLine($"---- ENVIO GRATIISSS----");
            }
            else
            {
                Console.WriteLine($"---- ENVIO 40 PESOS ----");
            }
        }
    }
}