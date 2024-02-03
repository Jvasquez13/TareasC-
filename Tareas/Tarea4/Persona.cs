namespace Tarea4
{
    public class Persona
    {
        public string nombre { get; set; }
        public int edad { get; set; }

       
        public void Imprimir()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
        }
    }
}
