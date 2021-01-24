using System;

namespace interfaces_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo miSpirit = new Caballo("MiSpirit");
            Humano miAndy = new Humano("Andy");
            Gorila miJorge = new Gorila("Jorge");

            Mamiferos[] almacenAnimales = new Mamiferos[3];

            almacenAnimales[0] = miSpirit;
            almacenAnimales[1] = miAndy;
            almacenAnimales[2] = miJorge;

            for (int i = 0; i < 3; i++)
            {
                almacenAnimales[i].Pensar();
            }

            Ballena miWally = new Ballena("Wally");
            miWally.Nadar();

            Console.WriteLine($"Numero de patas de Spirit: {miSpirit.NumeroPatas()}");
        }
    }

    // la clase base de la que van heredar algunos seres vivos
    class Mamiferos
    {
        public Mamiferos(string nombre)
        {
            nombreSerVivo = nombre;
        }
        public void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }
        public void CuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan por si mismas");
        }
        public virtual void Pensar()
        {
            Console.WriteLine("Pensamiento basico instintivo");
        }
        public void getNombre()
        {
            Console.WriteLine($"El nombre del mamifero es: {nombreSerVivo}");
        }
        private string nombreSerVivo;
    }

    // interface 
    interface IMamiferosTerrestres {
        int NumeroPatas();
    }
    

    // clases que heredan de mamiferos
    class Caballo : Mamiferos, IMamiferosTerrestres {
        public Caballo(string nombreCaballo) : base(nombreCaballo)
        {

        }
        public int NumeroPatas()
        {
            return 4;
        }
    }

    class Humano: Mamiferos
    {
        public Humano(string nombreHumano) : base(nombreHumano)
        {

        }
    }

    class Gorila : Mamiferos, IMamiferosTerrestres
    {
        public Gorila(string nombreGorila) : base(nombreGorila)
        {

        }
        public int NumeroPatas()
        {
            return 2;
        }
    }

    class Ballena : Mamiferos
    {
        public Ballena(string nombreBallena) : base(nombreBallena)
        {

        }
        public void Nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }
    }
}