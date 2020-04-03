using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dato;

namespace Capa_Negocio
{
    class ContactoDAOImpl : iContactoDAO
    {
        private string a;
        LogEvent GuardarError = new LogEvent();
     

        public void Actualizar(Contacto contacto)
        {
            a  =  ("Usuario " + contacto.Nombre + " actualizado");
           
        }

        public void Agregar(Contacto contacto)
        {
            try
            {
            using (AgendaElectronicaEntities db = new AgendaElectronicaEntities ())
            {
                var objDB = new Contactos();
                    {
                    objDB.Id = contacto.Id;
                    objDB.Nombre = contacto.Nombre;
                    objDB.Apellido = contacto.Apellido;
                    objDB.telefono = contacto.Telefono;
                }
                db.Contactos.Add(objDB);
                db.SaveChanges();

            }

                a = ("Usuario " + contacto.Nombre + " Agregado a la base de datos");

            }
            catch (Exception a)
            {

                GuardarError.RegistrarEvento(a);
                throw;
            }
                      
        }

        public void Eliminar(int id)
        {
             a = ("Usuario  eliminado");
        }

        public Contacto LeerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contacto> ListaContactos()
        {

            List<Contactos> lstDB= new List<Contactos>();
                List<Contacto> lstContactoDAO = new List<Contacto>();
           
            using (AgendaElectronicaEntities db = new AgendaElectronicaEntities ())
            {
                var query =  from a in db.Contactos
                             where a.Id!=0
                            select new { a.Nombre ,a.Apellido } ;

                var res = query.ToList();
                lstContactoDAO.Equals(res);
                return lstContactoDAO;
                
               
            }
        }

       
    }
}
