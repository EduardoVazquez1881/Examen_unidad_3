using System;
using System.Collections.Generic;
using IProductos;
using Flyweight;

namespace Fabrica
{
    public class ProductoCrearPeso
    {
        private readonly Dictionary<string, IProductosLigeros> _pesoLigero = new();

        public IProductosLigeros GetProductoLigeros(string categoria, string descripcion, string fabricante)
        {
            string llave = $"{categoria}_{fabricante}";

            if (!_pesoLigero.ContainsKey(llave))
            {
                _pesoLigero[llave] = new ProductoPesoLigero(categoria, descripcion, fabricante);
                Console.WriteLine($"- Nuevo objeto peso ligero creado: {llave}");
            }
            else
            {
                Console.WriteLine($"- Objeto peso ligero reutilizado: {llave}");
            }
            return _pesoLigero[llave];
        }

        public int GetTotalProductosLigeros() => _pesoLigero.Count;
    }
}