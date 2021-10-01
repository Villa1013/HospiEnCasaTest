using Microsoft.EntityFrameworkCore;
//using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class AppContext:DbContext
    {
        public DbSet<Persona> Persona {get;set;} //Al establecer la conexión asigna una tabla a la clase Persona, le doy el nombre Personas/
        
        //public DbSet<Medico> Medicos{get;set;}
        //public DbSet<FamiliarDesignado> familiarDesignado{get;set;}
        //public DbSet<Historia> Historia{get;set;}
        public DbSet<Paciente> Paciente {get;set;}
        //public DbSet<SugerenciaCuidados> SugerenciaCuidados{get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //Variable del ef
        {
            if (!optionsBuilder.IsConfigured) //Valida si la configuración o conexión se realizó
            {
                optionsBuilder.UseSqlServer("Data source=(localdb)\\MSSQLLocalDB; Initial Catalog=HospiEnCasaData"); //Se define el servidor de la DB
            }
        }
    }
}