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
    public partial class AltaProfesionalFrm : Form
    {
        public AltaProfesionalFrm()
        {
            InitializeComponent();
        }

        private void textDNI_TextChanged(object sender, EventArgs e)
        {
            Profesional p = new Profesional();
            try
            {
                errorProvider1.BlinkRate = 0;
                errorProvider1.Dispose();
                textNOmbre.Enabled = true;
                textMatricula.Enabled = true;
                textApellido.Enabled = true;
                textTelefono.Enabled = true;
                textMedico.Enabled = true;
                textNutricionista.Enabled = true;
                FechaAltaDpk.Enabled = true;
                p.findbykey(int.Parse(textDNI.Text));
                errorProvider1.SetError(textDNI,"Profesional ya ingresado");
                FechaAltaDpk.Enabled = false;
                textMatricula.Enabled = false;
                textApellido.Enabled = false;
                textTelefono.Enabled = false;
                textMedico.Enabled = false;
                textNutricionista.Enabled = false;
                textNOmbre.Enabled = false;


            }
            catch (NullReferenceException)
            {
                errorProvider1.Dispose();
                textNOmbre.Enabled = true;
                textMatricula.Enabled = true;
                textApellido.Enabled = true;
                textTelefono.Enabled = true;
                textMedico.Enabled = true;
                textNutricionista.Enabled = true;
                FechaAltaDpk.Enabled = true;
                
            }
            catch (FormatException)
            {
               //textNOmbre.Text = "formato";
            }


        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textDNI.Text) | string.IsNullOrEmpty(textNOmbre.Text) | string.IsNullOrEmpty(textMatricula.Text)| string.IsNullOrEmpty(textApellido.Text)| string.IsNullOrEmpty(textTelefono.Text)| string.IsNullOrEmpty(textMedico.Text)| string.IsNullOrEmpty(textNutricionista.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                if (!textNOmbre.Enabled)
                    MessageBox.Show("Debe ingresar un Profesional valido");
                else
                {
                    Profesional p = new Profesional();
                    p.Dni = int.Parse(this.textDNI.Text);
                    p.Matricula = textMatricula.Text;
                    p.Nombre = textNOmbre.Text;
                    p.Apellido = textApellido.Text;
                    p.Telefono = textTelefono.Text;

                    if(textMedico.Text.Equals("Si"))
                        p.EsMedico = 1;
                    else
                        p.EsMedico = 0;

                    if (textNutricionista.Text.Equals("Si"))
                        p.EsNutricionista = 1;
                    else
                        p.EsNutricionista = 0;

                    p.saveObj();
                    this.Dispose();
                }
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
