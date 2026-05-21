using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class PIZZA_CANCHA : PIZZA
    {
        public PIZZA_CANCHA(string origen)
        {
            Nombre = "Pizza de Cancha";
            this.Origen = origen;
        }

    }
}
