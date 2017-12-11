using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideotheekApp.LIB.DAL;
using VideotheekApp.LIB.Entities;

namespace VideotheekApp.LIB.BL
{
    public class BL_Movies
    {
        public static bool Save(Movies model)
        {
            try
            {
                if (model.IsNew())
                    Create(model);
                else
                    Update(model);

            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }



        private static void Create(Movies model)
        {
            try
            {
                DAL_Movies.Create(model);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private static void Update(Movies model)
        {
            try
            {
                DAL_Movies.Update(model);
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        public static List<Movies> GetAll()
        {
            try
            {
                return DAL_Movies.GetAll();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Delete(Movies model)
        {
            try
            {
                model.DeletedAt = DateTime.Now;
                Save(model);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
