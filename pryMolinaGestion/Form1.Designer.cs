namespace pryMolinaGestion
{
    partial class gestionInventario
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
            tituloPrincipal = new Label();
            btnBuscar = new Button();
            lblBuscar = new Label();
            grboxbuscar = new GroupBox();
            cmbcate = new ComboBox();
            txtDatoBuscar = new TextBox();
            rbtncategoria = new RadioButton();
            rbtncodigo = new RadioButton();
            rbtnnombre = new RadioButton();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            lblNombreProducto = new Label();
            txtNombreDelProducto = new TextBox();
            lblStock = new Label();
            txtStock = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            grboxbuscar.SuspendLayout();
            SuspendLayout();
            // 
            // tituloPrincipal
            // 
            tituloPrincipal.AutoSize = true;
            tituloPrincipal.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            tituloPrincipal.Location = new Point(56, 9);
            tituloPrincipal.Name = "tituloPrincipal";
            tituloPrincipal.Size = new Size(245, 32);
            tituloPrincipal.TabIndex = 0;
            tituloPrincipal.Text = "Gestion de Inventario";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(295, 50);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(99, 32);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBuscar.Location = new Point(6, 13);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(87, 32);
            lblBuscar.TabIndex = 8;
            lblBuscar.Text = "Buscar";
            // 
            // grboxbuscar
            // 
            grboxbuscar.Controls.Add(cmbcate);
            grboxbuscar.Controls.Add(txtDatoBuscar);
            grboxbuscar.Controls.Add(rbtncategoria);
            grboxbuscar.Controls.Add(rbtncodigo);
            grboxbuscar.Controls.Add(rbtnnombre);
            grboxbuscar.Controls.Add(lblBuscar);
            grboxbuscar.Controls.Add(btnBuscar);
            grboxbuscar.Location = new Point(56, 44);
            grboxbuscar.Name = "grboxbuscar";
            grboxbuscar.Size = new Size(416, 135);
            grboxbuscar.TabIndex = 11;
            grboxbuscar.TabStop = false;
            // 
            // cmbcate
            // 
            cmbcate.FormattingEnabled = true;
            cmbcate.Location = new Point(108, 99);
            cmbcate.Name = "cmbcate";
            cmbcate.Size = new Size(145, 23);
            cmbcate.TabIndex = 15;
            // 
            // txtDatoBuscar
            // 
            txtDatoBuscar.Location = new Point(108, 49);
            txtDatoBuscar.Name = "txtDatoBuscar";
            txtDatoBuscar.Size = new Size(145, 23);
            txtDatoBuscar.TabIndex = 14;
            // 
            // rbtncategoria
            // 
            rbtncategoria.AutoSize = true;
            rbtncategoria.Location = new Point(19, 100);
            rbtncategoria.Name = "rbtncategoria";
            rbtncategoria.Size = new Size(74, 19);
            rbtncategoria.TabIndex = 13;
            rbtncategoria.TabStop = true;
            rbtncategoria.Text = "categoria";
            rbtncategoria.UseVisualStyleBackColor = true;
            // 
            // rbtncodigo
            // 
            rbtncodigo.AutoSize = true;
            rbtncodigo.Location = new Point(19, 75);
            rbtncodigo.Name = "rbtncodigo";
            rbtncodigo.Size = new Size(64, 19);
            rbtncodigo.TabIndex = 12;
            rbtncodigo.TabStop = true;
            rbtncodigo.Text = "Codigo";
            rbtncodigo.UseVisualStyleBackColor = true;
            // 
            // rbtnnombre
            // 
            rbtnnombre.AutoSize = true;
            rbtnnombre.Location = new Point(19, 50);
            rbtnnombre.Name = "rbtnnombre";
            rbtnnombre.Size = new Size(67, 19);
            rbtnnombre.TabIndex = 11;
            rbtnnombre.TabStop = true;
            rbtnnombre.Text = "nombre";
            rbtnnombre.UseVisualStyleBackColor = true;
            rbtnnombre.CheckedChanged += rbtnnombre_CheckedChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(82, 363);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(99, 29);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(211, 363);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(99, 29);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(351, 363);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(99, 29);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(274, 221);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(198, 114);
            txtDescripcion.TabIndex = 12;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(274, 193);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 13;
            lblDescripcion.Text = "Descripción";
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Location = new Point(56, 182);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(122, 15);
            lblNombreProducto.TabIndex = 14;
            lblNombreProducto.Text = "Nombre del Producto";
            // 
            // txtNombreDelProducto
            // 
            txtNombreDelProducto.Location = new Point(56, 200);
            txtNombreDelProducto.Name = "txtNombreDelProducto";
            txtNombreDelProducto.Size = new Size(179, 23);
            txtNombreDelProducto.TabIndex = 15;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(56, 237);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 16;
            lblStock.Text = "Stock";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(56, 255);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(179, 23);
            txtStock.TabIndex = 17;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(56, 294);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 18;
            lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(56, 312);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(179, 23);
            txtPrecio.TabIndex = 19;
            // 
            // gestionInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(549, 433);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(txtStock);
            Controls.Add(lblStock);
            Controls.Add(txtNombreDelProducto);
            Controls.Add(lblNombreProducto);
            Controls.Add(lblDescripcion);
            Controls.Add(txtDescripcion);
            Controls.Add(btnEliminar);
            Controls.Add(grboxbuscar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(tituloPrincipal);
            Name = "gestionInventario";
            Load += form1_Load;
            grboxbuscar.ResumeLayout(false);
            grboxbuscar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloPrincipal;
        private Button btnBuscar;
        private Label lblBuscar;
        private GroupBox grboxbuscar;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private Label lblNombreProducto;
        private TextBox txtNombreDelProducto;
        private Label lblStock;
        private TextBox txtStock;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private RadioButton rbtncodigo;
        private RadioButton rbtnnombre;
        private TextBox txtDatoBuscar;
        private RadioButton rbtncategoria;
        private ComboBox cmbcate;
    }
}
