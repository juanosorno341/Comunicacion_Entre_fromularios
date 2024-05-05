using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comunicacion_Entre_fromularios
{
    public partial class Login : Form
    {
        String usuario = "Juan";
        String clave = "Juan123";
        public Login()
        {
            InitializeComponent();
            txtcontraseña.UseSystemPasswordChar = true; // este es para que se encripte el texto del txtcontraseña
        }

        private void Aceptar(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            String user = txtnomusuario.Text;
            String pass = txtcontraseña.Text;
           // Form1 form1 = new Form1(); // este se instancia para llamarlo desde el login y cerrrarlo con Dispose

            if((user == usuario) && (pass == clave))
            {
                Dispose();// al estar en el Formulario de Login se Cierra el Login por estar trabajando en el
                admin.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o Clave incorrectos");
            }

        }

        private void VerClave(object sender, EventArgs e)// para Programar el checkbox
        { 
            if (chkboxverclave.Checked)
            {

                txtcontraseña.UseSystemPasswordChar = false;// este es el cheched del  checkbox sirve para activar desde el evento Checked chain
            }
            else
            {
                txtcontraseña.UseSystemPasswordChar = true;
            }
        }
    }
}
