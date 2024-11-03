namespace AppTitin
{
    partial class FormActualizacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActualizacion));
            this.dgvVidrios = new System.Windows.Forms.DataGridView();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvCamaras = new System.Windows.Forms.DataGridView();
            this.btnGuardarC = new System.Windows.Forms.Button();
            this.btnModificarC = new System.Windows.Forms.Button();
            this.btnEliminarC = new System.Windows.Forms.Button();
            this.btnNuevoC = new System.Windows.Forms.Button();
            this.txtPrecioC = new System.Windows.Forms.TextBox();
            this.txtTipoC = new System.Windows.Forms.TextBox();
            this.btnCancelarC = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVidrios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamaras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVidrios
            // 
            this.dgvVidrios.AllowUserToAddRows = false;
            this.dgvVidrios.AllowUserToDeleteRows = false;
            this.dgvVidrios.AllowUserToResizeColumns = false;
            this.dgvVidrios.AllowUserToResizeRows = false;
            this.dgvVidrios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVidrios.Location = new System.Drawing.Point(14, 11);
            this.dgvVidrios.MultiSelect = false;
            this.dgvVidrios.Name = "dgvVidrios";
            this.dgvVidrios.ReadOnly = true;
            this.dgvVidrios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVidrios.Size = new System.Drawing.Size(244, 324);
            this.dgvVidrios.TabIndex = 0;
            this.dgvVidrios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVidrios_CellContentDoubleClick);
            this.dgvVidrios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVidrios_CellDoubleClick);
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(285, 67);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(116, 20);
            this.txtTipo.TabIndex = 0;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(421, 67);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(116, 20);
            this.txtPrecio.TabIndex = 1;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(294, 132);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(107, 30);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(294, 176);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 30);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(421, 132);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(107, 30);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(355, 225);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 30);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvCamaras
            // 
            this.dgvCamaras.AllowUserToAddRows = false;
            this.dgvCamaras.AllowUserToDeleteRows = false;
            this.dgvCamaras.AllowUserToResizeColumns = false;
            this.dgvCamaras.AllowUserToResizeRows = false;
            this.dgvCamaras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCamaras.Location = new System.Drawing.Point(600, 11);
            this.dgvCamaras.Name = "dgvCamaras";
            this.dgvCamaras.ReadOnly = true;
            this.dgvCamaras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCamaras.Size = new System.Drawing.Size(244, 324);
            this.dgvCamaras.TabIndex = 7;
            this.dgvCamaras.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCamaras_CellMouseDoubleClick);
            // 
            // btnGuardarC
            // 
            this.btnGuardarC.Location = new System.Drawing.Point(934, 225);
            this.btnGuardarC.Name = "btnGuardarC";
            this.btnGuardarC.Size = new System.Drawing.Size(107, 30);
            this.btnGuardarC.TabIndex = 9;
            this.btnGuardarC.Text = "Guardar";
            this.btnGuardarC.UseVisualStyleBackColor = true;
            this.btnGuardarC.Click += new System.EventHandler(this.btnGuardarC_Click);
            // 
            // btnModificarC
            // 
            this.btnModificarC.Location = new System.Drawing.Point(1000, 132);
            this.btnModificarC.Name = "btnModificarC";
            this.btnModificarC.Size = new System.Drawing.Size(107, 30);
            this.btnModificarC.TabIndex = 12;
            this.btnModificarC.Text = "Modificar";
            this.btnModificarC.UseVisualStyleBackColor = true;
            this.btnModificarC.Click += new System.EventHandler(this.btnModificarC_Click);
            // 
            // btnEliminarC
            // 
            this.btnEliminarC.Location = new System.Drawing.Point(873, 176);
            this.btnEliminarC.Name = "btnEliminarC";
            this.btnEliminarC.Size = new System.Drawing.Size(107, 30);
            this.btnEliminarC.TabIndex = 13;
            this.btnEliminarC.Text = "Eliminar";
            this.btnEliminarC.UseVisualStyleBackColor = true;
            this.btnEliminarC.Click += new System.EventHandler(this.btnEliminarC_Click);
            // 
            // btnNuevoC
            // 
            this.btnNuevoC.Location = new System.Drawing.Point(873, 132);
            this.btnNuevoC.Name = "btnNuevoC";
            this.btnNuevoC.Size = new System.Drawing.Size(107, 30);
            this.btnNuevoC.TabIndex = 11;
            this.btnNuevoC.Text = "Nuevo";
            this.btnNuevoC.UseVisualStyleBackColor = true;
            this.btnNuevoC.Click += new System.EventHandler(this.btnNuevoC_Click);
            // 
            // txtPrecioC
            // 
            this.txtPrecioC.Location = new System.Drawing.Point(1000, 67);
            this.txtPrecioC.Name = "txtPrecioC";
            this.txtPrecioC.Size = new System.Drawing.Size(116, 20);
            this.txtPrecioC.TabIndex = 8;
            this.txtPrecioC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioC_KeyPress);
            // 
            // txtTipoC
            // 
            this.txtTipoC.Location = new System.Drawing.Point(863, 67);
            this.txtTipoC.Name = "txtTipoC";
            this.txtTipoC.Size = new System.Drawing.Size(116, 20);
            this.txtTipoC.TabIndex = 7;
            // 
            // btnCancelarC
            // 
            this.btnCancelarC.Location = new System.Drawing.Point(1000, 176);
            this.btnCancelarC.Name = "btnCancelarC";
            this.btnCancelarC.Size = new System.Drawing.Size(107, 30);
            this.btnCancelarC.TabIndex = 10;
            this.btnCancelarC.Text = "Cancelar";
            this.btnCancelarC.UseVisualStyleBackColor = true;
            this.btnCancelarC.Click += new System.EventHandler(this.btnCancelarC_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(421, 176);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 30);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tipo Vidrio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1035, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(873, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tipo Camara";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "Precio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppTitin.Properties.Resources.zimmerglass2;
            this.pictureBox1.Location = new System.Drawing.Point(893, 312);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormActualizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1158, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCancelarC);
            this.Controls.Add(this.btnGuardarC);
            this.Controls.Add(this.btnModificarC);
            this.Controls.Add(this.btnEliminarC);
            this.Controls.Add(this.btnNuevoC);
            this.Controls.Add(this.txtPrecioC);
            this.Controls.Add(this.txtTipoC);
            this.Controls.Add(this.dgvCamaras);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.dgvVidrios);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1174, 405);
            this.MinimumSize = new System.Drawing.Size(1174, 405);
            this.Name = "FormActualizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos";
            this.Load += new System.EventHandler(this.FormActualizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVidrios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamaras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVidrios;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvCamaras;
        private System.Windows.Forms.Button btnGuardarC;
        private System.Windows.Forms.Button btnModificarC;
        private System.Windows.Forms.Button btnEliminarC;
        private System.Windows.Forms.Button btnNuevoC;
        private System.Windows.Forms.TextBox txtPrecioC;
        private System.Windows.Forms.TextBox txtTipoC;
        private System.Windows.Forms.Button btnCancelarC;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}