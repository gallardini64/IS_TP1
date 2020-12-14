using ControlCalidad.Servidor.Dominio.CapaTransversal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Servicio.CapaTransversal
{
    public class FactoriaDeEstrategias
    {
        private static FactoriaDeEstrategias Instancia { get; set; } = null;

        public static FactoriaDeEstrategias GetInstancia()
        {
            return Instancia ?? (Instancia = new FactoriaDeEstrategias());
        }

        protected FactoriaDeEstrategias()
        {

        }

        public EstrategiaTiempoLimite GetEstrategiaTiempoLimite()
        {
            return new EstrategiaTiempoLimite();
        }
    }
}
