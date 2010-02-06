using System;
using System.Windows.Forms;
using Inventarios.ApplicationControl.Validation;
using Inventarios.ApplicationServices;
using Inventarios.ApplicationServices.Impl;
using Inventarios.Core;
using Inventarios.WinForms.SingletonModels;

namespace Inventarios.WinForms
{
    public partial class FrmClientes : Form
    {
        readonly IClienteService clienteService;

        public FrmClientes()
        {
            InitializeComponent();
            clienteService = new ClienteService(new AlmacenORMDataContext());
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            GenerateNoControl();
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente
                                  {
                                      NoControl = int.Parse(txtNoControl.Text),
                                      Nombre = txtNombre.Text,
                                      ApellidoPaterno = txtApellidoPaterno.Text,
                                      ApellidoMaterno = txtApellidoMaterno.Text,
                                      Direccion = txtDireccion.Text,
                                      RFC = txtRFC.Text,
                                      Telefono = txtTelefono.Text
                                  };

            if (!cliente.IsValid)
            {
                MessageBox.Show(ModelStateValidation.ValidationResults(cliente.GetRuleViolations()));
            }
            else
            {
                clienteService.Save(cliente, ClienteForm.IsUpdate);

                MessageBox.Show(cliente.Nombre + " fue grabado exitosamente");
                LimpiarControles();
                txtRFC.Focus();
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            lsvClientes.Items.Clear();

            if (txtNombreBusqueda.Text == "") { return; }

            var clientes = clienteService.GetClientesByName(txtNombreBusqueda.Text);

            foreach (var cliente in clientes)
            {
                lsvClientes.Items.Add(new ListViewItem(new[] { cliente.NoControl.ToString(), cliente.Nombre, cliente.ApellidoPaterno, cliente.ApellidoMaterno, cliente.RFC, cliente.Direccion, cliente.Telefono }));
            }
        }

        private void lsvClientes_Click(object sender, EventArgs e)
        {
            
        }

        private void lsvClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var counter = 0;
            gpbAlta.Visible = true;
            gpbBusqueda.Visible = false;
            tsbGuardar.Enabled = true;
            ClienteForm.IsUpdate = true;

            txtNoControl.Text = lsvClientes.Items[lsvClientes.FocusedItem.Index].SubItems[0].Text;
            txtNombre.Text = lsvClientes.Items[lsvClientes.FocusedItem.Index].SubItems[1].Text;
            txtApellidoPaterno.Text = lsvClientes.Items[lsvClientes.FocusedItem.Index].SubItems[2].Text;
            txtApellidoMaterno.Text = lsvClientes.Items[lsvClientes.FocusedItem.Index].SubItems[3].Text;
            txtRFC.Text = lsvClientes.Items[lsvClientes.FocusedItem.Index].SubItems[4].Text;
            txtDireccion.Text = lsvClientes.Items[lsvClientes.FocusedItem.Index].SubItems[5].Text;
            txtTelefono.Text = lsvClientes.Items[lsvClientes.FocusedItem.Index].SubItems[6].Text;

            //foreach (Control control in gpbAlta.Controls)
            //{
            //    if (control.GetType() == typeof(TextBox))
            //    {
            //        control.Text = lsvClientes.Items[lsvClientes.FocusedItem.Index].SubItems[counter].Text;
            //        counter++;
            //    }
            //}
        }

        #region Form Event Handlers
        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            MostrargpbAltaClientes();
            LimpiarControles();
        }

        private void tsbBusqueda_Click(object sender, EventArgs e)
        {
            MostrargpbBusquedaClientes();
            LimpiarControles();
        }

        private void MostrargpbAltaClientes()
        {
            ClienteForm.IsUpdate = false;
            gpbAlta.Visible = true;
            gpbBusqueda.Visible = false;
            txtNombre.Focus();
            tsbGuardar.Enabled = true;
            GenerateNoControl();
        }

        private void MostrargpbBusquedaClientes()
        {
            gpbAlta.Visible = false;
            gpbBusqueda.Visible = true;
            txtNombreBusqueda.Focus();
            tsbGuardar.Enabled = false;
        }

        private void LimpiarControles()
        {
            foreach (Control control in Controls)
            {
                if (!(control is GroupBox)) continue;
                for (var i = 0; i < control.Controls.Count; i++)
                {
                    if (!(control.Controls[i] is TextBox)) continue;
                    control.Controls[i].Text = "";
                }
            }

            GenerateNoControl();
        }

        private void GenerateNoControl()
        {
            var noControl = new Random();

            txtNoControl.Text = Convert.ToString(noControl.Next());
        }
        #endregion Form Event Handlers
    }
}
