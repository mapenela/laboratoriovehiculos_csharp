using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Foolproof;

namespace PRUEBALABORATORIO.Models
{
 [MetadataType(typeof(VEHICULOSmetadata))]
    public partial class VEHICULOS
    {       
       
    }
/// <summary>
/// se hacen los getters y setters de los atributos del objeto vehiculo
/// </summary>

    public class VEHICULOSmetadata
    {
        public int IdVehiculo { get; set; }       
        [Required(ErrorMessage = "El modelo es obligatorio")]  
        public string Modelo { get; set; }
        [Required(ErrorMessage = "El precio es obligatorio")]
        public Decimal Precio { get; set; }
        [Required(ErrorMessage = "La fecha es obligatorio")]
        [DataType(DataType.Date, ErrorMessage = "La fecha fábrica debe ser dato tipo fecha")]
        public DateTime FechaFabrica { get; set; }

        [Required(ErrorMessage = "El campo Marca es obligatorio")]       
        public String Marca { get; set; }
    }
}