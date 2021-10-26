using Microsoft.EntityFramework.Core;
using Hospital.Dominio;

namespace Hospital.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get; set;}
        public DbSet<Paciente> Pacientes {get; set;}
        public DbSet<Medico> Medicos {get; set;}
        public DbSet<SignoVital> SignosVitales {get; set;}
      protected override void OnConfiguring(DbContextOptionBuilder optionsBuilder)
      {
          if (!optionsBuilder.IsConfigured)
          {
              optionsBuilder.UseSqlServer("Inital Catalog=HospitalSenaData; Data Source=HOMELUNA; Integrated Security=true");
              //optionsBuilder.UseSqlServer("Data Source=(localdb)\\Nombre_Servidor; Initial Catalog=HospitalSenaData");
          }
      }  //dotnet add package Microsoft.EntityFrameworkCore --version 5.0.0 
    }
}