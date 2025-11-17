using System;
using Producto;

namespace Decoradores
{
    public abstract class ProductoDecorator : IProductoComponent
    {
        protected IProductoComponent _producto;

        public ProductoDecorator(IProductoComponent producto)
        {
            _producto = producto;
        }

        public virtual string GetNombre() => _producto.GetNombre();
        public virtual decimal GetPrecio() => _producto.GetPrecio();
        public virtual string GetCategoria() => _producto.GetCategoria();
        public virtual void MostrarInformacion() => _producto.MostrarInformacion();
    }
}
