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
    public partial class MostrarClientes : Form
    {
        VeterinariaDAO veterinariaDAO = new VeterinariaDAO();
        public MostrarClientes()
        {
            InitializeComponent();
            NombreEmpresa();

        }

        private void MostrarClientes_Load(object sender, EventArgs e)
        {
           
            recargarGrilla();
            
        }

        private void button1_AgregarMascota_Click(object sender, EventArgs e)
        {
            // Verificar que haya una fila seleccionada en el DataGridView
            // Obtener la fila seleccionada
            DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
            int IDcliente = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            Form veterinariaMDI = this.MdiParent;
            Dispose();
            // abrimos la ventana informacionCliente con los datos del cliente
            InformacionCliente informacionCliente = new InformacionCliente(IDcliente);
            //int margenAncho = 5;
            //int margenAlto = 5;
            //veterinariaMDI.ClientSize = new Size(informacionCliente.Width + margenAncho, informacionCliente.Height + margenAlto);
            informacionCliente.MdiParent = veterinariaMDI;
            informacionCliente.Dock = DockStyle.Fill;
            informacionCliente.Show();
            
            
            
        }

        private void recargarGrilla()
        {
            dataGridView1.DataSource = veterinariaDAO.getAllClientes();
        }

        private void button1_Click(object sender, EventArgs e)
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
