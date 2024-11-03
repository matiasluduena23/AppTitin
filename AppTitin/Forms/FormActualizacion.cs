using AppTitin.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AppTitin
{
    public partial class FormActualizacion : Form
    {
        public FormActualizacion()
        {
            InitializeComponent();
        }

        private void FormActualizacion_Load(object sender, EventArgs e)
        {
            cargarData();
            txtTipo.Enabled = false; txtPrecio.Enabled = false;
            txtTipoC.Enabled = false; txtPrecioC.Enabled = false;
            btnCancelar.Enabled = false; btnEliminar.Enabled = false;
            btnGuardar.Enabled = false; btnModificar.Enabled = false;
            btnCancelarC.Enabled = false; btnEliminarC.Enabled = false;
            btnGuardarC.Enabled = false; btnModificarC.Enabled = false;
        }

        private void cargarData()
        {
            Metodos m = new Metodos();
            string pathV = @"C:\ZimmerGlass\Datos\Vidrios.xml";
            string pathC = @"C:\ZimmerGlass\Datos\Camaras.xml";
            dgvVidrios.DataSource = m.lista(pathV, "Vidrios", "vidrio").ToList();
            dgvCamaras.DataSource = m.lista(pathC, "Camaras", "camara").ToList();
        }

        private void dgvVidrios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvVidrios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtTipo.Enabled = false; txtPrecio.Enabled = false;
                txtTipo.Text = dgvVidrios.Rows[e.RowIndex].Cells[0].Value + "";
                txtPrecio.Text = dgvVidrios.Rows[e.RowIndex].Cells[1].Value + "";
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtTipo.Text = ""; txtPrecio.Text = "";
            txtPrecio.Enabled = true; txtTipo.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtTipo.Text = ""; txtPrecio.Text = "";
            txtPrecio.Enabled = false; txtTipo.Enabled = false;
            btnCancelar.Enabled = false;
            btnNuevo.Enabled = true;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtPrecio.Enabled = true; txtTipo.Enabled = false;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MetoActulizacion m = new MetoActulizacion();
            m.eliminar(txtTipo.Text, "Vidrios");
            cargarData();
            txtPrecio.Clear(); txtTipo.Clear(); btnModificar.Enabled = false;
            btnEliminar.Enabled = false; btnGuardar.Enabled = false; btnNuevo.Enabled = true;
            btnCancelar.Enabled = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MetoActulizacion m = new MetoActulizacion();
            m.Guardar(txtTipo.Text, txtPrecio.Text,"Vidrios","vidrio"); 
            cargarData();
            txtTipo.Clear(); txtPrecio.Clear(); btnCancelar.Enabled = false;
            btnGuardar.Enabled = false; btnNuevo.Enabled = true;
            txtTipo.Enabled = false; txtPrecio.Enabled = false;
        }

        private void btnNuevoC_Click(object sender, EventArgs e)
        {
            txtTipoC.Text = ""; txtPrecioC.Text = "";
            txtPrecioC.Enabled = true; txtTipoC.Enabled = true;
            btnCancelarC.Enabled = true;
            btnNuevoC.Enabled = false;
            btnModificarC.Enabled = false;
            btnGuardarC.Enabled = true;
            btnEliminarC.Enabled = false;

        }

        private void btnModificarC_Click(object sender, EventArgs e)
        {
            txtPrecioC.Enabled = true; txtTipoC.Enabled = false;
            btnCancelarC.Enabled = true;
            btnNuevoC.Enabled = false;
            btnModificarC.Enabled = false;
            btnGuardarC.Enabled = true;
            btnEliminarC.Enabled = false;
        }

        private void btnCancelarC_Click(object sender, EventArgs e)
        {
            txtTipoC.Text = ""; txtPrecioC.Text = "";
            txtPrecioC.Enabled = false; txtTipoC.Enabled = false;
            btnCancelarC.Enabled = false;
            btnNuevoC.Enabled = true;
            btnModificarC.Enabled = false;
            btnGuardarC.Enabled = false;
            btnEliminarC.Enabled = false;
        }

        private void dgvCamaras_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtTipoC.Enabled = false; txtPrecioC.Enabled = false;
                txtTipoC.Text = dgvCamaras.Rows[e.RowIndex].Cells[0].Value + "";
                txtPrecioC.Text = dgvCamaras.Rows[e.RowIndex].Cells[1].Value + "";
                btnEliminarC.Enabled = true;
                btnModificarC.Enabled = true;
                btnGuardarC.Enabled = false;
                btnCancelarC.Enabled = true;
                btnNuevoC.Enabled = false;
            }
        }

        private void btnEliminarC_Click(object sender, EventArgs e)
        {
            MetoActulizacion m = new MetoActulizacion();
            m.eliminar(txtTipoC.Text, "Camaras");
            cargarData();
            txtPrecioC.Clear(); txtTipoC.Clear(); btnModificarC.Enabled = false;
            btnEliminarC.Enabled = false; btnGuardarC.Enabled = false; btnNuevoC.Enabled = true;
            btnCancelarC.Enabled = false;
        }

        private void btnGuardarC_Click(object sender, EventArgs e)
        {
            MetoActulizacion m = new MetoActulizacion();
            m.Guardar(txtTipoC.Text, txtPrecioC.Text, "Camaras", "camara");
            cargarData();
            txtTipoC.Clear(); txtPrecioC.Clear(); btnCancelarC.Enabled = false;
            btnGuardarC.Enabled = false; btnNuevoC.Enabled = true;
            txtTipoC.Enabled = false; txtPrecioC.Enabled = false;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtPrecio.Text.Length; i++)
            {
                if (txtPrecio.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }


            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }

        private void txtPrecioC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtPrecioC.Text.Length; i++)
            {
                if (txtPrecioC.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }


            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}

