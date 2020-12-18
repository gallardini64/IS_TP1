using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlCalidad.Cliente.AccesoExterno.ControlCalidadServiceReference;


namespace ControlCalidad.Cliente.AccesoExterno
{
    public static class Adaptador
    {
        // cambio en el adaptador
       

        public static EspecificacionDeDefectoDto[] ObtenerEspecificacionesDefectosTipo(string tipo = null)
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                return servicio.GetEspecificacionDeDefectoTipo(tipo);
            }
        }
        public static bool RegistrarDefecto(int idEspDefecto, int numero, string pie,int numeroOP,TimeSpan? hora = null)
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                return servicio.RegistrarDefecto(idEspDefecto,numero,pie,numeroOP,hora);
            }
        }
        public static bool RegistrarPar(int numero, string calidad,int numeroOP, TimeSpan? hora = null)
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                return servicio.RegistrarPar(numero,calidad,numeroOP,hora);
            }
        }

        public static (ColorDto[], ModeloDto[], LineaDto[]) InicializarOp()
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                return servicio.InicializarOp();
            }
        }

        
        public static OpDto GetOP(string usuario)
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                return servicio.GetOP(usuario);
            }
        }

        public static OpDto AsignarOPaSupervisorDeCalidad()
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                return servicio.AsignarOPaSupervisorDeCalidad();
            }
        }

        public static (bool,string) ReanudarOP(int numero)
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                return servicio.ReanudarOP(numero);
            }
        }

        public static bool FinalizarOP(int numero)
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                return servicio.FinalizarOP(numero);
            }
        }

        public static bool PausarOP(int numero)
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                return servicio.PausarOP(numero);
            }
        }

        public static TurnoDto ObtenerDatosDeTurnoActual(int numeroOP)
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                return servicio.ObtenerDatosDeTurnoActual(numeroOP);
            }
        }
        public static (bool,string) ConfirmarOP(int numero, LineaDto linea, ModeloDto modelo, ColorDto color)
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                return servicio.ConfirmarOP(numero,linea,modelo,color);
            }
        }

        public static (bool, EmpleadoDto) IniciarSesion(string usuario, string password)
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                return servicio.IniciarSesion(usuario, password);
            }
        }

        public static (HorarioDto,DefectoDto,ParDto) auxiliar()
        {
            using (var servicio = new ControlCalidadServiceReference.ControlCalidadServicioClient())
            {
                return servicio.auxiliar();
            }
        }


    }
}
