using MOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace MO.Controllers
{
    public class SeccionController : ApiController
    {
        // GET: api/Seccion
        private MOModel.ModelContext db = new MOModel.ModelContext();

        public IEnumerable<MOModel.Seccion> Get()
        {
            var secciones = db.Seccion.ToList();
            return secciones;
        }

        // GET: api/Seccion/5
        public Seccion Get(int id)
        {
            if (id != 0)
            {
                var seccion = db.Seccion.Where(x => x.Id == id).FirstOrDefault();

                return seccion;
            }

            return null;
        }

        // POST: api/Seccion
        public void Post(Seccion seccion)
        {
            if (seccion != null)
            {
                db.Seccion.Add(seccion);
                db.SaveChanges();
            }
        }

        // PUT: api/Seccion/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Seccion/5
        public void Delete(int id)
        {
        }
    }
}


