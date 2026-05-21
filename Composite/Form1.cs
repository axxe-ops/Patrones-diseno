using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Composite
{
    public partial class Form1 : Form
    {
        private DIRECTORIO raiz;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            raiz = new DIRECTORIO("Mi PC");
            CargarArbolVirtual();
        }


        public void CargarArbolVirtual()
        {
            trvEstructura.Nodes.Clear();

            // Creamos el nodo visual principal
            TreeNode nodoRaizVisual = new TreeNode(raiz.Nombre);
            nodoRaizVisual.Tag = raiz;

            // Llamamos a una función que arme las ramas recursivamente
            ArmarRamasVisuales(raiz, nodoRaizVisual);

            trvEstructura.Nodes.Add(nodoRaizVisual);
            trvEstructura.ExpandAll(); // Muestra todo desplegado
        }

        // RECURSIVIDAD VISUAL: Mapea nuestro Composite al TreeView
        private void ArmarRamasVisuales(COMPONENTE componentePadre, TreeNode nodoVisualPadre)
        {
            // Si es un directorio, recorremos sus hijos
            if (componentePadre is DIRECTORIO directorio)
            {
                foreach (var hijo in directorio.ObtenerHijos())
                {
                    TreeNode nodoHijoVisual = new TreeNode(hijo.Nombre);
                    nodoHijoVisual.Tag = hijo; // Guardamos la referencia al objeto real

                    nodoVisualPadre.Nodes.Add(nodoHijoVisual);

                    // Volvemos a llamar a la función por si este hijo es otra carpeta (recursión)
                    ArmarRamasVisuales(hijo, nodoHijoVisual);
                }
            }
        }

        private void btnCrearCarpeta_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtTamaño.Text))
            {

                // 1. Averiguamos dónde está parado el usuario en el TreeView
                TreeNode nodoSeleccionado = trvEstructura.SelectedNode;

                // Si no seleccionó nada, asumimos la raíz
                DIRECTORIO destino = (nodoSeleccionado == null) ? raiz : nodoSeleccionado.Tag as DIRECTORIO;

                if (destino != null)
                {
                    // 2. Creamos el objeto de negocio Composite
                    DIRECTORIO nuevaCarpeta = new DIRECTORIO(txtNombre.Text);
                    destino.AgregarHijo(nuevaCarpeta);

                    // 3. Refrescamos la pantalla
                    CargarArbolVirtual();
                    txtNombre.Clear();
                }
                else
                {
                    MessageBox.Show("¡No podés agregar una carpeta adentro de un archivo!", "Error");
                }
            }
            else
            {
                MessageBox.Show("Completa los campos, por favor.", "Error");
            }
        }

        private void btnCrearArchivo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtTamaño.Text))
            {
                TreeNode nodoSeleccionado = trvEstructura.SelectedNode;
                DIRECTORIO destino = (nodoSeleccionado == null) ? raiz : nodoSeleccionado.Tag as DIRECTORIO;

                int tamaño = int.Parse(txtTamaño.Text);

                if (destino != null)
                {
                    // Creamos el objeto Hoja pasándole el tamaño del control numérico
                    ARCHIVO nuevoArchivo = new ARCHIVO(txtNombre.Text, tamaño);
                    destino.AgregarHijo(nuevoArchivo);

                    CargarArbolVirtual();
                    txtNombre.Clear();
                }
                else
                {
                    MessageBox.Show("¡No podés agregar cosas adentro de un archivo!", "Error");
                }
            }
            else
            {
                MessageBox.Show("Completa los campos, por favor.", "Error");
            }
        }
    }
}
