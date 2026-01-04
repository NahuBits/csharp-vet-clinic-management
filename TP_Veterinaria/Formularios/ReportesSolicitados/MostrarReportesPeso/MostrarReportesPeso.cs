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
    public partial class MostrarReportesPeso : Form
    {
        private int edadMin, edadMax;
        VeterinariaDAO veterinariaDAO = new VeterinariaDAO();
        public MostrarReportesPeso(int minimo, int maximo)
        {
            InitializeComponent();
            NombreEmpresa();
            edadMin = minimo;
            edadMax = maximo;

        }

        private void MostrarReportesPeso_Load(object sender, EventArgs e)
        {
            MostrarReportesPesoMinMaxAVG();
            
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

        public void MostrarReportesPesoMinMaxAVG()
        {
            dataGridView1.DataSource = veterinariaDAO.ReportesPesoMinMaxAVG(edadMin, edadMax);
        }

        public void NombreEmpresa()
        {
            string nomEmpresa = ConfigurationManager
                .AppSettings["nombre-empresa"];

            lbl_NombreEmpresa.Text = nomEmpresa;
        }
    }
}
