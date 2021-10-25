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
        public DbSet<Diagnose> diagnoses { get; set; }
        public DbSet<Verrichting> verrichtingen { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=2122681fysio-server2021.database.windows.net,1433; Catalog=2122681verkisdb2021;User ID=Draakedan2122681;Password=t&83N@gW0uO;");
        }

        private static string GetConnectionStringFromJson()
        {
            //string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"data/Settings.json");
            //using StreamReader r = new(path);
            //String json = r.ReadToEnd();
            //return (string)JObject.Parse(json)["ConnectionStrings"]["DefaultConnection"];
            return null;
        }
    }
}
