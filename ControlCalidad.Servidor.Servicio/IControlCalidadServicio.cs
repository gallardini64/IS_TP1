using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ControlCalidad.Servidor.Servicio
{
    
    [ServiceContract]
    public interface IControlCalidadServicio
    {
        [OperationContract]
        LineaDto[] GetLineas();

        [OperationContract]
        bool RegistrarDefecto();

        [OperationContract]
        bool FinalizarOp(OpDto op);

        [OperationContract]
        (ColorDto[], ModeloDto[], LineaDto[]) InicializarOp();

        [OperationContract]
        EspecificacionDeDefectoDto[] GetEspecificacionDeDefectoTipo(string tipo);


    }

    
}
