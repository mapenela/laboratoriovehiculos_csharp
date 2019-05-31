using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PRUEBALABORATORIO.Models.DataAccess
{
    public class DaVehiculos
    {
        // Método getAll para obtener todos los vehiculos de la base de datos.
        public List<VEHICULOS> getAll()
        {
            try
            {
                // se asigna el context con la base de datos y el entity framework
                PRUEBASLOCALEntities context = new PRUEBASLOCALEntities();
                return context.VEHICULOS.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                throw ex;
            }
        }
     public int insertVehiculo(VEHICULOS vehiculo)
        {
            //Método insertVehiculo para grabar un vehiculo en la base de datos
            // se asigna el context con la base de datos y el entity framework
            PRUEBASLOCALEntities context = new PRUEBASLOCALEntities();



            //context.VEHICULOS.Single(p => p.IdVehiculo == 1);


            int id = -1; // si el id retornado es = -1 es que ha habido error al grabar
 try
            {
            context.VEHICULOS.Add(vehiculo);

           
                context.SaveChanges();  //con el savechanges se actualiza el objeto entero con el resto de atributos
                id = vehiculo.IdVehiculo;  //recupero el id del vehiculo creado
            }
            catch(Exception e)
            {
                //SystemException e = new SystemException();
                Console.WriteLine(e);
            }
       
            return id;

        }
     public VEHICULOS getVehiculosDA(int idVehiculo)
     {
         /// se instancia el objeto vehiculo con la clase VEHICULOS.
         VEHICULOS vehiculo = new VEHICULOS();
         // se asigna el context con la base de datos y el entity framework
         PRUEBASLOCALEntities context = new PRUEBASLOCALEntities();

         try
         {
            /// Se obtiene un vehiculo de la base de datos
            vehiculo = context.VEHICULOS.Find(idVehiculo);
         }
         catch (Exception e)
         {
             System.Console.Write("Error en la clase DaVehiculos, al recuperar el vehiculo por id");
             throw new Exception("Error al recuperar el vehiculo", e);
         }


         return vehiculo;
     }
    }
}