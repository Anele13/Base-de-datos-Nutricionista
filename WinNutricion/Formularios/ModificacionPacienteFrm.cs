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
    public partial class ModificacionPacienteFrm : Form
    {
        public ModificacionPacienteFrm()
        {
            InitializeComponent();
        }

        private void textDNI_TextChanged(object sender, EventArgs e)
        {
            Paciente P = new Paciente();
            try
            {
                errorProvider1.BlinkRate = 0;
                textNombre.Enabled = true;
                textApellido.Enabled = true;
                textDomicilio.Enabled = true;
                textTelefono.Enabled = true;
                FechaAltaDpk.Enabled = true;
                fechaNacimiento.Enabled = true;
                textPeso.Enabled = true;
                textTalla.Enabled = true;
                P.findbykey(int.Parse(textDNI.Text));

                textNombre.Text= P.Nombre;
                textApellido.Text= P.Apellido;
                textDomicilio.Text=P.Domicilio;
                textTelefono.Text= P.Telefono;
                FechaAltaDpk.Value=P.FechaAlta;
                fechaNacimiento.Value= P.FechaNac;
                textPeso.Text= P.PesoInicial.ToString();
                textTalla.Text= P.Talla.ToString();
            }
            catch (NullReferenceException)
            {
                errorProvider1.SetError(textDNI, "Paciente no existe");
                textNombre.Enabled = false;
                textNombre.Enabled = false;
                textApellido.Enabled = false;
                textDomicilio.Enabled = false;
                textTelefono.Enabled = false;
                FechaAltaDpk.Enabled = false;
                fechaNacimiento.Enabled = false;
                textPeso.Enabled = false;
                textTalla.Enabled = false;

            }
            catch (FormatException)
            {
                //no hago nada mientras quiera reestablecer los datos
            }
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textDNI.Text) | string.IsNullOrEmpty(textNombre.Text) | string.IsNullOrEmpty(textApellido.Text) | string.IsNullOrEmpty(textDomicilio.Text) | string.IsNullOrEmpty(textTelefono.Text) | string.IsNullOrEmpty(textPeso.Text) | string.IsNullOrEmpty(textTalla.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                if (!textNombre.Enabled)
                    MessageBox.Show("Debe ingresar un Paciente valido");
                else
                {
                    Paciente P = new Paciente();
                    P.findbykey(textDNI.Text);
                    P.Nombre = textNombre.Text;
                    P.Apellido = textApellido.Text;
                    P.Domicilio = textDomicilio.Text;
                    P.Telefono = textTelefono.Text;
                    P.FechaAlta = FechaAltaDpk.Value;
                    P.FechaNac = fechaNacimiento.Value;
                    P.PesoInicial = double.Parse(textPeso.Text);
                    P.Talla = double.Parse(textTalla.Text);
                    P.saveObj();
                    this.Dispose();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}
