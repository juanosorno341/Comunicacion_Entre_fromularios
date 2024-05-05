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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }// Se dio doble click para inicializar el modo comando del Form Admin y luego creo el
         // metodo del boton enviar del form1

        public void Mostrar(String nom, String ape, String tel, int edad)
        {
            lblMostrarnombre.Text = nom;
            lblMostrarapellido.Text = ape;
            lblMostrartelefono.Text = tel;
            lblMostraredad.Text = edad.ToString();


           
        }
    }
}
