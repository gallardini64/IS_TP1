﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidad.Servidor.Dominio
{
    public class Empleado : EntityBase
    {
        public int Documento { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }

    }
}
