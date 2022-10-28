namespace Ejercicios
{
    internal class Program
    {

        public static double gananciasEmpresa(IPastaGansa trabajador)
        {
            double ganancias = 0;
            Console.WriteLine("\n¿Cuales son las ganancias de la empresa?");
            ganancias = double.Parse(Console.ReadLine());

            ganancias = trabajador.GanarPasta(ganancias);

            return ganancias;
        }

        static void Main(string[] args)
        {

            Directivo d1 = new Directivo("Oscar", "Bardales Dias del Valle", 54, "12084659E", "finanzas", 23);
            Empleado e1 = new Empleado("Alberto", "Sanchez Araujo", 34, "55498671Q", 4000, "659-321-845");
            EmpleadoEspecial es1 = new EmpleadoEspecial();
            es1.Nombre = "Allan";
            es1.Apellidos = "Paderes amador";
            es1.Edad = 48;
            es1.Dni = "87954621E  ";
            es1.Salario = 2450;
            es1.Tel = "621-987-652";

            int opc = 0;
            do
            {
                Console.WriteLine("\nMENU DE OPCIONES\n" +
                    "1.- Visualizar datos del Directivo\n" +
                    "2.- Visualizar datos del Empleado\n" +
                    "3.- Visualizar datos del Empleado Especial\n" +
                    "4.- Salir\n");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        d1.MostrarDatos();
                        Console.WriteLine("Las ganancias del directivo fueron de {0}\n",gananciasEmpresa(d1).ToString("0.##"));
                        Console.WriteLine("Lo que se lleva hacienda: {0}\n", d1.Hacienda().ToString("0.##"));
                        break;

                    case 2:
                        e1.MostrarDatos();
                        Console.WriteLine("Lo que se lleva hacienda: {0}\n", e1.Hacienda().ToString("0.##"));
                        break;

                    case 3:
                        es1.MostrarDatos();
                        Console.WriteLine("Las ganancias del empleado especial fueron de {0}\n", gananciasEmpresa(es1).ToString("0.##"));
                        Console.WriteLine("Lo que se lleva hacienda: {0}\n", es1.Hacienda().ToString("0.##"));
                        break;

                    case 4:
                        break;
                }
            } while (opc != 4);

        }
    }
}