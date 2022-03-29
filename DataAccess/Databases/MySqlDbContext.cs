﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Databases
{
    public class MySqlDbContext : WorkflowDbContext
    {
        public MySqlDbContext(IConfiguration configuration) : base(configuration)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseOracle(Configuration.GetConnectionString("MySqlConnection"));
        }
    }
}
