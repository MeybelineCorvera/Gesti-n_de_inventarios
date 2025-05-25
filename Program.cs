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

        // Menú de opciones para el usuario
        int opcion;
        do
        {
            Console.WriteLine("\nSeleccione una opción:");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Eliminar producto");
            Console.WriteLine("3. Mostrar inventario");
            Console.WriteLine("4. Salir");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                // Llamamos al método para agregar productos
                AgregarProducto();
            }
            else if (opcion == 2)
            {
                // Llamamos al método para eliminar productos
                EliminarProducto();
            }
            else if (opcion == 3)
            {
                // Mostramos los productos agregados
                MostrarInventario();
            }
            else if (opcion == 4)
            {
                Console.WriteLine("Saliendo del sistema...");
            }
            else
            {
                Console.WriteLine("Opción inválida. Intente nuevamente.");
            }

        } while (opcion != 4);
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

    // Método para eliminar un producto por su ID
    static void EliminarProducto()
    {
        Console.WriteLine("\n--- ELIMINAR PRODUCTO ---");

        Console.Write("Ingrese el ID del producto a eliminar: ");
        string idEliminar = Console.ReadLine();

        Producto productoAEliminar = inventario.Find(p => p.ID == idEliminar);

        if (productoAEliminar != null)
        {
            inventario.Remove(productoAEliminar);
            Console.WriteLine("✅ Producto eliminado correctamente.");
        }
        else
        {
            Console.WriteLine("❌ No se encontró ningún producto con ese ID.");
        }
    }
}
