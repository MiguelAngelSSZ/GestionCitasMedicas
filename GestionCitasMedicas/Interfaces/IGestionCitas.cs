using GestionCitasMedicas.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionCitasMedicas.Interfaces
{
    internal interface IGestionCitas
    {
        void AgendarCita(Cita cita);
        void CancelarCita(int citaId);
        void ReprogramarCita(int citaId, DateTime nuevaFecha);
    }
}
