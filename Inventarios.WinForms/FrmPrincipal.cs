using System;
using System.Windows.Forms;

namespace Inventarios.WinForms
{
    public partial class FrmPrincipal : Form
    {
        FrmClientes frmClientes;
        FrmProductos frmProductos;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmClientes == null || frmClientes.IsDisposed)
                frmClientes = new FrmClientes();

            frmClientes.MdiParent = this;
            frmClientes.Show();
            frmClientes.BringToFront();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmProductos == null || frmProductos.IsDisposed)
                frmProductos = new FrmProductos();

            frmProductos.MdiParent = this;
            frmProductos.Show();
            frmProductos.BringToFront();
        }
    }
}
