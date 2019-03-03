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
    public partial class ListarProfesionalesFrm : Form
    {
        private SaveFileDialog _saveFileDialog;

        public ListarProfesionalesFrm()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ListarProfesionalesFrm_Load(object sender, EventArgs e)
        {          
            this.gridProfesionales.AutoGenerateColumns = false;
            List<Profesional> lista = ManagerDB<Profesional>.findAll();
            this.gridProfesionales.DataSource = lista;
        }

        private void gridProfesionales_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Profesional profesional;

            foreach (DataGridViewRow row in gridProfesionales.Rows)
            {
                DataGridViewCell cell;
                profesional = (row.DataBoundItem as Profesional);
                cell = row.Cells[0];
                cell.Value = String.Format("{0}", profesional.Dni);
                cell = row.Cells[1];
                cell.Value = String.Format("{0}", profesional.Matricula);
                cell = row.Cells[2];
                cell.Value = String.Format("{0}, {1}", profesional.Nombre, profesional.Apellido);
                cell = row.Cells[3];
                cell.Value = String.Format("{0}", profesional.Telefono);
                cell = row.Cells[4];
                cell.Value = String.Format("{0}", profesional.FechaAlta);
                
                string rta = "";
                
                if (profesional.EsMedico == 1)
                { rta = "SI"; }
                else { rta = "NO"; }
                
                cell = row.Cells[5];
                cell.Value = String.Format("{0}", rta);

                if (profesional.EsNutricionista == 1)
                { rta = "SI"; }
                else { rta = "NO"; }
                cell = row.Cells[6];
                cell.Value = String.Format("{0}", rta);

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this._saveFileDialog = new SaveFileDialog();
            this._saveFileDialog.Title = "Guardar Archivo";
            this._saveFileDialog.Filter = "Archivo de Texto (.txt) |*.txt";
            this._saveFileDialog.DefaultExt = "txt";
            this._saveFileDialog.AddExtension = true;
            this._saveFileDialog.FileName = String.Format("listadoProfesionales({0}).txt", DateTime.Today.ToString("dd-MM-yyyy"));

            if (this._saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ruta = this._saveFileDialog.FileName;
                StreamWriter fichero = new StreamWriter(ruta);
                fichero.Write(listadoProfesionales());
                fichero.Close();
                MessageBox.Show("Se guardo el archivo: " + this._saveFileDialog.FileName);
            }

            this._saveFileDialog.Dispose();

        }

        private string listadoProfesionales()
        {
            List<Profesional> lista = ManagerDB<Profesional>.findAll();
            string listado = String.Format("Listado de Profesionales{0}{1}", Environment.NewLine, Environment.NewLine);

            listado = String.Format("DNI|Matricula|Nombre y Apellido|Telefono|Fecha Alta|Es Medico|Es Nutricionista{0}{1}",Environment.NewLine, Environment.NewLine);
            foreach (Profesional profesional in lista)
            {
                listado += String.Format
                    ("{0}|{1}|{2}|{3}|{4}|{4}|{6}{7}", profesional.Dni, profesional.Matricula, (profesional.Nombre + " " + profesional.Apellido), profesional.Telefono, profesional.FechaAlta, profesional.EsMedico, profesional.EsNutricionista, Environment.NewLine);
            }

            return listado;

        }
    }
}
