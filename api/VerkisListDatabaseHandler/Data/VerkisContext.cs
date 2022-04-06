using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VerkisListDatabaseHandler.Models;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Reflection;

namespace VerkisListDatabaseHandler.Data
{
    public class VerkisContext : DbContext
    {
        public DbSet<Diagnose> Diagnoses { get; set; }
        public DbSet<Verrichting> Verrichtingen { get; set; }

        public VerkisContext(DbContextOptions<VerkisContext> contextOptions) : base(contextOptions)
        { }
    }
}
