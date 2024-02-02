using System;


namespace Tarea3
{
    public class Jugar
    {
        private Dados[] dados { get; set; }

        public Jugar()
        {
            dados = new Dados[3];
            for (int i = 0; i < dados.Length; i++)
            {
                dados[i] = new Dados();
            }
        }

        public void JugarDados()
        {
            Console.WriteLine("Presiona Enter para tirar los dados...");
            Console.ReadLine();

            int valorDado1 = dados[0].tirar();
            int valorDado2 = dados[1].tirar();
            int valorDado3 = dados[2].tirar();

            Console.WriteLine($"Dado 1: {valorDado1}");
            Console.WriteLine($"Dado 2: {valorDado2}");
            Console.WriteLine($"Dado 3: {valorDado3}");

            if (valorDado1 == valorDado2 && valorDado2 == valorDado3)
            {
                Console.WriteLine("¡Ganaste!");
            }
            else
            {
                Console.WriteLine("Perdiste.");
            }
        }
    }

}

