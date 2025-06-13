using NUnit.Framework;
using Gesti_n_de_inventarios;
using System;

namespace Gesti_n_de_inventarios.Test
{
    public class CompraTests
    {
        [Test]
        public void RegistrarCompras_DeberiaIncrementarStockActual()
        {
            var compra = new Compra(1, "Mouse", "Mouse óptico", 10, 2, 10.0m, 5, DateTime.Now);
            compra.RegistrarCompras();
            Assert.That(compra.StockActual, Is.EqualTo(15));
        }
    }
}
