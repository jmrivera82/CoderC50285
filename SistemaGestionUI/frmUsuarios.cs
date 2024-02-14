using SistemaGestionData.Models;
using SistemaGestionData.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;


namespace SistemaGestionUI
{
    public partial class frmUsuarios : Form
    {

        public Usuario usuarioSeleccionado { get; private set; }

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarios = UsuarioService.ObtenerTodosLosUsuarios();
            this.ActualizarDgv(usuarios);
        }


        private void ActualizarDgv(object objeto)
        {
            this.dgvDatos.DataSource = null;
            this.dgvDatos.DataSource = objeto;
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            string idString = this.txtId.Text;
            int id = Convert.ToInt32(idString);

            Usuario usuarioBuscado = UsuarioService.ObtenerUsuarioPorId(id);

            List<Usuario> lista = new List<Usuario>() { usuarioBuscado };

            this.ActualizarDgv(lista);
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            ABMUsuarios frmAlta = new ABMUsuarios();
            frmAlta.ShowDialog();

            this.Hide();

            Usuario usuario = frmAlta.UsuarioCreado;


            this.Show();

            if (UsuarioService.AgregarUsuario(usuario))
            {
                MessageBox.Show("Se agregó un usuario", "Alta");

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Codigo para eliminar producto visto en clases

            string idString = this.txtId.Text;

            if (!string.IsNullOrWhiteSpace(idString))
            {
                int id = Convert.ToInt32(idString);
                bool resultado = ProductoService.EliminarProductoPorId(id);

                if (resultado)
                {
                    MessageBox.Show("Se eliminó", "Atencion ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);


                }

            }
            else
            {
                MessageBox.Show("Complete Id", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtId.Focus();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ABMUsuarios frm = new ABMUsuarios(this.usuarioSeleccionado);
            frm.ShowDialog();
            Usuario usuarioModificado = frm.UsuarioCreado;

            if (UsuarioService.ActualizarUsuarioPorId(usuarioModificado, this.usuarioSeleccionado.Id))
            {
                MessageBox.Show("Actualicé", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)

        {
            var seleccion = this.dgvDatos.SelectedRows;
            if (seleccion.Count > 0)
            {
                object dato = seleccion[0].DataBoundItem;

                this.usuarioSeleccionado = dato as Usuario;
            }

        }



    }
}
