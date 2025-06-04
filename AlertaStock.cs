public class AlertaStock
{
    public Producto Producto { get; set; }
    public DateTime Fecha { get; set; }
    public string Mensaje { get; set; }

    public AlertaStock(Producto producto)
    {
        Producto = producto;
        Fecha = DateTime.Now;
        Mensaje = $"⚠️ Alerta: El producto '{producto.Nombre}' tiene un stock bajo ({producto.StockActual}).";
    }

    public void GenerarAlerta()
    {
        Console.WriteLine(Mensaje);
    }
}