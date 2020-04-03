using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    interface iContactoDAO
    {
        //Se establece los meodos CRUD en la interfaz de la clase principal CONTACTO

        List<Contacto> ListaContactos();
        Contacto LeerPorId(int id);
        void Agregar(Contacto contacto);
        void Actualizar(Contacto contacto);
        void Eliminar(int id);

        
      
    }
}
