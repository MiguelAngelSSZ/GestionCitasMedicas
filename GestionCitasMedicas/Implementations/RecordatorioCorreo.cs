using GestionCitasMedicas.Interfaces;
using GestionCitasMedicas.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionCitasMedicas.Implementations
{
    public class RecordatorioCorreo  : IRecordatorio
    {
        public void EnviarRecordatorio(Cita cita)
        {
            Console.WriteLine("Remitiendo correo a " + cita.Paciente.Nombre + " para cita el " + cita.FechaHora);
        }
    }
}
