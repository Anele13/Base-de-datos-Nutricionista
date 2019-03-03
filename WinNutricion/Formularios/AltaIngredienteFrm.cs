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
    public partial class AltaIngredienteFrm : Form
    {
        public AltaIngredienteFrm()
        {
            InitializeComponent();
        }



        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text) | string.IsNullOrEmpty(txtUM.Text) | string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                if (!txtUM.Enabled)
                    MessageBox.Show("Debe ingresar un Ingrediente valido");
                else
                {
                    Ingrediente I = new Ingrediente();
                    I.Codigo = int.Parse(this.txtCodigo.Text);
                    I.UnidadMedida = txtUM.Text;
                    I.Nombre = txtNombre.Text;
                    I.saveObj();
                    this.Dispose();
                }
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            Ingrediente I = new Ingrediente();
            try
            {
                errorProvider1.BlinkRate = 0;
                errorProvider1.Dispose();
                txtNombre.Enabled = true;
                txtUM.Enabled = true;
                I.findbykey(int.Parse(txtCodigo.Text));
                errorProvider1.SetError(txtCodigo, "Ingrediente ya agregado");
                txtUM.Enabled = false;
                txtNombre.Enabled = false;

            }
            catch (NullReferenceException)
            {
                errorProvider1.Dispose();
                txtNombre.Enabled = true;
                txtUM.Enabled = true;
            }
            catch (FormatException)
            {
                //no hago nada mientras quiera reestablecer los datos
            }
        }
    }
}


