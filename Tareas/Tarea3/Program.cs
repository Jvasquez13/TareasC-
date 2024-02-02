using System;
using Tarea3;

class Program
{
    static void Main()
    {
        Jugar juego = new Jugar();

        while (true)
        {
            juego.JugarDados();

            Console.WriteLine("¿Quieres jugar otra vez? (s/n)");
            if (Console.ReadLine().ToLower() == "n")
            {
                break;
            }
        }

        Console.WriteLine("Gracias por jugar. ¡Hasta luego!");
    }
}