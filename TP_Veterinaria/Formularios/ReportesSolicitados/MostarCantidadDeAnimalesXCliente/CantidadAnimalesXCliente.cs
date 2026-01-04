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
    public partial class CantidadAnimalesXCliente : Form
    {
        VeterinariaDAO veterinariaDAO = new VeterinariaDAO();
        public CantidadAnimalesXCliente()
        {
            InitializeComponent();
            NombreEmpresa();


        }

        private void CantidadAnimalesXCliente_Load(object sender, EventArgs e)
        {
            MostrarCantidadAnimalesXCliente();
           
        }

        private void MostrarCantidadAnimalesXCliente()
        {
            dataGridView1.DataSource = veterinariaDAO.CantidadAnimalesXCliente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form veterinariaMDI = this.MdiParent;
            Dispose();
            //abrimos la ventana reportes solicitados
            ReportesSolicitados reportesSolicitados = new ReportesSolicitados();
            //int margenAncho = 5;
            //int margenAlto = 5;
            //veterinariaMDI.ClientSize = new Size(reportesSolicitados.Width + margenAncho, reportesSolicitados.Height + margenAlto);

            reportesSolicitados.MdiParent = veterinariaMDI;
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
