using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_abril_FJJI
{
    public abstract class Cliente
    {
        string Nombre;
        string RUT;

        public Cliente(string Nombre, string  RUT)
        {
            this.Nombre = Nombre;
            this.RUT = RUT;
        }

        public string GetNombre()
        {
            return Nombre;
        }
    }

}
