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
        private static AppDBContext _instance;

        public AppDBContext() : this(conn: @"Data Source=DESKTOP-5UDQTSH\SQLEXPRESS;Initial Catalog=Videotheek;Persist Security Info=True;User ID=GertjanVerhelst;Password=Gertjan01")
        {
              
        }

        private AppDBContext(string conn): base(conn) { }

#region Database sets

        public DbSet<Movies> Movies { get; set; }
#endregion

        public static AppDBContext Instance(string ConnectionString = null)
        {
            if (_instance == null)
            {
                if (!string.IsNullOrWhiteSpace(ConnectionString))
                {
                    _instance = new AppDBContext(ConnectionString);
                }
            }
            return _instance;
        }
    }

}
