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
    public partial class ListarPlatosPacienteFrm : Form
    {
        private SaveFileDialog _saveFileDialog;

        public ListarPlatosPacienteFrm()
        {
            InitializeComponent();
        }

        private void ListarPlatosPacienteFrm_Load(object sender, EventArgs e)
        {
            List<Paciente> pacientes = new List<Paciente>();
            pacientes = ManagerDB<Paciente>.findAll();
            foreach (Paciente paciente in pacientes)
            {
                this.cmbPaciente.Items.Add(paciente.Dni);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

            string criterio;
            criterio = "dni_paciente = " + this.cmbPaciente.SelectedItem;
            
            this.girdPacientePlato.AutoGenerateColumns = false;
            this.groupPlatoPaciente.Visible = true;
            List<PlatoPaciente> lista = ManagerDB<PlatoPaciente>.findAll(criterio);
            this.girdPacientePlato.DataSource = lista;


        }

        private void girdPacientePlato_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {            
            PlatoPaciente platoPaciente = new PlatoPaciente();
            
            foreach (DataGridViewRow row in girdPacientePlato.Rows)
            {
                DataGridViewCell cell;
                platoPaciente = (row.DataBoundItem as PlatoPaciente);
                cell = row.Cells[0];
                cell.Value = String.Format("{0}", platoPaciente.CodigoPlato);                
                cell = row.Cells[1];
                cell.Value = String.Format("{0}", platoPaciente.DniPaciente);
                cell = row.Cells[2];
                cell.Value = String.Format("{0}", platoPaciente.Cantidad);
                cell = row.Cells[3];
                cell.Value = String.Format("{0}", platoPaciente.Fecha);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this._saveFileDialog = new SaveFileDialog();
            this._saveFileDialog.Title = "Guardar Archivo";
            this._saveFileDialog.Filter = "Archivo de Texto (.txt) |*.txt";
            this._saveFileDialog.DefaultExt = "txt";
            this._saveFileDialog.AddExtension = true;
            this._saveFileDialog.FileName = String.Format("listadoPlatosPaciente({0}).txt", DateTime.Today.ToString("dd-MM-yyyy"));


            if (this._saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ruta = this._saveFileDialog.FileName;
                StreamWriter fichero = new StreamWriter(ruta);
                fichero.Write(listadoPlatosPaciente());
                fichero.Close();
                MessageBox.Show("Se guardo el archivo: " + this._saveFileDialog.FileName);
            }

            this._saveFileDialog.Dispose();
        }


        private string listadoPlatosPaciente()
        {
            string criterio;
            criterio = "dni_paciente = " + this.cmbPaciente.SelectedItem;

            List<PlatoPaciente> lista = ManagerDB<PlatoPaciente>.findAll(criterio);
            string listado = String.Format("Listado de Platos servidos a un Paciente{0}{1}", Environment.NewLine,Environment.NewLine);

            listado = String.Format("Codigo Plato|Dni Paciente|Cantidad|Fecha{0}{1}", Environment.NewLine, Environment.NewLine);
                    
            foreach (PlatoPaciente pp in lista)
            {
                listado += String.Format("{0}|{1}|{2}|{3}{4}", pp.CodigoPlato
                    , pp.DniPaciente, pp.Cantidad, pp.Fecha, Environment.NewLine);
            }

            return listado;

        }


    }
}
