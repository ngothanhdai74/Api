using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Databases
{
    // Add-Migration InitialDbMsSql -Context MsSqlDbContext -OutputDir Data\Migrations\MsSql
    // Add-Migration InitialDbPostgres -Context PostgresDbContext -OutputDir Data\Migrations\PostgreSql
    // Add-Migration CreateDatabase -Context OracleDbContext -OutputDir Data\Migrations\Oracle

    // Update-Database -Context OracleDbContext
    // Update-Database -Context PostgresDbContext
    // Update-Database -Context OracleDbContext

    public abstract class WorkflowDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        #pragma warning disable CS8618
        protected WorkflowDbContext(IConfiguration configuration)
        #pragma warning restore CS8618
        {
            Configuration = configuration;
        }
        public DbSet<ToDoList> ToDoLists { get; set; }
        public DbSet<ToDoListProps> ToDoListProps { get; set; }
    }
}
