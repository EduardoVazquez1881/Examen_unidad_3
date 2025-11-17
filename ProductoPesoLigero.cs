using System;
using IProductos;

namespace Flyweight
{
    public class ProductoPesoLigero : IProductosLigeros
    {
        private readonly string _categoria;
        private readonly string _descripcion;
        private readonly string _fabricante;

        public ProductoPesoLigero(string categoria, string descripcion, string fabricante)
        {
            _categoria = categoria;
            _descripcion = descripcion;
            _fabricante = fabricante;
        }

        public void MostrarDatos(string nombre, decimal precio)
        {
            Console.WriteLine($"Nombre     : {nombre}");
            Console.WriteLine($"Descripcion: {_descripcion}");
            Console.WriteLine($"Categoria  : {_categoria}");
            Console.WriteLine($"Fabricante : {_fabricante}");
            Console.WriteLine($"Precio     : {precio:C}");
        }

        public string GetCategoria() => _categoria;
    }
}