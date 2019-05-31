using PRUEBALABORATORIO.Models.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PRUEBALABORATORIO.Models.BusinessLogic
{
    public class BlVehiculos
    {
        public List<VEHICULOS> GetVehiculosBL()
        {
            //Lista para almacenar los datos que devuelve el método GETVEHICULOSBL
            List<VEHICULOS> lista = new List<VEHICULOS>();

            //Objeto de la clase DaVehiculos para acceder a sus métodos
            DaVehiculos dataAccessVh = new DaVehiculos();
            //se llama al método getAll de la clase DaVehiculos para obtener todos los vehiculos y se almacena en una lista
            lista = dataAccessVh.getAll();

            return lista;
        }
        public Boolean grabarVehiculo(VEHICULOS vehiculo)
        {
            ///Método para grabar un vehiculo en la base de datos
            bool grabacionCorrecta = false;
            //Objeto de la clase DaVehiculos para acceder a sus métodos
            DaVehiculos dataAccessVh = new DaVehiculos();
            

            

            
            //se accede al método insertVehiculo de la clase DaVehiculos para grabar un vehiculo en base de datos
            int idVehiculo = dataAccessVh.insertVehiculo(vehiculo);           
            if (idVehiculo != -1)
            {
                grabacionCorrecta = true;
                vehiculo.IdVehiculo = idVehiculo; // asigno el id al modelo.
            }

            return grabacionCorrecta;
        }
        public VEHICULOS getVehiculoId(int id)
        {
            //se inicializa vehiculo como instancia de la clase VEHICULOS
            VEHICULOS vehiculo = new VEHICULOS();
            //Objeto de la clase DaVehiculos para acceder a sus métodos
            DaVehiculos dataAcessVehiculos = new DaVehiculos();

            try
            {
                //Se accede al método getVehiculosDA de la clase DaVehiculos para obtener un objeto vehiculo
                vehiculo = dataAcessVehiculos.getVehiculosDA(id);
            }
            catch (Exception e)
            {
                System.Console.Write("Error en la clase BlVehiculos, no se ha podido recuperar el vehiculo por id");
                throw new Exception("No se puede recuperar el registro de Vehiculos", e);
            }


            return vehiculo;
        }

    }
}