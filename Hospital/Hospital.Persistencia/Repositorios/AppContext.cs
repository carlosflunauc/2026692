using Microsoft.EntityFramework.Core;

namespace Hospital.Persistencia
{
    public class AppContext
    {

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