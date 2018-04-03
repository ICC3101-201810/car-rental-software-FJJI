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

            Sucursal sucursal = new Sucursal("San Carlos");
            bool verificar = false;
            while (verificar == false)
            {
                Console.WriteLine("Ingrese sucursal");
                string lugar = Console.ReadLine();
                sucursal.VerificarSucursal(lugar);

            }

            

        }
    }
}
