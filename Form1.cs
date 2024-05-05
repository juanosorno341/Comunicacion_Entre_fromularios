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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Usuario"; //Se usa para coocar el nombre del formulario
        }

        private void Admin(object sender, EventArgs e)
        {   Login login = new Login(); //instanciamos y abrimos con .Show();
            login.Show();

            
        }

        private void Enviar(object sender, EventArgs e)
        {
            Admin admin = new Admin();// Se crea la instancia dentro del boton desde donde se va a enviar la informacion al formulario
            String nombre = txtnombre.Text;
            String apellido = txtapellido.Text;
            String telefono = txttelefono.Text;
            int edad = Convert.ToInt32(txtedadFform.Text);  //colocar atencion a los nombre de los label q se usan para mostrar los textbox

            // Esta funcionn es para enviar la informacion de formulario a formulario

            admin.Mostrar(nombre, apellido, telefono, edad); // esta funcion hay que crearla en el Form que
            admin.Show();                                                 // recibe la informacion: El boton enviar captura las
                                                             // variables Globales
        }

        private void Salir(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
