using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Negocio
{
   static public class CN_Validaciones
    {

        //Solo numero Validacion

        public static bool SoloNumero(TextBox  T1)
    {
            try
            {
                int a;

                a = int.Parse(T1.ToString());
                return true;

            }
            catch 
            {

               
                return false;

            }

            
    }
        public static bool SoloNumero(TextBox T1, TextBox T2)
        {
            try
            {
                int a;

                a = int.Parse(T1.ToString());
                return true;

            }
            catch
            {


                return false;

            }
        }
        public static bool SoloNumero(TextBox T1, TextBox T2, TextBox T3)
        {
            try
            {
                int a;

                a = int.Parse(T1.ToString());
                return true;

            }
            catch
            {


                return false;

            }
        }




    }

}
