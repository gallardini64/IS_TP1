using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlCalidad.Cliente.AccesoExterno.ControlCalidadServiceReference;
using ControlCalidad.Servidor.Servicio.Entidades;

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
                return servicio.ObtenerEspecificacionesDeDefectosTipo(tipo);
            }
        }
    }
}
