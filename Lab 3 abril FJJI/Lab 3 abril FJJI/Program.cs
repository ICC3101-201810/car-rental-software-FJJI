using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_abril_FJJI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a Arriendos de vehiculos 'Git Gud'");

            Sucursales sucursales = new Sucursales("San Carlos");
            bool verificar = false;
            while (verificar == false)
            {
                Console.WriteLine("Ingrese sucursal");
                string sucursal = Console.ReadLine();
                VerificarSucursal(sucursal);

            }

            

        }
    }
}
