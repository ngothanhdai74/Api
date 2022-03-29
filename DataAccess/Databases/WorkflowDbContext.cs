using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Databases
{
    public abstract class WorkflowDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        protected WorkflowDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

    }
}
