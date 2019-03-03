namespace WinNutricion
{
    partial class AltaProfesionalFrm
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
            this.components = new System.ComponentModel.Container();
            this.aceptar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textDNI = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textNOmbre = new System.Windows.Forms.TextBox();
            this.textMatricula = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.FechaAltaDpk = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textMedico = new System.Windows.Forms.ComboBox();
            this.textNutricionista = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(88, 231);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 0;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(274, 231);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 1;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Matricula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Medico";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nutricionista";
            // 
            // textDNI
            // 
            this.textDNI.Location = new System.Drawing.Point(63, 18);
            this.textDNI.Name = "textDNI";
            this.textDNI.Size = new System.Drawing.Size(106, 20);
            this.textDNI.TabIndex = 9;
            this.textDNI.TextChanged += new System.EventHandler(this.textDNI_TextChanged);
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(262, 15);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(106, 20);
            this.textTelefono.TabIndex = 10;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(63, 166);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(106, 20);
            this.textApellido.TabIndex = 13;
            // 
            // textNOmbre
            // 
            this.textNOmbre.Location = new System.Drawing.Point(63, 113);
            this.textNOmbre.Name = "textNOmbre";
            this.textNOmbre.Size = new System.Drawing.Size(106, 20);
            this.textNOmbre.TabIndex = 14;
            // 
            // textMatricula
            // 
            this.textMatricula.Location = new System.Drawing.Point(63, 63);
            this.textMatricula.Name = "textMatricula";
            this.textMatricula.Size = new System.Drawing.Size(106, 20);
            this.textMatricula.TabIndex = 15;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(196, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Fecha";
            // 
            // FechaAltaDpk
            // 
            this.FechaAltaDpk.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaAltaDpk.Location = new System.Drawing.Point(262, 62);
            this.FechaAltaDpk.Name = "FechaAltaDpk";
            this.FechaAltaDpk.Size = new System.Drawing.Size(111, 20);
            this.FechaAltaDpk.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textNutricionista);
            this.groupBox1.Controls.Add(this.textMedico);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textTelefono);
            this.groupBox1.Controls.Add(this.FechaAltaDpk);
            this.groupBox1.Controls.Add(this.textDNI);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textMatricula);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textApellido);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textNOmbre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 202);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta Profesional";
            // 
            // textMedico
            // 
            this.textMedico.FormattingEnabled = true;
            this.textMedico.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.textMedico.Location = new System.Drawing.Point(262, 165);
            this.textMedico.Name = "textMedico";
            this.textMedico.Size = new System.Drawing.Size(111, 21);
            this.textMedico.TabIndex = 19;
            // 
            // textNutricionista
            // 
            this.textNutricionista.FormattingEnabled = true;
            this.textNutricionista.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.textNutricionista.Location = new System.Drawing.Point(262, 112);
            this.textNutricionista.Name = "textNutricionista";
            this.textNutricionista.Size = new System.Drawing.Size(111, 21);
            this.textNutricionista.TabIndex = 20;
            // 
            // AltaProfesionalFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 266);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "AltaProfesionalFrm";
            this.Text = "Alta Profesional";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textDNI;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textNOmbre;
        private System.Windows.Forms.TextBox textMatricula;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker FechaAltaDpk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox textMedico;
        private System.Windows.Forms.ComboBox textNutricionista;
    }
}