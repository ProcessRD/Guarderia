﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Guarderia.Models
{
    public class Recogedores
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Relacion { get; set; }
    }
}