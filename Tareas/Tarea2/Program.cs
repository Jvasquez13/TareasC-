using System;
using Tarea2;

class Program
{
    static void Main()
    {
        Banco banco1 = new Banco();
        banco1.operar();
        banco1.totalBanco();
        banco1.consultarBalanceClientes();
    }
}
