public class Compra : Producto
{
    public int Cantidad { get; set; }
    public DateTime Fecha { get; set; }

    public Compra(int id, string nombre, string descripcion, int stockActual, int stockMinimo, decimal precioUnitario, int cantidad, DateTime fecha)
        : base(id, nombre, descripcion, stockActual, stockMinimo, precioUnitario)
    {
        Cantidad = cantidad;
        Fecha = fecha;
    }

    public void RegistrarCompras()
    {
        StockActual += Cantidad;
    }
}