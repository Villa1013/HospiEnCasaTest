using System;

namespace HospiEnCasa.App.Dominio
{
    public class Persona
    {
        public int Id {get; private set; }
        public string Nombre {get;set;}
        public string Apellidos {get;set;}
        public string NumeroTelefono {get;set;}
        public Genero Genero {get;set;}
    }
}
