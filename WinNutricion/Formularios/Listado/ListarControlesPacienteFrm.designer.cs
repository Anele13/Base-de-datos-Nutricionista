namespace WinNutricion
{
    partial class ListarControlesPacienteFrm
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
            this.groupControlPaciente = new System.Windows.Forms.GroupBox();
            this.girdPacienteControl = new System.Windows.Forms.DataGridView();
            this.dni_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControlPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.girdPacienteControl)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(132, 247);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 22);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(273, 247);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 22);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupControlPaciente
            // 
            this.groupControlPaciente.Controls.Add(this.girdPacienteControl);
            this.groupControlPaciente.Location = new System.Drawing.Point(22, 66);
            this.groupControlPaciente.Name = "groupControlPaciente";
            this.groupControlPaciente.Size = new System.Drawing.Size(476, 175);
            this.groupControlPaciente.TabIndex = 7;
            this.groupControlPaciente.TabStop = false;
            this.groupControlPaciente.Text = "Controles de un Paciente";
            this.groupControlPaciente.Visible = false;
            // 
            // girdPacienteControl
            // 
            this.girdPacienteControl.AllowUserToAddRows = false;
            this.girdPacienteControl.AllowUserToDeleteRows = false;
            this.girdPacienteControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.girdPacienteControl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dni_paciente,
            this.Nombre_apellido,
            this.Fecha,
            this.peso});
            this.girdPacienteControl.Location = new System.Drawing.Point(17, 32);
            this.girdPacienteControl.Name = "girdPacienteControl";
            this.girdPacienteControl.ReadOnly = true;
            this.girdPacienteControl.Size = new System.Drawing.Size(443, 125);
            this.girdPacienteControl.TabIndex = 0;
            this.girdPacienteControl.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.girdPacienteControl_DataBindingComplete);
            // 
            // dni_paciente
            // 
            this.dni_paciente.HeaderText = "Paciente";
            this.dni_paciente.Name = "dni_paciente";
            this.dni_paciente.ReadOnly = true;
            // 
            // Nombre_apellido
            // 
            this.Nombre_apellido.HeaderText = "Nombre y Apellido";
            this.Nombre_apellido.Name = "Nombre_apellido";
            this.Nombre_apellido.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // peso
            // 
            this.peso.HeaderText = "Peso";
            this.peso.Name = "peso";
            this.peso.ReadOnly = true;
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(342, 22);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(121, 21);
            this.cmbPaciente.TabIndex = 8;
            this.cmbPaciente.SelectedIndexChanged += new System.EventHandler(this.cmbPaciente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dni Paciente";
            // 
            // ListarControlesPacienteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 290);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPaciente);
            this.Controls.Add(this.groupControlPaciente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "ListarControlesPacienteFrm";
            this.Text = "Listado Controles Paciente";
            this.Load += new System.EventHandler(this.ListarControlesPacienteFrm_Load);
            this.groupControlPaciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.girdPacienteControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupControlPaciente;
        private System.Windows.Forms.DataGridView girdPacienteControl;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni_paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
    }
}