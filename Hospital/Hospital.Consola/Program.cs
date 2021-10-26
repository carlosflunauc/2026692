using System;
using System.Collections.Generic;
using Hospital.Dominio.Entidades;
using Hospital.Persistencia.Repositorios;

namespace Hospital.Consola
{
    class Program
    {
        //private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddPaciente();
        }
       /* private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre="Pepito",
                Apellidos="Perez",
                NumeroTelefono="30012345",
                Direccion="Calle 2 no 5-7",
                Ciudad="Manizales",
                Departamento="Caldas",
                FechaNacimiento= new DateTime(2000,05,20)
            };
            _repoPaciente.AddPaciente(paciente);
        }*/
    }
}
