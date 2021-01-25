using System;

namespace interfaces_4
{
    class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico Aviso1 = new AvisosTrafico();
            Aviso1.MostrarAviso();

            AvisosTrafico Aviso2 = new AvisosTrafico("Andres Gonzalez", "Tiene un limite de 2 dias para pagar. Urgente", "30/12/2021");
            Aviso2.MostrarAviso();
        }
    }
}
