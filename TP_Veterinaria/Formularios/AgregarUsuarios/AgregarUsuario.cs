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
    public partial class AgregarUsuario : Form
    {
        VeterinariaDAO veterinariaDAO = new VeterinariaDAO();
        public AgregarUsuario()
        {
            InitializeComponent();
            NombreEmpresa();
        }

        private void button1_Acceder_Click(object sender, EventArgs e)
        {
             bool validacion = true;
            //Validamos que no esten vacios los txb y le cambiamos el color a rojo
            if (string.IsNullOrWhiteSpace(txb_NewUser.Text))
            {
                txb_NewUser.BackColor = Color.Red;
                validacion = false;
            }
            if (string.IsNullOrWhiteSpace(txb_NewPass.Text))
            {
                txb_NewPass.BackColor = Color.Red;
                validacion = false;
            }
            if (string.IsNullOrWhiteSpace(txb_ConfirmPass.Text))
            {
                txb_ConfirmPass.BackColor = Color.Red;
                validacion = false;
            }
            //validamos que los password sean iguales
            if (!txb_NewPass.Text.Equals(txb_ConfirmPass.Text))
            {
                txb_ConfirmPass.BackColor = Color.Red;
                MessageBox.Show("Las contraseñas no coinciden");
                //Limpiamos los TXB del Password
                LimpiarPass();
                //retornamos para que ingrese nuevamente el pass
                return;

            }
            
            //Si no hubo ningun error validacion debera estar en 0 y ejecuta el codigo
            if (validacion == true)
            {

                     UsuarioAgregado();
                

            }
            else
            {
                MessageBox.Show("Debes llenar todos los campos");
                //limpiamos el color de los txb, a su color principal
                LimpiarColor();
            }

        }

        //Metodo para limpiar los txb y cambiar color a verde
        public void Limpiar()
        {
            txb_NewUser.Clear();
            txb_NewPass.Clear();
            txb_ConfirmPass.Clear();
            txb_NewUser.BackColor = Color.LightGreen;
            txb_NewPass.BackColor = Color.LightGreen;
            txb_ConfirmPass.BackColor = Color.LightGreen;
        }

        //Metodo para limpiar los password y cambiar su color al principal
        //tambien cambiamos el color del usuario en caso de que se haya dejado vacio
        public void LimpiarPass()
        {
            txb_NewPass.Clear();
            txb_ConfirmPass.Clear();
            txb_NewUser.BackColor = SystemColors.GradientInactiveCaption;
            txb_ConfirmPass.BackColor = SystemColors.GradientInactiveCaption;
            txb_NewPass.BackColor = SystemColors.GradientInactiveCaption;
        }
        //Si se dejo vacio algun cmapo, despues del mensaje, volvemos a su color principal
        public void LimpiarColor()
        {
            txb_NewUser.BackColor = SystemColors.GradientInactiveCaption;
            txb_ConfirmPass.BackColor = SystemColors.GradientInactiveCaption;
            txb_NewPass.BackColor = SystemColors.GradientInactiveCaption;
        }

        public void UsuarioAgregado()
        {
            try
            {

                bool Existe = true;

                string usuario = txb_NewUser.Text;
                string pass = txb_NewPass.Text;

                veterinariaDAO.UsuarioExiste(usuario, Existe);
                Existe = veterinariaDAO.ExisteUsuario;


                if (Existe == false)
                {
                    veterinariaDAO.AgregarUsuario(usuario, pass);

                    Limpiar();
                    Login();


                }
            }
            catch (SqlException sqlex)
            {
                //Error SQL
                MessageBox.Show("Atencion!! Ocurrio un error en la base de datos, por favor comuniquese con el administrador: " + sqlex.Message);
            }
        }

        public void Validacion()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login();
        }

        public void Login()
        {
            


            Form veterinariaMDI = this.MdiParent;
            Dispose();
            //abrimos la ventana Login
            Login login = new Login();
            // Ajustar el tamaño del formulario padre con un margen adicional
            //int margenAncho = 5; 
            //int margenAlto = 5;  
            //veterinariaMDI.ClientSize = new Size(login.Width + margenAncho, login.Height + margenAlto);
            login.MdiParent = veterinariaMDI;
            login.Dock = DockStyle.Fill;
            login.Show();
        }

        public void NombreEmpresa()
        {
            string nomEmpresa = ConfigurationManager
                .AppSettings["nombre-empresa"];

            lbl_NombreEmpresa.Text = nomEmpresa;
        }
    }
}
