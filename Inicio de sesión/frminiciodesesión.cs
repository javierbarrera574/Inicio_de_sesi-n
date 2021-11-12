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
        int intentos = 0;
        FrmEntrar logeo;
        public Form2()
        {
            InitializeComponent();
        }

        private void btUsuarios_Click(object sender, EventArgs e)
        {
            string username;
            string password;

            username = txtUsuario.Text;
            password = txtContraseña.Text;

            if ((username == "usuario") && (password == "contraseña"))
            {
                logeo = new FrmEntrar();
                logeo.Show();
                this.Hide();
            }
            else
            {
                DialogResult respuesta = MessageBox.Show("Datos erroneos", "Intentelo nuevamente",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
               
                if (respuesta == DialogResult.Retry)
                {
                    
                    intentos=intentos+1;
                    txtUsuario.Clear();
                    txtContraseña.Clear();
                    while (intentos==3)
                    {
                        intentos = intentos + 1;
                        MessageBox.Show("Alcanzo el máximo de intentos");
                        Application.Exit();
                    }
                }
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
