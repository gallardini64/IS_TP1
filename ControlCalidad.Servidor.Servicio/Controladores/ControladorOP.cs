using ControlCalidad.Servidor.Datos;
using ControlCalidad.Servidor.Dominio;
using ControlCalidad.Servidor.CapaTransversal;
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
        private Repositorio<Color> _repositorioColor = Repositorio<Color>.GetInstancia();
        private Repositorio<Modelo> _repositorioModelo = Repositorio<Modelo>.GetInstancia();
        private Repositorio<Horario> _repositorioHorario = Repositorio<Horario>.GetInstancia();
        
        private Op _op;

        public ControladorOP()
        {
           
        }

        public (ColorDto[], ModeloDto[], LineaDto[]) IniciarOP()
        {

            var colores = _repositorioColor.GetAll().Select(color => new ColorDto
            {
                Id = color.Id,
                Descripcion = color.Descripcion,
                Codigo = color.Codigo,

            }).ToArray();
           

            var modelos = _repositorioModelo.GetAll().Select(modelo => new ModeloDto()
            {
                Id = modelo.Id,
                Sku = modelo.Sku,
                Objetivo = modelo.Objetivo,
                Denominacion = modelo.Denominacion,

            }).ToArray();
            

            var lineas = _repositorioLineas
                .GetAll()
                .Select(l => new LineaDto
                {
                    Id = l.Id,
                    Numero = l.Numero,
                })
                .ToArray();
          
            
            return (colores, modelos, lineas);
        }

        public bool FinalizarOP(int numero)
        {
            _op = _repositorioOP.GetFiltered(o => o.Numero == numero).FirstOrDefault();
            if (_op == null)
            {
                return false;
            }
            _op.FinalizarOP();
            _repositorioOP.Update(_op);
            return true;
        }

        public (bool,string) ReanudarOP(int numero)
        {
            _op = _repositorioOP.GetFiltered(o => o.Numero == numero).FirstOrDefault();

            Turno turnoActual = null;
            var turnos = _repositorioTurnos.GetAll();

            if (turnos == null)
            {
                return(false, "No hay turnos disponibles.");
            }
            foreach (var turno in turnos)
            {
                if (turno.SoyTurnoActual())
                {
                    turnoActual = turno;
                    break;
                }
            }
            if (turnoActual == null)
            {
                return (false, "No existe turno para este horario.");
            }


            _op.ReanudarOP(turnoActual);
            _repositorioOP.Update(_op);
            return (true, null);
            
        }

        public bool PausarOP(int numero)
        {
            _op = _repositorioOP.GetFiltered(o => o.Numero == numero).FirstOrDefault();
            _op.PausarOP();
            try
            {
                _repositorioOP.Update(_op);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        internal OpDto GetOP(string usuario)
        {
            Op op = _repositorioOP.GetFiltered(o => o.Empleado.Usuario == usuario && o.Estado != EstadoOP.Finalizada).FirstOrDefault();
            if (op == null)
            {
                return null;
            }
            return new OpDto()
            {
                Numero = op.Numero,
                Modelo = new ModeloDto
                {
                    Denominacion = op.Modelo.Denominacion,
                    Objetivo = op.Modelo.Objetivo
                },
                Linea = new LineaDto
                {
                    Numero = op.Linea.Numero
                },
                Color = new ColorDto
                {
                    Descripcion = op.Color.Descripcion
                },
                FechaInicio = op.FechaInicio,
                Estado = op.Estado.ToString()
            };
        }

        public bool RegistrarPar(int numero, string calidad)
        {
            Calidad c = (Calidad) Enum.Parse(typeof(Calidad), calidad);
            bool bandera = _op.RegistrarPar(numero, c, Sesion.GetEmpleado());
            _repositorioOP.Update(_op);
            return bandera;
        }

        public bool RegistrarDefecto(int idEspDefecto, int numero, string pie)
        {
            var esp = _repositorioEsp.GetFiltered(e => e.Id == idEspDefecto).FirstOrDefault();
            _repositorioEsp.Dispose();
            bool registrada = _op.RegistrarDefecto(1, esp, pie, DateTime.Now,Sesion.GetEmpleado());
            _repositorioOP.Update(_op);
            return registrada;
        }

        public List<string> ObtenerHorasTurno()
        {
            return _op.Horarios.LastOrDefault().Turno.GetListaDeHoras();
        }

        public (bool,string) ConfirmarOP(int numero, LineaDto linea, ModeloDto modelo, ColorDto color)
        {
            _op = new Op();
            var lineaC = _repositorioLineas.GetFiltered(l => l.Numero == linea.Numero).FirstOrDefault();
          
            if (lineaC == null || !lineaC.EstoyLibre())
            {
                return (false, "Linea Opcupada o inexistente");
            }
            else
            {
                Turno turnoActual = null;
                var turnos = _repositorioTurnos.GetAll();
                
                if (turnos == null)
                {
                    return (false, "No hay turnos disponibles.");
                }
                foreach (var turno in turnos)
                {
                    if(turno.SoyTurnoActual())
                    {
                        turnoActual = turno;
                        break;
                    }
                }
                if(turnoActual == null)
                {
                    return (false, "No existe turno para este horario.");
                }
                
                var color1 = _repositorioColor.GetFiltered(c => c.Codigo == color.Codigo).FirstOrDefault();
                var modelo1 = _repositorioModelo.GetFiltered(m => m.Sku == modelo.Sku).FirstOrDefault();
                _op.ConfirmarOP(numero,color1, modelo1, turnoActual, lineaC,Sesion.GetEmpleado());
                _repositorioOP.Add(_op);
               
                

                return (true,"La OP se creó con éxito.");
            }
        }
        
    }

  
}
