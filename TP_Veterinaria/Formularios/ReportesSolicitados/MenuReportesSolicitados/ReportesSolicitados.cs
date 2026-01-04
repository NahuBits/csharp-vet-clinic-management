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
    public partial class ReportesSolicitados : Form
    {
        public ReportesSolicitados()
        {
            InitializeComponent();
            NombreEmpresa();

        }

        private void button1_Buscar_Click(object sender, EventArgs e)
        {
            
            int edadMin, edadMax;

            // Verificamos que los valores ingresados sean numeros validos
            if (!int.TryParse(txb_Min.Text, out edadMin) || !int.TryParse(txb_Max.Text, out edadMax))
            {
                MessageBox.Show("Ingrese un rango de edad valido");
                return;
            }
            Form veterinariaMDI = this.MdiParent;
            Dispose();
            //abrimos la ventana MostrarReportesPeso
            MostrarReportesPeso mostrarReportesPeso = new MostrarReportesPeso(edadMin, edadMax);
            //int margenAncho = 5;
            //int margenAlto = 5;
            //veterinariaMDI.ClientSize = new Size(mostrarReportesPeso.Width + margenAncho, mostrarReportesPeso.Height + margenAlto);

            mostrarReportesPeso.MdiParent = veterinariaMDI;
            mostrarReportesPeso.Show();
            

        }

        private void button1_MostaraCantidadxCliente_Click(object sender, EventArgs e)
        {
            Form veterinariaMDI = this.MdiParent;
            Dispose();
            //abrimos la ventana MostrarCantidadXCliente
            CantidadAnimalesXCliente cantidadAnimalesXCliente = new CantidadAnimalesXCliente();
            //int margenAncho = 5;
            //int margenAlto = 5;
            //veterinariaMDI.ClientSize = new Size(cantidadAnimalesXCliente.Width + margenAncho, cantidadAnimalesXCliente.Height + margenAlto);

            cantidadAnimalesXCliente.MdiParent = veterinariaMDI;
            cantidadAnimalesXCliente.Show();
            
        }

        private void txb_Min_KeyPress(object sender, KeyPressEventArgs e)
        { // verificamos que no sea una tecla de control ni tampoco un digito
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // activamos el evento de pulsación de tecla, para que no se muestre la tecla ingresada 
                e.Handled = true;
            }
            //si se ingresan digitos se mostraran correctamente
        }
        private void txb_Max_KeyPress(object sender, KeyPressEventArgs e)
        { // verificamos que no sea una tecla de control ni tampoco un digito
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // activamos el evento de pulsación de tecla, para que no se muestre la tecla ingresada 
                e.Handled = true;
            }
            //si se ingresan digitos se mostraran correctamente
        }

        private void ReportesSolicitados_Load(object sender, EventArgs e)
        {

        }

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
