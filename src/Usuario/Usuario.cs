using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel
{
    public class Usuario
    {
        private string apellido;
        private string nombre;
        private string id;
        private string rol;

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Rol
        {
            get { return this.rol; }
            set { this.rol = value; }
        }
        public Usuario()
        {
            this.apellido = "";
            this.nombre = "";
            this.id = "";
            this.rol = "";
        }
    }
}
