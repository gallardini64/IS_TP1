using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ControlCalidad.Servidor.Datos;

namespace ControlCalidad.Servidor.Servicio
{
    
    public class ControlCalidadServicio : IControlCalidadServicio
    {
        private Repositorio _repositorio = Repositorio.GetInstancia();
        public LineaDto[] GetLineas()
        {
            return _repositorio
                .GetLineas()
                .Select(l => new LineaDto
                    {
                        Numero = l.Numero,
                    })
                .ToArray();
        }
        public void prueba()
        {

        }
    }
}
