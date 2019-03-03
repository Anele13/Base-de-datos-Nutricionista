namespace WinNutricion
{
    partial class ListarDietasPacienteFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.groupDietaPaciente = new System.Windows.Forms.GroupBox();
            this.girdPacienteDieta = new System.Windows.Forms.DataGridView();
            this.Codigo_dieta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Dieta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni_Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupDietaPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.girdPacienteDieta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dni Paciente";
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(433, 29);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(121, 21);
            this.cmbPaciente.TabIndex = 11;
            this.cmbPaciente.SelectedIndexChanged += new System.EventHandler(this.cmbPaciente_SelectedIndexChanged);
            // 
            // groupDietaPaciente
            // 
            this.groupDietaPaciente.AutoSize = true;
            this.groupDietaPaciente.Controls.Add(this.girdPacienteDieta);
            this.groupDietaPaciente.Location = new System.Drawing.Point(12, 64);
            this.groupDietaPaciente.Name = "groupDietaPaciente";
            this.groupDietaPaciente.Size = new System.Drawing.Size(578, 226);
            this.groupDietaPaciente.TabIndex = 12;
            this.groupDietaPaciente.TabStop = false;
            this.groupDietaPaciente.Text = "Dietas de un Paciente";
            this.groupDietaPaciente.Visible = false;
            // 
            // girdPacienteDieta
            // 
            this.girdPacienteDieta.AllowUserToAddRows = false;
            this.girdPacienteDieta.AllowUserToDeleteRows = false;
            this.girdPacienteDieta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.girdPacienteDieta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_dieta,
            this.Nombre_Dieta,
            this.Dni_Paciente,
            this.Nombre_Apellido,
            this.Fecha,
            this.Fecha_Fin});
            this.girdPacienteDieta.Location = new System.Drawing.Point(20, 19);
            this.girdPacienteDieta.Name = "girdPacienteDieta";
            this.girdPacienteDieta.ReadOnly = true;
            this.girdPacienteDieta.Size = new System.Drawing.Size(545, 188);
            this.girdPacienteDieta.TabIndex = 0;
            this.girdPacienteDieta.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.girdPacienteDieta_DataBindingComplete);
            // 
            // Codigo_dieta
            // 
            this.Codigo_dieta.HeaderText = "Codigo Dieta";
            this.Codigo_dieta.Name = "Codigo_dieta";
            this.Codigo_dieta.ReadOnly = true;
            // 
            // Nombre_Dieta
            // 
            this.Nombre_Dieta.HeaderText = "Nombre Dieta";
            this.Nombre_Dieta.Name = "Nombre_Dieta";
            this.Nombre_Dieta.ReadOnly = true;
            // 
            // Dni_Paciente
            // 
            this.Dni_Paciente.HeaderText = "DNI Paciente";
            this.Dni_Paciente.Name = "Dni_Paciente";
            this.Dni_Paciente.ReadOnly = true;
            // 
            // Nombre_Apellido
            // 
            this.Nombre_Apellido.HeaderText = "Nombre y Apellido";
            this.Nombre_Apellido.Name = "Nombre_Apellido";
            this.Nombre_Apellido.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Fecha_Fin
            // 
            this.Fecha_Fin.HeaderText = "Fecha Fin";
            this.Fecha_Fin.Name = "Fecha_Fin";
            this.Fecha_Fin.ReadOnly = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(171, 314);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 22);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 22);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListarDietasPacienteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupDietaPaciente);
            this.Controls.Add(this.cmbPaciente);
            this.Controls.Add(this.label1);
            this.Name = "ListarDietasPacienteFrm";
            this.Text = "Listado Dietas Paciente";
            this.Load += new System.EventHandler(this.ListarDietasPacienteFrm_Load);
            this.groupDietaPaciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.girdPacienteDieta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.GroupBox groupDietaPaciente;
        private System.Windows.Forms.DataGridView girdPacienteDieta;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_dieta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Dieta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni_Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Fin;
    }
}