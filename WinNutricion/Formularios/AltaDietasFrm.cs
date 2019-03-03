using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibNutricion.db;

namespace WinNutricion
{
    public partial class AltaDietasFrm : Form
    {
        public AltaDietasFrm()
        {
            InitializeComponent();
        }
        
        private void textCodigo_TextChanged(object sender, EventArgs e)
        {
            Dieta d = new Dieta();
            try
            {
                errorProvider1.BlinkRate = 0;
                errorProvider1.Dispose();
                textNombre.Enabled = true;
                textDescripcion.Enabled = true;
                textAutor.Enabled = true;
                FechaAltaDpk.Enabled = true;
                d.findbykey(int.Parse(textCodigo.Text));
                errorProvider1.SetError(textCodigo, "Dieta ya agregada");
                textNombre.Enabled = false;
                textDescripcion.Enabled = false;
                textAutor.Enabled = false;
                FechaAltaDpk.Enabled = false;

            }
            catch (NullReferenceException)
            {
                errorProvider1.Dispose();
                textNombre.Enabled = true;
                textDescripcion.Enabled = true;
                textAutor.Enabled = true;
                FechaAltaDpk.Enabled = true;
            }
            catch (FormatException)
            {
                //no hago nada mientras quiera reestablecer los datos
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textCodigo.Text) | string.IsNullOrEmpty(textNombre.Text) | string.IsNullOrEmpty(textDescripcion.Text) | string.IsNullOrEmpty(textAutor.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                if (!textNombre.Enabled)
                    MessageBox.Show("Debe ingresar una Dieta valida");
                else
                {
                    Dieta D = new Dieta();
                    D.Codigo = int.Parse(textCodigo.Text);
                    D.Nombre = textNombre.Text;
                    D.Descripcion = textDescripcion.Text;
                    D.Autor = textAutor.Text;
                    D.FechaAlta = FechaAltaDpk.Value;
                    D.saveObj();
                    this.Dispose();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

