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

            //Persona cliente = new Persona("juan", "123123123");

            Console.WriteLine("Bienvenido a Arriendos de vehiculos 'Git Gud'");

            Console.WriteLine("\nPrecione 1 para realizar un arriendo, 2 para recibir un vehiculo ,3 para agregar sucursal, 4 para ver las sucursales disponibles, 5 para agregar vehiculo, 6 para agregar nuevo vehiculo a sucursal, 7 para salir\n");
            string respuesta = Console.ReadLine();

            while (true)
            {
                if (respuesta == "3") //agregar sucursal
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
                if (!((respuesta == "1") | (respuesta == "2") | (respuesta == "3") | (respuesta == "4") | (respuesta == "5") | (respuesta == "6") | (respuesta == "7")))
                {
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Seleccion erronea");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                if (respuesta == "1") //realizar arriendo
                {
                    
                    if (directorio.Tamano() == 0   )
                    {
                        Console.WriteLine("no hay sucursal creada aun, seleccione la opcion 3 para crear una\n\n");
                        Console.WriteLine("\nPrecione 1 para realizar un arriendo, 2 para recibir un vehiculo ,3 para agregar sucursal, 4 para ver las sucursales disponibles, 5 para agregar vehiculo, 6 para agregar nuevo vehiculo a sucursal, 7 para salir\n");
                        respuesta = Console.ReadLine();
                        continue;
                    }

                    Console.WriteLine("Seleccione su sucursal");
                    string lugar = Console.ReadLine();
                    while (!(directorio.VerificarSucursal(lugar)))
                    {
                        Console.WriteLine("Seleccion invalida\nFavor seleccione nuevamente sucursal");
                        lugar = Console.ReadLine();
                    }

                    //hasta aca exito
                    if (directorio.CantidadClientes() == 0)
                    {
                        Console.WriteLine("No hay Clientes aun, procederemos a crear un cliente \n");
                        Console.WriteLine("Presione 1 si el cliente es persona, 2 si es empresa");
                        string resp = Console.ReadLine();
                        while (!((resp == "1") | (resp == "2")))
                        {
                            Console.WriteLine("Seleccion invalida\n");
                            Console.WriteLine("Presione 1 si el cliente es persona, 2 si es empresa");
                        }

                        if (resp == "1")
                        {
                            Console.WriteLine("Ingrese nombte del cliente");
                            string nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese rut de cliente sin puntos ni guion ej(123456789)");
                            string rut = Console.ReadLine();
                            Persona cliente = new Persona(nombre, rut);
                            Console.WriteLine("¿Tiene " + nombre + " alguna licencia? responda s/n");
                            string lic = Console.ReadLine().ToLower();
                            while (lic == "s")
                            {
                                Console.WriteLine("indique tipo de licencia que posee: moto/auto/lancha/vehiculo pesado ");
                                string tolic = Console.ReadLine().ToLower();
                                if (cliente.AgregarLicencia(tolic) == false)
                                {
                                    Console.WriteLine("Pruebe nuevamente\n");
                                }
                                else
                                {
                                    Console.WriteLine("\nLicencia agregada\n");
                                    Console.WriteLine("¿Desea agregar otra licencia? responda s/n");
                                    lic = Console.ReadLine().ToLower();
                                }

                            }
                            directorio.AgregarCliente(cliente);
                            Console.WriteLine("Cliente exitosamente agregado");  //aqui voy
                        }
                        //falta empresa y fundacion, si selecciono una de esas entrara a un loop infinito o se caera
                    }

                    // ya hay clientes

                    Console.WriteLine("Escriba el nombre del cliente");
                    string cli = Console.ReadLine();
                    while (!(directorio.BuscarCliente(cli)))
                    {
                        Console.WriteLine("Escriba el nombre del cliente");
                        cli = Console.ReadLine();
                    }
                    // encontramos cliente

                    //lugar es el nombre de la sucursal
                    directorio.MostrarVehiculos(lugar);

                    Console.WriteLine("\nSeleccione vehiculo a utilizar\n"); //hasta ahora no hay vehiculos, por lo que no se mostraran
                    string VeArrendar = Console.ReadLine();

                    




                }


                if (respuesta == "6")
                {
                    if (directorio.Tamano() == 0)
                    {
                        Console.WriteLine("No hay sucursales creadas aún, favor cree una");
                    }
                    else
                    {
                        Console.WriteLine("Seleccione sucursal a agregar vehiculo \n");
                        string lugar = Console.ReadLine();
                        while (!(directorio.VerificarSucursal(lugar)))
                        {
                            Console.WriteLine("Seleccion invalida\nFavor seleccione nuevamente sucursal");
                            lugar = Console.ReadLine();
                        }
                        
                        Console.WriteLine("\nSeleccione tipo de vehiculo a agreguar: auto, moto, lancha, vehiculo pesado\n");
                        string tipo = Console.ReadLine().ToLower();
                        while (!( (tipo == "moto") | (tipo == "auto") | (tipo == "lancha") | ( tipo == "vehiculo pesado") ))
                        {
                            Console.Beep();
                            Console.Beep();
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("Seleccion erronea");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine("\nSeleccione tipo de vehiculo a agreguar: auto, moto, lancha, vehiculo pesado\n");
                            tipo = Console.ReadLine().ToLower();
                        }
                        Console.WriteLine("Ingrese patente");
                        string patente = Console.ReadLine();
                        Console.WriteLine("Ingrese Marca");
                        string marca = Console.ReadLine();
                        Console.WriteLine("ingrese costo");
                        string costo = Console.ReadLine();
                        Vehiculo vehiculo = new Vehiculo(tipo, patente, marca, costo);
                        directorio.AgregarVehiculo(vehiculo, lugar);
                    }
                }

                if (respuesta == "4") //mostrar sucursales
                {
                    if (directorio.Tamano() == 0)
                    {
                        Console.WriteLine("No hay sucursales creadas aún");
                    }
                    directorio.ImprimirSucursales();
                }


                // falta respuesra == 5 y 2 
                if (respuesta == "7") //salir 
                {
                    Console.Beep();
                    Console.Beep();
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("gracias por operar con 'Git Gud'");
                    Console.Beep();
                    break;
                }

                Console.WriteLine("\nPrecione 1 para realizar un arriendo, 2 para recibir un vehiculo ,3 para agregar sucursal, 4 para ver las sucursales disponibles, 5 para agregar vehiculo, 6 para agregar nuevo vehiculo a sucursal, 7 para salir\n");
                respuesta = Console.ReadLine();


            }






            Console.ReadLine();

        }
    }
}
