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

    static void RealizarSuma()
    {
        Console.Clear();
        Console.WriteLine("Suma");

        try
        {
            Console.Write("Ingresa el primer número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            double resultado = numero1 + numero2;
            Console.WriteLine($"El resultado de la suma es: {resultado}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingresa valores numéricos válidos.");
        }

        Console.WriteLine("Presiona cualquier tecla para volver al menú...");
        Console.ReadKey();
    }

    static void CalcularFactorial()
    {
        Console.Clear();
        Console.WriteLine("Factorial");

        try
        {
            Console.Write("Ingresa un número entero positivo: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("Error: El número debe ser positivo.");
            }
            else
            {
                long resultado = Factorial(numero);
                Console.WriteLine($"El factorial de {numero} es: {resultado}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingresa un número entero válido.");
        }

        Console.WriteLine("Presiona cualquier tecla para volver al menú");
        Console.ReadKey();
    }

    static long Factorial(int numero)
    {
        if (numero == 0 || numero == 1)
            return 1;

        return numero * Factorial(numero - 1);
    }
}
