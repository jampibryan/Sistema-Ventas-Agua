using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace Capa_Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);


        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = true;
        }

        private void btn_rpt_Venta_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
        }

        private void btn_rpt_Compra_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
        }

        private void btn_rpt_Pago_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void AbrirFormHija(object formhija)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);

            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }


        private void btnProductos_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            AbrirFormHija(new Productos());
        }
        private void btnVentas_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            AbrirFormHija(new Ventas());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            AbrirFormHija(new Clientes());
        }

        private void btnColaboradores_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            AbrirFormHija(new Colaboradores());
        }

        private void btnAbastecimiento_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            AbrirFormHija(new Abastecimiento());
        }

    }
}
