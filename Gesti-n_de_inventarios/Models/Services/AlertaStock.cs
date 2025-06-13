public class AlertaStock
{
    public Producto Producto { get; set; }= null!;
    public DateTime Fecha { get; set; }
    public string Mensaje { get; set; }= string.Empty;

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