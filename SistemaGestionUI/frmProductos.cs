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

namespace SistemaGestionUI
{
    public partial class frmProductos : Form
    {
        public object ProductoBusiness { get; private set; }

        public frmProductos()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
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

        private void btnBuscarId_Click(object sender, EventArgs e)
        {

        }

        private void frmProductos_Load(object sender, EventArgs e)
        {

            List<Producto> productos = ProductoBusiness.GetProductos();

            dgvProductos.AutoGenerateColumns = true;
            dgvProductos.DataSource = productos;



        }
    }
}
