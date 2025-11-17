using IProductos;

namespace Producto
{
    public interface IProductoComponent
    {
        string GetNombre();
        decimal GetPrecio();
        void MostrarInformacion();
        string GetCategoria();
    }

    public class Producto : IProductoComponent
    {
        private readonly IProductosLigeros _productoLigero;
        private readonly string _nombre;
        private readonly decimal _precio;

        public Producto(IProductosLigeros productoLigero, string nombre, decimal precio)
        {
            _productoLigero = productoLigero;
            _nombre = nombre;
            _precio = precio;
        }

        public string GetNombre() => _nombre;
        public decimal GetPrecio() => _precio;
        public string GetCategoria() => _productoLigero.GetCategoria();

        public void MostrarInformacion()
        {
            _productoLigero.MostrarDatos(_nombre, _precio);
        }
    }
}