using System;
using System.Windows.Forms;
using Inventarios.ApplicationControl.Validation;
using Inventarios.ApplicationServices;
using Inventarios.ApplicationServices.Impl;
using Inventarios.Core;
using Inventarios.WinForms.SingletonModels;

namespace Inventarios.WinForms
{
    public partial class FrmProductos : Form
    {
        readonly IProductoService productoService;

        public FrmProductos()
        {
            InitializeComponent();
            productoService = new ProductoService(new AlmacenORMDataContext());
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            var producto = new Producto
            {
                Codigo = int.Parse(txtCodigo.Text),
                Nombre = txtNombre.Text
            };

            if (!producto.IsValid)
            {
                MessageBox.Show(ModelStateValidation.ValidationResults(producto.GetRuleViolations()));
            }
            else
            {
                productoService.Save(producto, ProductoForm.IsUpdate);

                MessageBox.Show(producto.Nombre + " fue grabado exitosamente");
                LimpiarControles();
            }
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            GenerateNoControl();
        }

        private void lsvProductos_Click(object sender, EventArgs e)
        {
            var counter = 0;
            gpbAlta.Visible = true;
            gpbBusqueda.Visible = false;
            tsbGuardar.Enabled = true;
            ProductoForm.IsUpdate = true;

            foreach (Control control in gpbAlta.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    control.Text = lsvProductos.Items[lsvProductos.FocusedItem.Index].SubItems[counter].Text;
                    counter++;
                }
            }
        }

        private void txtNombreBusqueda_TextChanged(object sender, EventArgs e)
        {
            lsvProductos.Items.Clear();

            if (txtNombreBusqueda.Text == "") { return; }

            var productos = productoService.GetProductosByName(txtNombreBusqueda.Text);

            foreach (var producto in productos)
            {
                lsvProductos.Items.Add(new ListViewItem(new[] { producto.Codigo.ToString(), producto.Nombre }));
            }
        }

        #region Form Event Handlers
        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            MostrargpbAltaProductos();
            LimpiarControles();
        }

        private void tsbBusqueda_Click(object sender, EventArgs e)
        {
            MostrargpbBusquedaProductos();
            LimpiarControles();
        }

        private void MostrargpbAltaProductos()
        {
            ProductoForm.IsUpdate = false;
            gpbAlta.Visible = true;
            gpbBusqueda.Visible = false;
            txtNombre.Focus();
            tsbGuardar.Enabled = true;
            GenerateNoControl();
        }

        private void MostrargpbBusquedaProductos()
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
            var codigo = new Random();

            txtCodigo.Text = Convert.ToString(codigo.Next());
        }
        #endregion Form Event Handlers
    }
}