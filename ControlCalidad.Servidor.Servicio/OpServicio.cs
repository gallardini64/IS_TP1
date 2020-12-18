using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Servicio
{
    class OpServicio : IOpServicio
    {

        private List<IOpServicioCallBack> _callbackList;

        public int Suscribirse()
        {
            IOpServicioCallBack guest =
             OperationContext.Current.GetCallbackChannel<IOpServicioCallBack>();

            if (!_callbackList.Contains(guest))
            {
                _callbackList.Add(guest);
            }
            return _callbackList.Count;
        }
        public void OpCambiaDeEstado()
        {
            _callbackList.ForEach(
            delegate (IOpServicioCallBack callback)
            { callback.BuscarUltimaOP(); });

        }
    }
}
