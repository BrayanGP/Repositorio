using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Entidades;
using MVC_Presentacion.Models;
using Negocio;

namespace MVC_Presentacion.Controllers
{
    public class AlumnoController : Controller
    {

        private NegocioAlumno negocio = new NegocioAlumno();

        private ConvertirObjetos obje = new ConvertirObjetos();



        // GET: Alumno
        public ActionResult Index()
        {
          


            return View(negocio.Consultar().ToList());
        }

        public ActionResult detail(int id)
        {
            

            return View(negocio.detail(id));
        }
        public ActionResult Edit(int id)
        {
            Alumnos alumnos = negocio.Editar(id);

            ViewBag.idEstadoOrigen = new SelectList(negocio.ConsultarEstado(), "id", "nombre", alumnos.idEstadoOrigen);
            ViewBag.idEstatus = new SelectList(negocio.ConsultarEstatus(), "id", "nombre", alumnos.idEstatus);
            return View(obje.CoAlumno(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AlumnoModelo alumnos)
        {
            if (ModelState.IsValid)
            {
             
                negocio.Editar2(obje.CoAlumnoModelo(alumnos));
            }
            ViewBag.idEstadoOrigen = new SelectList(negocio.ConsultarEstado(), "id", "nombre", alumnos.idEstadoOrigen);
            ViewBag.idEstatus = new SelectList(negocio.ConsultarEstado(), "id", "Clave", alumnos.idEstatus);
            return RedirectToAction("Index");

        }
        public ActionResult Delete(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumnos alumnos = negocio.Editar(id);
            if (alumnos == null)
            {
                return HttpNotFound();
            }
            return View(alumnos);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            negocio.Eliminar(id);
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {

            ViewBag.idEstadoOrigen = new SelectList(negocio.ConsultarEstado(), "id", "nombre");
            ViewBag.idEstatus = new SelectList(negocio.ConsultarEstatus(), "id", "Clave");
            return View();

        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AlumnoModelo alumnos)
        {
            if(ModelState.IsValid)
            {

                negocio.Crear(obje.CoAlumnoModelo(alumnos));
                return RedirectToAction("Index");
            }
            ViewBag.idEstadoOrigen = new SelectList(negocio.ConsultarEstado(), "id", "nombre", alumnos.idEstadoOrigen);
            ViewBag.idEstatus = new SelectList(negocio.ConsultarEstado(), "id", "Clave", alumnos.idEstatus);
            return View(alumnos);

        }

        public ActionResult _Detalle(int id)
        {
           
            return PartialView(negocio.detail(id));
        }
    }
}