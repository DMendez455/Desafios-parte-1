using System;

class Program
{
    static void Main()
    {
        int resultado = SumarValores();
        Console.WriteLine($"El resultado de la suma es: {resultado}");
    }

    static int SumarValores()
    {
        int num1 = 0, num2 = 0;
        int suma = 0;

        try
        {
            Console.Write("Ingrese el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            suma = num1 + num2;
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Debe ingresar un número válido.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: El número ingresado es demasiado grande o demasiado pequeño.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Operación finalizada.");
        }

        return suma;
    }
}
