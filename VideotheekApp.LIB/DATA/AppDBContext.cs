using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideotheekApp.LIB.Entities;

namespace VideotheekApp.LIB.DATA
{
    public class AppDBContext : DbContext
    {
        #region Database sets

        public DbSet<Movies> Movies { get; set; }
        
        #endregion


        private static AppDBContext _instance;

        public AppDBContext() : base(@"Data Source=DESKTOP-5UDQTSH\SQLEXPRESS;Initial Catalog=Videotheek;Persist Security Info=True;User ID=GertjanVerhelst;Password=Gertjan01") //this(conn: @"Data Source=DESKTOP-5UDQTSH\SQLEXPRESS;Initial Catalog=Videotheek;Persist Security Info=True;User ID=GertjanVerhelst;Password=Gertjan01")
        {
              
        }

        private AppDBContext(string conn): base(conn) { }



        public static AppDBContext Instance(string conn = null)
        {
            if (_instance == null)
            {
                if (!string.IsNullOrWhiteSpace(conn))
                {
                    _instance = new AppDBContext(conn);
                }
            }
            return _instance;
        }
    }

}
