using ControlCalidad.Cliente.AccesoExterno;
using ControlCalidad.Cliente.AccesoExterno.ControlCalidadServiceReference;
using ControlCalidad.Cliente.Presentacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Cliente.Presentacion.Presentadores
{
    public class PresentadorLinea: IControlCalidadServicioCallback
    {
        private IVistaSupervisorDeLinea _vista;
        private IVistaLineaProduccion _vistaPantalla;
        public EmpleadoDto empleadoLinea { get; set; }
        public PresentadorLinea(IVistaSupervisorDeLinea vista,IVistaLineaProduccion vistaPantalla,EmpleadoDto empleado)
        {
            Adaptador.SetContexto(this);
            empleadoLinea = empleado;
            _vista = vista;
            _vistaPantalla = vistaPantalla;
            _vista.SetPresentador(this,empleado.Usuario);
            _vistaPantalla.Desplegar();
            _vista.Desplegar();
        }


        public void ActualizarPantalla(OpDto opActual)
        {
            var turno = Adaptador.ObtenerDatosDeTurnoActual(opActual.Numero);
            _vistaPantalla.ActualizarDatosDeOPActual(opActual);
            _vistaPantalla.ActualizarTurno(turno);
            _vistaPantalla.CargarEspecificaciones(Adaptador.ObtenerEspecificacionesDefectosTipo());
          
        }


        public (ColorDto[], ModeloDto[], LineaDto[]) IniciarOP()
        {
            return Adaptador.InicializarOp();
        }

        public (bool,string) ConfirmarOP(int numero, LineaDto linea, ModeloDto modelo, ColorDto color)
        {
            return Adaptador.ConfirmarOP(numero, linea, modelo, color);
        }

        public OpDto GetOp(string usuario)
        {
            return Adaptador.GetOP(usuario);
        }

        public bool PausarOP(int numero)
        {
            return Adaptador.PausarOP(numero);
        }

        public (bool,string) ReanudarOP(int numero)
        {
           return Adaptador.ReanudarOP(numero);
        }

        public bool FinalizarOP(int numero)
        {
           return Adaptador.FinalizarOP(numero);
        }

        public void OnOPCambiaDeEstado(string estado, int numeroOP)
        {
            
        }
    }
}
