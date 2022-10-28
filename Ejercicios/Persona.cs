using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public abstract class Persona
    {
        // CONSTRUCTORES
        public Persona(string nombre, string apellidos, int edad, string dni)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Edad = edad;
            this.Dni = dni;
        }

        public Persona()
            : this("", "", 0, "")
        {
        }

        // PROPIEDADES
        private string? nombre;
        public string? Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        private string? apellidos;
        public string? Apellidos
        {
            set
            {
                apellidos = value;
            }
            get
            {
                return apellidos;
            }
        }

        private int? edad;
        public int? Edad
        {
            set
            {
                if (value > 0)
                {
                    edad = value;
                }
                else
                {
                    edad = 0;
                }
            }
            get
            {
                return edad;
            }
        }

        private string dni;
        public string Dni
        {
            set
            {
                if (value.Length != 0)
                {
                    dni = value.Remove(8, 1);

                } 
            }
            get
            {
                string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
                int resto;
                resto = int.Parse(this.dni) % 23;

                return this.dni + letras[resto];
            }
        }


        // FUNCIONES
        public virtual void IntroduceDatos()
        {
            Console.WriteLine("Introduce tu nombre: ");
            this.Nombre = Console.ReadLine();

            Console.WriteLine("Introduce tus apellidos: ");
            this.Apellidos = Console.ReadLine();

            Console.WriteLine("Introduce tu edad: ");
            this.Edad = Console.Read();

            Console.WriteLine("Introduce tu DNI:");
            this.Dni = Console.ReadLine();
        }

        public virtual void MostrarDatos()
        {
            Console.WriteLine("Nombre del empleado: {0}", this.Nombre);
            Console.WriteLine("Apellidos del empleado: {0}", this.Apellidos);
            Console.WriteLine("Edad del empleado: {0}", this.Edad);
            Console.WriteLine("DNI del empleado: {0}", this.Dni);
        }

        public abstract double Hacienda();
    }
}