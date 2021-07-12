using Entidades;
using MVC_Presentacion.Models;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Presentacion.Controllers
{
    public class ConvertirObjetos
    {
         
        public  AlumnoModelo CoAlumno(int id)
        {
            NegocioAlumno negocio = new NegocioAlumno();

            AlumnoModelo oMAlumno = new AlumnoModelo()
            {
                id = negocio.detail(id).id,
                nombre = negocio.detail(id).nombre,
                primerApellido = negocio.detail(id).primerApellido,
                segundoApellido = negocio.detail(id).segundoApellido,
                correo = negocio.detail(id).correo,
                telefono = negocio.detail(id).telefono,
                fechaNacimiento = negocio.detail(id).fechaNacimiento,
                curp = negocio.detail(id).curp,
                idEstadoOrigen = negocio.detail(id).idEstadoOrigen,
                idEstatus = negocio.detail(id).idEstatus

            };
            return oMAlumno;
        }
        public Alumnos CoAlumnoModelo(AlumnoModelo alumnos)
        {
            NegocioAlumno negocio = new NegocioAlumno();

            Alumnos oAlumnos = new Alumnos()
            {
                id = alumnos.id,
                nombre = alumnos.nombre,
                primerApellido = alumnos.primerApellido,
                segundoApellido = alumnos.segundoApellido,
                correo = alumnos.correo,
                telefono = alumnos.telefono,
                fechaNacimiento = alumnos.fechaNacimiento,
                curp = alumnos.curp,
                idEstadoOrigen = alumnos.idEstadoOrigen,
                idEstatus = alumnos.idEstatus
            };
            return oAlumnos;
        }
    }
}