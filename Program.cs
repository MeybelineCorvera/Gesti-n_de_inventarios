using System;
using System.Collections.Generic;

class Program
{
    // Lista para almacenar los productos del inventario
    static List<Producto> inventario = new();

    // Método principal del programa
    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n=== MENÚ DE INVENTARIO ===");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Mostrar productos en inventarios");
            Console.WriteLine("3. Actualizar producto");
            Console.WriteLine("4. Eliminar producto");
            Console.WriteLine("5. Mostrar stock mínimo de un producto");
            Console.WriteLine("6. Registrar salida de productos"); // NUEVA OPCIÓN
            Console.WriteLine("7. Salir"); // Mover "Salir" a la opción 7

            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: AgregarProducto(); break;
                case 2: MostrarInventario(); break;
                case 3: ActualizarProducto(); break;
                case 4: EliminarProducto(); break;
                case 5: MostrarStockMinimo(); break;
                case 6: RegistrarSalida(); break;
                case 7: Console.WriteLine("Saliendo..."); break;
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

    //Mostrar productos en inventario 
    //MAURICIO
    
    static void MostrarInventario()
{
    Console.WriteLine("\n=== LISTA DE PRODUCTOS EN INVENTARIO ===");

    if (inventario.Count == 0)
    {
        Console.WriteLine("⚠️ No hay productos en el inventario.");
        return;
    }

    foreach (var producto in inventario)
    {
        Console.WriteLine($"ID: {producto.ID}");
        Console.WriteLine($"Nombre: {producto.Nombre}");
        Console.WriteLine($"Descripción: {producto.Descripcion}");
        Console.WriteLine($"Stock actual: {producto.StockActual}");
        Console.WriteLine($"Stock mínimo: {producto.StockMinimo}");
        Console.WriteLine($"Precio: ${producto.Precio}");

        if (producto.StockActual < producto.StockMinimo)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("⚠️ ¡Alerta! El stock está por debajo del mínimo.");
            Console.ResetColor();
        }

        Console.WriteLine(new string('-', 40));
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

    // Mostrar stop minimo de un producto 
    static void MostrarStockMinimo()
    {
        Console.Write("Ingrese el ID del producto: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("❌ ID inválido.");
            return;
        }

        Producto producto = inventario.Find(p => p.ID == id);
        if (producto != null)
        {
            Console.WriteLine($"🟡 El stock mínimo del producto '{producto.Nombre}' (ID: {producto.ID}) es: {producto.StockMinimo}");
        }
        else
        {
            Console.WriteLine("❌ Producto no encontrado.");
        }
    }

    // NUEVO MÉTODO AGREGADO PARA REGISTRAR SALIDA DE PRODUCTOS  gustavo 
    static void RegistrarSalida()
    {
        Console.Write("ID del producto a retirar: ");
        int id = int.Parse(Console.ReadLine());

        Producto producto = inventario.Find(p => p.ID == id);

        if (producto != null)
        {
            Console.Write("Cantidad a retirar: ");
            int cantidad = int.Parse(Console.ReadLine());

            if (cantidad > 0 && cantidad <= producto.StockActual)
            {
                producto.StockActual -= cantidad;
                Console.WriteLine($"✅ Se han retirado {cantidad} unidades del producto '{producto.Nombre}'.");
            }
            else
            {
                Console.WriteLine("❌ No hay suficiente stock disponible o la cantidad ingresada es inválida.");
            }
        }
        else
        {
            Console.WriteLine("❌ Producto no encontrado.");
        }
    }
}