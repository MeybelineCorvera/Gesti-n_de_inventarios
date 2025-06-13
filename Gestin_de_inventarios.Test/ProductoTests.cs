using NUnit.Framework;
using Gesti_n_de_inventarios;
using System;

namespace Gesti_n_de_inventarios.Test
{
    public class ProductoTests
    {
        [Test]
        public void VerificarStockMinimo_DeberiaRetornarTrue_SiStockIgualMinimo()
        {
            var producto = new Producto(1, "Lapicero", "Color azul", 5, 5, 0.5m);
            Assert.That(producto.VerificarStockMinimo(), Is.True);
        }

        [Test]
        public void VerificarStockMinimo_DeberiaRetornarFalse_SiStockMayorAlMinimo()
        {
            var producto = new Producto(2, "Cuaderno", "100 hojas", 10, 5, 1.5m);
            Assert.That(producto.VerificarStockMinimo(), Is.False);
        }
    }
}

