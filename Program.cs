using System;
using System.Collections.Generic;

class Program
{
    // Lista que simula la base de datos de productos en memoria
    static List<Producto> inventario = new List<Producto>();

    static void Main()
    {
        // Título principal
        Console.WriteLine("=== GESTIÓN DE INVENTARIOS ===");

        // Llamamos al método para agregar productos
        AgregarProducto();

        // Mostramos los productos agregados
        MostrarInventario();
    }

    // Método para agregar un nuevo producto
    static void AgregarProducto()
    {
        Console.WriteLine("\n--- AGREGAR NUEVO PRODUCTO ---");

        // Pedimos los datos al usuario
        Console.Write("ID del producto: ");
        string id = Console.ReadLine(); // Leer ID

        Console.Write("Nombre del producto: ");
        string nombre = Console.ReadLine(); // Leer nombre

        Console.Write("Stock actual: ");
        int stockActual = int.Parse(Console.ReadLine()); // Leer stock actual

        Console.Write("Stock mínimo: ");
        int stockMinimo = int.Parse(Console.ReadLine()); // Leer stock mínimo

        Console.Write("Precio: ");
        decimal precio = decimal.Parse(Console.ReadLine()); // Leer precio

        // Creamos el objeto producto con los datos ingresados
        Producto nuevo = new Producto(id, nombre, stockActual, stockMinimo, precio);

        // Lo agregamos a la lista de inventario
        inventario.Add(nuevo);

        // Confirmamos que se agregó correctamente
        Console.WriteLine("\n✅ Producto agregado correctamente.");
    }

    // Método para mostrar todos los productos en el inventario
    static void MostrarInventario()
    {
        Console.WriteLine("\n--- INVENTARIO ACTUAL ---");

        // Recorremos la lista e imprimimos cada producto
        foreach (var producto in inventario)
        {
            producto.Mostrar(); // Llama al método Mostrar() de la clase Producto
        }
    }
}
