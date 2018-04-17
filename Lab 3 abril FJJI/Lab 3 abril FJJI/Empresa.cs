using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_abril_FJJI
{
    class Empresa : Cliente
    {
        //autorizacion para operar vehiculos del tipo asociado
        public Empresa(string Nombre, string RUT) : base(Nombre, RUT)
        {
        }
    }
}
