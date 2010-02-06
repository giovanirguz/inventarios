namespace Inventarios.WinForms
{
    partial class FrmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.txtNombreBusqueda = new System.Windows.Forms.TextBox();
            this.tlsBarraMenu = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbBusqueda = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.gpbBusqueda = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lsvClientes = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.gpbAlta = new System.Windows.Forms.GroupBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNoControl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tlsBarraMenu.SuspendLayout();
            this.gpbBusqueda.SuspendLayout();
            this.gpbAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreBusqueda
            // 
            this.txtNombreBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreBusqueda.Location = new System.Drawing.Point(56, 20);
            this.txtNombreBusqueda.Name = "txtNombreBusqueda";
            this.txtNombreBusqueda.Size = new System.Drawing.Size(259, 20);
            this.txtNombreBusqueda.TabIndex = 12;
            this.txtNombreBusqueda.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // tlsBarraMenu
            // 
            this.tlsBarraMenu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsBarraMenu.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tlsBarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbBusqueda,
            this.tsbGuardar,
            this.tsbSalir});
            this.tlsBarraMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsBarraMenu.Name = "tlsBarraMenu";
            this.tlsBarraMenu.Size = new System.Drawing.Size(569, 48);
            this.tlsBarraMenu.TabIndex = 26;
            this.tlsBarraMenu.Text = "Menu de articulos";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.ForeColor = System.Drawing.Color.White;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(52, 45);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbNuevo.ToolTipText = "Crea un nuevo registro";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbBusqueda
            // 
            this.tsbBusqueda.ForeColor = System.Drawing.Color.White;
            this.tsbBusqueda.Image = ((System.Drawing.Image)(resources.GetObject("tsbBusqueda.Image")));
            this.tsbBusqueda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBusqueda.Name = "tsbBusqueda";
            this.tsbBusqueda.Size = new System.Drawing.Size(75, 45);
            this.tsbBusqueda.Text = "Busqueda";
            this.tsbBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBusqueda.ToolTipText = "Realiza la busqueda un registro";
            this.tsbBusqueda.Click += new System.EventHandler(this.tsbBusqueda_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.ForeColor = System.Drawing.Color.White;
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(64, 45);
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbGuardar.ToolTipText = "Guarda los datos de un registro";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsbSalir
            // 
            this.tsbSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSalir.ForeColor = System.Drawing.Color.White;
            this.tsbSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalir.Image")));
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(40, 45);
            this.tsbSalir.Text = "Salir";
            this.tsbSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSalir.ToolTipText = "Cerrar la forma";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // gpbBusqueda
            // 
            this.gpbBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbBusqueda.Controls.Add(this.label6);
            this.gpbBusqueda.Controls.Add(this.txtNombreBusqueda);
            this.gpbBusqueda.Controls.Add(this.lsvClientes);
            this.gpbBusqueda.Location = new System.Drawing.Point(12, 51);
            this.gpbBusqueda.Name = "gpbBusqueda";
            this.gpbBusqueda.Size = new System.Drawing.Size(535, 357);
            this.gpbBusqueda.TabIndex = 28;
            this.gpbBusqueda.TabStop = false;
            this.gpbBusqueda.Text = "Ver Cliente";
            this.gpbBusqueda.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Nombre";
            // 
            // lsvClientes
            // 
            this.lsvClientes.AllowColumnReorder = true;
            this.lsvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lsvClientes.FullRowSelect = true;
            this.lsvClientes.GridLines = true;
            this.lsvClientes.Location = new System.Drawing.Point(6, 61);
            this.lsvClientes.MultiSelect = false;
            this.lsvClientes.Name = "lsvClientes";
            this.lsvClientes.Size = new System.Drawing.Size(523, 290);
            this.lsvClientes.TabIndex = 15;
            this.lsvClientes.UseCompatibleStateImageBehavior = false;
            this.lsvClientes.View = System.Windows.Forms.View.Details;
            this.lsvClientes.SelectedIndexChanged += new System.EventHandler(this.lsvClientes_SelectedIndexChanged);
            this.lsvClientes.Click += new System.EventHandler(this.lsvClientes_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No. de Control";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 89;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Apellido Paterno";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Apellido Materno";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "R.F.C.";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Direccion";
            this.columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Telefono";
            // 
            // gpbAlta
            // 
            this.gpbAlta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbAlta.Controls.Add(this.txtApellidoMaterno);
            this.gpbAlta.Controls.Add(this.label8);
            this.gpbAlta.Controls.Add(this.txtApellidoPaterno);
            this.gpbAlta.Controls.Add(this.label7);
            this.gpbAlta.Controls.Add(this.txtNoControl);
            this.gpbAlta.Controls.Add(this.label5);
            this.gpbAlta.Controls.Add(this.txtNombre);
            this.gpbAlta.Controls.Add(this.txtRFC);
            this.gpbAlta.Controls.Add(this.label4);
            this.gpbAlta.Controls.Add(this.txtDireccion);
            this.gpbAlta.Controls.Add(this.label3);
            this.gpbAlta.Controls.Add(this.txtTelefono);
            this.gpbAlta.Controls.Add(this.label2);
            this.gpbAlta.Controls.Add(this.label1);
            this.gpbAlta.Location = new System.Drawing.Point(12, 87);
            this.gpbAlta.Name = "gpbAlta";
            this.gpbAlta.Size = new System.Drawing.Size(545, 251);
            this.gpbAlta.TabIndex = 29;
            this.gpbAlta.TabStop = false;
            this.gpbAlta.Text = "Alta Cliente";
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellidoMaterno.Location = new System.Drawing.Point(110, 112);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(157, 20);
            this.txtApellidoMaterno.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Apellido Materno";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellidoPaterno.Location = new System.Drawing.Point(110, 87);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(157, 20);
            this.txtApellidoPaterno.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Apellido Paterno";
            // 
            // txtNoControl
            // 
            this.txtNoControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoControl.Location = new System.Drawing.Point(110, 34);
            this.txtNoControl.Name = "txtNoControl";
            this.txtNoControl.ReadOnly = true;
            this.txtNoControl.Size = new System.Drawing.Size(157, 20);
            this.txtNoControl.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "No. Control";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(110, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(157, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtRFC
            // 
            this.txtRFC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRFC.Location = new System.Drawing.Point(110, 142);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(157, 20);
            this.txtRFC.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Telefono";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion.Location = new System.Drawing.Point(110, 169);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(399, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Direccion";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono.Location = new System.Drawing.Point(110, 195);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(399, 20);
            this.txtTelefono.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "RFC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 424);
            this.Controls.Add(this.tlsBarraMenu);
            this.Controls.Add(this.gpbAlta);
            this.Controls.Add(this.gpbBusqueda);
            this.MinimumSize = new System.Drawing.Size(577, 458);
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.tlsBarraMenu.ResumeLayout(false);
            this.tlsBarraMenu.PerformLayout();
            this.gpbBusqueda.ResumeLayout(false);
            this.gpbBusqueda.PerformLayout();
            this.gpbAlta.ResumeLayout(false);
            this.gpbAlta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreBusqueda;
        private System.Windows.Forms.ToolStrip tlsBarraMenu;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbBusqueda;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.GroupBox gpbBusqueda;
        private System.Windows.Forms.ListView lsvClientes;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox gpbAlta;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNoControl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}