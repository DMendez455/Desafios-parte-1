using System;

class Calculadora
{
    public static int Sumar(int a, int b)
    {
        return a + b;
    }

    public static int Restar(int a, int b)
    {
        return a - b;
    }

    public static int Multiplicar(int a, int b)
    {
        return a * b;
    }

    public static int Dividir(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("No se puede dividir por cero.");
        }
        return a / b;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Suma: {Calculadora.Sumar(num1, num2)}");
        Console.WriteLine($"Resta: {Calculadora.Restar(num1, num2)}");
        Console.WriteLine($"Multiplicación: {Calculadora.Multiplicar(num1, num2)}");
        Console.WriteLine($"División: {(num2 != 0 ? Calculadora.Dividir(num1, num2).ToString() : "Error: División por cero")}");
    }
}
