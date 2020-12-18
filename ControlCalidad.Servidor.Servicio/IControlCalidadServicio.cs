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
        bool RegistrarDefecto(int idEspDefecto, int numero, string pie,int numeroOP , TimeSpan? hora = null);

        [OperationContract]
        bool RegistrarPar(int numero, string calidad, int numeroOP, TimeSpan? hora = null);

        [OperationContract]
        (ColorDto[], ModeloDto[], LineaDto[]) InicializarOp();

        [OperationContract]
        (bool,string) ConfirmarOP(int numero, LineaDto linea, ModeloDto modelo, ColorDto color);

        [OperationContract]
        EspecificacionDeDefectoDto[] GetEspecificacionDeDefectoTipo(string tipo);
        
        [OperationContract]
        TurnoDto ObtenerDatosDeTurnoActual(int numeroOP);

        [OperationContract]
        (bool, EmpleadoDto) IniciarSesion(string usuario, string password);

        [OperationContract]
        OpDto GetOP(string usuario);
        
        [OperationContract]
        bool PausarOP(int numero);

        [OperationContract]
        (bool,string) ReanudarOP(int numero);

        [OperationContract]
        bool FinalizarOP(int numero);

        [OperationContract]
        OpDto AsignarOPaSupervisorDeCalidad();

        [OperationContract]
        (HorarioDto,DefectoDto,ParDto) auxiliar();

    }


}
