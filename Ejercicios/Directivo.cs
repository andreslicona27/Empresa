using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Directivo : Persona, IPastaGansa
    {
        // CONSTRUCTORES 
        public Directivo(string nombre, string apellidos, int edad, string dni, string depart, int personasAcargo)
            : base(nombre, apellidos, edad, dni)
        {
            this.Depart = depart;
            this.NumPersonasAcargo = personasAcargo;

        }

        // PROPIEDADES 
        private double pastaGanada;
        public double PastaGanada
        {
            get
            {
                return pastaGanada;
            }
        }

        private string? depart;
        public string? Depart
        {
            set
            {
                this.depart = value;
            }
            get
            {
                return this.depart;
            }
        }

        private double porcentajeBeneficios;
        public double PorcentajeBeneficios
        {
            get
            {
                return this.porcentajeBeneficios;
            }
        }

        private int? numPersonasAcargo;
        public int? NumPersonasAcargo
        {
            set 
            { 
                this.numPersonasAcargo = value; 
                if (value <= 10)
                {
                    porcentajeBeneficios = 2;
                } else if (value <= 50)
                {
                    porcentajeBeneficios = 3.5;
                } else
                {
                    porcentajeBeneficios = 4;
                }
            }
            get
            {
                return numPersonasAcargo;
            }
        }

        // FUNCIONES 
        public override double Hacienda()
        {
            return this.PastaGanada * 0.3;
        }

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine("Departamento del empleado: {0}", this.Depart);
            Console.WriteLine("Porcentaje de Beneficios del empleado: {0}", this.PorcentajeBeneficios);
            Console.WriteLine("Personas a cargo del empleado: {0}", this.NumPersonasAcargo);
        }

        public override void IntroduceDatos()
        {
            base.IntroduceDatos();

            Console.WriteLine("Introduce tu departamento: ");
            this.Depart = Console.ReadLine();

            Console.WriteLine("Introduce tu nombre: ");
            this.NumPersonasAcargo = Console.Read();
        }

        public static Directivo operator --(Directivo directivo)
        {
            directivo.porcentajeBeneficios--;
            if (directivo.PorcentajeBeneficios < 0)
            {
                directivo.porcentajeBeneficios = 0;
            }

            return directivo;
        }

        public double GanarPasta(double beneficiosEmpresa)
        {
            Directivo directivo = this;

            if (beneficiosEmpresa < 0)
            {
                pastaGanada = 0;
                directivo--;
            } else
            {
                pastaGanada = this.PorcentajeBeneficios * beneficiosEmpresa / 100;

            }
            return pastaGanada;
        }
    }
}
