using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Databases
{
    public class OracleDbContext: WorkflowDbContext
    {
        public OracleDbContext(IConfiguration configuration) : base(configuration)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = @"DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.162.113.140)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=PDB1)));USER ID=ED_TEST; Password=Davidkmhd!1;";
            connectionString = Configuration.GetConnectionString("DatabaseOptions:ConnectionStrings:Oracle");
            options.UseOracle(connectionString);
        }
    }
}
