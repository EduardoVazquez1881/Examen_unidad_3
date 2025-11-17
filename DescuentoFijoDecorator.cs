using System;
using Producto;

namespace Decoradores
{
    public class DescuentoFijoDecorator : ProductoDecorator
    {
        private readonly decimal _montoDescuento;

        public DescuentoFijoDecorator(IProductoComponent producto, decimal montoDescuento) 
            : base(producto)
        {
            if (montoDescuento < 0)
                throw new ArgumentException("El descuento no puede ser negativo");
            
            _montoDescuento = montoDescuento;
        }

        public override decimal GetPrecio()
        {
            decimal precioOriginal = base.GetPrecio();
            decimal precioFinal = precioOriginal - _montoDescuento;
            return precioFinal < 0 ? 0 : precioFinal;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Descuento  : -{_montoDescuento:C}");
            Console.WriteLine($"PRECIO FINAL: {GetPrecio():C}");
        }
    }
}