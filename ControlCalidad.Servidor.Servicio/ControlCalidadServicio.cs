using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ControlCalidad.Servidor.Datos;
using ControlCalidad.Servidor.Servicio.Controladores;

namespace ControlCalidad.Servidor.Servicio
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class ControlCalidadServicio : IControlCalidadServicio
    {

        private ControladorOP _controladorOP = new ControladorOP();
        private ControladorEspecificacionDeDefecto _controladorEspec = new ControladorEspecificacionDeDefecto();
        private ControladorEmpleados _controladorEmpleado = new ControladorEmpleados();
        private static List<IControlCalidadServicioCallback> _callbackList = new List<IControlCalidadServicioCallback>();
        private static event EventHandler<(string,int)> opCambiaDeEstado;


        public bool RegistrarDefecto(int idEspDefecto, int numero, string pie, int numeroOP, TimeSpan? hora = null)
        {
            return _controladorOP.RegistrarDefecto(idEspDefecto, numero, pie, numeroOP, hora);
        }

        public bool RegistrarPar(int numero, string calidad, int numeroOP, TimeSpan? hora = null)
        {
            return _controladorOP.RegistrarPar(numero, calidad, numeroOP, hora);
        }


        public (ColorDto[], ModeloDto[], LineaDto[]) InicializarOp()
        {
            return _controladorOP.IniciarOP();
        }
        public EspecificacionDeDefectoDto[] GetEspecificacionDeDefectoTipo(string tipo)
        {
            return _controladorEspec.GetEspecificaciones(tipo);
        }

        public (bool, string) ConfirmarOP(int numero, LineaDto linea, ModeloDto modelo, ColorDto color)
        {
            return _controladorOP.ConfirmarOP(numero, linea, modelo, color);
        }

        public (bool, EmpleadoDto) IniciarSesion(string usuario, string password)
        {

            return _controladorEmpleado.OtorgarPermisoDeSesion(usuario, password);
        }

        public OpDto GetOP(string usuario)
        {
            return _controladorOP.GetOP(usuario);
        }

        public bool PausarOP(int numero)
        {
            return _controladorOP.PausarOP(opCambiaDeEstado,numero);
        }

        public (bool, string) ReanudarOP(int numero)
        {
            return _controladorOP.ReanudarOP(opCambiaDeEstado, numero);
        }

        public bool FinalizarOP(int numero)
        {
            return _controladorOP.FinalizarOP(opCambiaDeEstado, numero);
        }

        public OpDto AsignarOPaSupervisorDeCalidad()
        {
            return _controladorOP.AsignarOPaSupervisorDeCalidad();
        }

        public TurnoDto ObtenerDatosDeTurnoActual(int numeroOP)
        {
            return _controladorOP.ObtenerDatosDeTurno(numeroOP);
        }

        public (HorarioDto, DefectoDto, ParDto) auxiliar()
        {
            return (null, null, null);
        }

        public void SeHaPausadoOP(object sender,(string estado,int numeroOP) tupla)
        {
            _callbackList.ForEach(
                delegate (IControlCalidadServicioCallback callback)
                { callback.OnOPCambiaDeEstado(tupla.estado,tupla.numeroOP); });
        }

        public void Suscribirse()
        {

            IControlCalidadServicioCallback guest =
             OperationContext.Current.GetCallbackChannel<IControlCalidadServicioCallback>();
            opCambiaDeEstado += SeHaPausadoOP;
            if (!_callbackList.Contains(guest))
            {
                _callbackList.Add(guest);
            }

        }
    }
}
