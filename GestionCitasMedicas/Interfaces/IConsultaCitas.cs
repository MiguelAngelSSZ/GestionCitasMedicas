using GestionCitasMedicas.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionCitasMedicas.Interfaces
{
    internal interface IConsultaCitas
    {
        List<Cita> ConsultarPorPaciente(int pacienteId);
        List<Cita> ConsultarPorMedico(int medicoId);
    }
}
