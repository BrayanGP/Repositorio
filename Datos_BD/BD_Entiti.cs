using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web.Mvc;
using System.Net;


namespace Datos_BD
{
    public class BD_Entiti
    {
        private IstitutoTich2Entities db = new IstitutoTich2Entities();
        
        public BD_Entiti()
        {

        }

        public List<Alumnos> Consultar()
        {

            var alumnos = db.Alumnos.Include(a => a.Estados).Include(a => a.EstatusAlumnos);

            return alumnos.ToList();
        }
        public List<Estados> consultarEstado()
        {

            var estados = db.Estados;

            return estados.ToList();
        }
        public List<EstatusAlumnos> consultarEstatus()
        {

            var Estatus = db.Set<EstatusAlumnos>();

            return Estatus.ToList();
        }

        public void Create(Alumnos alumnos)
        {
            db.Alumnos.Add(alumnos);
            db.SaveChanges();
        }

        public void Actualizar(Alumnos alumnos)
        {
            db.Entry(alumnos).State = EntityState.Modified;
            db.SaveChanges();
        }
        public Alumnos detail(int? id)
        {

            if (id == null)
            {
                return HttpNotFound();
            }
            Alumnos alumnos = db.Alumnos.Find(id);
            if (alumnos == null)
            {
                return HttpNotFound();
            }
            return alumnos;
        }

        private Alumnos HttpNotFound()
        {
            throw new NotImplementedException();
        }

  
     
        public void Edit2(Alumnos alumnos)
        {
           
                db.Entry(alumnos).State = EntityState.Modified;
                db.SaveChanges();
           
        }

        public void Eliminar(int id)
        {
            Alumnos alumnos = db.Alumnos.Find(id);
            db.Alumnos.Remove(alumnos);
            db.SaveChanges();
        }



    }


}
