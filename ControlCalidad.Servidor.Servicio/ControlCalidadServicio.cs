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
        private ControladorLineas _controladorLineas = new ControladorLineas();
        private ControladorOP _controladorOP = new ControladorOP();
        private ControladorEspecificacionDeDefecto _controladorEspec = new ControladorEspecificacionDeDefecto();
        public LineaDto[] GetLineas()
        {
            return _controladorLineas.GetLineas();
        }
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

        public bool ConfirmarOP(int numero, LineaDto linea, ModeloDto modelo, ColorDto color, DateTime fecha)
        {
            return _controladorOP.ConfirmarOP(numero, linea, modelo, color, fecha);
        }
    }
}
