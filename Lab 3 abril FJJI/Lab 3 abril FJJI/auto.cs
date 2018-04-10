using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_abril_FJJI
{
    public class Auto : Vehiculo
    {
        public Auto (string Marca, string Patente, int  Año, int Costo )
        {
            marca = Marca;
            patente = Patente;
            año = Año;
            costo = Costo;
            
        }



        public override bool VerificarAccesorio()
        {
            /* auto puede tener
                Radio;
                GPS;
                RuedaRepuesto;
                SillaInfantil;
                */
            
            return true; 
        }
    }
    //class Auto : Vehiculo 
    //{
    //}
}
