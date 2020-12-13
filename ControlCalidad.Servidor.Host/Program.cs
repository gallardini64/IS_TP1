using ControlCalidad.Servidor.Servicio;
using ControlCalidad.Servidor.Servicio.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            //ControladorOP c = new ControladorOP();
            //(ColorDto[], ModeloDto[], LineaDto[]) array = c.IniciarOP();
            //foreach (var item in array.Item1)
            //{
            //    Console.WriteLine($"color: {item.Descripcion}");
            //}
            //foreach (var item in array.Item2)
            //{
            //    Console.WriteLine($"Modelo: {item.Denominacion}");
            //}
            //foreach (var item in array.Item3)
            //{
            //    Console.WriteLine($"linea: {item.Numero}");
            //}

            ControladorEspecificacionDeDefecto c = new ControladorEspecificacionDeDefecto();
            EspecificacionDeDefectoDto[] array = c.GetEspecificaciones("Observado");
            foreach (var item in array)
            {
                Console.WriteLine($"especificacion: tipo {item.TipoDefecto.Tipo} descripcion {item.Descripcion}" );
            }



            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
        }
    }
}
