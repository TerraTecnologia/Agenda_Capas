using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
   public abstract class CN_Abstraccion_Persona
    {

        private string _nombre;
        private string _apellido;
        private string _telefono;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }

        public abstract bool InsertarEnDB();
        public abstract bool BorrarEnDB();
        public abstract bool ActualizarEnDB();
        public abstract bool list<LeerEnDB>();





    }
}
