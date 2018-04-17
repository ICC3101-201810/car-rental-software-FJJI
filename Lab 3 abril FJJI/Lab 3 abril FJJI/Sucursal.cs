using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_abril_FJJI
{
    public class Sucursal
    {
        public string sede;
        List<Arriendo> arriendos = new List<Arriendo>();
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        List<Vehiculo> arrendados = new List<Vehiculo>();


        public Sucursal(string LaSucursal)
        {
            sede = LaSucursal;

        }

        public bool  AgregarVehiculo(Vehiculo vehiculo)
        {
            if (vehiculos.IndexOf(vehiculo) == -1)
            {
                vehiculos.Add(vehiculo);
                Console.WriteLine("vehiculo agregado");
                return true;
            }
            Console.WriteLine("Vehiculo ya esta en la sucursal");
            return false;
            vehiculos.Add(vehiculo);
            Console.WriteLine("");
        }

        public bool ArrendarVehiculo (string id, string cliente) //nombre del cliente
        {
            foreach(Vehiculo vehiculo in vehiculos)
            {
                if (vehiculo.Getid() == id)
                {
                    vehiculos.Remove(vehiculo);
                    arrendados.Add(vehiculo);
                    string nombre = cliente;
                    Console.WriteLine("se ha arrendado el vehiculo " + id + "a el cliente " + nombre + "\n");
                    return true;
                }
            }

            Console.WriteLine("Vehiculo no disponible, no se pudo arrendar");
            return false;
        }

        public void MostrarVehiculos()
        {
            foreach (Vehiculo vehiculo in vehiculos)
            {
                Console.WriteLine(vehiculo.Getid()+"\n");
            }
        }
        
    }
}


  