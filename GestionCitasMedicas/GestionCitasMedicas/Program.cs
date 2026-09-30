using GestionCitasMedicas.Models;
using GestionCitasMedicas.Services;
using GestionCitasMedicas.Interfaces;
using GestionCitasMedicas.Implementations;


namespace GestionCitasMedicas.GestionCitasMedicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Especialidad especialidad = new Especialidad(1, "nefrología");
            Medico medico = new Medico(1, "Dr. Gregory House", especialidad);
            Paciente paciente = new Paciente(1, "Miguel A. Severino S.");

            IRecordatorio recordatorio = new RecordatorioCorreo();
            GestorCitas gestor = new GestorCitas(recordatorio);

            Cita cita = new Cita(1, DateTime.Now.AddDays(2), paciente, medico);
            gestor.AgendarCita(cita);

            Console.WriteLine("La cita fue programada con exito");

            var citasPaciente = gestor.ConsultarPorPaciente(paciente.Id);
            foreach (var c in citasPaciente)
                Console.WriteLine("Cita" + c.Id + " con " + c.Medico.Nombre + " el " + c.FechaHora);

            gestor.CancelarCita(1);
            Console.WriteLine("La cita fue cancelada del sistema");

            gestor.ReprogramarCita(1, DateTime.Now.AddDays(5));
            Console.WriteLine("La cita fue reprogramada en el sistema");
        }

    }
}
