using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class PIZZERIA_ARGENTINA : Pizzeria
    {
        public override PIZZA CrearPizza(string tipo)
        {
            if(tipo == "Cancha")
            {
                return new PIZZA_CANCHA("Argentina");
            }
            else if(tipo == "Napo")
            {
                return new PIZZA_NAPO_("Argentina");
            }
            else
            {
                return null;
            }
        }
    }
}
