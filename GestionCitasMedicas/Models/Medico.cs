using GestionCitasMedicas.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionCitasMedicas.Models
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Especialidad Especialidad { get; set; }

        public Medico(int id, string nombre, Especialidad especialidad)
        {
            Comprobador.ComprobarCadena(nombre, "nombre");
            Id = id;
            Nombre = nombre;
            Especialidad = especialidad;
        }
    }
}
