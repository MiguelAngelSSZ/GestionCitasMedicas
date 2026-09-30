using GestionCitasMedicas.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionCitasMedicas.Models
{
    public class Cita
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public Paciente Paciente { get; set; }
        public Medico Medico { get; set; }
        public string Estado { get; set; }

        public Cita(int id, DateTime fechaHora, Paciente paciente, Medico medico)
        {
            Comprobador.ComprobarFechaFutura(fechaHora);
            Id = id;
            FechaHora = fechaHora;
            Paciente = paciente;
            Medico = medico;
            Estado = "Agendada";
        }
    }
}
