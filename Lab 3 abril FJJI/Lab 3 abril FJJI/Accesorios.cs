using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_abril_FJJI
{
    abstract class Accesorios
    {
        string Radio;
        string GPS;
        string RuedaRepuesto;
        string Cortina;
        string SillaInfantil;


        public abstract bool VerificarAccesorio(); 


        //radios con bluetooth
        //GPS
        //rueda repuesto
        //cortina ventanas
        //silla infantiles
        //etc
        //la forma en que se concreta una transacción cambia si se pide incluir accesorios.
    }
}
