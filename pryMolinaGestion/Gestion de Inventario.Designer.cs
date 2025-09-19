namespace pryMolinaGestion
{
    partial class form1
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
            listBox1 = new ListBox();
            groupBox2 = new GroupBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            textBox1 = new TextBox();
            lblDescripcion = new Label();
            lblNombreProducto = new Label();
            txtNombreDelProducto = new TextBox();
            lblStock = new Label();
            txtStock = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tituloPrincipal
            // 
            tituloPrincipal.AutoSize = true;
            tituloPrincipal.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            tituloPrincipal.Location = new Point(14, 12);
            tituloPrincipal.Name = "tituloPrincipal";
            tituloPrincipal.Size = new Size(305, 41);
            tituloPrincipal.TabIndex = 0;
            tituloPrincipal.Text = "Gestion de Inventario";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(310, 21);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(113, 43);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(38, 27);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(52, 20);
            lblBuscar.TabIndex = 8;
            lblBuscar.Text = "Buscar";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Nombre", "Codigo", "Categoria" });
            listBox1.Location = new Point(122, 27);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(169, 24);
            listBox1.TabIndex = 10;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBox1);
            groupBox2.Controls.Add(lblBuscar);
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Location = new Point(64, 85);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(475, 79);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(112, 497);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(113, 33);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(346, 497);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(113, 33);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(568, 497);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(113, 33);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(382, 237);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 151);
            textBox1.TabIndex = 12;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(382, 200);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 13;
            lblDescripcion.Text = "Descripción";
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Location = new Point(64, 200);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(153, 20);
            lblNombreProducto.TabIndex = 14;
            lblNombreProducto.Text = "Nombre del Producto";
            // 
            // txtNombreDelProducto
            // 
            txtNombreDelProducto.Location = new Point(64, 224);
            txtNombreDelProducto.Margin = new Padding(3, 4, 3, 4);
            txtNombreDelProducto.Name = "txtNombreDelProducto";
            txtNombreDelProducto.Size = new Size(204, 27);
            txtNombreDelProducto.TabIndex = 15;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(64, 273);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(45, 20);
            lblStock.TabIndex = 16;
            lblStock.Text = "Stock";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(64, 297);
            txtStock.Margin = new Padding(3, 4, 3, 4);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(204, 27);
            txtStock.TabIndex = 17;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(64, 349);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 18;
            lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(64, 373);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(204, 27);
            txtPrecio.TabIndex = 19;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(752, 600);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(txtStock);
            Controls.Add(lblStock);
            Controls.Add(txtNombreDelProducto);
            Controls.Add(lblNombreProducto);
            Controls.Add(lblDescripcion);
            Controls.Add(textBox1);
            Controls.Add(btnEliminar);
            Controls.Add(groupBox2);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(tituloPrincipal);
            Margin = new Padding(3, 4, 3, 4);
            Name = "form1";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloPrincipal;
        private Button btnBuscar;
        private Label lblBuscar;
        private ListBox listBox1;
        private GroupBox groupBox2;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private TextBox textBox1;
        private Label lblDescripcion;
        private Label lblNombreProducto;
        private TextBox txtNombreDelProducto;
        private Label lblStock;
        private TextBox txtStock;
        private Label lblPrecio;
        private TextBox txtPrecio;
    }
}
