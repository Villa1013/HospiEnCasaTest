// using System.Collections.Generic;
// using HospiEnCasa.App.Dominio;
using System.ComponentModel.Composition;
using System.Diagnostics;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPaciente();

        Paciente AddPaciente(Paciente paciente);

        Paciente UpdatePaciente(Paciente paciente);

        void DeletePaciente(int idPaciente);

        Paciente GetPaciente(int idPaciente);

        // Medico GetPaciente(int idPaciente);

    }
}