using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_abril_FJJI
{
    public class Sucursales
    {
        public string sede;
        List<string> LasSucursales;

        public Sucursales(string LaSucursal)
        {
            sede = LaSucursal;

        }

        public bool AgregarSucursal (string sede)
        {
            foreach (string Lugar in LasSucursales)
            {
                if (sede == Lugar)
                {
                    Console.WriteLine("La sucursal " + sede + " ya existe");
                    return false;
                }

            }
            LasSucursales.Add(sede);
            Console.WriteLine("La sucursal" + sede + " ha sido agregada");
            return true;

        }
        public bool VerificarSucursal(string sede)
        {
            foreach (string Lugar in LasSucursales)
            {
                if (sede == Lugar )
                {
                    Console.WriteLine();
                    return true;
                }
            }
            Console.WriteLine("La Sede seleccionada no existe");
            return false;
        }
    }
}
