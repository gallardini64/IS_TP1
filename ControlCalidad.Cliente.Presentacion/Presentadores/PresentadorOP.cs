using ControlCalidad.Cliente.AccesoExterno;
using ControlCalidad.Cliente.Presentacion.Interfaces;
using ControlCalidad.Cliente.AccesoExterno.ControlCalidadServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Cliente.Presentacion.Presentadores
{
    public class PresentadorOP
    {
        private IVistaOP _vista;
        public PresentadorOP(IVistaOP vista)
        {
            _vista = vista;
        }
        public void RegistrarDefecto(int idEspDefecto,int numero,string pie) 
        {
            bool registrado = Adaptador.RegistrarDefecto(idEspDefecto,numero, pie);
            if (registrado)
            {
                _vista.ActualizarNumeroDeDefectosTipo(idEspDefecto, numero, pie);
            }
            else
            {
                _vista.ActualizarNumeroDeDefectosTipo(idEspDefecto, numero, pie);
            }
        }

        public EspecificacionDeDefectoDto[] ObtenerEspecificacionesDefectosTipo(string v)
        {
            return Adaptador.ObtenerEspecificacionesDefectosTipo(v);
        }

        
    }
}
