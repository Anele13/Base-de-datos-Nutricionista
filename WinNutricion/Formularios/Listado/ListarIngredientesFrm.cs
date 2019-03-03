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
    public partial class ListarIngredientesFrm : Form
    {
        private SaveFileDialog _saveFileDialog;

        public ListarIngredientesFrm()
        {
            InitializeComponent();
        }

        private void ListarIngredientesFrm_Load(object sender, EventArgs e)
        {
            this.gridIngredientes.AutoGenerateColumns = false;
            List<Ingrediente> lista = ManagerDB<Ingrediente>.findAll();
            this.gridIngredientes.DataSource = lista;
        }

        private void gridIngredientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Ingrediente ingrediente;

            foreach (DataGridViewRow row in gridIngredientes.Rows)
            {
                DataGridViewCell cell;
                ingrediente = (row.DataBoundItem as Ingrediente);
                cell = row.Cells[0];
                cell.Value = String.Format("{0}", ingrediente.Codigo);
                cell = row.Cells[1];
                cell.Value = String.Format("{0}", ingrediente.Nombre);
                cell = row.Cells[2];
                cell.Value = String.Format("{0}", ingrediente.UnidadMedida);                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            this._saveFileDialog = new SaveFileDialog();
            this._saveFileDialog.Title = "Guardar Archivo";
            this._saveFileDialog.Filter = "Archivo de Texto (.txt) |*.txt";
            this._saveFileDialog.DefaultExt = "txt";
            this._saveFileDialog.AddExtension = true;
            this._saveFileDialog.FileName = String.Format("listadoIngredientes({0}).txt", DateTime.Today.ToString("dd-MM-yyyy"));
        

            if (this._saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ruta = this._saveFileDialog.FileName;
                StreamWriter fichero = new StreamWriter(ruta);
                fichero.Write(listadoIngredientes());
                fichero.Close();
                MessageBox.Show("Se guardo el archivo: " + this._saveFileDialog.FileName);
            }

            this._saveFileDialog.Dispose();

            
        }
            
          
        private string listadoIngredientes()         
        {
            List<Ingrediente> ingredientes = ManagerDB<Ingrediente>.findAll();
            string listado = String.Format("Listado de Ingredientes{0}", Environment.NewLine);

            listado = String.Format("Codigo|Nombre|Unidad de Medida{0}{1}", Environment.NewLine, Environment.NewLine);


            foreach (Ingrediente i in ingredientes)
            {
                listado += String.Format("{0}|{1}|{2}{3}", i.Codigo, i.Nombre, i.UnidadMedida, Environment.NewLine);
            }
            
            return listado;
            
        }
        
    }

    
}

