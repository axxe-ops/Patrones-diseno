using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class ARCHIVO : COMPONENTE
    {

        private int tamaño;
        public int Tamaño
        {
            get { return tamaño; }
            set { tamaño = value; }
        }

        public ARCHIVO(string nombre, int tamaño) : base(nombre)
        {            
            this.tamaño = tamaño;
        }
        public override void AgregarHijo(COMPONENTE componente)
        {
            throw new NotImplementedException();
        }

        public override void EliminarHijo(COMPONENTE componente)
        {
            throw new NotImplementedException();
        }

        public override List<COMPONENTE> ObtenerHijos()
        {
            throw new NotImplementedException();
        }

        public override int ObtenerTamaño()
        {
            return Tamaño;
        }

        public override string ToString()
        {
            return " " + Nombre + " " + Tamaño + " Kb" ;
        }
    }
}
