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
            Sucursal sucursal = new Sucursal("san carlos");
            DirectorioSucursales directorio = new DirectorioSucursales();
            directorio.AgregarSucursal(sucursal.sede);

            Console.WriteLine("Bienvenido a Arriendos de vehiculos 'Git Gud'");

            Console.WriteLine("\nPrecione 1 para realizar un arriendo, 2 para agregar sucursal, 3 para salir");
            string respuesta = Console.ReadLine();

            while (true)
            {
                if (respuesta == "2")
                {
                    Console.WriteLine("Ingrese sucursal");
                    string lugar = Console.ReadLine();
                    lugar = lugar.ToLower();
                    if (directorio.VerificarSucursal(lugar) == false)
                    {
                        directorio.AgregarSucursal(lugar);
                        Console.WriteLine("La sucuresal " + lugar + " ha sido agregada exitosamente");
                    }
                    else
                        Console.WriteLine("el nombre " + lugar + " ya tiene asociado una sucursal");
                    //entramos a la sucursal
                }
                if (!((respuesta == "1") | (respuesta == "2") | (respuesta == "3")))
                {
                    Console.WriteLine("Seleccion erronea");
                }

                if (respuesta == "3")
                {
                    Console.WriteLine("gracias por operar con 'Git Gud'");
                    break;
                }

                Console.WriteLine("\nPrecione 1 para realizar un arriendo, 2 para agregar sucursal, 3 para salir");
                respuesta = Console.ReadLine();


            }

           
            while (respuesta == "1")
            {
                respuesta = Console.ReadLine();
            }





            Console.ReadLine();

        }
    }
}
