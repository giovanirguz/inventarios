using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Inventarios.ApplicationServices;
using Inventarios.ApplicationServices.Impl;
using Inventarios.Core;

namespace Inventarios.WinForms
{
    public partial class FrmPrincipal : Form
    {
        FrmClientes frmClientes;

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
    }
}
