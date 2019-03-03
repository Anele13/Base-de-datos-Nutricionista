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
    public partial class ModificacionProfesionalFrm : Form
    {
        public ModificacionProfesionalFrm()
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
                textNombre.Enabled = true;
                textMatricula.Enabled = true;
                textApellido.Enabled = true;
                textTelefono.Enabled = true;
                textMedico.Enabled = true;
                textNutricionista.Enabled = true;
                FechaAltaDpk.Enabled = true;
                p.findbykey(int.Parse(textDNI.Text));
                //errorProvider1.SetError(textDNI, "Profesional ya ingresado");
                FechaAltaDpk.Value = p.FechaAlta;
                textMatricula.Text = p.Nombre;
                textNombre.Text =  p.Matricula;
                textApellido.Text = p.Apellido;
                textTelefono.Text = p.Telefono;

                if (p.EsMedico == 1)
                    textMedico.Text = "Si";
                else
                    textMedico.Text = "No";

                if (p.EsNutricionista == 1)
                    textNutricionista.Text = "Si";
                else
                    textNutricionista.Text = "No";
                

            }
            catch (NullReferenceException)
            {
                //p.findbykey(int.Parse(textDNI.Text));
                errorProvider1.SetError(textDNI, "Profesional no encontrado");
                FechaAltaDpk.Enabled = false;
                textMatricula.Enabled = false;
                textApellido.Enabled = false;
                textTelefono.Enabled = false;
                textMedico.Enabled = false;
                textNutricionista.Enabled = false;
                textNombre.Enabled = false;

            }
            catch (FormatException)
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profesional plato = new Profesional();
            if (string.IsNullOrEmpty(textDNI.Text) | string.IsNullOrEmpty(textNombre.Text) | string.IsNullOrEmpty(textMatricula.Text) | string.IsNullOrEmpty(textApellido.Text) | string.IsNullOrEmpty(textTelefono.Text) | string.IsNullOrEmpty(textMedico.Text) | string.IsNullOrEmpty(textNutricionista.Text))
            {
                MessageBox.Show("No debe dejar campos vacios");
            }
            else
            {
                    Profesional p = new Profesional();
                    p.findbykey(int.Parse(textDNI.Text));
                    //p.Dni = int.Parse(this.textDNI.Text);
                    p.Matricula = textNombre.Text;
                    p.Nombre = textMatricula.Text;
                    p.Apellido = textApellido.Text;
                    p.Telefono = textTelefono.Text;

                    if (textMedico.Text.Equals("Si"))
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
