public class SalidaInventario
{
    public int Id { get; set; }
    public Producto Producto { get; set; }
    public int Cantidad { get; set; }
    public DateTime Fecha { get; set; }

    public SalidaInventario(int id, Producto producto, int cantidad, DateTime fecha)
    {
        Id = id;
        Producto = producto;
        Cantidad = cantidad;
        Fecha = fecha;
    }

    public void RegistrarSalida()
    {
        if (Producto.StockActual >= Cantidad)
        {
            Producto.StockActual -= Cantidad;
            Console.WriteLine("✅ Salida registrada correctamente.");
        }
        else
        {
            Console.WriteLine("❌ No hay suficiente stock para esta salida.");
        }
    }
}
