using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Capa_Negocio
{
    class LogEvent
    {

        

        public void RegistrarEvento ( Exception ex )
        {
            string path = "@C:/Users/KMC/Google Drive/Proyectos Visual Studio 2019/LogError.txt";

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine("-----------------------------------------------------------------------------");
                writer.WriteLine("Fecha : " + DateTime.Now.ToString());
                writer.WriteLine();

                while (ex != null)
                {
                    writer.WriteLine(ex.GetType().FullName);
                    writer.WriteLine("Mensaje : " + ex.Message);
                    writer.WriteLine("Numero de Informe : " + ex.StackTrace);

                    ex = ex.InnerException;
                }
            }
        }
    }
}
