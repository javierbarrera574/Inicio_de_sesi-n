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
    public partial class Form2 : Form
    {
        //string usuario;
        //string contraeña;
        frmEntrar logeo;
        public Form2()
        {
            InitializeComponent();
        }

        private void btUsuarios_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text != " ") && (txtContraseña.Text != " "))
            {
                if ((txtUsuario.Text == "Usuario") && (txtContraseña.Text == "Contraseña"))
                    logeo = new frmEntrar();
                logeo.Show();
                this.Hide();
            }
            //else
            //{
            //    if (txtUsuario.Text !="Usuario" && txtContraseña.Text != "Contraseña")
            //    {
            //        MessageBox.Show("La contraseña o usuario ingresados es incorrecto, intentelo de nuevo");

            //    }
            //}
            }
        }
    }
























//else
//{
//    if (usuario != "Usuario" && txtUsuario.Text != usuario)
//    {
//        if (contraeña != "Contraseña" && txtContraseña.Text != contraeña)
//        {

//        }
//        MessageBox.Show("Contraseña o usuario incorrectos, intentelo de nuevo");
//    }











//try 
//{
//    lblResultado.Text = (Convert.ToInt32(txtNumerador.Text)
//         / Convert.ToInt32(txtDenominador.Text)).ToString();


//    if (lblMensaje.Text != txtUsuario.Text !="Usuario" && txtContraseña.Text != "Contraseña")
//    {
//        Exception error = new Exception("La contraseña o usuario ingresados es incorrecto, intentelo de nuevo");
//        throw error;
//    }
//}
//catch (DivideByZeroException error)
//{
//    lblMensaje.Text = error.Message;
//    txtDenominador.Text = "";
//    lblMensaje.Visible = true;

//}
//catch (Exception error)
//{
//    lblMensaje.Text = error.Message;



//}

