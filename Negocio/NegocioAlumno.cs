using Datos_BD;
using Datos_BD.ServiceWCF;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Negocio
{

    public class NegocioAlumno
    {
       private BD_Entiti clas = new BD_Entiti();
       
        BD_WCF wcf = new BD_WCF();
        DAlumno repo =new DAlumno();

        //public List<Alumnos> Consultar() => clas.Consultar();
        //public List<Alumnos> Consultar() => wcf.Consultar();
        public List<Alumnos> Consultar() => repo.Consultar();
        public List<Estados> ConsultarEstado() => clas.consultarEstado();
        public List<EstatusAlumnos> ConsultarEstatus() => clas.consultarEstatus();
        //public Alumnos detail(int id ) => clas.detail(id);
        ///aqui se llama al WCF que se instancio
        ///
        //public Alumnos detail(int id) => wcf.detailWCF(id);
        public Alumnos detail(int id) => repo.Consultar(x=>x.id==id);
        public void Crear(Alumnos alumnos) => repo.Crear(alumnos);
        //public void Actualizar(Alumnos alumnos) => clas.Actualizar(alumnos);
        //public void Editar2(Alumnos alumnos) => wcf.Actualizar(alumnos);
        public void Editar2(Alumnos alumnos) => repo.Actualizar(alumnos);
        public Alumnos Editar(int id) => clas.detail(id);
        //public void Editar2(Alumnos alumno) => clas.Edit2(alumno);

        //public void Eliminar(int id) => clas.Eliminar(id);
        public void Eliminar(int id) => repo.Elimiar(x=>x.id==id);



    }
}
