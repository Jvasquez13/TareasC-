using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Tarea2
{
    public class Cliente
    {
        private string nombre { get; set; }
        private int saldo { get; set; }

        public Cliente(string nombre)
        {
            this.nombre = nombre;
            saldo = 0;
        }

        public void depositar(int deposito)
        {
            saldo += deposito;
        }

        public void extraer(int retiro)
        {
            saldo -= retiro;
        }

        public int retornarBalance()
        {
            return saldo;
        }

        public void consultarBalance()
        {
            Console.WriteLine(nombre + " tiene depositado la suma de " + saldo);
        }

    }
}
