using ControlCalidad.Servidor.Datos;
using ControlCalidad.Servidor.Dominio;
using ControlCalidad.Servidor.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Servicio.Controladores
{
    public class ControladorOP
    {
        private Repositorio<Op> _repositorioOP = Repositorio<Op>.GetInstancia();
        private Repositorio<EspecificacionDeDefecto> _repositorioEsp = Repositorio<EspecificacionDeDefecto>.GetInstancia();
        private Repositorio<Linea> _repositorioLineas = Repositorio<Linea>.GetInstancia();
        private Repositorio<Turno> _repositorioTurnos = Repositorio<Turno>.GetInstancia();
        
        private Op _op;

        public ControladorOP()
        {
           
        }
        public (ColorDto[], ModeloDto[], LineaDto[]) IniciarOP()
        {

            var controladorLineas = new ControladorLineas();
            var controladorColor = new ControladorColor();
            var controladorModelo = new ControladorModelo();

            var colores = controladorColor.GetColores();
            var modelos = controladorModelo.GetModelos();
            var lineas = controladorLineas.GetLineas();
            _op = new Op();
            return (colores, modelos, lineas);
        }

        public bool ConfirmarOP()
        {
            return false;
        }
        public bool RegistrarPar(int numero, string calidad)
        {
            Calidad c = (Calidad) Enum.Parse(typeof(Calidad), calidad);
            return _op.RegistrarPar(numero, c);
        }

        public bool RegistrarDefecto(int idEspDefecto, int numero, string pie)
        {
            var esp = _repositorioEsp.GetFiltered(e => e.Id == idEspDefecto).FirstOrDefault();
            bool registrada = _op.RegistrarDefecto(1, esp, pie, DateTime.Now);
            _repositorioOP.Update(_op);
            return registrada;
        }

        public List<string> ObtenerHorasTurno()
        {
            return _op.HorarioActual.Turno.GetListaDeHoras();
        }

        public bool ConfirmarOP(int numero, LineaDto linea, ModeloDto modelo, ColorDto color, DateTime fecha)
        {
            var lineaC = _repositorioLineas.GetFiltered(l => l.Numero == linea.Numero && l.EstoyLibre());
            if (lineaC == null)
            {
                return false;
            }
            else
            {
                var turnos = _repositorioTurnos.GetFiltered(t => t.SoyTurnoActual()).FirstOrDefault();
                _op.Color = new Color { Codigo = color.Codigo, Descripcion = color.Descripcion };
                _op.Modelo = new Modelo { Denominacion = modelo.Denominacion, Objetivo = modelo.Objetivo, Sku = modelo.Sku };
                _op.FechaInicio = fecha;
                _op.IniciarNuevoHorario(turnos);
                _repositorioOP.Add(_op);
                return true;
            }
        }
        
    }

  
}
