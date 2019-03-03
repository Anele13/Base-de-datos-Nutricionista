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

namespace WinNutricion
{
    public partial class ListarPacientesProfesionalFrm : Form
    {
        private SaveFileDialog _saveFileDialog;

        public ListarPacientesProfesionalFrm()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ListarPacientesProfesionalFrm_Load(object sender, EventArgs e)
        {
            this.grupPacientesProfesional.Visible = false;

            List<Profesional> profesionales = new List<Profesional>();
            profesionales = ManagerDB<Profesional>.findAll();
            foreach (Profesional profesional in profesionales)
            {
                this.cmbProfesional.Items.Add(profesional.Dni);
            } 
        }

        private void gridPacienteProfesional_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            PacienteProfesional pacienteProfesional = new PacienteProfesional();            

            foreach (DataGridViewRow row in gridPacienteProfesional.Rows)
            {
                DataGridViewCell cell;
                pacienteProfesional = (row.DataBoundItem as PacienteProfesional);
                cell = row.Cells[0];
                cell.Value = String.Format("{0}", pacienteProfesional.DniPaciente);
                cell = row.Cells[1];                
                cell.Value = String.Format("{0}", pacienteProfesional.DniMedico);
                cell = row.Cells[2];
                cell.Value = String.Format("{0}", pacienteProfesional.FechaDesde);
                cell = row.Cells[3];
                cell.Value = String.Format("{0}", pacienteProfesional.FechaHasta);                
            }   
        }

        private void cmbProfesional_SelectedIndexChanged(object sender, EventArgs e)
        {
            string criterio;
            criterio = "dni_medico = " + this.cmbProfesional.SelectedItem;
            

            this.gridPacienteProfesional.AutoGenerateColumns = false;
            this.gridPacienteProfesional.Visible = true;
            this.grupPacientesProfesional.Visible = true;
            List<PacienteProfesional> lista = ManagerDB<PacienteProfesional>.findAll(criterio);
            this.gridPacienteProfesional.DataSource = lista;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this._saveFileDialog = new SaveFileDialog();
            this._saveFileDialog.Title = "Guardar Archivo";
            this._saveFileDialog.Filter = "Archivo de Texto (.txt) |*.txt";
            this._saveFileDialog.DefaultExt = "txt";
            this._saveFileDialog.AddExtension = true;
            this._saveFileDialog.FileName = String.Format("listadoPacientesProfesional({0}).txt", DateTime.Today.ToString("dd-MM-yyyy"));

            if (this._saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ruta = this._saveFileDialog.FileName;
                StreamWriter fichero = new StreamWriter(ruta);
                fichero.Write(listadoPacientesProfesional());
                fichero.Close();
                MessageBox.Show("Se guardo el archivo: " + this._saveFileDialog.FileName);
            }

            this._saveFileDialog.Dispose();

        }

        private string listadoPacientesProfesional()
        {
            string criterio;
            criterio = "dni_medico = " + this.cmbProfesional.SelectedItem;

            List<PacienteProfesional> lista = ManagerDB<PacienteProfesional>.findAll(criterio);
            string listado = String.Format("Listado de Pacientes de un Profesional{0}", Environment.NewLine);

            listado = String.Format("DNI Paciente|DNI medico|Fecha desde|Fecha Hasta{0}{1}", Environment.NewLine, Environment.NewLine);
 

            foreach (PacienteProfesional pp in lista)
            {
                listado += String.Format
                    ("{0}|{1}|{2}|{3}{4}", pp.DniPaciente, pp.DniMedico, pp.FechaDesde, pp.FechaHasta, Environment.NewLine);
            }

            return listado;

        }

    }
}
