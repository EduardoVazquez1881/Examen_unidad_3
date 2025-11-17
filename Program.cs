using System;
using Producto;
using Decoradores;

class Program
{
    static void Main()
    {
        Console.WriteLine(" \nAPLICACION DE PEDIDOS CON DESCUENTOS DINAMICOS\n");

        var fabrica = new Fabrica.ProductoCrearPeso();

        Console.WriteLine("\n---------------------------------------");
        IProductoComponent producto1 = new Producto.Producto(
            fabrica.GetProductoLigeros("Electrónica", "Dispositivos electrónicos", "Sony"),
            "Televisor LED 55\"",
            899.99m
        );
        producto1 = new FormatoEspecialDecorator(producto1, "destacado");
        producto1 = new DescuentoPorcentajeDecorator(producto1, 15);
        producto1 = new EnvioGratisDecorator(producto1);
        producto1.MostrarInformacion();

        Console.WriteLine("\n---------------------------------------");
        IProductoComponent producto2 = new Producto.Producto(
            fabrica.GetProductoLigeros("Electrónica", "Dispositivos electrónicos", "Sony"),
            "Soundbar HT-500",
            299.99m
        );
        producto2 = new DescuentoFijoDecorator(producto2, 50);
        producto2 = new EnvioGratisDecorator(producto2);
        producto2.MostrarInformacion();

        Console.WriteLine("\n---------------------------------------");
        IProductoComponent producto3 = new Producto.Producto(
            fabrica.GetProductoLigeros("Electrónica", "Dispositivos móviles", "Samsung"),
            "Smartphone Galaxy",
            699.99m
        );
        producto3 = new FormatoEspecialDecorator(producto3, "oferta");
        producto3 = new GarantiaExtendidaDecorator(producto3, 2, 99.99m);
        producto3 = new DescuentoPorcentajeDecorator(producto3, 10);
        producto3 = new EnvioGratisDecorator(producto3);
        producto3.MostrarInformacion();

        Console.WriteLine("\n---------------------------------------");
        IProductoComponent producto4 = new Producto.Producto(
            fabrica.GetProductoLigeros("Electrónica", "Dispositivos electrónicos", "Sony"),
            "Auriculares Bluetooth",
            199.99m
        );
        producto4 = new ValidacionPrecioDecorator(producto4);
        producto4 = new DescuentoPorcentajeDecorator(producto4, 20);
        producto4 = new EnvioGratisDecorator(producto4, 500);
        producto4.MostrarInformacion();

        Console.WriteLine($"\n\nTotal de objetos creados con peso ligero: {fabrica.GetTotalProductosLigeros()}");
    }
}