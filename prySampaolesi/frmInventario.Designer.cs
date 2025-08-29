namespace prySampaolesi
{
    partial class frmInventario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgregar = new Button();
            btnEliminarInicio = new Button();
            btnModificar = new Button();
            mrcAgregar = new GroupBox();
            lblDescripcionAgregar = new Label();
            txtDescripcionAgregar = new TextBox();
            lblCantidad = new Label();
            txtCantidadAgregar = new TextBox();
            lblPrecioA = new Label();
            txtPrecioAgregar = new TextBox();
            lblCodigoA = new Label();
            txtCodigoAgregar = new TextBox();
            txtNombreAgregar = new TextBox();
            lblNombreProductoA = new Label();
            mrcEliminar = new GroupBox();
            lblCodigoEliminar = new Label();
            txtCodigoEliminar = new TextBox();
            mrcModificar = new GroupBox();
            lblModificacion = new Label();
            txtModificacion = new TextBox();
            lstCaracteristica = new ListBox();
            lblCaracteristicaModificar = new Label();
            lblCodigoModificar = new Label();
            txtCodigoModificar = new TextBox();
            mrcAgregar.SuspendLayout();
            mrcEliminar.SuspendLayout();
            mrcModificar.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(592, 113);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(111, 34);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button1_Click;
            // 
            // btnEliminarInicio
            // 
            btnEliminarInicio.Location = new Point(592, 58);
            btnEliminarInicio.Name = "btnEliminarInicio";
            btnEliminarInicio.Size = new Size(111, 34);
            btnEliminarInicio.TabIndex = 1;
            btnEliminarInicio.Text = "Eliminar";
            btnEliminarInicio.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(592, 53);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(111, 36);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // mrcAgregar
            // 
            mrcAgregar.BackColor = SystemColors.Control;
            mrcAgregar.Controls.Add(lblDescripcionAgregar);
            mrcAgregar.Controls.Add(txtDescripcionAgregar);
            mrcAgregar.Controls.Add(lblCantidad);
            mrcAgregar.Controls.Add(txtCantidadAgregar);
            mrcAgregar.Controls.Add(lblPrecioA);
            mrcAgregar.Controls.Add(btnAgregar);
            mrcAgregar.Controls.Add(txtPrecioAgregar);
            mrcAgregar.Controls.Add(lblCodigoA);
            mrcAgregar.Controls.Add(txtCodigoAgregar);
            mrcAgregar.Controls.Add(txtNombreAgregar);
            mrcAgregar.Controls.Add(lblNombreProductoA);
            mrcAgregar.Location = new Point(33, 31);
            mrcAgregar.Name = "mrcAgregar";
            mrcAgregar.Size = new Size(709, 167);
            mrcAgregar.TabIndex = 3;
            mrcAgregar.TabStop = false;
            mrcAgregar.Text = "Agregar";
            // 
            // lblDescripcionAgregar
            // 
            lblDescripcionAgregar.AutoSize = true;
            lblDescripcionAgregar.Location = new Point(28, 106);
            lblDescripcionAgregar.Name = "lblDescripcionAgregar";
            lblDescripcionAgregar.Size = new Size(69, 15);
            lblDescripcionAgregar.TabIndex = 13;
            lblDescripcionAgregar.Text = "Descripcion";
            // 
            // txtDescripcionAgregar
            // 
            txtDescripcionAgregar.Location = new Point(28, 124);
            txtDescripcionAgregar.Multiline = true;
            txtDescripcionAgregar.Name = "txtDescripcionAgregar";
            txtDescripcionAgregar.Size = new Size(306, 23);
            txtDescripcionAgregar.TabIndex = 12;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(467, 41);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(109, 15);
            lblCantidad.TabIndex = 11;
            lblCantidad.Text = "Cantidad a Ingresar";
            // 
            // txtCantidadAgregar
            // 
            txtCantidadAgregar.Location = new Point(467, 59);
            txtCantidadAgregar.Name = "txtCantidadAgregar";
            txtCantidadAgregar.Size = new Size(122, 23);
            txtCantidadAgregar.TabIndex = 10;
            // 
            // lblPrecioA
            // 
            lblPrecioA.AutoSize = true;
            lblPrecioA.Location = new Point(339, 41);
            lblPrecioA.Name = "lblPrecioA";
            lblPrecioA.Size = new Size(85, 15);
            lblPrecioA.TabIndex = 9;
            lblPrecioA.Text = "Precio Unitario";
            // 
            // txtPrecioAgregar
            // 
            txtPrecioAgregar.Location = new Point(317, 59);
            txtPrecioAgregar.Name = "txtPrecioAgregar";
            txtPrecioAgregar.Size = new Size(122, 23);
            txtPrecioAgregar.TabIndex = 8;
            // 
            // lblCodigoA
            // 
            lblCodigoA.AutoSize = true;
            lblCodigoA.Location = new Point(171, 41);
            lblCodigoA.Name = "lblCodigoA";
            lblCodigoA.Size = new Size(117, 15);
            lblCodigoA.TabIndex = 7;
            lblCodigoA.Text = "Codigo del Producto";
            // 
            // txtCodigoAgregar
            // 
            txtCodigoAgregar.Location = new Point(171, 59);
            txtCodigoAgregar.Name = "txtCodigoAgregar";
            txtCodigoAgregar.Size = new Size(122, 23);
            txtCodigoAgregar.TabIndex = 6;
            // 
            // txtNombreAgregar
            // 
            txtNombreAgregar.Location = new Point(23, 59);
            txtNombreAgregar.Name = "txtNombreAgregar";
            txtNombreAgregar.Size = new Size(122, 23);
            txtNombreAgregar.TabIndex = 4;
            // 
            // lblNombreProductoA
            // 
            lblNombreProductoA.AutoSize = true;
            lblNombreProductoA.Location = new Point(23, 41);
            lblNombreProductoA.Name = "lblNombreProductoA";
            lblNombreProductoA.Size = new Size(122, 15);
            lblNombreProductoA.TabIndex = 5;
            lblNombreProductoA.Text = "Nombre del Producto";
            // 
            // mrcEliminar
            // 
            mrcEliminar.Controls.Add(lblCodigoEliminar);
            mrcEliminar.Controls.Add(txtCodigoEliminar);
            mrcEliminar.Controls.Add(btnEliminarInicio);
            mrcEliminar.Location = new Point(33, 204);
            mrcEliminar.Name = "mrcEliminar";
            mrcEliminar.Size = new Size(709, 108);
            mrcEliminar.TabIndex = 4;
            mrcEliminar.TabStop = false;
            mrcEliminar.Text = "Eliminar";
            // 
            // lblCodigoEliminar
            // 
            lblCodigoEliminar.AutoSize = true;
            lblCodigoEliminar.Location = new Point(23, 41);
            lblCodigoEliminar.Name = "lblCodigoEliminar";
            lblCodigoEliminar.Size = new Size(117, 15);
            lblCodigoEliminar.TabIndex = 8;
            lblCodigoEliminar.Text = "Codigo del Producto";
            // 
            // txtCodigoEliminar
            // 
            txtCodigoEliminar.Location = new Point(23, 65);
            txtCodigoEliminar.Name = "txtCodigoEliminar";
            txtCodigoEliminar.Size = new Size(122, 23);
            txtCodigoEliminar.TabIndex = 5;
            // 
            // mrcModificar
            // 
            mrcModificar.Controls.Add(lblModificacion);
            mrcModificar.Controls.Add(txtModificacion);
            mrcModificar.Controls.Add(lstCaracteristica);
            mrcModificar.Controls.Add(lblCaracteristicaModificar);
            mrcModificar.Controls.Add(lblCodigoModificar);
            mrcModificar.Controls.Add(txtCodigoModificar);
            mrcModificar.Controls.Add(btnModificar);
            mrcModificar.Location = new Point(33, 318);
            mrcModificar.Name = "mrcModificar";
            mrcModificar.Size = new Size(709, 105);
            mrcModificar.TabIndex = 5;
            mrcModificar.TabStop = false;
            mrcModificar.Text = "Modificar";
            // 
            // lblModificacion
            // 
            lblModificacion.AutoSize = true;
            lblModificacion.Location = new Point(400, 43);
            lblModificacion.Name = "lblModificacion";
            lblModificacion.Size = new Size(77, 15);
            lblModificacion.TabIndex = 13;
            lblModificacion.Text = "Modificacion";
            // 
            // txtModificacion
            // 
            txtModificacion.Location = new Point(378, 61);
            txtModificacion.Name = "txtModificacion";
            txtModificacion.Size = new Size(122, 23);
            txtModificacion.TabIndex = 12;
            // 
            // lstCaracteristica
            // 
            lstCaracteristica.FormattingEnabled = true;
            lstCaracteristica.ItemHeight = 15;
            lstCaracteristica.Items.AddRange(new object[] { "Precio ", "Cantidad ", "Nombre", "Codigo ", "Descripcion" });
            lstCaracteristica.Location = new Point(193, 61);
            lstCaracteristica.Name = "lstCaracteristica";
            lstCaracteristica.Size = new Size(141, 19);
            lstCaracteristica.TabIndex = 11;
            lstCaracteristica.SelectedIndexChanged += lstCaracteristica_SelectedIndexChanged;
            // 
            // lblCaracteristicaModificar
            // 
            lblCaracteristicaModificar.AutoSize = true;
            lblCaracteristicaModificar.Location = new Point(193, 43);
            lblCaracteristicaModificar.Name = "lblCaracteristicaModificar";
            lblCaracteristicaModificar.Size = new Size(141, 15);
            lblCaracteristicaModificar.TabIndex = 10;
            lblCaracteristicaModificar.Text = "Caracteristica a modificar";
            // 
            // lblCodigoModificar
            // 
            lblCodigoModificar.AutoSize = true;
            lblCodigoModificar.Location = new Point(23, 43);
            lblCodigoModificar.Name = "lblCodigoModificar";
            lblCodigoModificar.Size = new Size(117, 15);
            lblCodigoModificar.TabIndex = 9;
            lblCodigoModificar.Text = "Codigo del Producto";
            // 
            // txtCodigoModificar
            // 
            txtCodigoModificar.Location = new Point(23, 61);
            txtCodigoModificar.Name = "txtCodigoModificar";
            txtCodigoModificar.Size = new Size(122, 23);
            txtCodigoModificar.TabIndex = 6;
            // 
            // frmInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 453);
            Controls.Add(mrcModificar);
            Controls.Add(mrcEliminar);
            Controls.Add(mrcAgregar);
            Name = "frmInventario";
            Text = "Inventario";
            mrcAgregar.ResumeLayout(false);
            mrcAgregar.PerformLayout();
            mrcEliminar.ResumeLayout(false);
            mrcEliminar.PerformLayout();
            mrcModificar.ResumeLayout(false);
            mrcModificar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregar;
        private Button btnEliminarInicio;
        private Button btnModificar;
        private GroupBox mrcAgregar;
        private TextBox txtNombreAgregar;
        private Label lblNombreProductoA;
        private Label lblCantidad;
        private TextBox txtCantidadAgregar;
        private Label lblPrecioA;
        private TextBox txtPrecioAgregar;
        private Label lblCodigoA;
        private TextBox txtCodigoAgregar;
        private GroupBox mrcEliminar;
        private GroupBox mrcModificar;
        private Label lblCodigoEliminar;
        private TextBox txtCodigoEliminar;
        private TextBox txtCodigoModificar;
        private ListBox lstCaracteristica;
        private Label lblCaracteristicaModificar;
        private Label lblCodigoModificar;
        private Label lblModificacion;
        private TextBox txtModificacion;
        private TextBox txtDescripcionAgregar;
        private Label lblDescripcionAgregar;
    }
}
