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
    
    public class ControlCalidadServicio : IControlCalidadServicio
    {
        
        private ControladorOP _controladorOP = new ControladorOP();
        private ControladorEspecificacionDeDefecto _controladorEspec = new ControladorEspecificacionDeDefecto();
        private ControladorEmpleados _controladorEmpleado = new ControladorEmpleados();
        
        public bool RegistrarDefecto(int idEspDefecto, int numero, string pie)
        {
            return _controladorOP.RegistrarDefecto(idEspDefecto, numero, pie);
        }

        public bool FinalizarOp(OpDto op)
        {
            // return _controladorOP.FinalizarOp(op);
            return false;
        }

        public (ColorDto[], ModeloDto[], LineaDto[]) InicializarOp()
        {
            return _controladorOP.IniciarOP();
        }
        public EspecificacionDeDefectoDto[] GetEspecificacionDeDefectoTipo(string tipo)
        {
            return _controladorEspec.GetEspecificaciones(tipo);
        }

        public (bool,string)ConfirmarOP(int numero, LineaDto linea, ModeloDto modelo, ColorDto color)
        {
            return _controladorOP.ConfirmarOP(numero, linea, modelo, color);
        }

        public List<string> ObtenerHorasDeTurnoActual()
        {
            return _controladorOP.ObtenerHorasTurno();
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
            return _controladorOP.PausarOP(numero);
        }

        public (bool,string) ReanudarOP(int numero)
        {
            return _controladorOP.ReanudarOP(numero);
        }
    }
}
