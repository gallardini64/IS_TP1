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
        public static LineaDto[] GetLineas()
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                return servicio.GetLineas();
            }
        }
    }
}
