using System;


public class Club
{
    private Socio socio1;
    private Socio socio2;
    private Socio socio3;

    public Club(Socio socio1, Socio socio2, Socio socio3)
    {
        this.socio1 = socio1;
        this.socio2 = socio2;
        this.socio3 = socio3;
    }

     public void SocioMayorAntiguedad()
    {
        Console.WriteLine("Socio de mayor antiguedad : ");

        if(socio1.retornarAntiguedad() > socio2.retornarAntiguedad() && socio1.retornarAntiguedad() > socio3.retornarAntiguedad())
        {
            socio1.imprimir();
        }else if (socio2.retornarAntiguedad() > socio3.retornarAntiguedad())
        {
            socio2.imprimir();
        }
        else
        {
            socio3.imprimir();
        }
    }
}

