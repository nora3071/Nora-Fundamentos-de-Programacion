// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System;  // Importa las clases básicas (como Console)

class Program
{
    static void Main()
    {
        // Variable para acumular el total de la compra
        decimal total = 0m;

        // Constante: monto mínimo para aplicar descuento
        const decimal limiteDescuento = 1000m;

        // Constante: porcentaje de descuento (10%)
        const decimal porcentajeDescuento = 0.10m;

        // === VALIDACIÓN: número de productos ===
        int n;
        while (true)
        {
            Console.Write("¿Cuántos productos desea ingresar? ");
            if (int.TryParse(Console.ReadLine(), out n) && n > 0)
            {
                break;
            }
            Console.WriteLine(" Debe ingresar un número entero mayor que 0.");
        }

        // Bucle que se repite para cada producto
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"\nProducto #{i}");

            // === VALIDACIÓN: nombre del producto ===
            string nombre;
            while (true)
            {
                Console.Write("Nombre: ");
                nombre = Console.ReadLine()?.Trim() ?? "";
                if (!string.IsNullOrEmpty(nombre))
                {
                    break;
                }
                Console.WriteLine(" El nombre no puede estar vacío.");
            }

            // === VALIDACIÓN: cantidad de unidades ===
            int cantidad;
            while (true)
            {
                Console.Write("Cantidad: ");
                if (int.TryParse(Console.ReadLine(), out cantidad) && cantidad > 0)
                {
                    break;
                }
                Console.WriteLine(" La cantidad debe ser un número entero mayor que 0.");
            }

            // === VALIDACIÓN: precio unitario ===
            decimal precio;
            while (true)
            {
                Console.Write("Precio unitario (C$): ");
                if (decimal.TryParse(Console.ReadLine(), out precio) && precio > 0)
                {
                    break;
                }
                Console.WriteLine(" El precio debe ser un número mayor que 0.");
            }

            // Calcular subtotal (cantidad × precio)
            decimal subtotal = cantidad * precio;

            // Sumar al total acumulado
            total += subtotal;

            // Mostrar el subtotal de este producto
            Console.WriteLine($"Subtotal {nombre}: C${subtotal:F2}");
        }

        // Subprograma 2: Verificar si el total supera el límite para aplicar descuento
        if (total > limiteDescuento)
        {
            decimal descuento = total * porcentajeDescuento;
            total -= descuento; // Aplicar el descuento
            Console.WriteLine($"\n Se aplicó un {porcentajeDescuento * 100}% de descuento.");
        }

        // Subprograma 3: Mostrar el total final a pagar
        Console.WriteLine($"\n Total a pagar: C${total:F2}");

        // Pausa para que el usuario vea el resultado antes de cerrar
        Console.WriteLine("\nPresione una tecla para salir...");
        Console.ReadKey();
    }
}



