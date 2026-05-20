using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatronSingleton
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            USUARIO usuario = new USUARIO();

            usuario.Nombre = txtNombre.Text;
            usuario.Contraseña = txtContraseña.Text;

            SESSIONMANAGER.Login(usuario);

            var SesionActual = SESSIONMANAGER.ObtenerInstancia();


            lblSesionActual.Text = "Sesion Actual: " + SesionActual.usuarioLogueado + " a las (" + SesionActual.fecha + ").";

        }
    }
}
