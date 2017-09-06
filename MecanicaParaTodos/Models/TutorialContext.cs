using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MecanicaParaTodos.Models
{
    public class TutorialContext: DbContext
    {
        public TutorialContext()
            : base("DefaultConnection")
        {

        }
        public DbSet<Tutorial> Tutoriales { get; set; }
    }
}