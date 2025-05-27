using System;
using System.Collections.Generic;

class Program
{
    static List<Producto> inventario = new();

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n=== MENÚ DE INVENTARIO ===");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Mostrar todos los productos");
            Console.WriteLine("3. Actualizar producto");
            Console.WriteLine("4. Eliminar producto");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: AgregarProducto(); break;
                case 2: AgregarProducto(); break;
                case 3: ActualizarProducto(); break;
                case 4: EliminarProducto(); break;
                case 5: Console.WriteLine("Saliendo..."); break;
                default: Console.WriteLine("Opción inválida."); break;
            }

        } while (opcion != 7);
    }
    //Metodo para agregar productos
    static void AgregarProducto()
    {
        Console.Write("ID: "); int id = int.Parse(Console.ReadLine());
        Console.Write("Nombre: "); string nombre = Console.ReadLine();
        Console.Write("Descripción: "); string descripcion = Console.ReadLine();
        Console.Write("Stock actual: "); int stock = int.Parse(Console.ReadLine());
        Console.Write("Stock mínimo: "); int stockMin = int.Parse(Console.ReadLine());
        Console.Write("Precio: "); decimal precio = decimal.Parse(Console.ReadLine());

        Producto nuevo = new(id, nombre, descripcion, stock, stockMin, precio);
        inventario.Add(nuevo);
        Console.WriteLine("✅ Producto agregado correctamente.");
    }

    //Metodo para mostrar productos
    //MAURICIO
    static void MostrarInventario()
    {
        Console.WriteLine("\n=== LISTA DE PRODUCTOS ===");

        if (inventario.Count == 0)
        {
            Console.WriteLine("⚠️ No hay productos en el inventario.");
            return;
        }

        foreach (var producto in inventario)
        {
            Console.WriteLine(producto);
        }
    }

    //Metodo para actualizar productos
    static void ActualizarProducto()
    {
        Console.Write("ID del producto a actualizar: ");
        int id = int.Parse(Console.ReadLine());
        Producto producto = inventario.Find(p => p.ID == id);
        if (producto != null)
        {
            Console.Write("Nuevo nombre: "); producto.Nombre = Console.ReadLine();
            Console.Write("Nueva descripción: "); producto.Descripcion = Console.ReadLine();
            Console.Write("Nuevo stock actual: "); producto.StockActual = int.Parse(Console.ReadLine());
            Console.Write("Nuevo stock mínimo: "); producto.StockMinimo = int.Parse(Console.ReadLine());
            Console.Write("Nuevo precio: "); producto.Precio = decimal.Parse(Console.ReadLine());
            Console.WriteLine("✅ Producto actualizado correctamente.");
        }
        else
        {
            Console.WriteLine("❌ Producto no encontrado.");
        }
    }
    
    //Metodo para elimminar productos
    static void EliminarProducto()
    {
        Console.Write("ID del producto a eliminar: ");
        int id = int.Parse(Console.ReadLine());
        Producto producto = inventario.Find(p => p.ID == id);
        if (producto != null)
        {
            inventario.Remove(producto);
            Console.WriteLine("✅ Producto eliminado correctamente.");
        }
        else
        {
            Console.WriteLine("❌ Producto no encontrado.");
        }
    }    
}
