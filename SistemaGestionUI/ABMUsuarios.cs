using SistemaGestionData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUI
{
    public partial class ABMUsuarios : Form
    {
        public ABMUsuarios()
        {
            InitializeComponent();
        }


        public ABMUsuarios(Usuario usuario) : this()
        {
            this.txtNombre.Text = usuario.Nombre;
            this.txtApellido.Text = usuario.Apellido;
            this.txtNombreUsuario.Text = usuario.NombreUsuario;
            this.txtClave.Text = usuario.Contraseña;
            this.txtMail.Text = usuario.Mail;


        }


        public Usuario UsuarioCreado { get; private set; }



        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario() { Apellido = this.txtApellido.Text, Nombre = this.txtNombre.Text, Contraseña = this.txtClave.Text, NombreUsuario = this.txtNombreUsuario.Text, Mail = this.txtMail.Text };

            this.UsuarioCreado = usuario;

            this.Close();
        }
    }
}
