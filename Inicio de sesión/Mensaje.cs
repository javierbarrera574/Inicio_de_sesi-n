using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio_de_sesión
{
    public partial class FrmEntrar : Form
    {
        public FrmEntrar()
        {
            InitializeComponent();
        }

      
        private void btMensaje_Click(object sender, EventArgs e)
        {

            lblMensaje.Visible = true;
            lblMensaje.Text = "¡Felicidades, Bienvenidos a este Formulario!";
        }

        private void FrmEntrar_Load(object sender, EventArgs e)
        {

        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 logeo = new Form2();
            logeo.Show();
            this.Close();

        }

        private void cerrarProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
