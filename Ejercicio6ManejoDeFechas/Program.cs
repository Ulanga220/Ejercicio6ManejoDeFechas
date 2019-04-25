using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6ManejoDeFechas
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingreso;
            DateTime fecha;
            Console.WriteLine("Ingrese la fecha de hoy");
            ingreso = Console.ReadLine();

            fecha = DateTime.Parse(ingreso);

            Console.WriteLine(fecha);
            Console.WriteLine(fecha.Hour);
            Console.ReadKey();


            /* Console.WriteLine("Ingrese una fecha pasada");
               ingreso = Console.ReadLine();
               fecha = DateTime.Parse(ingreso);
               if (fecha < DateTime.Now)
               { Console.WriteLine(fecha); }
               else
                   Console.WriteLine("Ud. no ingresó una fecha acorde a lo solicitado"); */


            do
            {
                Console.WriteLine("Ingrese cualquier fecha pero una hora entre las 14 y las 16");
                ingreso = Console.ReadLine();
                fecha = DateTime.Parse(ingreso);
            }

            while (fecha.Hour <= 14 && fecha.Hour >= 16);

            if (fecha.Hour >= 14 && fecha.Hour <= 16)
            { Console.WriteLine($"La fecha y hora ingresada fue: {fecha}"); }
            else
            Console.WriteLine("Ingresaste una hora incorrecta");
            Console.ReadKey();

            do
            {
                Console.WriteLine("Ingrese una fecha del mes de Abril de cualquier año");
                ingreso = Console.ReadLine();
                fecha = DateTime.Parse(ingreso);
            }

            while (fecha.Month != 4);

            if (fecha.Month == 4)
            { Console.WriteLine($"La fecha y hora ingresada fue: {fecha}"); }
            else
                Console.WriteLine("Ingresaste un mes que no es Abril(Mes 4)");

            Console.WriteLine(fecha.ToShortDateString()); 

            Console.WriteLine(fecha.ToString("MM / yyyy"));

            Console.WriteLine("Ingrese una fecha cualquiera");
            ingreso = Console.ReadLine();
            fecha = DateTime.Parse(ingreso);

            Console.WriteLine(fecha.AddYears(1));
            Console.WriteLine(fecha.AddDays(-2));
            Console.WriteLine(fecha.AddDays(2));
            Console.WriteLine(fecha.DayOfWeek);


            Console.WriteLine(fecha.ToString("MMMM"));

       


            Console.ReadKey();

            Console.WriteLine("Ingrese su fecha de nacimiento");
            ingreso = Console.ReadLine();
            fecha = DateTime.Parse(ingreso);

            int edad = DateTime.Today.AddTicks(-fecha.Ticks).Year -1;

            Console.WriteLine(edad);
            Console.ReadKey();





        }
    }
}
