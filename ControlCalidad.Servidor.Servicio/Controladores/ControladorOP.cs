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


        #region Vista Supervisor De Linea

 
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
        public OpDto GetOP(string usuario)
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
        public (bool, string) ConfirmarOP(int numero, LineaDto linea, ModeloDto modelo, ColorDto color)
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

                var color1 = _repositorioColor.GetFiltered(c => c.Codigo == color.Codigo).FirstOrDefault();
                var modelo1 = _repositorioModelo.GetFiltered(m => m.Sku == modelo.Sku).FirstOrDefault();
                _op.ConfirmarOP(numero, color1, modelo1, turnoActual, lineaC, Sesion.GetEmpleado());
                _repositorioOP.Add(_op);

                return (true, "La OP se creó con éxito.");
            }
        }

        #endregion


        public OpDto AsignarOPaSupervisorDeCalidad()
        {

            Op op = _repositorioOP.GetFiltered(o => o.Estado == EstadoOP.Activa || o.Estado == EstadoOP.Pausada).FirstOrDefault();
            if (op != null)
            {
                var opE = new OpDto()
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
                var HorariosE = new List<HorarioDto>();
                foreach (var horario in op.Horarios)
                {
                    var h = new HorarioDto()
                    {
                        Id = horario.Id,
                        Inicio = horario.Inicio
                    };
                    var defectos = new List<DefectoDto>();
                    foreach (var defecto in horario.Defectos)
                    {
                        var espD = new EspecificacionDeDefectoDto()
                        {
                            Descripcion = defecto.EspecificacionDeDefecto.Descripcion,
                            Id = defecto.EspecificacionDeDefecto.Id,
                            TipoDefecto = defecto.EspecificacionDeDefecto.TipoDefecto.ToString()
                        };

                        var d = new DefectoDto()
                        {
                            EspecificacionDeDefecto = espD,
                            Pie = defecto.Pie.ToString(),
                            Hora = defecto.Hora
                        };
                        defectos.Add(d);
                    }
                    h.Defectos = defectos;
                    var pares = new List<ParDto>();
                    foreach (var par in horario.Pares)
                    {
                        var p = new ParDto()
                        {
                            calidad = par.Calidad.ToString()
                        };
                        pares.Add(p);
                    }
                    h.Pares = pares;
                    HorariosE.Add(h);
                }

                opE.Horarios = HorariosE;


                return opE;
            }
            return null;
            

        }
        public bool RegistrarPar(int numero, string calidad, int numeroOP)
        {
            Calidad c = (Calidad) Enum.Parse(typeof(Calidad), calidad);
            _op = _repositorioOP.GetFiltered(o => o.Numero == numeroOP).FirstOrDefault();
            bool bandera = _op.RegistrarPar(numero, c, Sesion.GetEmpleado());
            _repositorioOP.Update(_op);
            return bandera;
        }
        public bool RegistrarDefecto(int idEspDefecto, int numero, string pie, int numeroOP)
        {
            var esp = _repositorioEsp.GetFiltered(e => e.Id == idEspDefecto).FirstOrDefault();
            _op = _repositorioOP.GetFiltered(o => o.Numero == numeroOP).FirstOrDefault();
            bool registrada = _op.RegistrarDefecto(1, esp, pie, DateTime.Now,Sesion.GetEmpleado());
            _repositorioOP.Update(_op);
            return registrada;
        }

        public TurnoDto ObtenerDatosDeTurno(int numeroOP)
        {
            _op = _repositorioOP.GetFiltered(o => o.Numero == numeroOP).FirstOrDefault();
            Turno t = _op.Horarios.LastOrDefault().Turno;
            return new TurnoDto() { Id = t.Id, Inicio = t.Inicio, Fin = t.Fin, Descripcion = t.Descripcion, Horas = t.GetListaDeHoras() };
        }
        
    }

  
}
