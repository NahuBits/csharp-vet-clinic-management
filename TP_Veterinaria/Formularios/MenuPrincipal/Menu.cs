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
    public partial class Menu : Form
    {
        VeterinariaDAO veterinariaDAO = new VeterinariaDAO();
        string user, usuario_actual;
        public Menu()
        {
            InitializeComponent();
            NombreEmpresa();
            user = Login.user;


            try
            {
                veterinariaDAO.UsuarioActual(user, usuario_actual);
                usuario_actual = veterinariaDAO.Usuario_Actual;
                lbl_User.Text = "Bienvenido " + usuario_actual;
                
            }
            catch (SqlException sqlex)
            {
                //Error SQL
                MessageBox.Show("Atencion!! Ocurrio un error en la base de datos, por favor comuniquese con el administrador: " + sqlex.Message);
            }

        }

        //Boton GestionDeClientes
        private void button2_GestionClientes_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form veterinariaMDI = this.MdiParent;
            Dispose();
            //abrimos la ventana Login
            Login login = new Login();
            //int margenAncho = 5;
            //int margenAlto = 5;
            //veterinariaMDI.ClientSize = new Size(login.Width + margenAncho, login.Height + margenAlto);

            login.MdiParent = veterinariaMDI;
            login.Dock = DockStyle.Fill;
            login.Show();
        }

        //Boton Registros Solicitados
        private void button3_Registros_Click(object sender, EventArgs e)
        {
            Form veterinariaMDI = this.MdiParent;
            Dispose();
            //abrimos la ventana reportes solicitados
            ReportesSolicitados reportesSolicitados = new ReportesSolicitados();
            //int margenAncho = 5;
            //int margenAlto = 5;
            //veterinariaMDI.ClientSize = new Size(reportesSolicitados.Width + margenAncho, reportesSolicitados.Height + margenAlto);

            reportesSolicitados.MdiParent = veterinariaMDI;
            reportesSolicitados.Dock = DockStyle.Fill;
            reportesSolicitados.Show();
            
            
            
        }
        public void NombreEmpresa()
        {
            string nomEmpresa = ConfigurationManager
                .AppSettings["nombre-empresa"];

            lbl_NombreEmpresa.Text = nomEmpresa;
        }

    }
}
