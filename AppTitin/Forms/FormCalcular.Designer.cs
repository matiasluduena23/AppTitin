namespace AppTitin
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cboT1 = new System.Windows.Forms.ComboBox();
            this.cboT2 = new System.Windows.Forms.ComboBox();
            this.cboCam = new System.Windows.Forms.ComboBox();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.txtAlto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preciotipo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciotipo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metrosl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metros2T1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntEliminar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtObsevaciones = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboT1
            // 
            this.cboT1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboT1.FormattingEnabled = true;
            this.cboT1.Location = new System.Drawing.Point(370, 54);
            this.cboT1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboT1.Name = "cboT1";
            this.cboT1.Size = new System.Drawing.Size(128, 23);
            this.cboT1.TabIndex = 0;
            this.cboT1.SelectedIndexChanged += new System.EventHandler(this.cboT1_SelectedIndexChanged);
            // 
            // cboT2
            // 
            this.cboT2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboT2.FormattingEnabled = true;
            this.cboT2.Location = new System.Drawing.Point(788, 54);
            this.cboT2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboT2.Name = "cboT2";
            this.cboT2.Size = new System.Drawing.Size(128, 23);
            this.cboT2.TabIndex = 2;
            this.cboT2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cboCam
            // 
            this.cboCam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCam.FormattingEnabled = true;
            this.cboCam.Location = new System.Drawing.Point(579, 54);
            this.cboCam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboCam.Name = "cboCam";
            this.cboCam.Size = new System.Drawing.Size(128, 23);
            this.cboCam.TabIndex = 1;
            this.cboCam.SelectedIndexChanged += new System.EventHandler(this.cboCam_SelectedIndexChanged);
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(788, 136);
            this.txtAncho.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(128, 23);
            this.txtAncho.TabIndex = 5;
            this.txtAncho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAncho_KeyPress);
            // 
            // txtAlto
            // 
            this.txtAlto.Location = new System.Drawing.Point(579, 136);
            this.txtAlto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAlto.Name = "txtAlto";
            this.txtAlto.Size = new System.Drawing.Size(128, 23);
            this.txtAlto.TabIndex = 4;
            this.txtAlto.TextChanged += new System.EventHandler(this.txtAlto_TextChanged);
            this.txtAlto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlto_KeyPress);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(370, 136);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(128, 23);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(608, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Camara";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(822, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(391, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(820, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ancho";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(624, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Alto";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, 184);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeColumns = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column7,
            this.Preciotipo1,
            this.preciotipo2,
            this.precioc,
            this.metrosl,
            this.metros2T1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvDatos.Location = new System.Drawing.Point(26, 249);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(1228, 250);
            this.dgvDatos.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "dcan";
            this.Column1.HeaderText = "Cantidad";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "dAlto";
            this.Column6.HeaderText = "Alto";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "dAncho";
            this.Column7.HeaderText = "Ancho";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Preciotipo1
            // 
            this.Preciotipo1.DataPropertyName = "preciotipo1";
            this.Preciotipo1.HeaderText = "Precio   T-1";
            this.Preciotipo1.Name = "Preciotipo1";
            this.Preciotipo1.ReadOnly = true;
            // 
            // preciotipo2
            // 
            this.preciotipo2.DataPropertyName = "preciotipo2";
            this.preciotipo2.HeaderText = "Precio   T-2";
            this.preciotipo2.Name = "preciotipo2";
            this.preciotipo2.ReadOnly = true;
            // 
            // precioc
            // 
            this.precioc.DataPropertyName = "preiocamara";
            this.precioc.HeaderText = "Precio Cam";
            this.precioc.Name = "precioc";
            this.precioc.ReadOnly = true;
            // 
            // metrosl
            // 
            this.metrosl.DataPropertyName = "metrosl";
            this.metrosl.HeaderText = "Metros Lineal";
            this.metrosl.Name = "metrosl";
            this.metrosl.ReadOnly = true;
            // 
            // metros2T1
            // 
            this.metros2T1.DataPropertyName = "metros2T1";
            this.metros2T1.HeaderText = "m2 Por   T";
            this.metros2T1.Name = "metros2T1";
            this.metros2T1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "preT1";
            this.Column2.HeaderText = "Precio   T-1";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "preT2";
            this.Column3.HeaderText = "Precio   T-2";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "PreCam";
            this.Column4.HeaderText = "Precio Cam";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "preTotal";
            this.Column5.HeaderText = "Precio Total";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // bntEliminar
            // 
            this.bntEliminar.Location = new System.Drawing.Point(40, 579);
            this.bntEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bntEliminar.Name = "bntEliminar";
            this.bntEliminar.Size = new System.Drawing.Size(150, 41);
            this.bntEliminar.TabIndex = 14;
            this.bntEliminar.Text = "Eliminar Fila";
            this.bntEliminar.UseVisualStyleBackColor = true;
            this.bntEliminar.Click += new System.EventHandler(this.bntEliminar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(1028, 579);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(150, 41);
            this.btnReporte.TabIndex = 9;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppTitin.Properties.Resources.zimmerglass2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // txtObsevaciones
            // 
            this.txtObsevaciones.Location = new System.Drawing.Point(694, 521);
            this.txtObsevaciones.Multiline = true;
            this.txtObsevaciones.Name = "txtObsevaciones";
            this.txtObsevaciones.Size = new System.Drawing.Size(237, 77);
            this.txtObsevaciones.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(563, 527);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "Observaciones";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 527);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(335, 524);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(163, 23);
            this.txtCliente.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1277, 632);
            this.Controls.Add(this.txtObsevaciones);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.bntEliminar);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtAlto);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.cboCam);
            this.Controls.Add(this.cboT2);
            this.Controls.Add(this.cboT1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1293, 671);
            this.MinimumSize = new System.Drawing.Size(1293, 671);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DVH";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboT1;
        private System.Windows.Forms.ComboBox cboT2;
        private System.Windows.Forms.ComboBox cboCam;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.TextBox txtAlto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button bntEliminar;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preciotipo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciotipo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioc;
        private System.Windows.Forms.DataGridViewTextBoxColumn metrosl;
        private System.Windows.Forms.DataGridViewTextBoxColumn metros2T1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtObsevaciones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCliente;
    }
}

