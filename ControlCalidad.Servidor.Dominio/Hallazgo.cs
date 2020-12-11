using System;

namespace ControlCalidad.Servidor.Dominio
{
    public class Hallazgo
    {
        public DateTime Hora { get; set; }
        public int Cantidad { get; set; }
        public Pie Pie { get; set; }

        public Hallazgo(Pie pie, string descripcion)
        {
            Pie = pie;
                    
        }
    }
}