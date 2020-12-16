using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Dominio
{
    public abstract class EntityBase
    {
        public virtual int Id { get; set; }

        public virtual bool IsNew()
        {
            return Id == 1;
        }
    }
}
