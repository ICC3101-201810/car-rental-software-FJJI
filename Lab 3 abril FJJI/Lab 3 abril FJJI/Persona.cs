using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_abril_FJJI
{

    class Persona : Cliente
    {
        bool LicenciaAuto = false;
        bool LicenciaMoto = false;
        bool LicenciaVehiculoPesado = false;
        bool LicenciaLancha = false;


        public Persona(string TuNombre, string TuRut) 
        {
            Nombre = TuNombre;
            Rut = TuRut;
        }
        
        public bool AgregarLicencia (string tipo)
        {
            if (tipo == "moto")
                LicenciaMoto = true; 
            else if (tipo == "auto")
                LicenciaAuto = true;
            else if (tipo == "vehiculo pesado")
                LicenciaVehiculoPesado = true;
            else if (tipo == "lancha")
                LicenciaLancha = true;

            else
            {
                Console.WriteLine("Su seleccion de tipo de licencia es invalido");
                return false;
            }
            return true;
        }
    }
}
