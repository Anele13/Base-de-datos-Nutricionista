namespace WinNutricion
{
    partial class ListarProfesionalesFrm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grupProfesionales = new System.Windows.Forms.GroupBox();
            this.gridProfesionales = new System.Windows.Forms.DataGridView();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Alta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.es_medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.es_nutricionista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grupProfesionales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfesionales)).BeginInit();
            this.SuspendLayout();
            // 
            // grupProfesionales
            // 
            this.grupProfesionales.Controls.Add(this.gridProfesionales);
            this.grupProfesionales.Location = new System.Drawing.Point(40, 37);
            this.grupProfesionales.Name = "grupProfesionales";
            this.grupProfesionales.Size = new System.Drawing.Size(547, 175);
            this.grupProfesionales.TabIndex = 0;
            this.grupProfesionales.TabStop = false;
            this.grupProfesionales.Text = "Profesionales";
            // 
            // gridProfesionales
            // 
            this.gridProfesionales.AllowUserToAddRows = false;
            this.gridProfesionales.AllowUserToDeleteRows = false;
            this.gridProfesionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProfesionales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dni,
            this.Matricula,
            this.Nombre,
            this.Telefono,
            this.Fecha_Alta,
            this.es_medico,
            this.es_nutricionista});
            this.gridProfesionales.Location = new System.Drawing.Point(16, 19);
            this.gridProfesionales.Name = "gridProfesionales";
            this.gridProfesionales.ReadOnly = true;
            this.gridProfesionales.Size = new System.Drawing.Size(512, 136);
            this.gridProfesionales.TabIndex = 0;
            this.gridProfesionales.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridProfesionales_DataBindingComplete);
            // 
            // Dni
            // 
            this.Dni.HeaderText = "Dni";
            this.Dni.Name = "Dni";
            this.Dni.ReadOnly = true;
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre y Apellido";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Fecha_Alta
            // 
            this.Fecha_Alta.HeaderText = "Fecha Alta";
            this.Fecha_Alta.Name = "Fecha_Alta";
            this.Fecha_Alta.ReadOnly = true;
            // 
            // es_medico
            // 
            this.es_medico.HeaderText = "Medico";
            this.es_medico.Name = "es_medico";
            this.es_medico.ReadOnly = true;
            // 
            // es_nutricionista
            // 
            this.es_nutricionista.HeaderText = "Nutricionista";
            this.es_nutricionista.Name = "es_nutricionista";
            this.es_nutricionista.ReadOnly = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(56, 231);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(493, 231);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ListarProfesionalesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 280);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grupProfesionales);
            this.Name = "ListarProfesionalesFrm";
            this.Text = "ListarProfesionalesFrm";
            this.Load += new System.EventHandler(this.ListarProfesionalesFrm_Load);
            this.grupProfesionales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProfesionales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupProfesionales;
        private System.Windows.Forms.DataGridView gridProfesionales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Alta;
        private System.Windows.Forms.DataGridViewTextBoxColumn es_medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn es_nutricionista;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}