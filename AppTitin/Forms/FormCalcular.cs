using System;
using System.Linq;
using System.Windows.Forms;
using AppTitin.Modelos;

namespace AppTitin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Metodos m = new Metodos();
            m.cargarCombo(cboT1, "Vidrios", "vidrio");
            m.cargarCombo(cboT2, "Vidrios", "vidrio");
            m.cargarCombo(cboCam, "Camaras", "camara");
        }

        

        private void limpiar()
        {
            txtAlto.Clear(); txtAncho.Clear(); txtCantidad.Clear();
            dgvDatos.Rows.Clear();
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool validar()
        {
            bool v = true;
            if(txtAlto.Text == "" || txtAncho.Text == "" || txtCantidad.Text == "")
            {
                v = false;
                MessageBox.Show("Completa todos los campos!!", "Atencion!",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    string precioT1 = m.precioTipo(cboT1.SelectedValue.ToString(), Convert.ToDouble(m2tipo)).ToString();
                    string precioT2 = m.precioTipo(cboT2.SelectedValue.ToString(), Convert.ToDouble(m2tipo)).ToString();
                    string precioCAm = m.precioCamara(cboCam.SelectedValue.ToString(), m.metrosLineales(txtAlto.Text, txtAncho.Text, txtCantidad.Text)).ToString();
                    
                        dgvDatos.Rows.Insert(0,txtCantidad.Text, txtAlto.Text, txtAncho.Text, cboT1.Text+": "+ cboT1.SelectedValue.ToString(), cboT2.Text+ ": "+ cboT2.SelectedValue.ToString(),cboCam.Text+": "+ cboCam.SelectedValue.ToString(),
                                                m.metrosLineales(txtAlto.Text, txtAncho.Text, txtCantidad.Text).ToString(), m2tipo, precioT1,  precioT2
                                                , precioCAm, m.total(precioT1, precioT2, precioCAm));
                    
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

        private void txtAlto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAncho_KeyPress(object sender, KeyPressEventArgs e)
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
        
        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (dgvDatos.RowCount > 0 && txtCliente.Text != "")
            {
                Metodos m = new Metodos();
                m.generarPdf(dgvDatos, txtCliente.Text, txtObsevaciones.Text);
                limpiar();
            }
            else
                MessageBox.Show("Ingrese datos!!", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            txtCantidad.Focus();
        }
        
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboT1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboCam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAlto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



