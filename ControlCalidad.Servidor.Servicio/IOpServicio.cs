using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Servicio
{
    [ServiceContract(
    CallbackContract = typeof(IOpServicioCallBack))]
    public interface IOpServicio
    {
        [OperationContract()]
        int Suscribirse();

    }
}
