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
        private Op _op;
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

        public bool RegistrarDefecto(int idEspDefecto, int numero, string pie)
        {
            var esp = _repositorioEsp.GetFiltered(e => e.Id == idEspDefecto).FirstOrDefault();
            bool registrada = _op.RegistrarDefecto(1, esp, pie, DateTime.Now);





            return registrada;
        }
        public bool FinalizarOp(OpDto op)
        {
            throw new NotImplementedException();
        }
    }

  
}
