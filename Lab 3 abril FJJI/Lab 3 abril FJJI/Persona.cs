using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_abril_FJJI
{
    class Persona : Cliente
    {
        int Licencia;

        public Persona(int TuLicencia, string TuNombre) 
        {
            Licencia = TuLicencia;
            Nombre = TuNombre;
        }
    }
}
