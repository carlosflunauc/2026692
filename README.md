# 2026692

Instalación Global del Entity Framework

	dotnet tool install --global dotnet-ef

Actualizar el EF

  	dotnet tool update --global dotnet-ef

Instalacion solucion EF

  	dotnet new sln -o Hospital
  
Instalar las carpetas MVC
                                
	dotnet new classlib -o Hospital.Persistencia 	(Controlador)
                                
  	dotnet new classlib -o Hospital.Dominio 	(Modelo)
                                 
	dotnet new webapp -o Hospital.Frontend 		(Vista)
  
En la carpeta de Persistencia instalamos los paquetes:

	dotnet add package Microsoft.EntityFrameworkCore --version 5.0.0
	dotnet add package Microsoft.EntityFrameworkCore.Tools --version 5.0.0
	dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.0
	dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.0

Conexion con la base de datos:

// optionsBuilder.UseSqlServer("Inital Catalog=HospitalSenaData; Data Source=HOMELUNA; Integrated Security=true");
// optionsBuilder.UseSqlServer("Data Source=(localdb)\\Nombre_Servidor; Initial Catalog=HospitalSenaData");
