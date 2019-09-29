using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea1_prog2
{
    public partial class Form1 : Form
    {
        int n;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int n = dtgvAgenda.Rows.Add();

            dtgvAgenda.Rows[n].Cells[0].Value = textBoxNombre.Text;
            dtgvAgenda.Rows[n].Cells[1].Value = textBoxApellido.Text;
            dtgvAgenda.Rows[n].Cells[2].Value = textBoxEdad.Text;
            dtgvAgenda.Rows[n].Cells[3].Value = textBoxNacimiento.Text;
            dtgvAgenda.Rows[n].Cells[4].Value = textBoxDireccion.Text;
            dtgvAgenda.Rows[n].Cells[5].Value = textBoxPais.Text;
            dtgvAgenda.Rows[n].Cells[6].Value = textBoxProvincia.Text;
            dtgvAgenda.Rows[n].Cells[7].Value = textBoxTelefono.Text;
            dtgvAgenda.Rows[n].Cells[8].Value = textBoxCelular.Text;

            //Limpiar los txt
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxEdad.Text = "";
            textBoxNacimiento.Text = "";
            textBoxDireccion.Text = "";
            textBoxPais.Text = "";
            textBoxProvincia.Text = "";
            textBoxTelefono.Text = "";
            textBoxCelular.Text = "";
        }

        private void dtgvAgenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if(n!=-1)
            {
                lblInformacion.Text = (string)dtgvAgenda.Rows[n].Cells[1].Value;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                dtgvAgenda.Rows.RemoveAt(n);
            }
        }
    }
}
