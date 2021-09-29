using System;

namespace HospiEnCasa.App.Dominio
{
    public class Paciente:Persona
    {
        public string Direccion {get;set;}
        public string Especialidad {get;set;}
        public string Codigo {get;set;}
        public string RegistroRethus {get;set;}
        public string Historia {get;set;}
        public string Latitud {get;set;}
        public string Longitud {get;set;}
        public string Ciudad {get;set;}
        public string Medico {get;set;}
        public string Familiar {get;set;}
        public string FechaNacimiento {get;set;}
        public string Enfermera {get;set;}
    }
}