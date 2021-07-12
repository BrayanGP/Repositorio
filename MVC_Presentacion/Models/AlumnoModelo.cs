using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Presentacion.Models
{
    public class AlumnoModelo
    {



        //[Key]
        public int id { get; set; }
        [Required(ErrorMessage = "{0} es un campo obligatorio")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "El {0} debe tener minimo 3 maximo 60 caracteres")]
        [DataType(DataType.Text)]
        public string nombre { get; set; }
        [Required(ErrorMessage = "{0} es un campo obligatorio")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El {0} debe tener minimo 3 maximo 60 caracteres")]
        [DataType(DataType.Text)]
        public string primerApellido { get; set; }
       
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El {0} debe tener minimo 3 maximo 60 caracteres")]
        [DataType(DataType.Text)]
        public string segundoApellido { get; set; }
        [Required(ErrorMessage = "{0} es un campo obligatorio")]
        //[RegularExpression("\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\\.[A-Z]{2,4}\b", ErrorMessage = "Mail incorrecto")]
        [DataType(DataType.Text)]
        public string correo { get; set; }
        [Required(ErrorMessage = "{0} es un campo obligatorio")]
        [StringLength(10, MinimumLength = 10,
       ErrorMessage = "La propiedad {0} debe tener 10 Digitos")]
        [DataType(DataType.PhoneNumber)]
        public string telefono { get; set; }
        [Required(ErrorMessage = "{0} es un campo obligatorio")]
       // [Range(typeof(DateTime), "1900/01/1", "2002/01/1",
       //ErrorMessage = "Eres menor de edad")]
        [DataType(DataType.Text)]
        public Nullable<System.DateTime> fechaNacimiento { get; set; }
        [Required(ErrorMessage = "{0} es un campo obligatorio")]
        //[RegularExpression("^[A-Z]{1}[AEIOU]{1}[A-Z]{2}[0-9]{2}(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1])[HM]{1}(AS | BC | BS | CC | CS | CH | CL | CM | DF | DG | GT | GR | HG | JC | MC | MN | MS | NT | NL | OC | PL | QT | QR | SP | SL | SR | TC | TS | TL | VZ | YN | ZS | NE)[B - DF - HJ - NP - TV - Z]{ 3}[0-9A-Z]{ 1}[0-9]{ 1}$", ErrorMessage = "CURP incorrecto")]
        [DataType(DataType.Text)]
        public string curp { get; set; }
        public Nullable<int> idEstadoOrigen { get; set; }
        public Nullable<short> idEstatus { get; set; }

        public virtual Estados Estados { get; set; }
        public virtual EstatusAlumnos EstatusAlumnos { get; set; }
    }
}