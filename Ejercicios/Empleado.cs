using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Empleado : Persona
    {
        // CONSTRUCTORES    
        public Empleado(string nombre, string apellidos, int edad, string dni, double salario, string tel)
            : base(nombre, apellidos, edad, dni)
        {
            this.Salario = salario;
            this.Tel = tel;
        }

        public Empleado()
            :this("","",0,"",0,"")
        {
        }

        // PROPIEDADES 
        private double salario;
        public double Salario
        {
            set
            {
                salario = value;

                if (value <= 600)
                {
                    irpf = 7;
                } else if ( value <= 3000)
                {
                    irpf = 15;
                } else
                {
                    irpf = 20;
                }
            }
            get
            {
                return salario;
            }
        }

        private double irpf;
        public double Irpf
        {
            get
            {
                return irpf;
            }
        }

        private string? tel;
        public string? Tel
        {
            set 
            { 
                tel = value; 
            }
            get 
            { 
                return "+34 " + tel; 
            }
        }

        // FUNCIONES
        public override double Hacienda()
        {
            return irpf * salario / 100;
        }

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine("Salario del empleado: {0}", this.Salario);
            Console.WriteLine("IRPF del empleado: {0}", this.Irpf);
            Console.WriteLine("Teléfono del empleado: {0}", this.Tel);

        }

        public void MostrarDatos(int dato)
        {
            switch (dato)
            {
                case 0:
                    Console.WriteLine("Nombre del empleado: {0}", base.Nombre);
                    break;
                case 1:
                    Console.WriteLine("Apellidos del empleado: {0}", base.Apellidos);
                    break;
                case 3:
                    Console.WriteLine("Edad del empleado: {0}", base.Edad);
                    break;
                case 4:
                    Console.WriteLine("DNI del empleado: {0}", base.Dni);
                    break;
                case 5:
                    Console.WriteLine("Salario del empleado: {0}", this.Salario);
                    break;
                case 6:
                    Console.WriteLine("IRPF del empleado: {0}", this.Irpf);
                    break;
                default:
                    Console.WriteLine("Teléfono del empleado: {0}", this.Tel);
                    break;

            }
        }
    }
}
