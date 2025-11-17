using System;
using Producto;

namespace Decoradores
{
    public class GarantiaExtendidaDecorator : ProductoDecorator
    {
        private readonly int _anios;
        private readonly decimal _costoGarantia;

        public GarantiaExtendidaDecorator(IProductoComponent producto, int anios, decimal costoGarantia) 
            : base(producto)
        {
            _anios = anios;
            _costoGarantia = costoGarantia;
        }

        public override decimal GetPrecio()
        {
            return base.GetPrecio() + _costoGarantia;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Garantia: {_anios} años extendidos (+{_costoGarantia:C})");
            Console.WriteLine($"PRECIO FINAL: {GetPrecio():C}");
        }
    }
}