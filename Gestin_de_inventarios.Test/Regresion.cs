using NUnit.Framework;
using Gesti_n_de_inventarios;
using System;

namespace Gestin_de_inventarios.Test
{
    public class ProductoTests
    {
        [Test]
        [Category("Regresion")]
        public void VerificarStockMinimo_TrueCuandoStockEsIgualAlMinimo()
        {
            var producto = new Producto(1, "Lapicero", "Color azul", 5, 5, 0.5m);
            Assert.That(producto.VerificarStockMinimo(), Is.True);
        }

        [Test]
        [Category("Regresion")]
        public void VerificarStockMinimo_FalseCuandoStockEsMayorAlMinimo()
        {
            var producto = new Producto(2, "Cuaderno", "100 hojas", 10, 5, 1.5m);
            Assert.That(producto.VerificarStockMinimo(), Is.False);
        }
    }

    public class CompraTests
    {
        [Test]
        [Category("Regresion")]
        public void RegistrarCompras_AumentaStockActual()
        {
            var compra = new Compra(1, "Mouse", "Mouse óptico", 10, 2, 10.0m, 5, DateTime.Now);
            compra.RegistrarCompras();
            Assert.That(compra.StockActual, Is.EqualTo(15));
        }
    }

    public class SalidaInventarioTests
    {
        [Test]
        [Category("Regresion")]
        public void RegistrarSalida_ReduceStock_CuandoHayStock()
        {
            var producto = new Producto(1, "Teclado", "Mecánico", 10, 3, 25m);
            var salida = new SalidaInventario(1, producto, 4, DateTime.Now);
            salida.RegistrarSalida();
            Assert.That(producto.StockActual, Is.EqualTo(6));
        }

        [Test]
        [Category("Regresion")]
        public void RegistrarSalida_NoCambiaStock_CuandoNoHaySuficiente()
        {
            var producto = new Producto(1, "Monitor", "24 pulgadas", 3, 1, 100m);
            var salida = new SalidaInventario(1, producto, 5, DateTime.Now);
            salida.RegistrarSalida();
            Assert.That(producto.StockActual, Is.EqualTo(3));
        }
    }

    
}
