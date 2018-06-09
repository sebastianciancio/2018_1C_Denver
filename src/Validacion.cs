using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel
{
    public class Validacion
    {
        public Validacion()
        {
        }

        public static bool esInicial(string texto)
        {

            return texto == "";

        }
        public static bool checkListVacia(CheckedListBox list)
        {

            return list.SelectedItems.Count == 0;
        }
    }
}