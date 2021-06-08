using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicaciónFuncional
{
    public partial class frmProductos : Form
    {
        int posX = 0;
        int posY = 0;

        public frmProductos()
        {
            InitializeComponent();
        }

        /***PARA MOVER EL FORMULARIO***/
        private void pnlMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        /***PARA CERRAR EL FORMULARIO***/
        private void picCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /***PARA IR ATRAS***/
        private void picAtras_Click(object sender, EventArgs e)
        {
            frmMenu FMen = new frmMenu();
            this.Hide();
            FMen.Show();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo.Text == "")
                {
                    clsProductos productos = new clsProductos();
                    dgvProductos.DataSource = productos.Consultar();
                }
                else
                {
                    clsProductos productos = new clsProductos();
                    dgvProductos.DataSource = productos.Seleccionar(Convert.ToInt32(txtCodigo.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar el dato" + ex.Message);
            }

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                clsProductos productos = new clsProductos(Convert.ToInt32(txtCodigo.Text), txtDescripcion.Text, Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(nudCantidad.Value));

                productos.Ingresar();

                MessageBox.Show("Producto ingresado correctamente");
                dgvProductos.DataSource = productos.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar el producto " + ex.Message);
            }

        }

        private void btnDescontinuar_Click(object sender, EventArgs e)
        {
            try
            {
                clsProductos productos = new clsProductos();

                productos.Descontinuar(Convert.ToInt32(txtCodigo.Text));

                dgvProductos.DataSource = productos.Consultar();

                MessageBox.Show("Producto eliminado con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                clsProductos productos = new clsProductos(Convert.ToInt32(txtCodigo.Text), txtDescripcion.Text, Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(nudCantidad.Value));
                productos.Modificar();

                dgvProductos.DataSource = productos.Consultar();
                MessageBox.Show("Producto modificado con éxtio");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el producto" + ex.Message);
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProductos.Rows[e.RowIndex];
                txtCodigo.Text = row.Cells["Código"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripción"].Value.ToString();
                txtPrecio.Text = row.Cells["Precio"].Value.ToString();
                nudCantidad.Text = row.Cells["Unidades"].Value.ToString();
            }
        }
    }
}
