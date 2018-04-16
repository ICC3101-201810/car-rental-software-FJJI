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
            //Sucursal sucursal = new Sucursal("san carlos");
            DirectorioSucursales directorio = new DirectorioSucursales();
            //directorio.AgregarSucursal(sucursal.sede);

            Console.WriteLine("Bienvenido a Arriendos de vehiculos 'Git Gud'");

            Console.WriteLine("\nPrecione 1 para realizar un arriendo, 2 para agregar sucursal, 3 para ver las sucursales disponibles, 4 para salir");
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
                if (!((respuesta == "1") | (respuesta == "2") | (respuesta == "3") | (respuesta == "4")))
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Seleccion erronea");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                if (respuesta == "1")
                {
                    
                    if (directorio.Tamano() == 0   )
                    {
                        Console.WriteLine("no hay sucursal creada aun, seleccione la opcion 2 para crear una\n\n");
                        Console.WriteLine("\nPrecione 1 para realizar un arriendo, 2 para agregar sucursal, 3 para ver las sucursales disponibles, 4 para salir");
                        respuesta = Console.ReadLine();
                        continue;
                    }

                    Console.WriteLine("Seleccione su sucursal");
                    string lugar = Console.ReadLine();



                }

                if (respuesta == "3")
                {
                    if (directorio.Tamano() == 0)
                    {
                        Console.WriteLine("No hay sucursales creadas aún");
                    }
                    directorio.ImprimirSucursales();
                }
                if (respuesta == "4")
                {

                    Console.WriteLine("gracias por operar con 'Git Gud'");
                    break;
                }

                Console.WriteLine("\nPrecione 1 para realizar un arriendo, 2 para agregar sucursal, 3 para ver las sucursales disponibles, 4 para salir");
                respuesta = Console.ReadLine();


            }






            Console.ReadLine();

        }
    }
}
