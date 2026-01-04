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
using TP_VeterinariaServices.DAOs;

namespace TP_Veterinaria
{
    public partial class RegistrarCliente : Form
    {
        VeterinariaDAO veterinariaDAO = new VeterinariaDAO();
        public RegistrarCliente()
        {
            InitializeComponent();
            NombreEmpresa();

        }

        private void button1_Guardar_Click(object sender, EventArgs e)
        {
            //Validacion para evitar errores generales
            bool validacion = true;

            //Validamos que no esten vacios los txb y le cambiamos el color a rojo
            if (string.IsNullOrWhiteSpace(txb_Nombre_Cliente.Text))
            {
                txb_Nombre_Cliente.BackColor = Color.Red;
                validacion = false;
            }
            if (string.IsNullOrWhiteSpace(txb_DNI_Cliente.Text))
            {
                txb_DNI_Cliente.BackColor = Color.Red;
                validacion = false;
            }

            //Si no hubo ningun error validacion debera estar en 0 y ejecuta el codigo
            if (validacion == true)
            {
                ClienteAgregado();

            }
            else
            {
                //si se dejo vacio algun campo
                MessageBox.Show("Debes llenar todos los campos");

                //limpiamos el color de los txb, a su color principal
                LimpiarColor();
            }

        }

        public void Limpiar()
        {
            txb_Nombre_Cliente.Clear();
            txb_DNI_Cliente.Clear();
            txb_Nombre_Cliente.BackColor = Color.LightGreen;
            txb_DNI_Cliente.BackColor = Color.LightGreen;
        }
        public void LimpiarColor()
        {
            txb_Nombre_Cliente.BackColor = SystemColors.GradientInactiveCaption;
            txb_DNI_Cliente.BackColor = SystemColors.GradientInactiveCaption;

        }
        public void ClienteAgregado()
        {
            try
            {

                bool Existe = true;

                string nombre_cliente = txb_Nombre_Cliente.Text;
                string dni = txb_DNI_Cliente.Text;

                veterinariaDAO.DNIExiste(dni, Existe);
                Existe = veterinariaDAO.ExisteDNI;


                if (Existe == false)
                {
                    veterinariaDAO.AgregarCliente(nombre_cliente, dni);

                    Limpiar();
                    Gestion();

                }
            }
            catch (SqlException sqlex)
            {
                //Error SQL
                MessageBox.Show("Atencion!! Ocurrio un error en la base de datos, por favor comuniquese con el administrador: " + sqlex.Message);
            }
        }

        private void txb_DNI_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        { // verificamos que no sea una tecla de control ni tampoco un digito
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // activamos el evento de pulsación de tecla, para que no se muestre la tecla ingresada 
                e.Handled = true;
            }
            //si se ingresan digitos se mostraran correctamente
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gestion();
        }

        public void Gestion()
        {
            Form veterinariaMDI = this.MdiParent;
            //abrimos la ventana GestionDeClientes
            Dispose();
            GestionDeClientes gestionDeClientes = new GestionDeClientes();
            //int margenAncho = 5;
            //int margenAlto = 5;
            //veterinariaMDI.ClientSize = new Size(gestionDeClientes.Width + margenAncho, gestionDeClientes.Height + margenAlto);

            gestionDeClientes.MdiParent = veterinariaMDI;
            gestionDeClientes.Dock = DockStyle.Fill;
            gestionDeClientes.Show();
        }
        public void NombreEmpresa()
        {
            string nomEmpresa = ConfigurationManager
                .AppSettings["nombre-empresa"];

            lbl_NombreEmpresa.Text = nomEmpresa;
        }
    }
}
