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


        public Sucursal(string LaSucursal)
        {
            sede = LaSucursal;

        }
    }
}


  