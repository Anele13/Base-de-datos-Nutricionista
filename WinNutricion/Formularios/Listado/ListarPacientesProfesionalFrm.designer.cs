namespace WinNutricion
{

    partial class ListarPacientesProfesionalFrm
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbProfesional = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grupPacientesProfesional = new System.Windows.Forms.GroupBox();
            this.gridPacienteProfesional = new System.Windows.Forms.DataGridView();
            this.DNI_Profesional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni_Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupPacientesProfesional.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacienteProfesional)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(46, 247);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(418, 247);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbProfesional
            // 
            this.cmbProfesional.FormattingEnabled = true;
            this.cmbProfesional.Location = new System.Drawing.Point(391, 25);
            this.cmbProfesional.Name = "cmbProfesional";
            this.cmbProfesional.Size = new System.Drawing.Size(121, 21);
            this.cmbProfesional.TabIndex = 2;
            this.cmbProfesional.SelectedIndexChanged += new System.EventHandler(this.cmbProfesional_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Profesional";
            // 
            // grupPacientesProfesional
            // 
            this.grupPacientesProfesional.Controls.Add(this.gridPacienteProfesional);
            this.grupPacientesProfesional.Location = new System.Drawing.Point(23, 49);
            this.grupPacientesProfesional.Name = "grupPacientesProfesional";
            this.grupPacientesProfesional.Size = new System.Drawing.Size(500, 190);
            this.grupPacientesProfesional.TabIndex = 4;
            this.grupPacientesProfesional.TabStop = false;
            this.grupPacientesProfesional.Text = "Pacientes de un Profesional";
            // 
            // gridPacienteProfesional
            // 
            this.gridPacienteProfesional.AllowUserToAddRows = false;
            this.gridPacienteProfesional.AllowUserToDeleteRows = false;
            this.gridPacienteProfesional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPacienteProfesional.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI_Profesional,
            this.Dni_Paciente,
            this.Fecha_desde,
            this.Fecha_hasta});
            this.gridPacienteProfesional.Location = new System.Drawing.Point(32, 37);
            this.gridPacienteProfesional.Name = "gridPacienteProfesional";
            this.gridPacienteProfesional.ReadOnly = true;
            this.gridPacienteProfesional.Size = new System.Drawing.Size(447, 136);
            this.gridPacienteProfesional.TabIndex = 0;
            this.gridPacienteProfesional.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridPacienteProfesional_DataBindingComplete);
            // 
            // DNI_Profesional
            // 
            this.DNI_Profesional.HeaderText = "DNI Profesional";
            this.DNI_Profesional.Name = "DNI_Profesional";
            this.DNI_Profesional.ReadOnly = true;
            // 
            // Dni_Paciente
            // 
            this.Dni_Paciente.HeaderText = "DNI Paciente";
            this.Dni_Paciente.Name = "Dni_Paciente";
            this.Dni_Paciente.ReadOnly = true;
            // 
            // Fecha_desde
            // 
            this.Fecha_desde.HeaderText = "Fecha Inicio";
            this.Fecha_desde.Name = "Fecha_desde";
            this.Fecha_desde.ReadOnly = true;
            // 
            // Fecha_hasta
            // 
            this.Fecha_hasta.HeaderText = "Fecha Fin";
            this.Fecha_hasta.Name = "Fecha_hasta";
            this.Fecha_hasta.ReadOnly = true;
            // 
            // ListarPacientesProfesionalFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 293);
            this.Controls.Add(this.grupPacientesProfesional);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProfesional);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "ListarPacientesProfesionalFrm";
            this.Text = "Listar Pacientes Profesional";
            this.Load += new System.EventHandler(this.ListarPacientesProfesionalFrm_Load);
            this.grupPacientesProfesional.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPacienteProfesional)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbProfesional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grupPacientesProfesional;
        private System.Windows.Forms.DataGridView gridPacienteProfesional;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI_Profesional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni_Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_hasta;
    }
}