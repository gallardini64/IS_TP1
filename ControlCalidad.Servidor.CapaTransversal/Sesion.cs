using ControlCalidad.Servidor.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControlCalidad.Servidor.CapaTransversal
{
    public static class Sesion
    {
        private static Empleado _empleado;
        public static Empleado GetEmpleado()

        {
            if (_empleado != null)
            {
                return _empleado;
            }
            return null;
        }

        public static void SetEmpleado(Empleado empleado)
        {
            _empleado = empleado;
        }

        public static void CerrarSesion()
        {
            _empleado = null;
        }


    }
}
