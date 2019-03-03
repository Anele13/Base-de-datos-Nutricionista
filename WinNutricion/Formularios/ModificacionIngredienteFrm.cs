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
    public partial class ModificacionIngredienteFrm : Form
    {
        public ModificacionIngredienteFrm()
        {
            InitializeComponent();
        }

        private void textCodigo_TextChanged(object sender, EventArgs e)
        {
            Ingrediente I = new Ingrediente();
            try
            {
                textNombre.Text= " ";
                textUM.Text = " ";
                errorProvider1.BlinkRate = 0;
                errorProvider1.Dispose();
                I.findbykey(int.Parse(textCodigo.Text));
                textCodigo.Enabled = true;
                textNombre.Enabled = true;
                textUM.Enabled = true;
                textNombre.Text = I.Nombre;
                textUM.Text = I.UnidadMedida;

            }
            catch (NullReferenceException)
            {
                errorProvider1.SetError(textCodigo, "Ingrediente no encontrado");
                textNombre.Enabled = false; ;
                textUM.Enabled = false;
            }

            catch (FormatException)
            {
                //no hago nada mientras borra
            }

        }
    }
}
