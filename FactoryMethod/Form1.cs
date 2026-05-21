using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> listaDePizzas = new List<string>();
            listaDePizzas.Add("Cancha");
            listaDePizzas.Add("Napo");

            List<string> listaDePizzerias = new List<string>();
            listaDePizzerias.Add("Argentina");
            listaDePizzerias.Add("Italiana");

            cmbTipoPizza.Items.AddRange(listaDePizzas.ToArray());
            cmbPizzeria.Items.AddRange(listaDePizzerias.ToArray());
        }

        private void btnOrdenarPizza_Click(object sender, EventArgs e)
        {

            if(cmbPizzeria.SelectedItem != null && cmbTipoPizza.SelectedItem != null)
            {
                Pizzeria fabricaPizzeria;

                string pizzeriaSeleccionada = cmbPizzeria.SelectedItem.ToString();
                string tipoPizzaSeleccionada = cmbTipoPizza.SelectedItem.ToString();

                if (pizzeriaSeleccionada == "Argentina")
                {
                    fabricaPizzeria = new PIZZERIA_ARGENTINA();

                }
                else if (pizzeriaSeleccionada == "Italiana")
                {
                    fabricaPizzeria = new PIZZERIA_ITALIANA();
                }
                else
                {
                    fabricaPizzeria = null;
                }

                PIZZA pizza = fabricaPizzeria.CrearPizza(tipoPizzaSeleccionada);

                if(pizza != null)
                {
                    lblResultado.Text = "Resultado de la orden: " + "\n Nombre: " + pizza.Nombre + "\n Tipo: " + pizza.Origen;
                }
                else
                {
                    lblResultado.Text = "No se pudo cocinar esta pizza, lo sentimos!";
                }


            }
            else
            {
                MessageBox.Show("Debes completar todos los campos antes de ordenar.");
            }


        }

        
    }
}
