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
        public LineaDto[] GetLineas()
        {
            return _controladorLineas.GetLineas();
        }





        public void prueba()
        {

        }
    }
}
