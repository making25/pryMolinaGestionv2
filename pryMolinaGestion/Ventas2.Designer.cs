namespace pryMolinaGestion
{
    partial class Ventas2
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
            lblCodDelArti = new Label();
            txtCodArticulo = new TextBox();
            btnBuscar = new Button();
            dataGridView1 = new DataGridView();
            Marca = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            Temporada = new DataGridViewTextBoxColumn();
            PrecioMayor = new DataGridViewTextBoxColumn();
            PrecioMenor = new DataGridViewTextBoxColumn();
            PrecioCosto = new DataGridViewTextBoxColumn();
            Promoción = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblCodDelArti
            // 
            lblCodDelArti.AutoSize = true;
            lblCodDelArti.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCodDelArti.Location = new Point(53, 34);
            lblCodDelArti.Name = "lblCodDelArti";
            lblCodDelArti.Size = new Size(182, 28);
            lblCodDelArti.TabIndex = 0;
            lblCodDelArti.Text = "Codigo del articulo";
            // 
            // txtCodArticulo
            // 
            txtCodArticulo.Location = new Point(247, 35);
            txtCodArticulo.Name = "txtCodArticulo";
            txtCodArticulo.Size = new Size(233, 27);
            txtCodArticulo.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.LightSlateGray;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(502, 24);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(113, 48);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Marca, Nombre, Sexo, Temporada, PrecioMayor, PrecioMenor, PrecioCosto, Promoción, Estado });
            dataGridView1.Location = new Point(53, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(639, 269);
            dataGridView1.TabIndex = 3;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.MinimumWidth = 6;
            Marca.Name = "Marca";
            Marca.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.MinimumWidth = 6;
            Sexo.Name = "Sexo";
            Sexo.Width = 125;
            // 
            // Temporada
            // 
            Temporada.HeaderText = "Temporada";
            Temporada.MinimumWidth = 6;
            Temporada.Name = "Temporada";
            Temporada.Width = 125;
            // 
            // PrecioMayor
            // 
            PrecioMayor.HeaderText = "PrecioMayor";
            PrecioMayor.MinimumWidth = 6;
            PrecioMayor.Name = "PrecioMayor";
            PrecioMayor.Width = 125;
            // 
            // PrecioMenor
            // 
            PrecioMenor.HeaderText = "PrecioMenor";
            PrecioMenor.MinimumWidth = 6;
            PrecioMenor.Name = "PrecioMenor";
            PrecioMenor.Width = 125;
            // 
            // PrecioCosto
            // 
            PrecioCosto.HeaderText = "PrecioCosto";
            PrecioCosto.MinimumWidth = 6;
            PrecioCosto.Name = "PrecioCosto";
            PrecioCosto.Width = 125;
            // 
            // Promoción
            // 
            Promoción.HeaderText = "Promoción";
            Promoción.MinimumWidth = 6;
            Promoción.Name = "Promoción";
            Promoción.Width = 125;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.Width = 125;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.LimeGreen;
            btnAgregar.Location = new Point(138, 400);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(125, 51);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.SteelBlue;
            btnEditar.Location = new Point(325, 402);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(125, 47);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Location = new Point(502, 402);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(125, 47);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // Ventas2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(757, 487);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Controls.Add(btnBuscar);
            Controls.Add(txtCodArticulo);
            Controls.Add(lblCodDelArti);
            Name = "Ventas2";
            Text = "Ventas2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodDelArti;
        private TextBox txtCodArticulo;
        private Button btnBuscar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewTextBoxColumn Temporada;
        private DataGridViewTextBoxColumn PrecioMayor;
        private DataGridViewTextBoxColumn PrecioMenor;
        private DataGridViewTextBoxColumn PrecioCosto;
        private DataGridViewTextBoxColumn Promoción;
        private DataGridViewTextBoxColumn Estado;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
    }
}