using GestionCitasMedicas.Interfaces;
using GestionCitasMedicas.Models;
using GestionCitasMedicas.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionCitasMedicas.Services
{
    public class GestorCitas : IConsultaCitas, IGestionCitas
    {
        private List<Cita> _citas;
        private IRecordatorio _recordatorio;

        public GestorCitas(IRecordatorio recordatorio)
        {
            _citas = new List<Cita>();
            _recordatorio = recordatorio;

        }
        public void AgendarCita(Cita cita)
        {
            _citas.Add(cita);
            _recordatorio.EnviarRecordatorio(cita);

        }

        public void CancelarCita(int citaId)
        {
            foreach (Cita cita in _citas)
            {
                if (cita.Id == citaId)
                {
                    cita.Estado = "Cancelada";
                    Console.WriteLine("Cita cancelada");
                    return;
                }
            }
        }

        public void ReprogramarCita(int citaId, DateTime nuevaFecha)
        {
            Comprobador.ComprobarFechaFutura(nuevaFecha);
            foreach (Cita cita in _citas)
            {
                if (cita.Id == citaId && cita.Estado != "Cancelada")
                {
                    cita.FechaHora = nuevaFecha;
                    _recordatorio.EnviarRecordatorio(cita);
                    return;
                }
            }
        }

        public List<Cita> ConsultarPorPaciente(int pacienteId)
        {
            List<Cita> resultado = new List<Cita>();
            foreach (Cita cita in _citas)
            {
                if (cita.Paciente.Id == pacienteId) resultado.Add(cita);
            }
            return resultado;
        }

        public List<Cita> ConsultarPorMedico(int medicoId)
        {
            List<Cita> resultado = new List<Cita>();
            foreach (Cita cita in _citas)
            {
                if (cita.Medico.Id == medicoId) resultado.Add(cita);
            }
            return resultado;
        }

    }

}