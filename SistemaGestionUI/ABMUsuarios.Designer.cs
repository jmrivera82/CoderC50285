namespace SistemaGestionUI
{
    partial class ABMUsuarios
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtMail = new TextBox();
            txtClave = new TextBox();
            txtNombreUsuario = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(177, 215);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 21;
            label5.Text = "MAIL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(173, 175);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 20;
            label4.Text = "CONTRASEÑA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(173, 138);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 19;
            label3.Text = "USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 96);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 18;
            label2.Text = "APELLIDO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 54);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 17;
            label1.Text = "NOMBRE";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(272, 212);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(215, 23);
            txtMail.TabIndex = 16;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(272, 172);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(215, 23);
            txtClave.TabIndex = 15;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(272, 135);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(215, 23);
            txtNombreUsuario.TabIndex = 14;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(272, 88);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(215, 23);
            txtApellido.TabIndex = 13;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(272, 46);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(215, 23);
            txtNombre.TabIndex = 12;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(318, 289);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(137, 51);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // ABMUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMail);
            Controls.Add(txtClave);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(btnAceptar);
            Name = "ABMUsuarios";
            Text = "ABMUsuarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMail;
        private TextBox txtClave;
        private TextBox txtNombreUsuario;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Button btnAceptar;
    }
}