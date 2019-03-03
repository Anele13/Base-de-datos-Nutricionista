using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using LibNutricion.db;
using WinNutricion;

namespace WinNutricion
{
    public partial class ListarControlesPacienteFrm : Form
    {
        private SaveFileDialog _saveFileDialog;

        public ListarControlesPacienteFrm()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ListarControlesPacienteFrm_Load(object sender, EventArgs e)
        {
            List<Paciente> pacientes = new List<Paciente>();
            pacientes = ManagerDB<Paciente>.findAll();
            foreach (Paciente paciente in pacientes)
            {
                this.cmbPaciente.Items.Add(paciente.Dni);
            }            


        }

        private void girdPacienteControl_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            PacienteControl pacienteControl = new PacienteControl();

            foreach (DataGridViewRow row in girdPacienteControl.Rows)
            {
                DataGridViewCell cell;
                pacienteControl = (row.DataBoundItem as PacienteControl);
                cell = row.Cells[0];
                cell.Value = String.Format("{0}", pacienteControl.DniPaciente);                                
                cell = row.Cells[1];
                cell.Value = String.Format("{0}", pacienteControl.Fecha);
                cell = row.Cells[2];
                cell.Value = String.Format("{0}", pacienteControl.Peso);
            }       

        }

        private void cmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
                     
            string criterio;
            criterio = "dni_paciente = " + this.cmbPaciente.SelectedItem;

            
            this.girdPacienteControl.AutoGenerateColumns = false;
            this.groupControlPaciente.Visible = true;
            List<PacienteControl> lista = ManagerDB<PacienteControl>.findAll(criterio);
            this.girdPacienteControl.DataSource = lista;

            /* PONER MENSAJE SI ES NULA
            if (lista.)
            {
                MessageBox.Show("El paciente cuyo Dni: " + this.cmbPaciente.SelectedItem + " no posee controles");
            }*/
            

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this._saveFileDialog = new SaveFileDialog();
            this._saveFileDialog.Title = "Guardar Archivo";
            this._saveFileDialog.Filter = "Archivo de Texto (.txt) |*.txt";
            this._saveFileDialog.DefaultExt = "txt";
            this._saveFileDialog.AddExtension = true;
            this._saveFileDialog.FileName = String.Format("listadoControlesPaciente({0}).txt", DateTime.Today.ToString("dd-MM-yyyy"));


            if (this._saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ruta = this._saveFileDialog.FileName;
                StreamWriter fichero = new StreamWriter(ruta);
                fichero.Write(listadoControlesPaciente());
                fichero.Close();
                MessageBox.Show("Se guardo el archivo: " + this._saveFileDialog.FileName);
            }

            this._saveFileDialog.Dispose();
        }

        private string listadoControlesPaciente()
        {
            string criterio;
            criterio = "dni_paciente = " + this.cmbPaciente.SelectedItem;

            List<PacienteControl> lista = ManagerDB<PacienteControl>.findAll(criterio);
            string listado = String.Format("Listado de Controles de un Paciente{0}", Environment.NewLine);

            listado = String.Format("DNI|Fecha|Peso{0}{1}", Environment.NewLine, Environment.NewLine);

            foreach (PacienteControl pc in lista)
            {
                listado += String.Format("{0}|{1}|{2}{3}", pc.DniPaciente, pc.Fecha, pc.Peso, Environment.NewLine);
            }

            return listado;

        }

    }
}
