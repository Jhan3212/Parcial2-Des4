using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Asociar eventos del menú
            librosToolStripMenuItem.Click += librosToolStripMenuItem_Click;
            prestamosToolStripMenuItem.Click += prestamosToolStripMenuItem_Click;
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;

            // Evento del timer
            timer1.Tick += timer1_Tick;

            // Evento Load del formulario
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Usuario: Admin";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLibros ventana = new FrmLibros();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrestamos ventana = new FrmPrestamos();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
