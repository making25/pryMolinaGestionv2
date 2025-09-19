namespace pryMolinaGestion
{
    partial class Agenda
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
            lblTitulo = new Label();
            dataGridView1 = new DataGridView();
            Asunto = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Observación = new DataGridViewTextBoxColumn();
            btnAceptar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(237, 39);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(323, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Agenda de Actividades";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Asunto, Fecha, Observación });
            dataGridView1.Location = new Point(91, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(647, 227);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Asunto
            // 
            Asunto.HeaderText = "Asunto";
            Asunto.MinimumWidth = 6;
            Asunto.Name = "Asunto";
            Asunto.Width = 125;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.Width = 125;
            // 
            // Observación
            // 
            Observación.HeaderText = "Observación";
            Observación.MinimumWidth = 6;
            Observación.Name = "Observación";
            Observación.Width = 125;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(103, 362);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(148, 46);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(312, 362);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(148, 46);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(527, 362);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(148, 46);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // Agenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAceptar);
            Controls.Add(dataGridView1);
            Controls.Add(lblTitulo);
            Name = "Agenda";
            Text = "Agenda";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Asunto;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Observación;
        private Button btnAceptar;
        private Button btnEditar;
        private Button btnEliminar;
    }
}