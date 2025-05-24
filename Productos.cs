// Clase que representa un producto en el inventario
public class Producto
{
    // Propiedades del producto
    public string ID { get; set; }              // Identificador único del producto
    public string Nombre { get; set; }          // Nombre del producto
    public int StockActual { get; set; }        // Cantidad actual en stock
    public int StockMinimo { get; set; }        // Cantidad mínima antes de generar una alerta
    public decimal Precio { get; set; }         // Precio del producto

    // Constructor que inicializa los valores del producto
    public Producto(string id, string nombre, int stockActual, int stockMinimo, decimal precio)
    {
        ID = id;
        Nombre = nombre;
        StockActual = stockActual;
        StockMinimo = stockMinimo;
        Precio = precio;
    }

    // Método para mostrar los datos del producto por consola
    public void Mostrar()
    {
        Console.WriteLine($"ID: {ID}, Nombre: {Nombre}, Stock: {StockActual}, Stock Mínimo: {StockMinimo}, Precio: {Precio:C}");
    }
}
