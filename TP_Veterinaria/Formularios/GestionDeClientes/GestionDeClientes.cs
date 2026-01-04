using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Veterinaria
{
    public partial class GestionDeClientes : Form
    {
       
        public GestionDeClientes()
        {
            InitializeComponent();
            NombreEmpresa();

        }

        //Boton RegistrarClientes
        private void button1_RegistrarClientes_Click(object sender, EventArgs e)
        {
            Form veterinariaMDI = this.MdiParent;
            //abrimos la ventana registrar cliente
            Dispose();
            RegistrarCliente registrarCliente = new RegistrarCliente();
            //int margenAncho = 5;
            //int margenAlto = 5;
            //veterinariaMDI.ClientSize = new Size(registrarCliente.Width + margenAncho, registrarCliente.Height + margenAlto);

            registrarCliente.MdiParent = veterinariaMDI;
            registrarCliente.Dock = DockStyle.Fill;
            registrarCliente.Show();
            

        }

        //Boton MostrarClientes
        private void button2_MostrarClientes_Click(object sender, EventArgs e)
        {
            Form veterinariaMDI = this.MdiParent;
            //abrimos la ventana Mostrar clientes
            Dispose();
            MostrarClientes mostrarClientes = new MostrarClientes();
            //int margenAncho = 5;
            //int margenAlto = 5;
            //veterinariaMDI.ClientSize = new Size(mostrarClientes.Width + margenAncho, mostrarClientes.Height + margenAlto);

            mostrarClientes.MdiParent = veterinariaMDI;
            mostrarClientes.Dock = DockStyle.Fill;
            mostrarClientes.Show();
        }

        //Regresar
        private void button1_Click(object sender, EventArgs e)
        {
            Form veterinariaMDI = this.MdiParent; 
            Dispose();
            //abrimos la ventana Menu
            Menu menu = new Menu();
            //int margenAncho = 5;
            //int margenAlto = 5;
            //veterinariaMDI.ClientSize = new Size(menu.Width + margenAncho, menu.Height + margenAlto);

            menu.MdiParent = veterinariaMDI;
            menu.Dock = DockStyle.Fill;
            menu.Show();
        }

        public void NombreEmpresa()
        {
            string nomEmpresa = ConfigurationManager
                .AppSettings["nombre-empresa"];

            lbl_NombreEmpresa.Text = nomEmpresa;
        }
    }
}
