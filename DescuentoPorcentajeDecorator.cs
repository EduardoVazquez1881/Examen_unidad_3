using System;
using Producto;

namespace Decoradores
{
    public class DescuentoPorcentajeDecorator : ProductoDecorator
    {
        private readonly decimal _porcentaje;

        public DescuentoPorcentajeDecorator(IProductoComponent producto, decimal porcentaje) 
            : base(producto)
        {
            if (porcentaje < 0 || porcentaje > 100)
                throw new ArgumentException("El porcentaje debe estar entre 0 y 100");
            
            _porcentaje = porcentaje;
        }

        public override decimal GetPrecio()
        {
            decimal precioOriginal = base.GetPrecio();
            decimal descuento = precioOriginal * (_porcentaje / 100);
            return precioOriginal - descuento;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            decimal precioOriginal = _producto.GetPrecio();
            Console.WriteLine($"Descuento  : {_porcentaje}% OFF");
            Console.WriteLine($"Ahorro     : {precioOriginal * (_porcentaje / 100):C}");
            Console.WriteLine($"PRECIO FINAL: {GetPrecio():C}");
        }
    }
}