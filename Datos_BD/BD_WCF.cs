using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos_BD.ServiceWCF;
using Entidades;

namespace Datos_BD
{
    
    public class BD_WCF
    {

        public Alumnos detailWCF(int id)
        {
            WCFAlumnoClient instaciaReferenciaWS = new WCFAlumnoClient();

            DCAlumno dcAlumno = new DCAlumno();
            instaciaReferenciaWS.Open();
            dcAlumno = instaciaReferenciaWS.detail(id);
            instaciaReferenciaWS.Close();
            Alumnos otroGAto = new Alumnos()
            {
                id = dcAlumno.id,
                nombre = dcAlumno.nombre,
                primerApellido = dcAlumno.primerApellido,
                segundoApellido = dcAlumno.segundoApellido,
                correo = dcAlumno.correo,
                telefono = dcAlumno.telefono,
                fechaNacimiento = dcAlumno.fechaNacimiento,
                curp = dcAlumno.curp,
                idEstadoOrigen = dcAlumno.idEstadoOrigen,
                idEstatus = dcAlumno.idEstatus

            };

            return otroGAto;

        }
        public void Actualizar(Alumnos alumno)
        {
            WCFAlumnoClient instaciaReferenciaWS = new WCFAlumnoClient();

           

            DCAlumno otroGAto = new DCAlumno()
            {
                id = alumno.id,
                nombre = alumno.nombre,
                primerApellido = alumno.primerApellido,
                segundoApellido = alumno.segundoApellido,
                correo = alumno.correo,
                telefono = alumno.telefono,
                fechaNacimiento = alumno.fechaNacimiento,
                curp = alumno.curp,
                idEstadoOrigen = alumno.idEstadoOrigen,
                idEstatus = alumno.idEstatus

            };


            instaciaReferenciaWS.Open();

            instaciaReferenciaWS.Actualizar(otroGAto);
            instaciaReferenciaWS.Close();

        }
        public void crear(Alumnos alumno)
        {
            WCFAlumnoClient instaciaReferenciaWS = new WCFAlumnoClient();



            DCAlumno otroGAto = new DCAlumno()
            {
                id = alumno.id,
                nombre = alumno.nombre,
                primerApellido = alumno.primerApellido,
                segundoApellido = alumno.segundoApellido,
                correo = alumno.correo,
                telefono = alumno.telefono,
                fechaNacimiento = alumno.fechaNacimiento,
                curp = alumno.curp,
                idEstadoOrigen = alumno.idEstadoOrigen,
                idEstatus = alumno.idEstatus

            };


            instaciaReferenciaWS.Open();

            instaciaReferenciaWS.Create(otroGAto);
            instaciaReferenciaWS.Close();

        }

        public List<Alumnos> Consultar()
        {
            WCFAlumnoClient instaciaReferenciaWS = new WCFAlumnoClient();

            DCAlumno dcAlumno = new DCAlumno();
            instaciaReferenciaWS.Open();
            
           

            List<Alumnos> lista = new List<Alumnos>();

            foreach (var li in instaciaReferenciaWS.Consultar())
            {
                Alumnos _alumnos = new Alumnos()
                {
                    id = li.id,
                    nombre = li.nombre,
                    primerApellido = li.primerApellido,
                    segundoApellido = li.segundoApellido,
                    correo = li.correo,
                    telefono = li.telefono,
                    fechaNacimiento = li.fechaNacimiento,
                    curp = li.curp,
                    idEstadoOrigen = li.idEstadoOrigen,
                    idEstatus = li.idEstatus
                };
                lista.Add(_alumnos);
            }
            instaciaReferenciaWS.Close();

            return lista.ToList();

        }
    }
}
