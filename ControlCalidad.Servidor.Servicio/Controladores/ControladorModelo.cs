using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlCalidad.Servidor.Datos;
using ControlCalidad.Servidor.Dominio;
using ControlCalidad.Servidor.Servicio;

namespace ControlCalidad.Servidor.Servicio.Controladores
{
    class ControladorModelo
    {
        private Repositorio<Modelo> _repositorio = Repositorio<Modelo>.GetInstancia();

        public ModeloDto[] GetModelos()
        {
            return _repositorio.GetAll().Select(modelo => new ModeloDto()
            {
                Sku = modelo.Sku,
                Objetivo = modelo.Objetivo,
                Denominacion = modelo.Denominacion,

            }).ToArray();
        }
    }
}
