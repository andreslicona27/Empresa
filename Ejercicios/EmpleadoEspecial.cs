using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class EmpleadoEspecial : Empleado, IPastaGansa
    {
        // CONSRTUCTORES
        public EmpleadoEspecial()
            : base("", "", 0, "", 0, "")
        {
        }

        // FUNCIONES 
        public double GanarPasta(double beneficiosEmpresa)
        {
            return beneficiosEmpresa * 0.5;
        }

        public override double Hacienda()
        {
            return base.Hacienda() * 1.05;
        }
    }
}
