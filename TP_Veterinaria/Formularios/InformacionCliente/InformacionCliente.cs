using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_VeterinariaServices.DAOs;
using TP_VeterinariaServices.Models;

namespace TP_Veterinaria
{
    public partial class InformacionCliente : Form
    {
        VeterinariaDAO veterinariaDAO = new VeterinariaDAO();
        private int ClienteID;
        //pedimos el id del cliente en el constructor
        public InformacionCliente(int id)
        {
            InitializeComponent();
            NombreEmpresa();

            // guardamos el id del cliente
            ClienteID = id;

        }

        //Boton para Guardar la mascota
        private void button1_GuardarMascota_Click(object sender, EventArgs e)
        {

            //Validacion para evitar errores generales
            bool validacion = true;

            //Validamos que no esten vacios los txb y le cambiamos el color a rojo
            if (string.IsNullOrWhiteSpace(txb_Nombre_Mascota.Text))
            {
                txb_Nombre_Mascota.BackColor = Color.Red;
                validacion = false;
            }
            if (string.IsNullOrWhiteSpace(txb_Edad_Mascota.Text))
            {
                txb_Edad_Mascota.BackColor = Color.Red;
                validacion = false;
            }
            if (string.IsNullOrWhiteSpace(txb_PesoMascota.Text))
            {
                txb_PesoMascota.BackColor = Color.Red;
                validacion = false;
            }

            //Si no hubo ningun error validacion debera estar en 0 y ejecuta el codigo
            if (validacion == true)
            {
                MascotaAgregada();
               
            }
            else
            {
                //si se dejo vacio algun campo
                MessageBox.Show("Debes llenar todos los campos");

                //limpiamos el color de los txb, a su color principal
                LimpiarColor();
            }

        }
        // Metodo para cargar todo al iniciar
        private void InformacionCliente_Load(object sender, EventArgs e)
        {
            //Muestra en la parte superior izq el nombre y dni del cliente
            CargarLabelCliente();

            //Muestra las especies en el cmb info
            CargarInfoEspecieCMB();

            //Muestra las especies en el cmb para registrarlos
            CargarEspecieCMB();
            
            //Muestra Todas las mascotas del cliente
            MostrarMascotas();
        }

        //Metodo para seleccionar  especie desde el cmb
        private void cmb_especie_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Muestra informacion de la especie selecionada en el apartado de info
            CargarLabelEspecies();
            
        }

        //Metodo para actualizar la grilla
        private void button1_ActualizarListaMascotas_Click(object sender, EventArgs e)
        {
            //Actualizamos las mascotas 
            MostrarMascotas();
           
        }

        //Metodo para limpiar texto y color
        public void Limpiar()
        {
            txb_Nombre_Mascota.Clear();
            txb_PesoMascota.Clear();
            txb_Edad_Mascota.Clear();
            txb_Nombre_Mascota.BackColor = Color.LightGreen;
            txb_PesoMascota.BackColor = Color.LightGreen;
            txb_Edad_Mascota.BackColor = Color.LightGreen;
        }
        //Metodo para limpiar color
        public void LimpiarColor()
        {
            txb_Nombre_Mascota.BackColor = SystemColors.GradientInactiveCaption;
            txb_PesoMascota.BackColor = SystemColors.GradientInactiveCaption;
            txb_Edad_Mascota.BackColor = SystemColors.GradientInactiveCaption;

        }
        //Metodo para cargar el label del cliente
        public void CargarLabelCliente()
        {
            try
            {
                veterinariaDAO.LabelCliente(ClienteID);
                lbl_NombreCliente.Text = veterinariaDAO.NombreCliente;
                lbl_DNICliente.Text = veterinariaDAO.DNICliente;
            }
            catch (SqlException sqlex)
            {
                //Error SQL
                MessageBox.Show("Atencion!! Ocurrio un error en la base de datos, por favor comuniquese con el administrador: " + sqlex.Message);
            }

        }
        //Metodo para cargar la especie al cmb
        public void CargarEspecieCMB()
        {
            try
            {
                DataTable dtEspecie = veterinariaDAO.getEspecies();

                cmb_especie.DataSource = dtEspecie;
                cmb_especie.DisplayMember = "especie";
                cmb_especie.ValueMember = "id";

            }
            catch (SqlException sqlex)
            {
                //Error SQL
                MessageBox.Show("Atencion!! Ocurrio un error en la base de datos, por favor comuniquese con el administrador: " + sqlex.Message);
            }
        }
        //Metodo para cargar la especie al cmb del apartado info
        public void CargarInfoEspecieCMB()
        {
            try
            {
                DataTable dtEspecieInfo = veterinariaDAO.getInfoEspecies();

                cmb_especieinfo.DataSource = dtEspecieInfo;
                cmb_especieinfo.DisplayMember = "especie";
                cmb_especieinfo.ValueMember = "especie";

            }
            catch (SqlException sqlex)
            {
                //Error SQL
                MessageBox.Show("Atencion!! Ocurrio un error en la base de datos, por favor comuniquese con el administrador: " + sqlex.Message);
            }
        }

        //Metodo para cargar la info de las especies en info
        public void CargarLabelEspecies()
        {
            if (cmb_especieinfo.SelectedValue != null)
            {
                try
                {
                    string especieSeleccionada = cmb_especieinfo.SelectedValue.ToString();
                    veterinariaDAO.getLabelEspecie(especieSeleccionada);
                    lbl_EdadMadurez.Text = veterinariaDAO.EdadMadurez;
                    lbl_PesoPromedio.Text = veterinariaDAO.PesoPromedio;
                }
                catch (SqlException sqlex)
                {
                    //Error SQL
                    MessageBox.Show("Atencion!! Ocurrio un error en la base de datos, por favor comuniquese con el administrador: " + sqlex.Message);
                }

            }
            else
            {
                MessageBox.Show("No se encontro una especie");
            }
        }

        //Metodo para mostrar las mascotas en la grilla
        public void MostrarMascotas()
        {
            dataGridView1.DataSource = veterinariaDAO.getAllAnimales(ClienteID);
        }
        //Metodo para agregar mascotas
        public void MascotaAgregada()
        {
            try
            {
                int especieSeleccionada = (int)cmb_especie.SelectedValue;
                string nombre = txb_Nombre_Mascota.Text;
                int edad = Int32.Parse(txb_Edad_Mascota.Text);
                decimal peso = Decimal.Parse(txb_PesoMascota.Text);
                veterinariaDAO.AgregarMascota(nombre, peso, edad, ClienteID, especieSeleccionada);
                Limpiar();
                LimpiarColor();
            }
            catch (SqlException sqlex)
            {
                //Error SQL
                MessageBox.Show("Atencion!! Ocurrio un error en la base de datos, por favor comuniquese con el administrador: " + sqlex.Message);

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para la edad.");
                txb_Edad_Mascota.Focus();
                txb_PesoMascota.Focus();
            }


        }
        // Metodo para que solo se puedan ingresar digitos en el campo pesoMascota
        private void txb_PesoMascota_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            // verificamos que no sea una tecla de control ni tampoco un digito y que haya un solo punto '.' como decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            
            

        }
        // Metodo para que solo se puedan ingresar digitos en el campo edadMascota
        private void txb_Edad_Mascota_KeyPress(object sender, KeyPressEventArgs e)
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

        public void NombreEmpresa()
        {
            string nomEmpresa = ConfigurationManager
                .AppSettings["nombre-empresa"];

            lbl_NombreEmpresa.Text = nomEmpresa;
        }
    }
}
