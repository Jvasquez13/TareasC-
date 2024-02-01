using System;

public class Socio
{
    private string nombre { get; set; }
	private int antiguedad { get; set; }

    public Socio(string nombre, int antiguedad)
	{
		this.nombre = nombre;
        this.antiguedad = antiguedad;
    }

    public void imprimir()
    {
        Console.WriteLine("El nombre del socio es " + nombre + " y su antiguedad es de " + antiguedad);
      
    }

    public int retornarAntiguedad()
    {
        return antiguedad;
    }
}
