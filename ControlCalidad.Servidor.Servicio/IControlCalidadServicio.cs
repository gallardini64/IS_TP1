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
        bool RegistrarDefecto(int idEspDefecto, int numero, string pie);

        [OperationContract]
        bool FinalizarOp(OpDto op);

        [OperationContract]
        (ColorDto[], ModeloDto[], LineaDto[]) InicializarOp();

        [OperationContract]
        (bool,string) ConfirmarOP(int numero, LineaDto linea, ModeloDto modelo, ColorDto color);

        [OperationContract]
        EspecificacionDeDefectoDto[] GetEspecificacionDeDefectoTipo(string tipo);
        
        [OperationContract]
        List<string> ObtenerHorasDeTurnoActual();

        [OperationContract]
        (bool, EmpleadoDto) IniciarSesion(string usuario, string password);

        [OperationContract]
        OpDto GetOP(string usuario);
        
        [OperationContract]
        bool PausarOP(int numero);
        [OperationContract]
        (bool,string) ReanudarOP(int numero);

        

    }


}
