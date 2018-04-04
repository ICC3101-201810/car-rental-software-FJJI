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
            DirectorioSucursales directorio = new DirectorioSucursales();
            directorio.AgregarSucursal(sucursal.sede);

            bool verificar = false;
            while (verificar == false)
            {
                Console.WriteLine("Ingrese sucursal");
                string lugar = Console.ReadLine();
                if (directorio.VerificarSucursal(lugar) == true)
                {
                    verificar = true;
                }
            } //entramos a la sucursal

            Console.ReadLine();

        }
    }
}
