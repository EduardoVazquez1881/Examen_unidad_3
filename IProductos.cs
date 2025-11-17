namespace IProductos
{
    public interface IProductosLigeros
    {
        void MostrarDatos(string nombre, decimal precio);
        string GetCategoria();
    }
}