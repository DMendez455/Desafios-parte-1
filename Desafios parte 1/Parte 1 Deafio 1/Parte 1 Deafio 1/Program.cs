using System;

class Program
{
	static void Main()
	{
		CalcularIngresos();
	}

	static void CalcularIngresos()
	{
		Console.Write("Ingrese su nombre: ");
		string usuario = Console.ReadLine();

		double suma = 0;
		int meses = 3;

		for (int i = 1; i <= meses; i++)
		{
			Console.Write($"Ingrese sus ingresos del mes {i}: ");
			suma += Convert.ToDouble(Console.ReadLine());
		}

		double promedio = suma / meses;

		Console.WriteLine($"Hola {usuario}, en total ganaste {suma} y promediaste {promedio}.");
	}
}



