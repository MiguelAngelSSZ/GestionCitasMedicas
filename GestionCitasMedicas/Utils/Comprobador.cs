using System;
using System.Collections.Generic;
using System.Text;

namespace GestionCitasMedicas.Utils
{
    public static class Comprobador
    {
        public static void ComprobarCadena(string valor, string nombreCampo)
        {
            if (string.IsNullOrEmpty(valor))
                throw new ArgumentNullException("Debe ingresar un valor", nombreCampo);
        }
                    public static void ComprobarFechaFutura(DateTime fecha)
        {
            if (fecha <= DateTime.Now)
                throw new ArgumentException("La cita debe programarse para una fecha futura", "fecha");
        }
    }

}