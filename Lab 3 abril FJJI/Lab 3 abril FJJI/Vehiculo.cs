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
        int costo;
        TipoVehiculo tipo;

        public Vehiculo (TipoVehiculo tipo, string ID , string marca, int costo)
        {
            this.tipo = tipo;
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
