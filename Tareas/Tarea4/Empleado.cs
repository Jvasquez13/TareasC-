namespace Tarea4
{
    public class Empleado : Persona
    {
        public float sueldo { get; set; }


        new public void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("Sueldo: " + sueldo); 
        }
    }
}
