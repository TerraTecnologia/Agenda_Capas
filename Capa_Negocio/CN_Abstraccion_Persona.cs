﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
   public abstract class CN_Abstraccion_Persona
    {

        private int _id;
        private string _nombre;
        private string _apellido;
        private string _telefono;

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }


        public string Telefono { get => _telefono;
            set => _telefono =  value ; }
    }
}
