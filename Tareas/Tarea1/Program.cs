using System;

class Program 
{
    static void Main()
    {
        Socio socio1 = new Socio("juan", 35);
        Socio socio2 = new Socio("Pedro", 10);
        Socio socio3 = new Socio("Javier", 25);

        Club club1 = new Club(socio1, socio2, socio3);

        club1.SocioMayorAntiguedad();
    }

}
