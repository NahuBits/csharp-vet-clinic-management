using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP_Veterinaria
{
    public partial class Veterinaria : Form
    {
        private bool arrastrando = false;
        private Point offset;

        public Veterinaria()
        {
            InitializeComponent();
            this.Text = "VETERINARIA - NARICITAS";
            this.StartPosition = FormStartPosition.CenterScreen;

            //panel
            panelUp.MouseDown += panelUp_MouseDown;
            panelUp.MouseMove += panelUp_MouseMove;
            panelUp.MouseUp += panelUp_MouseUp;
        }

        private void Veterinaria_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.MdiParent = this;
            login.Dock = DockStyle.Fill; // Hace que ocupe todo el espacio disponible
            login.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void panelUp_MouseDown(object sender, MouseEventArgs e)
        {
            arrastrando = true;
            offset = e.Location; // Guardamos la posición inicial del cursor en el panel
        }

        private void panelUp_MouseMove(object sender, MouseEventArgs e)
        {
            if (arrastrando)
            {
                Point nuevaPos = this.PointToScreen(e.Location);
                this.Location = new Point(nuevaPos.X - offset.X, nuevaPos.Y - offset.Y);
            }
        }

        private void panelUp_MouseUp(object sender, MouseEventArgs e)
        {
            arrastrando = false;
        }
    }
}
