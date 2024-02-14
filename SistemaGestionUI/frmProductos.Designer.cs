namespace SistemaGestionUI
{
    partial class frmProductos
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
            btnEliminar = new Button();
            btnBuscarId = new Button();
            txtId = new TextBox();
            dgvProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(382, 40);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(84, 23);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar ";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscarId
            // 
            btnBuscarId.Location = new Point(145, 40);
            btnBuscarId.Name = "btnBuscarId";
            btnBuscarId.Size = new Size(75, 23);
            btnBuscarId.TabIndex = 9;
            btnBuscarId.Text = "Buscar Id";
            btnBuscarId.UseVisualStyleBackColor = true;
            btnBuscarId.Click += btnBuscarId_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(240, 40);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 8;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(100, 89);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(538, 228);
            dgvProductos.TabIndex = 10;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProductos);
            Controls.Add(btnBuscarId);
            Controls.Add(txtId);
            Controls.Add(btnEliminar);
            Name = "frmProductos";
            Text = "frmProductos";
            Load += frmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Button btnBuscarId;
        private TextBox txtId;
        private DataGridView dgvProductos;
    }
}