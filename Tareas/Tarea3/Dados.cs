namespace Tarea3
{
    public class Dados
    {
        public Random valor { get; set; }

        public Dados() 
        { 
            valor = new Random();
        
        }

        public int tirar()
        {
            return valor.Next(1, 7);
        }
    }
}
