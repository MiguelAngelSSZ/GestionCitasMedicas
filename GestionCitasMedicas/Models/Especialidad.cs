using GestionCitasMedicas.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionCitasMedicas.Models
{
    public class Especialidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Especialidad(int id, string nombre)
        {
            Comprobador.ComprobarCadena(nombre, "nombre");
            Id = id;
            Nombre = nombre;
        }
    }
}
