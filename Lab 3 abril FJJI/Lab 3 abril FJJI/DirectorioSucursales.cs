using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_abril_FJJI
{
    class DirectorioSucursales
    {
        List<Sucursal> directorio;
        List<Cliente> clientes = new List<Cliente>();

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
            if (directorio.LongCount() == 0)
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

        public void ImprimirSucursales()
        {
            foreach (Sucursal suc in  directorio)
            {
                Console.WriteLine(suc.sede);
            }
        }

        public long   Tamano()
        {
            long  a = (directorio.LongCount());
            return a;
        }
        
        public bool AgregarCliente(Cliente cliente)
        {
            if (clientes.LongCount() == 0)
            {
                clientes.Add(cliente);
                return true;
            }

            foreach (Cliente a in clientes)
            {
                if (cliente == a)
                {
                    Console.WriteLine("cliente ya existe");
                    return false;
                }
            }
            clientes.Add(cliente);
            Console.WriteLine("El cliente " + cliente + " ha sido creado");
            return true;

        }
        public long CantidadClientes()
        {
            long a = clientes.LongCount();
            return a;
        }
    }
}
