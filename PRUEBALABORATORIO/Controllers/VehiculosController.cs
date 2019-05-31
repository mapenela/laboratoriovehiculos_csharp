using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PRUEBALABORATORIO.Models.BusinessLogic;
using PRUEBALABORATORIO.Models;
using PRUEBALABORATORIO.Models.ViewModel;
using PagedList;

namespace PRUEBALABORATORIO.Controllers
{
    public class VehiculosController : Controller
    {

        // GET: /Vehiculos/Create
        public ActionResult Create()
        {            
            VmVehiculos vmvehiculos = new VmVehiculos();
            ///Se llama a la vista FormularioVehiculo donde se piden los datos del vehiculo a tratar
            ///
            return View(vmvehiculos);
        }        



        //
        // POST: /Vehiculos/Grabar
        [HttpPost]
        // Método acción de Grabar por POST. Grabación de un vehiculo en la base de datos.
        public ActionResult Grabar()
        {
            VmVehiculos vmVehiculos = new VmVehiculos();
            ViewBag.Grabar = false;
            if (ModelState.IsValid)
            {
                 
                //VEHICULOS vehiculo = new VEHICULOS();
                BlVehiculos blvehiculo = new BlVehiculos();
                UpdateModel(vmVehiculos); //updatemodel del vehiculo
                //pasamos el modelo vehiculo al bussines logic que devuelve true si la grabación es correcta
                if (blvehiculo.grabarVehiculo(vmVehiculos.vehiculo) == true)
                {
                    ViewBag.Grabar = true;

                }
                else
                {
                    //error al grabar.... mostramos un mensaje indicando el error en la grabación
                }

            }  
            else
            {
                Console.WriteLine("estoy aqui en grabar incorrecto");
            }
            return RedirectToAction("Create", "Vehiculos", new { vmVehiculos });
        }
        public ActionResult MostrarTodos()
        {
            BlVehiculos blvehiculos = new BlVehiculos();
            List<VEHICULOS> listaVehiculos = new List<VEHICULOS>();
            listaVehiculos = blvehiculos.GetVehiculosBL();
            ViewBag.listaVehiculos=listaVehiculos;
            ///Se llama a la vista MostrarTodos que lista todos los vehiculos grabados en la base de datos
            return PartialView("MostrarTodos");
        }        
        [ActionName("List")]
        public ActionResult List(int page, int? pageSize)
        {
            List<VEHICULOS> listaVehiculos = new List<VEHICULOS>();

            VmVehiculos vmvehiculos = new VmVehiculos();
            

            //BlCursos blCursos = new BlCursos();
            BlVehiculos blVehiculos = new BlVehiculos();
            

            //Ejecutamos el método getAllCursos para obtener una lista de todos los cursos.
            listaVehiculos = blVehiculos.GetVehiculosBL();
            int resultsOnPage = (pageSize ?? 10); //size;
            int pageNumber = page;

            return (ActionResult)PartialView("_Results", listaVehiculos.ToPagedList(pageNumber, resultsOnPage));

        }
        [ActionName("Edit")]
        public ActionResult Edit(int id)
        {
            VmVehiculos vmvehiculos = new VmVehiculos();
            ///Se llama a la vista FormularioVehiculo donde se piden los datos del vehiculo a tratar
            ///
            BlVehiculos blvehiculos = new BlVehiculos();
            vmvehiculos.vehiculo = blvehiculos.getVehiculoId(id);

            return (ActionResult)PartialView("List", vmvehiculos);
        }
 
    }
}
