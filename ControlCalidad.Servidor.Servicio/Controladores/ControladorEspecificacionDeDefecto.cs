﻿using ControlCalidad.Servidor.Datos;
using ControlCalidad.Servidor.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Servicio.Controladores
{
    public class ControladorEspecificacionDeDefecto
    {
        private Repositorio<EspecificacionDeDefecto> _repositorio = Repositorio<EspecificacionDeDefecto>.GetInstancia();

        public EspecificacionDeDefectoDto[] GetEspecificaciones()
        {
            return _repositorio.GetAll().Select(especificacion => new EspecificacionDeDefectoDto
            {

                Id = especificacion.Id,

                Descripcion = especificacion.Descripcion,
                TipoDefecto = especificacion.TipoDefecto.ToString(),

            }).ToArray();
            
        }

        public EspecificacionDeDefectoDto[] GetEspecificaciones(string tipo = null)
        {
            if (tipo == null)
            {
                return _repositorio.GetAll().Select(especificacion => new EspecificacionDeDefectoDto
                {

                    Id = especificacion.Id,

                    Descripcion = especificacion.Descripcion,
                    TipoDefecto = especificacion.TipoDefecto.ToString(),
                }).ToArray();
            }
            return _repositorio.GetAll().Where(e => e.TipoDefecto.ToString() == tipo).Select(especificacion => new EspecificacionDeDefectoDto
            {

                Id = especificacion.Id,

                Descripcion = especificacion.Descripcion,
                TipoDefecto = especificacion.TipoDefecto.ToString(),
            }).ToArray();
        }

    }
}
