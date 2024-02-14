namespace SistemaGestionUI
{
    partial class frmUsuarios
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
            dgvDatos = new DataGridView();
            btnListar = new Button();
            btnBuscarId = new Button();
            txtId = new TextBox();
            btnAgregarUsuario = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(99, 86);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.Size = new Size(655, 264);
            dgvDatos.TabIndex = 0;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(36, 36);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnBuscarId
            // 
            btnBuscarId.Location = new Point(149, 36);
            btnBuscarId.Name = "btnBuscarId";
            btnBuscarId.Size = new Size(75, 23);
            btnBuscarId.TabIndex = 2;
            btnBuscarId.Text = "Buscar Id";
            btnBuscarId.UseVisualStyleBackColor = true;
            btnBuscarId.Click += btnBuscarId_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(230, 36);
            txtId.Name = "txtId";
            txtId.Size = new Size(54, 23);
            txtId.TabIndex = 3;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Location = new Point(334, 36);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(75, 23);
            btnAgregarUsuario.TabIndex = 4;
            btnAgregarUsuario.Text = "Agregar Usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(442, 35);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(555, 35);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(txtId);
            Controls.Add(btnBuscarId);
            Controls.Add(btnListar);
            Controls.Add(dgvDatos);
            Name = "frmUsuarios";
            Text = "Gestion de Usuarios";
            Load += frmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDatos;
        private Button btnListar;
        private Button btnBuscarId;
        private TextBox txtId;
        private Button btnAgregarUsuario;
        private Button btnEliminar;
        private Button btnActualizar;
    }
}