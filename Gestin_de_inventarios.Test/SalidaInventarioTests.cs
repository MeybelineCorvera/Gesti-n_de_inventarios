using NUnit.Framework;
using Gesti_n_de_inventarios;
using System;

namespace Gesti_n_de_inventarios.Test
{
    public class SalidaInventarioTests
    {
        [Test]
        public void RegistrarSalida_DeberiaReducirStockActual_CuandoHayStock()
        {
            var producto = new Producto(1, "Teclado", "Mecánico", 10, 3, 25m);
            var salida = new SalidaInventario(1, producto, 4, DateTime.Now);
            salida.RegistrarSalida();
            Assert.That(producto.StockActual, Is.EqualTo(6));
        }

        [Test]
        public void RegistrarSalida_NoDeberiaReducirStock_SiNoHaySuficiente()
        {
            var producto = new Producto(1, "Monitor", "24 pulgadas", 3, 1, 100m);
            var salida = new SalidaInventario(1, producto, 5, DateTime.Now);
            salida.RegistrarSalida();
            Assert.That(producto.StockActual, Is.EqualTo(3));
        }
    }
}
