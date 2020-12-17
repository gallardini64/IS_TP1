using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlCalidad.Servidor.Datos;
using ControlCalidad.Servidor.Dominio;
using ControlCalidad.Servidor.CapaTransversal;

namespace ControlCalidad.Servidor.Servicio.Controladores
{
    class ControladorEmpleados
    {
        private Repositorio<Empleado> _repositorio = Repositorio<Empleado>.GetInstancia();
        private Repositorio<Op> _repositorioOPs = Repositorio<Op>.GetInstancia();

        public ControladorEmpleados()
        {

        }

        public (bool, EmpleadoDto) OtorgarPermisoDeSesion(string usuario, string password)
        {
            Empleado empleado = _repositorio.GetFiltered(e => e.Usuario == usuario && e.Contrasenia == password).FirstOrDefault();



            if (empleado != null)
            {
                if (empleado.Rol == Rol.SupervisorCalidad)//consultar
                {
                    if (_repositorioOPs.GetFiltered(op => op.Estado == EstadoOP.Activa) == null)
                    {
                        return (false, new EmpleadoDto());
                    }
                }


                EmpleadoDto emp = new EmpleadoDto()
                {
                    Usuario = empleado.Usuario,
                    Rol = empleado.Rol.ToString(),
                    Nombre = empleado.Nombre
                };
                Sesion.SetEmpleado(empleado);
                return (true, emp);



            }//TODO controlar que si no hay una op el supervisor de calidad no puede iniciar sesion
            return (false, null);
        }
    }
}
