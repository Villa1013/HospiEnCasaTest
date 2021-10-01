using System;

namespace HospiEnCasa.App.Dominio
{
    ///<sumary> Class <c>Paciente</c>
    /// Modela un paciente que esta en atencion hospitalaria
    ///</sumary>
    public class Paciente:Persona
    {
        public string Direccion {get;set;}
        public float Latitud {get;set;}
        public float Longitud {get;set;}
        public string Ciudad {get;set;}
        public DateTime FechaNacimiento {get;set;}
        // public FamiliarDesignado Familiar {get;set;}
        // public Enfermera Enfermera {get;set;}
        // public Medico Medico {get;set;}
        // public Historia Historia {get;set;}
        
        public string Especialidad {get;set;}
        public string Codigo {get;set;}
        public string RegistroRethus {get;set;}
        public string Historia {get;set;}
        
        
        
        public string Medico {get;set;}
        public string Familiar {get;set;}
        
        public string Enfermera {get;set;}
    }
}