using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_abril_FJJI
{
    class DirectorioSucursales
    {
        List<Sucursal>  directorio ;

        public DirectorioSucursales()
        {
            directorio = new List<Sucursal>();
        }

        public bool VerificarSucursal(string sede)
        {

            foreach (Sucursal Lugar in directorio)
            {
                if (sede == Lugar.sede)
                {
                    Console.WriteLine();
                    //la sucursal existe, pero no es necesario decirlo al cliente aqui
                    return true;
                }
            }
            //la sucursal no existe
            return false;
        }
        public bool AgregarSucursal(string sede)
        {
            if (directorio == null)
            {
                Sucursal NuevaSede1 = new Sucursal(sede);
                directorio.Add(NuevaSede1);
                return true;
            }
            foreach (Sucursal Lugar in directorio)
            {
                if (sede == Lugar.sede)
                {
                    Console.WriteLine("La sucursal " + sede + " ya existe");
                    return false;
                }
            }
            Sucursal NuevaSede = new Sucursal(sede);
            directorio.Add(NuevaSede);
            return true;
        }
    }
}
