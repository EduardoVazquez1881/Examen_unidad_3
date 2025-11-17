using System;
using Producto;

namespace Decoradores
{
    public class FormatoEspecialDecorator : ProductoDecorator
    {
        private readonly string _estilo;

        public FormatoEspecialDecorator(IProductoComponent producto, string estilo = "destacado") : base(producto)
        {
            _estilo = estilo;
        }

        public override void MostrarInformacion()
        {
            if (_estilo == "destacado")
            {
                Console.WriteLine("----- PRODUCTO DESTACADO -----");
            }
            else if (_estilo == "oferta")
            {
                Console.WriteLine("\n----- OFERTA ESPECIAL -----");
            }
            
            base.MostrarInformacion();
            
            if (_estilo == "destacado")
            {
                Console.WriteLine("------------------------------");
            }
        }
    }
}