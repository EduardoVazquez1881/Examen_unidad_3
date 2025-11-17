using System;
using Producto;

namespace Decoradores
{
    public class ValidacionPrecioDecorator : ProductoDecorator
    {
        public ValidacionPrecioDecorator(IProductoComponent producto) : base(producto)
        {
            if (producto.GetPrecio() <= 0)
                throw new InvalidOperationException($"Precio inválido para {producto.GetNombre()}");
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Precio validado");
            base.MostrarInformacion();
        }
    }
}