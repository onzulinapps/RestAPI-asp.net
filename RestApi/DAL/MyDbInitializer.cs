﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using RestApi.Models;
namespace RestApi.DAL
{
    public class MyDbInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MyDbContext>
    //System.Data.Entity. DropCreateDatabaseIfModelChanges<MyDbContext>
    // CreateDatabaseIfNotExists<MyDbContext>
    {
        protected override void Seed(MyDbContext context)
        {
            //aqui crearemos un usuario de prueba para que la gente pueda probar la aplicacion REST tanto en interfaz web como interfaz movil. Windows, iOS, Android.
            context.Usuarios.Add(new Usuarios {id = 1, email="example@restapi.com", password="jlsmjlsm", nombre = "example", created_at = DateTime.Now, updated_at = DateTime.Now});
            //context.Students.Add(new Student { ID = 1, FirstName = "Mark", LastName = "Richards", EnrollmentDate = DateTime.Now });
        }
    }
}