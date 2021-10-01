// using System.Collections.Generic;
using System.Collections.Generic;
using HospiEnCasa.App.Dominio;
using System.Linq;
using System;
using HospiEnCasa.App.Persistencia;


namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioPaciente:IRepositorioPaciente 
    {
        private readonly HospiEnCasa.App.Persistencia.AppContext _appContext;

        public RepositorioPaciente(HospiEnCasa.App.Persistencia.AppContext appContext){
            _appContext=appContext;
        }


        Paciente IRepositorioPaciente.AddPaciente(Paciente paciente)
        {
            // throw new System.NotImplementedExeption();
            var pacienteAdicionado = _appContext.Pacientes.Add(paciente);
            _appContext.SaveChanges();
            return pacienteAdicionado.Entity;
        }
        Paciente IRepositorioPaciente.UpdatePaciente(Paciente paciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == paciente.Id);
            if (pacienteEncontrado!=null)
            {
                pacienteEncontrado.Nombre=paciente.Nombre;
                pacienteEncontrado.Apellidos=paciente.Apellidos;
                pacienteEncontrado.NumeroTelefono=paciente.NumeroTelefono;
                pacienteEncontrado.Genero=paciente.Genero;
                pacienteEncontrado.Direccion=paciente.Direccion;
                pacienteEncontrado.Latitud=paciente.Latitud;
                pacienteEncontrado.Longitud=paciente.Longitud;
                pacienteEncontrado.Ciudad=paciente.Ciudad;
                pacienteEncontrado.FechaNacimiento=paciente.FechaNacimiento;
                pacienteEncontrado.Familiar=paciente.Familiar;
                pacienteEncontrado.Enfermera=paciente.Enfermera;
                pacienteEncontrado.Medico=paciente.Medico;
                pacienteEncontrado.Historia=paciente.Historia;

                _appContext.SaveChanges();

            }
            return pacienteEncontrado;
        }
        void IRepositorioPaciente.DeletePaciente(int idPaciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if(pacienteEncontrado == null) 
            return;
            _appContext.Pacientes.Remove(pacienteEncontrado);
            _appContext.SaveChanges();
        }
        Paciente IRepositorioPaciente.GetPaciente(int idPaciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            return pacienteEncontrado;
        }
        IEnumerable<Paciente> IRepositorioPaciente.GetAllPaciente()
        {
            return _appContext.Pacientes;
        }
        // ///<sumary>
        // /// Referencia al contexto paciente
        // ///</sumary>
        // private readonly AppContext _appContext;
        // ///<sumary>
        // ///Método constructor utiliza
        // ///Inyección de dependencias para indicar el contexto a utilizar
        // ///</sumary>
        // ///<param name="appContext"></param>//
        // public RepositorioPaciente(AppContext appContext)
        // {
        //     _appContext=appContext;
        // } 
        
        // Paciente IRepositorioPaciente.AddPaciente(Paciente paciente)
        // {
        //     var PacienteAdicionado = _appContext.Pacientes.Add(paciente);
        //     _appContext.SaveChanges();
        //     return PacienteAdicionado.Entity;
        // }

        // void IRepositorioPaciente.DeletePaciente(int idPaciente)
        // {
        //     var pacienteEncontrado= _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
        //     if(pacienteEncontrado == null) 
        //         return;
        //     _appContext.Pacientes.Remove(pacienteEncontrado);
        //     _appContext.SaveChanges();
        // }

        // IEnumerable<Paciente> IRepositorioPaciente.GetAllPaciente()
        // {
        //     return _appContext.Pacientes;
        // }

        // Paciente IRepositorioPaciente.GetPaciente(int idPaciente)
        // {
        //     return _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
        // }

        // Paciente IRepositorioPaciente.UpdatePaciente(Paciente paciente)
        // {
        //     var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == paciente.Id);
        //     if (pacienteEncontrado!=null)
        //     {
        //         pacienteEncontrado.Nombre=paciente.Nombre;
        //         pacienteEncontrado.Apellidos=paciente.Apellidos;
        //         pacienteEncontrado.NumeroTelefono=paciente.NumeroTelefono;
        //         pacienteEncontrado.Genero=paciente.Genero;
        //         pacienteEncontrado.Direccion=paciente.Direccion;
        //         pacienteEncontrado.Latitud=paciente.Latitud;
        //         pacienteEncontrado.Longitud=paciente.Longitud;
        //         pacienteEncontrado.Ciudad=paciente.Ciudad;
        //         pacienteEncontrado.FechaNacimiento=paciente.FechaNacimiento;
        //         pacienteEncontrado.Familiar=paciente.Familiar;
        //         pacienteEncontrado.Enfermera=paciente.Enfermera;
        //         pacienteEncontrado.Medico=paciente.Medico;
        //         pacienteEncontrado.Historia=paciente.Historia;

        //         _appContext.SaveChanges();

        //     }
        //     return pacienteEncontrado;
        // }
    }
}