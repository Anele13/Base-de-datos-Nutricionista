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
    public partial class AltaPlatoFrm : Form
    {
        public AltaPlatoFrm()
        {
            InitializeComponent();
        }
        
        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textCodPlato.Text) | string.IsNullOrEmpty(textNombrePlato.Text) | string.IsNullOrEmpty(textDetallePlato.Text))
            {
                MessageBox.Show("Debe completar todos los datos");
            }
            else
            {
                if (!textDetallePlato.Enabled)
                    MessageBox.Show("Debe ingresar un Plato valido");
                else
                {
                    Plato plato = new Plato();
                    plato.Codigo = int.Parse(this.textCodPlato.Text);
                    plato.Nombre = textNombrePlato.Text;
                    plato.Detalle = textDetallePlato.Text;
                    plato.saveObj();
                    this.Dispose();
                }
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textCodPlato_TextChanged(object sender, EventArgs e)
        {
            Plato p = new Plato();
            try
            {
                errorProvider1.BlinkRate=0;
                errorProvider1.Dispose();
                textNombrePlato.Enabled = true;
                textDetallePlato.Enabled = true;
                p.findbykey(int.Parse(textCodPlato.Text));
                errorProvider1.SetError(textCodPlato, "Plato ya agregado!");
                textNombrePlato.Enabled = false;
                textDetallePlato.Enabled = false;

            }
            catch (NullReferenceException)
            {
                errorProvider1.Dispose();
                textNombrePlato.Enabled = true;
                textDetallePlato.Enabled = true;
            }
            catch (FormatException)
            {
                //no hago nada mientras quiera reestablecer los datos
            }
            
        }

        
    }
}
