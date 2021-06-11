using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicaciónFuncional
{
    public partial class frmProductos : Form
    {
        clsProductos productos = new clsProductos();
        int posX = 0;
        int posY = 0;
        private Stream myStream;
        string archivo = "";

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

        /***DATAGRIDVIEW***/
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

        /***FORMULARIO***/
        private void frmProductos_Load(object sender, EventArgs e)
        {
            
            dgvProductos.AllowUserToAddRows = false;
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

        /***BOTONES***/
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtDescripcion.Text == "" || txtPrecio.Text == "" || nudCantidad.Value == 0)
            {
                MessageBox.Show("¡Hay campos vacíos! \n Por favor diligencia todos los campos.");
            }
            else
            {
                try
                {
                    clsProductos productos = new clsProductos(Convert.ToInt32(txtCodigo.Text), txtDescripcion.Text, Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(nudCantidad.Value));
                    productos.Ingresar();

                    dgvProductos.DataSource = productos.Consultar();
                    MessageBox.Show("Producto ingresado correctamente");

                    txtCodigo.Text = "";
                    txtDescripcion.Text = "";
                    txtPrecio.Text = "";
                    nudCantidad.Value = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ingresar el producto " + ex.Message);
                }
            }
        }

        private void btnDescontinuar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtDescripcion.Text == "" || txtPrecio.Text == "" || nudCantidad.Value == 0)
            {
                MessageBox.Show("¡Hay campos vacíos! \n Por favor selecciona la fila del dato que deseas descontinuar.");
            }
            else
            {
                try
                {
                    clsProductos productos = new clsProductos();
                    productos.Descontinuar(Convert.ToInt32(txtCodigo.Text));

                    dgvProductos.DataSource = productos.Consultar();
                    MessageBox.Show("Producto eliminado con éxito");

                    txtCodigo.Text = "";
                    txtDescripcion.Text = "";
                    txtPrecio.Text = "";
                    nudCantidad.Value = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el producto " + ex.Message);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtDescripcion.Text == "" || txtPrecio.Text == "" || nudCantidad.Value == 0)
            {
                MessageBox.Show("¡Hay campos vacíos! \n Por favor selecciona la fila del dato que deseas modificar.");
            }
            else
            {
                try
                {
                    label1.Text = nudCantidad.Value.ToString();
                    clsProductos productos = new clsProductos(Convert.ToInt32(txtCodigo.Text), txtDescripcion.Text, Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(label1.Text));
                    productos.Modificar();

                    dgvProductos.DataSource = productos.Consultar();
                    MessageBox.Show("Producto modificado con éxtio");

                    txtCodigo.Text = "";
                    txtDescripcion.Text = "";
                    txtPrecio.Text = "";
                    nudCantidad.Value = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el producto" + ex.Message);
                }
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            FdProductos.Title = "Carga de archivo";
            FdProductos.InitialDirectory = Application.StartupPath;
            FdProductos.Filter = "Archivos de texto (*.txt)|*.txt| Archivos (*.csv)|*.csv";
            if (FdProductos.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = FdProductos.OpenFile()) != null)
                    {
                        archivo = FdProductos.FileName;
                        dgvProductos.DataSource = productos.Importar(myStream, ',', archivo);
                        dgvProductos.AllowUserToAddRows = false;
                        productos.Guardar(dgvProductos);
                        dgvProductos.DataSource = productos.Consultar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
        }

        private void btnExportarXLSX_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileXlsx = new SaveFileDialog() { Filter = "Archivo XLSX|*.xlsx" };
            if (saveFileXlsx.ShowDialog() == DialogResult.OK)
            {
                SLDocument sl = new SLDocument();

                int iR = 1;
                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    sl.SetCellValue(iR, 1, row.Cells[0].Value.ToString());
                    sl.SetCellValue(iR, 2, row.Cells[1].Value.ToString());
                    sl.SetCellValue(iR, 3, row.Cells[2].Value.ToString());
                    sl.SetCellValue(iR, 4, row.Cells[3].Value.ToString());
                    iR += 1;
                }
                sl.SaveAs(saveFileXlsx.FileName);
            }
        }
    }
}
