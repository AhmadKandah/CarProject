using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer;
using System.Data.Entity;
    
namespace CarProject
{
    public class ApplicationDataContext : DbContext


    {
        protected override void onConfiguring(DbContextOptionBuilder options)
        {
            
        }



        public DbSet<Car> Cars { set; get; }
        public DbSet<Customer> Customers { set {  } get {} }

        public DbSet<Salels> Salels { set; get; }
        public DbSet<Parts> Partss { set; get; }













        public ApplicationDataContext(string fileOrServerOrConnection) : base(fileOrServerOrConnection)
        {
        }

        public ApplicationDataContext(IDbConnection connection) : base(connection)
        {
        }

        public ApplicationDataContext(string fileOrServerOrConnection, MappingSource mapping) : base(fileOrServerOrConnection, mapping)
        {
        }

        public ApplicationDataContext(IDbConnection connection, MappingSource mapping) : base(connection, mapping)
        {
        }
    }
}
