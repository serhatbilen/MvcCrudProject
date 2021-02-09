using MvcCrudProject.Data.Entities;
using MvcCrudProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MvcCrudProject.Models.Context
{
    public class CrudDbContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public CrudDbContext()
        {
            Database.Connection.ConnectionString = "server=DESKTOP-2IPPHG8\\MSSQLSERVER1;database=MvcCrudProject;Trusted_Connection=true";
        }

        public DbSet <Departman> Departman { get; set; }
        public DbSet<Calisan> Calisan { get; set; }
        public DbSet<Login> Login { get; set; }
    }
}