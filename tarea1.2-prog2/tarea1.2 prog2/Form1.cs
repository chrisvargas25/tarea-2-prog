using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea1._2_prog2
{
    public partial class Form1 : Form
    {
        int n;
        public Form1()
        {
            InitializeComponent();
        }

        private void Apellido_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int n = dtgvProducto.Rows.Add();

            dtgvProducto.Rows[n].Cells[0].Value = textBoxCodigo.Text;
            dtgvProducto.Rows[n].Cells[1].Value = textBoxNombre.Text;
            dtgvProducto.Rows[n].Cells[2].Value = textBoxDetalle.Text;
            dtgvProducto.Rows[n].Cells[3].Value = textBoxCosto.Text;
            dtgvProducto.Rows[n].Cells[4].Value = textBoxPrecio.Text;
            dtgvProducto.Rows[n].Cells[5].Value = textBoxFechaCreacion.Text;
            dtgvProducto.Rows[n].Cells[6].Value = textBoxFechaVencimiento.Text;
            dtgvProducto.Rows[n].Cells[7].Value = textBoxCategoria.Text;
            dtgvProducto.Rows[n].Cells[8].Value = textBoxEstado.Text;

            //Limpiar los txt
            textBoxCodigo.Text = "";
            textBoxNombre.Text = "";
            textBoxDetalle.Text = "";
            textBoxCosto.Text = "";
            textBoxPrecio.Text = "";
            textBoxFechaCreacion.Text = "";
            textBoxFechaVencimiento.Text = "";
            textBoxCategoria.Text = "";
            textBoxEstado.Text = "";
        }

        private void dtgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if (n != -1)
            {
                lblInformacion.Text = (string)dtgvProducto.Rows[n].Cells[1].Value;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                dtgvProducto.Rows.RemoveAt(n);
            }
        }
    }
}
