using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using VideotheekApp.LIB.Entities;
using VideotheekApp.LIB.DATA;

namespace VideotheekApp.LIB.DAL
{
    class DAL_Movies
    {
        public static void Create(Movies model)
        {
            var ctx = AppDBContext.Instance();

            ctx.Movies.Add(model);
            ctx.SaveChanges();
        }

        public static void Update(Movies model)
        {
            var ctx = AppDBContext.Instance();
            ctx.Entry(model).State = EntityState.Modified;
            ctx.SaveChanges();
        }

        public static List<Movies> GetAll()
        {
            var ctx = AppDBContext.Instance();

            return ctx.Movies.Where(p => p.DeletedAt == null).ToList();
        }
    }
}
