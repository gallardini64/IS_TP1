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

        public bool RegistrarDefecto()
        {
            throw new NotImplementedException();
        }

        public bool FinalizarOp(OpDto op)
        {
            return _controladorOP.FinalizarOp(op);
        }

        public (ColorDto[], ModeloDto[], LineaDto[]) InicializarOp()
        {
            return _controladorOP.IniciarOP();
        }

        public EspecificacionDeDefectoDto[] GetEspecificacionDeDefectoTipo(string tipo)
        {
            return _controladorEspec.GetEspecificaciones(tipo);
        }

        public void Prueba()
        {

        }
    }
}
