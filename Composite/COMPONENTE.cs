using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class COMPONENTE
    {
		private string nombre;
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		public COMPONENTE(string nombre)
		{
			this.nombre = nombre;
		}

		public abstract void AgregarHijo(COMPONENTE componente);

		public abstract void EliminarHijo(COMPONENTE componente);

		public abstract List<COMPONENTE> ObtenerHijos();

		public abstract int ObtenerTamaño();




	}
}
