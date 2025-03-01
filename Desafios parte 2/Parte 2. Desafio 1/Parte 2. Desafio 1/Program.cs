using System;

class Program
{
    static string registeredUsername = "";
    static string registeredPassword = "";

    static void Main()
    {
        RegisterUser();
        LoginUser();
    }

    static void RegisterUser()
    {
        Console.WriteLine("Registro de usuario");
        Console.Write("Ingrese un nombre de usuario: ");
        registeredUsername = Console.ReadLine();

        Console.Write("Ingrese una contraseña: ");
        registeredPassword = Console.ReadLine();

        Console.WriteLine("Registro exitoso!\n");
    }

    static void LoginUser()
    {
        Console.WriteLine("Inicio de sesión");
        Console.Write("Ingrese su nombre de usuario: ");
        string username = Console.ReadLine();

        Console.Write("Ingrese su contraseña: ");
        string password = Console.ReadLine();

        if (username == registeredUsername && password == registeredPassword)
        {
            Console.WriteLine("Inicio de sesión exitoso! Bienvenido, " + username + "\n");
        }
        else
        {
            Console.WriteLine("Error: Nombre de usuario o contraseña incorrectos.\n");
        }
    }
}
;
