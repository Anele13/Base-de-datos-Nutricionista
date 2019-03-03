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
    public partial class ListarPacientesFrm : Form
    {

        private SaveFileDialog _saveFileDialog;

        public ListarPacientesFrm()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ListarPacientes_Load(object sender, EventArgs e)
        {
            this.gridPacientes.AutoGenerateColumns = false;
            List<Paciente> lista = ManagerDB<Paciente>.findAll();
            this.gridPacientes.DataSource = lista;
        }

        private void gridPacientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Paciente paciente;
            foreach (DataGridViewRow row in gridPacientes.Rows)
            {
                DataGridViewCell cell;
                paciente = (row.DataBoundItem as Paciente);
                cell = row.Cells[0];
                cell.Value = String.Format("{0}",paciente.Dni);                                
                cell = row.Cells[1];
                cell.Value = String.Format("{0}", (paciente.Nombre + " " + paciente.Apellido));
                cell = row.Cells[2];
                cell.Value = String.Format("{0}", paciente.FechaNac);
                cell = row.Cells[3];
                cell.Value = String.Format("{0}", paciente.Domicilio);
                cell = row.Cells[4];
                cell.Value = String.Format("{0}", paciente.Telefono);
                cell = row.Cells[5];
                cell.Value = String.Format("{0}", paciente.PesoInicial);
                cell = row.Cells[6];
                cell.Value = String.Format("{0}", paciente.Talla);
                cell = row.Cells[7];
                cell.Value = String.Format("{0}", paciente.FechaAlta);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this._saveFileDialog = new SaveFileDialog();
            this._saveFileDialog.Title = "Guardar Archivo";
            this._saveFileDialog.Filter = "Archivo de Texto (.txt) |*.txt";
            this._saveFileDialog.DefaultExt = "txt";
            this._saveFileDialog.AddExtension = true;
            this._saveFileDialog.FileName = String.Format("listadoPacientes({0}).txt", DateTime.Today.ToString("dd-MM-yyyy"));


            if (this._saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ruta = this._saveFileDialog.FileName;
                StreamWriter fichero = new StreamWriter(ruta);
                fichero.Write(listadoPacientes());
                fichero.Close();
                MessageBox.Show("Se guardo el archivo: " + this._saveFileDialog.FileName);
            }

            this._saveFileDialog.Dispose();
        }

        private string listadoPacientes()
        {
            List<Paciente> lista = ManagerDB<Paciente>.findAll();
            string listado = String.Format("Listado de Pacientes:{0}", Environment.NewLine);

            listado += String.Format("DNI | Nombre y Apellido | Fecha de Nacimiento | Domicilio | Telefono | Peso Inicial | Talla | Fecha Alta{0}{1}", Environment.NewLine, Environment.NewLine);

            foreach (Paciente p in lista)
            {
                listado += String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}{8}{9}", p.Dni, (p.Nombre + " " + p.Apellido), p.FechaNac, p.Domicilio, p.Telefono, p.PesoInicial, p.Talla, p.FechaAlta, Environment.NewLine, Environment.NewLine);
            }

            return listado;

        }
    }
}
