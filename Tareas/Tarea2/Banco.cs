using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public class Banco
    {
        private Cliente cliente1;
        private Cliente cliente2;
        private Cliente cliente3;
 
        public Banco() 
        { 
            cliente1 = new Cliente("Javier");
            cliente2 = new Cliente("Jennifer");
            cliente3 = new Cliente("Esther");
       
        }

        public void operar()
        {
            cliente1.depositar(600);
            cliente2.depositar(300);
            cliente3.depositar(400);
            cliente1.extraer(100);
        }

        public void totalBanco() 
        {
            int total = cliente1.retornarBalance() + cliente2.retornarBalance() + cliente3.retornarBalance();

            Console.WriteLine("El balance total en el banco es de " + total + "DOP");
        }

        public void consultarBalanceClientes() 
        {
            cliente1.consultarBalance();
            cliente2.consultarBalance();
            cliente3.consultarBalance();    

        }
    }
}
