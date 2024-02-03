using Tarea4;

class Program
{
    static void Main()
    {
        Persona persona1 = new Persona();
        persona1.nombre = "Javier";
        persona1.edad = 25;
        Console.WriteLine("Los datos de la persona son:");
        persona1.Imprimir();

        Empleado empleado1 = new Empleado();
        empleado1.nombre = "Jennifer";
        empleado1.edad = 42;
        empleado1.sueldo = 2524;
        Console.WriteLine("Los datos del empleado son:");
        empleado1.Imprimir();

        Console.ReadKey();
    }
}

