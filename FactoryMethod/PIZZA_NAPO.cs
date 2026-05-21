using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class PIZZA_NAPO_ : PIZZA
    {
        public PIZZA_NAPO_(string origen)
        {
            Nombre = "Pizza de Napolitana";
            this.Origen = origen;
        }

    }
}
