using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Dominio
{
    public class Linea: EntityBase
    {
        public int Numero { get; set; }
        public virtual ICollection<Op> OPs{ get; set; }

        public Linea()
        {

        }
        public bool EstoyLibre()
        {
            foreach (var op in OPs)
            {
                if (op.Estado == EstadoOP.Activa || op.Estado == EstadoOP.Pausada)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
