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
    public partial class ListarPlatosFrm : Form
    {
        private SaveFileDialog _saveFileDialog;

        public ListarPlatosFrm()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void gridPlatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Plato plato;

            foreach (DataGridViewRow row in gridPlatos.Rows)
            {
                DataGridViewCell cell;
                plato = (row.DataBoundItem as Plato);
                cell = row.Cells[0];
                cell.Value = String.Format("{0}", plato.Codigo);
                cell = row.Cells[1];
                cell.Value = String.Format("{0}", plato.Nombre);
                cell = row.Cells[2];
                cell.Value = String.Format("{0}", plato.Detalle);                
            }
        }

        private void ListarPlatosFrm_Load(object sender, EventArgs e)
        {
            this.gridPlatos.AutoGenerateColumns = false;
            List<Plato> lista = ManagerDB<Plato>.findAll();
            this.gridPlatos.DataSource = lista;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this._saveFileDialog = new SaveFileDialog();
            this._saveFileDialog.Title = "Guardar Archivo";
            this._saveFileDialog.Filter = "Archivo de Texto (.txt) |*.txt";
            this._saveFileDialog.DefaultExt = "txt";
            this._saveFileDialog.AddExtension = true;
            this._saveFileDialog.FileName = String.Format("listadoPlatos({0}).txt", DateTime.Today.ToString("dd-MM-yyyy"));


            if (this._saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ruta = this._saveFileDialog.FileName;
                StreamWriter fichero = new StreamWriter(ruta);
                fichero.Write(listadoPlatos());
                fichero.Close();
                MessageBox.Show("Se guardo el archivo: " + this._saveFileDialog.FileName);
            }

            this._saveFileDialog.Dispose();
        }

        private string listadoPlatos()
        {            
            List<Plato> lista = ManagerDB<Plato>.findAll();
            string listado = String.Format("Listado de Platos{0}{1}", Environment.NewLine, Environment.NewLine);

            listado = String.Format("Codigo Plato|Nombre|Detalle{0}{1}", Environment.NewLine, Environment.NewLine);
   

            foreach (Plato plato in lista)
            {
                listado += String.Format("{0}|{1}|{2}{3}", plato.Codigo, plato.Nombre, plato.Detalle, Environment.NewLine);
            }

            return listado;

        }

    }
}
