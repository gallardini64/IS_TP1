using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Servicio
{

    public interface IOpServicioCallBack
    {
        [OperationContract(IsOneWay = true)]
        int BuscarUltimaOP();
    }
}
