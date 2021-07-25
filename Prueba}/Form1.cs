using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_
{
    public partial class Form1 : Form
    {
        private Timer ti;
        public Form1()
        {
            ti = new Timer();
            ti.Tick += new EventHandler(eventoTimer);
            InitializeComponent();
            ti.Enabled = true;
        }
        private void eventoTimer(object ob, EventArgs evt)
        {
            DateTime hoy = DateTime.Now;
            lblHora.Text = hoy.ToString("hh:mm tt").ToUpper(); ;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btVentas1_MouseEnter(object sender, EventArgs e)
        {
            panelbotones.Width = 222;
            Relleno.Width = 219;
        }

        private void panelbotones_MouseLeave(object sender, EventArgs e)
        {
            panelbotones.Width = 51;
            Relleno.Width = 49;
        }

        private void panelbotones_MouseLeave(object sender, MouseEventArgs e)
        {
            panelbotones.Width = 51;
            Relleno.Width = 49;
        }

        private void btVentas1_Click(object sender, EventArgs e)
        {
            tbMenu.SelectedIndex = 0;
        }

        private void btClientes1_Click(object sender, EventArgs e)
        {
            tbMenu.SelectedIndex = 1;
        }

        private void btProveedores1_Click(object sender, EventArgs e)
        {
            tbMenu.SelectedIndex = 2;
        }

        private void btProductos1_Click(object sender, EventArgs e)
        {
            tbMenu.SelectedIndex = 3;
        }

        private void btVentasP1_Click(object sender, EventArgs e)
        {
            tbMenu.SelectedIndex = 4;
        }

        private void btCotizaciones1_Click(object sender, EventArgs e)
        {
            tbMenu.SelectedIndex = 5;
        }

        private void btInventario1_Click(object sender, EventArgs e)
        {
            tbMenu.SelectedIndex = 6;
        }

        private void btCuentas1_Click(object sender, EventArgs e)
        {
            tbMenu.SelectedIndex = 7;
        }

        private void btDiario1_Click(object sender, EventArgs e)
        {
            tbMenu.SelectedIndex = 8;
        }

        private void btEmpleados1_Click(object sender, EventArgs e)
        {
            tbMenu.SelectedIndex = 9;
        }

        private void btReportes1_Click(object sender, EventArgs e)
        {
            tbMenu.SelectedIndex = 10;
        }

        private void btCaja1_Click(object sender, EventArgs e)
        {
            tbMenu.SelectedIndex = 11;
        }

        private void btSucursales1_Click(object sender, EventArgs e)
        {
            tbMenu.SelectedIndex = 12;
        }

        private void btConfiguraciones1_Click(object sender, EventArgs e)
        {
            tbMenu.SelectedIndex = 13;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            tamanioGeneral();
        }
        private void tamanioGeneral()
        {
            Relleno.Height = this.Height-754;
            PiePag.Width = this.Width;
            PanelUsuario.Left = this.Width - 205;
            pnlFechaHora.Left = this.Width - pnlFechaHora.Width-30;
            pnlFechaHora.Top = this.Height - pnlFechaHora.Height-50;
            pnlcontenedortap.Width = this.Width - 80;
            pnlcontenedortap.Height = this.Height - 160;
            tbMenu.Width = this.Width - 90;
            tbMenu.Height = this.Height - 180;
            dgvDetalles.Left = 5;
            dgvDetalles.Top = 178;
            dgvDetalles.Width = this.Width - 400;
            Menufacturar.Width = dgvDetalles.Width;
            dgvDetalles.Height = this.Height - 400;
            pnlProductos.Left = this.Width - 705;
            pnlfacturar.Left = this.Width - 380;

        }
    }
}
