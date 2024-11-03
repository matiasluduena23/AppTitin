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

namespace AppTitin.Forms
{
    public partial class FLOAT : Form
    {
        public FLOAT()
        {
            InitializeComponent();
        }

        private void FormCalculo2_Load(object sender, EventArgs e)
        {
            Metodos m = new Metodos();
            m.cargarCombo(cboV, "Vidrios", "vidrio");
        }


        private bool validar()
        {
            bool v = true;
            if (txtAlto.Text == "" || txtAncho.Text == "" || txtCantidad.Text == "")
            {
                v = false;
                MessageBox.Show("Completar todos los campos!!", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return v;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                try
                {
                    Metodos m = new Metodos();
                    string m2tipo = m.metrosCuadradosXtipo(txtAlto.Text, txtAncho.Text, txtCantidad.Text).ToString();

                    dgvDatos.Rows.Insert(0, txtCantidad.Text, txtAlto.Text, txtAncho.Text, m2tipo,
                                            m.metrosLineales(txtAlto.Text, txtAncho.Text, txtCantidad.Text).ToString(),
                                            cboV.Text + ": " + cboV.SelectedValue.ToString(),
                                              m.precioTipo(cboV.SelectedValue.ToString(), Convert.ToDouble(m2tipo)).ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en dataGrid: " + ex.Message);
                }
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }

        private void bntEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDatos.RowCount > 0)
                {
                    dgvDatos.Rows.RemoveAt(dgvDatos.CurrentRow.Index);
                }
            }
            catch (Exception l)
            {
                MessageBox.Show("Error eliminando fila: " + l.Message);
            }
        }

        private void limpiar()
        {
            txtAlto.Clear(); txtAncho.Clear(); txtCantidad.Clear();
            dgvDatos.Rows.Clear();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (dgvDatos.RowCount > 0 && txtCliente.Text != "")
            {
                Metodos m = new Metodos();
                m.generarPdf(dgvDatos, txtCliente.Text, txtObsevaciones.Text);
                limpiar();
            }
            else
            {
                MessageBox.Show("Ingrese datos!!", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCantidad.Focus();
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
