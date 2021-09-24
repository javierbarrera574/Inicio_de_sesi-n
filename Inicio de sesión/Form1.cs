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
    public partial class frmEntrar : Form
    {
        public frmEntrar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("¡Felicidades, accediste a este Formulario!");
        }

        private void btMensaje_Click(object sender, EventArgs e)
        {
            lblmensaje.Visible = true;
            lblmensaje.Text = "¡Felicidades, ingresaste a este Formulario!";

        }
    }
}
