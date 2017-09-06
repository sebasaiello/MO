using MecanicaParaTodos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MecanicaParaTodos.Services
{
    public class TutorialRepository
    {
        public List<Tutorial> GetAll()
        {
            using (var db = new TutorialContext())
            {
                return db.Tutoriales.ToList(); 
            }
        }

        internal void Create(Tutorial model)
        {
            using (var db = new TutorialContext())
            {
                db.Tutoriales.Add(model);
                db.SaveChanges();
            }
        }
    }
}