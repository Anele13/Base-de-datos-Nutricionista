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
    public partial class ListarDietasPacienteFrm : Form
    {
        private SaveFileDialog _saveFileDialog;

        public ListarDietasPacienteFrm()
        {
            InitializeComponent();
        }

        private void cmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string criterio;
            criterio = "dni_paciente = " + this.cmbPaciente.SelectedItem;


            this.girdPacienteDieta.AutoGenerateColumns = false;
            this.groupDietaPaciente.Visible = true;
            List<DietaPaciente> lista = ManagerDB<DietaPaciente>.findAll(criterio);
            this.girdPacienteDieta.DataSource = lista;


        }

        private void girdPacienteDieta_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DietaPaciente dietaPaciente = new DietaPaciente();

            foreach (DataGridViewRow row in girdPacienteDieta.Rows)
            {
                DataGridViewCell cell;
                dietaPaciente = (row.DataBoundItem as DietaPaciente);
                cell = row.Cells[0];
                cell.Value = String.Format("{0}", dietaPaciente.CodigoDieta);
                cell = row.Cells[1];
                cell.Value = String.Format("{0}", dietaPaciente.Dieta.Nombre);                
                cell = row.Cells[2];
                cell.Value = String.Format("{0}", dietaPaciente.DniPaciente);
                cell = row.Cells[3];
                cell.Value = String.Format("{0}", dietaPaciente.Paciente.Nombre + " " + dietaPaciente.Paciente.Apellido);
                cell = row.Cells[4];
                cell.Value = String.Format("{0}", dietaPaciente.Fecha);
                cell = row.Cells[5];
                cell.Value = String.Format("{0}", dietaPaciente.FechaFin);
            }       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ListarDietasPacienteFrm_Load(object sender, EventArgs e)
        {
            List<Paciente> pacientes = new List<Paciente>();
            pacientes = ManagerDB<Paciente>.findAll();
            foreach (Paciente paciente in pacientes)
            {
                this.cmbPaciente.Items.Add(paciente.Dni);
            } 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this._saveFileDialog = new SaveFileDialog();
            this._saveFileDialog.Title = "Guardar Archivo";
            this._saveFileDialog.Filter = "Archivo de Texto (.txt) |*.txt";
            this._saveFileDialog.DefaultExt = "txt";
            this._saveFileDialog.AddExtension = true;
            this._saveFileDialog.FileName = String.Format("listadoDietasPaciente({0}).txt", DateTime.Today.ToString("dd-MM-yyyy"));


            if (this._saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ruta = this._saveFileDialog.FileName;
                StreamWriter fichero = new StreamWriter(ruta);
                fichero.Write(listadoDietasPaciente());
                fichero.Close();
                MessageBox.Show("Se guardo el archivo: " + this._saveFileDialog.FileName);
            }

            this._saveFileDialog.Dispose();
        }

        private string listadoDietasPaciente()
        {
            string criterio;
            criterio = "dni_paciente = " + this.cmbPaciente.SelectedItem;

            List<DietaPaciente> lista = ManagerDB<DietaPaciente>.findAll(criterio);
            string listado = String.Format("Listado de Dietas de un Paciente{0}", Environment.NewLine);

            listado = String.Format("Codigo|Codigo de Dieta|Nombre|DNI Pacientet|Nombre y Apellido|Fecha Inicio|Fecha Fin{0}{1}", Environment.NewLine, Environment.NewLine);

            foreach (DietaPaciente dp in lista)
            {
                listado += String.Format
                    ("{0}|{1}|{2}|{3}|{4}|{5}|{6}{7}", dp.Codigo, dp.CodigoDieta, dp.Dieta.Nombre, dp.DniPaciente, (dp.Paciente.Nombre + " " + dp.Paciente.Apellido)
                        , dp.Fecha, dp.FechaFin, Environment.NewLine
                    );
            }

            return listado;

        }
    }
}
