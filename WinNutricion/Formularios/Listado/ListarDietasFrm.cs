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

    public partial class ListarDietasFrm : Form
    {
        private SaveFileDialog _saveFileDialog;

        public ListarDietasFrm()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void girdDietas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Dieta dieta;
            
            foreach (DataGridViewRow row in gridDietas.Rows)
            {
                DataGridViewCell cell;
                dieta = (row.DataBoundItem as Dieta);
                cell = row.Cells[0];
                cell.Value = String.Format("{0}", dieta.Codigo);
                cell = row.Cells[1];
                cell.Value = String.Format("{0}", dieta.Nombre);
                cell = row.Cells[2];
                cell.Value = String.Format("{0}", dieta.Autor);
                cell = row.Cells[3];
                cell.Value = String.Format("{0}", dieta.Descripcion);
                cell = row.Cells[4];
                cell.Value = String.Format("{0}", dieta.FechaAlta);
            }

        }

        private void ListarDietasFrm_Load(object sender, EventArgs e)
        {
            this.gridDietas.AutoGenerateColumns = false;
            List<Dieta> lista = ManagerDB<Dieta>.findAll();
            this.gridDietas.DataSource = lista;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this._saveFileDialog = new SaveFileDialog();
            this._saveFileDialog.Title = "Guardar Archivo";
            this._saveFileDialog.Filter = "Archivo de Texto (.txt) |*.txt";
            this._saveFileDialog.DefaultExt = "txt";
            this._saveFileDialog.AddExtension = true;
            this._saveFileDialog.FileName = String.Format("listadoDietas({0}).txt", DateTime.Today.ToString("dd-MM-yyyy"));


            if (this._saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ruta = this._saveFileDialog.FileName;
                StreamWriter fichero = new StreamWriter(ruta);
                fichero.Write(listadoDietas());
                fichero.Close();
                MessageBox.Show("Se guardo el archivo: " + this._saveFileDialog.FileName);
            }

            this._saveFileDialog.Dispose();
        }


        private string listadoDietas()
        {
            List<Dieta> lista = ManagerDB<Dieta>.findAll();
            string listado = String.Format("Listado de todas las Dietas{0}", Environment.NewLine);

            listado = String.Format("Codigo|Nombre|Autor|Descripcion|Fecha creacion{0}{1}",Environment.NewLine, Environment.NewLine);

                
            foreach (Dieta dieta in lista)
            {
                listado += String.Format("{0}|{1}|{2}|{3}|{4}{5}",dieta.Codigo, dieta.Nombre, dieta.Autor, dieta.Descripcion, dieta.FechaAlta, Environment.NewLine);
            }

            return listado;

        }

    }
}
