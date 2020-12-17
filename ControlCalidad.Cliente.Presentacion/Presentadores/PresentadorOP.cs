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
        public EmpleadoDto empleadoCalidad { get; set; }
        public PresentadorOP(IVistaOP vista,EmpleadoDto empleado)
        {
            empleadoCalidad = empleado;
            _vista = vista;
            _vista.SetPresentador(this, empleadoCalidad.Usuario);
            _vista.CargarOpActual();
            _vista.Desplegar();
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

        public OpDto AsignarOPaSupervisorDeCalidad()
        {
            return Adaptador.AsignarOPaSupervisorDeCalidad();
        }

        public TurnoDto ObtenerDatosDeTurnoActual(OpDto opActual)
        {
            return Adaptador.ObtenerDatosDeTurnoActual(opActual.Numero);
        }

        public EspecificacionDeDefectoDto[] ObtenerEspecificacionesDefectosTipo(string v)
        {
            return Adaptador.ObtenerEspecificacionesDefectosTipo(v);
        }

        
    }
}
