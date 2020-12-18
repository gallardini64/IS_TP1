using ControlCalidad.Cliente.Presentacion.Presentadores;
using ControlCalidad.Servidor.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Cliente.Presentacion.Interfaces
{
    public interface IVistaOP
    {
        
        void DesactivarControles();

        void RegistrarPar(int numero, string calidad);
        void LimpiarCamposOP();
        void CargarOpActual();
        void RegistrarDefecto(int idEspDefecto,int numero, string pie);
        void ActualizarNumeroDeDefectosTipo(int id, int numero, string pie);
        void SetPresentador(PresentadorOP presentadorOP, string usuario);
        void Desplegar();
        void ActualizarParesCalidad(int numero, string calidad);
        void MostrarMensaje(string v);
    }
}
