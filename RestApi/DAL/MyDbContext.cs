using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using RestApi.Models;
//using System.Data.Entity; 
//using System.Data.Entity.ModelConfiguration.Conventions; 
namespace RestApi.DAL
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("RestApiConnection")
        {
            //inicializar la base de datos 
            base.Configuration.ProxyCreationEnabled = false;
            
        }
        
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Actividades> Actividades { get; set; }
        public DbSet<ActividadesAmigos> ActividadesAmigos { get; set; }
        #region metodos
        /*
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<ActividadesAmigos>().HasKey(a => new { a.idactividad, a.idamigo });
        }
        */
        #endregion
    }
}