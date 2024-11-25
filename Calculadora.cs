using System;

class Calculadora
{

    static void Main()
    {

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Calculadora de Consola");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Factorial");
            Console.WriteLine("3. Salir");
            Console.Write("Selecciona una opción: ");
            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    RealizarSuma();
                    break;
                case "2":
                    CalcularFactorial();
                    break;
                case "3":
                    Console.WriteLine("Hasta luego");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Presiona cualquier tecla para intentarlo de nuevo.");
                    Console.ReadKey();
                    break;
            }

        }
    }
}
