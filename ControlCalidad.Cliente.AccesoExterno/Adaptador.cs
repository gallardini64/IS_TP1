using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlCalidad.Cliente.AccesoExterno.ControlCalidadServiceReference;


namespace ControlCalidad.Cliente.AccesoExterno
{
    public static class Adaptador
    {
        // cambio en el adaptador
        public static LineaDto[] GetLineas()
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                return servicio.GetLineas();
            }
        }

        public static EspecificacionDeDefectoDto[] ObtenerEspecificacionesDefectosTipo(string tipo)
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                return servicio.GetEspecificacionDeDefectoTipo(tipo);
            }
        }
        public static bool RegistrarDefecto(int idEspDefecto, int numero, string pie)
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                return servicio.RegistrarDefecto();
            }
        }
    }
}
