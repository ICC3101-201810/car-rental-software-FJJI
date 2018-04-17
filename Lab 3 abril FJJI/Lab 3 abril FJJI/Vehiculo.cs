using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_abril_FJJI
{
    public class Vehiculo
    {
        public enum TipoVehiculo { auto, moto, lancha, VehiculoPesado}

        string marca;
        string id;
        string costo;
        TipoVehiculo tipo; //no me funciono como queria
        int tipove;
        string TipoDeVehiculo;

        public Vehiculo (string TipoDeVehiculo, string ID , string marca, string costo)
        {
            this.TipoDeVehiculo = TipoDeVehiculo;
            id = ID;
            this.costo = costo;
            this.marca = marca;

        }

        public  bool VerificarAccesorio()
        {
            throw new NotImplementedException();
        }

        public string Getid ()
        {
            return id;
        }



        /*  auto;
            acuatico;
            moto;
            camion;
            bus;
            maquinariaPesada;*/
    }
}
