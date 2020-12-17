﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Servicio
{
    [DataContract]
    public class HorarioDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public DateTime Inicio { get; set; }
        [DataMember]
        public DateTime Fin { get; set; }

        [DataMember]
        public List<DefectoDto> Defectos { get; set; }
        
        [DataMember]
        public List<ParDto> Pares { get; set; }

    }
}
