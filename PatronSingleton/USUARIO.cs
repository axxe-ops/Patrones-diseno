using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronSingleton
{
    public class USUARIO
    {
		private string nombre;
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private string contraseña;
		public string Contraseña
		{
			get { return contraseña; }
			set { contraseña = value; }
		}

        public override string ToString()
        {
            return Nombre;
        }

	}
}
