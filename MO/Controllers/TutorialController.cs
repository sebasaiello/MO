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
    public class TutorialController : ApiController
    {
        // GET: api/Tutorial
        private MOModel.ModelContext db = new MOModel.ModelContext();

        public IEnumerable<MOModel.Tutorial> Get()
        {
            var test = db.Tutorial.ToList();
            return test;
        }

        // GET: api/Tutorial/5
        public Tutorial Get(int id)
        {
            if (id != 0)
            {
                var tutorial = db.Tutorial.Where(x => x.Id == id).FirstOrDefault();

                return tutorial;
            }

            return null;
        }

        // POST: api/Tutorial
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Tutorial/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Tutorial/5
        public void Delete(int id)
        {
        }
    }
}


