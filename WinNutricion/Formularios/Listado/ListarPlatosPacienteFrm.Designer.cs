namespace WinNutricion
{
    partial class ListarPlatosPacienteFrm
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupPlatoPaciente = new System.Windows.Forms.GroupBox();
            this.girdPacientePlato = new System.Windows.Forms.DataGridView();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Codigo_Plato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni_Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPlatoPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.girdPacientePlato)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 22);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(75, 221);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 22);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupPlatoPaciente
            // 
            this.groupPlatoPaciente.Controls.Add(this.girdPacientePlato);
            this.groupPlatoPaciente.Location = new System.Drawing.Point(12, 56);
            this.groupPlatoPaciente.Name = "groupPlatoPaciente";
            this.groupPlatoPaciente.Size = new System.Drawing.Size(603, 159);
            this.groupPlatoPaciente.TabIndex = 17;
            this.groupPlatoPaciente.TabStop = false;
            this.groupPlatoPaciente.Text = "Platos de un Paciente";
            this.groupPlatoPaciente.Visible = false;
            // 
            // girdPacientePlato
            // 
            this.girdPacientePlato.AllowUserToAddRows = false;
            this.girdPacientePlato.AllowUserToDeleteRows = false;
            this.girdPacientePlato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.girdPacientePlato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_Plato,
            this.Dni_Paciente,
            this.Cantidad,
            this.Fecha});
            this.girdPacientePlato.Location = new System.Drawing.Point(63, 31);
            this.girdPacientePlato.Name = "girdPacientePlato";
            this.girdPacientePlato.ReadOnly = true;
            this.girdPacientePlato.Size = new System.Drawing.Size(443, 108);
            this.girdPacientePlato.TabIndex = 0;
            this.girdPacientePlato.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.girdPacientePlato_DataBindingComplete_1);
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(281, 29);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(121, 21);
            this.cmbPaciente.TabIndex = 16;
            this.cmbPaciente.SelectedIndexChanged += new System.EventHandler(this.cmbPaciente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Dni Paciente";
            // 
            // Codigo_Plato
            // 
            this.Codigo_Plato.HeaderText = "Codigo Plato";
            this.Codigo_Plato.Name = "Codigo_Plato";
            this.Codigo_Plato.ReadOnly = true;
            // 
            // Dni_Paciente
            // 
            this.Dni_Paciente.HeaderText = "DNI Paciente";
            this.Dni_Paciente.Name = "Dni_Paciente";
            this.Dni_Paciente.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // ListarPlatosPacienteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 273);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupPlatoPaciente);
            this.Controls.Add(this.cmbPaciente);
            this.Controls.Add(this.label1);
            this.Name = "ListarPlatosPacienteFrm";
            this.Text = "ListarPlatosPacienteFrm";
            this.Load += new System.EventHandler(this.ListarPlatosPacienteFrm_Load);
            this.groupPlatoPaciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.girdPacientePlato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupPlatoPaciente;
        private System.Windows.Forms.DataGridView girdPacientePlato;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Plato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni_Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}