using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente= new RepositorioPaciente(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World EF!");
            AddPaciente();
        }

        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre = "MisionTIC",
                Apellidos = "Ciclo3",
                NumeroTelefono = "7777777",
                Genero = Genero.Masculino,
                Direccion = "calle 4 No 7-4",
                Longitud = 5.07062F,
                Latitud = -75.52290F,
                Ciudad = "Caldas",
                FechaNacimiento = new DateTime(1990, 04, 12)
            };
            _repoPaciente.AddPaciente(paciente);
        } 
    }
}
