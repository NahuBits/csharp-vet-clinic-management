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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TP_Veterinaria
{
    public partial class Login : Form
    {
        VeterinariaDAO veterinariaDAO = new VeterinariaDAO();
        //  public static string conexion = "Data Source=DESKTOP-CU2VMC1;Initial Catalog=db_veterinaria;Integrated Security=True";


        public static string user = "";
        string pass = "";
        public Login()
        {
            InitializeComponent();
            NombreEmpresa();

        }

        private void button1_Ingresar_Click(object sender, EventArgs e)
        {
            user = txb_User.Text.Trim();
            pass = txb_Pass.Text.Trim();

            if (!user.Equals("") || !pass.Equals(""))
            {
                      SesionIniciada();
                
            }
            else
            {
                MessageBox.Show("Debes llenar todos los campos");
            }
        }


        private void button_Registrarse_Click(object sender, EventArgs e)
        {
            
            Form veterinariaMDI = this.MdiParent;
            Dispose();
            //abrimos la ventana Agregar Usuario
            AgregarUsuario agregarUsuario = new AgregarUsuario();
            //veterinariaMDI.ClientSize = agregarUsuario.Size;
            //int margenAncho = 5;  
            //int margenAlto = 5;  
            //veterinariaMDI.ClientSize = new Size(agregarUsuario.Width + margenAncho, agregarUsuario.Height + margenAlto);

            agregarUsuario.MdiParent = veterinariaMDI;
            agregarUsuario.Dock = DockStyle.Fill;
            agregarUsuario.Show();
            
        }

        //***********
        //* METODOS *
        //***********
        public void Limpiar()
        {
            //limpiamos los txb
            txb_User.Clear();
            txb_Pass.Clear();
        }

        private void SesionIniciada()
        {
            try
            {
                bool verdadero = false;
                veterinariaDAO.IniciarSesion(user, pass, verdadero);
                verdadero = veterinariaDAO.Verdadero;

                if (verdadero == true)
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
                if (verdadero == false)
                {
                    MessageBox.Show("Usuario o Contraseña incorrectos");
                }
            }
            catch (SqlException sqlex)
            {
                //Error SQL
                MessageBox.Show("Atencion!! Ocurrio un error en la base de datos, por favor comuniquese con el administrador: " + sqlex.Message);
            }
            catch (Exception ex)
            {
                //Otros errores
                MessageBox.Show("ERROR!! Por favor comuniquese con el administrador: " + ex.Message);
            }
        }

        public void NombreEmpresa()
        {
            string nomEmpresa = ConfigurationManager
                .AppSettings["nombre-empresa"];

            lbl_NombreEmpresa.Text = nomEmpresa;
        }

        private void Login_Load(object sender, EventArgs e)
        {
          
        }
    }
}
