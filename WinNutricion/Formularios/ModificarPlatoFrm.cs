using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using LibNutricion.db;
using System.Windows.Forms;

namespace WinNutricion
{
    public partial class ModificarPlatoFrm : Form
    {
        
        public ModificarPlatoFrm()
        {
            InitializeComponent();
        }

        private void ModificarBtn_Click_1(object sender, EventArgs e)
        {
            Plato plato = new Plato();
            if (string.IsNullOrEmpty(textCodigo.Text) | string.IsNullOrEmpty(textNombre.Text) | string.IsNullOrEmpty(textDetalle.Text)|(!textDetalle.Enabled))
            {
                MessageBox.Show("No debe dejar campos vacios");
            }
            else
            {
                plato.findbykey(int.Parse(textCodigo.Text));
                plato.Nombre = textNombre.Text;
                plato.Detalle = textDetalle.Text;
                plato.saveObj();
                this.Dispose();
            }
        }

        private void textCodigo_TextChanged_1(object sender, EventArgs e)
        {
            Plato plato = new Plato();
            try
            {
                textNombre.Text = " ";
                textDetalle.Text = " ";
                errorProvider1.BlinkRate = 0;
                errorProvider1.Dispose();
                plato.findbykey(int.Parse(textCodigo.Text));
                textCodigo.Enabled = true;
                textNombre.Enabled = true;
                textDetalle.Enabled = true;
                textNombre.Text = plato.Nombre;
                textDetalle.Text = plato.Detalle;

            }
            catch (NullReferenceException)
            {
                errorProvider1.SetError(textCodigo, "Plato no encontrado");
                textNombre.Enabled = false; ;
                textDetalle.Enabled = false;
            }

            catch (FormatException)
            {
                //no hago nada mientras borra
            }


        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}
