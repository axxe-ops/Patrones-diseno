using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class DIRECTORIO : COMPONENTE
    {
        private List<COMPONENTE> listaHijos;
        public List<COMPONENTE> ListaHijos
        {
            get { return listaHijos; }
            set { listaHijos = value; }
        }

        public DIRECTORIO(string nombre) : base(nombre)
        {
            listaHijos = new List<COMPONENTE>();
        }

        public override void AgregarHijo(COMPONENTE componente)
        {
            listaHijos.Add(componente);
        }

        public override List<COMPONENTE> ObtenerHijos()
        {
            return listaHijos;
        }

        public override int ObtenerTamaño()
        {
            throw new NotImplementedException();
        }

        public override void EliminarHijo(COMPONENTE componente)
        {
            listaHijos.Remove(componente);
        }
    }
}
