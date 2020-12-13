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
        private Repositorio<Op> _repositorio = Repositorio<Op>.GetInstancia();

        public (ColorDto[], ModeloDto[], LineaDto[]) IniciarOP()
        {

            var controladorLineas = new ControladorLineas();
            var controladorColor = new ControladorColor();
            var controladorModelo = new ControladorModelo();

            var colores = controladorColor.GetColores();
            var modelos = controladorModelo.GetModelos();
            var lineas = controladorLineas.GetLineas();

            return (colores, modelos, lineas);
        }


        public bool FinalizarOp(OpDto op)
        {
            throw new NotImplementedException();
        }
    }

  
}
