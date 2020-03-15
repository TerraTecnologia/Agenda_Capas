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
            MessageBox.Show("Solo numeros admitidos");
             return true;
    }
        public static bool SoloNumero(TextBox T1, TextBox T2)
        {
            MessageBox.Show("Solo numeros admitidos");
            return true;
        }
        public static bool SoloNumero(TextBox T1, TextBox T2, TextBox T3)
        {
            MessageBox.Show("Solo numeros admitidos");
            return true;
        }




    }

}
