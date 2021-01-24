using System;

namespace interfaces_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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

    // interfaces
    interface IMamiferosTerrestres
    {
        int NumeroPatas();
    }
    interface IAnimalesYDeportes
    {
        string TipoDeporte();
        bool EsOlimpico();
    }
    interface ISaltoConPatas
    {
        int NumeroPatas();
    }


    // clases que heredan de mamiferos
    class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesYDeportes, ISaltoConPatas
    {
        public Caballo(string nombreCaballo) : base(nombreCaballo)
        {

        }
        // ambiguedad
        public int NumeroPatas()
        {
            return 4;
        }
        public string TipoDeporte()
        {
            return "Carreras de caballos";
        }
        public bool EsOlimpico()
        {
            return true;
        }
    }

    class Humano : Mamiferos
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