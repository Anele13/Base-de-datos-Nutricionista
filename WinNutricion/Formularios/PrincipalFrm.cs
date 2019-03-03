using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql; // Libreria para conectar con PostgreSQL
using LibNutricion.db; // incluir libreria para poder acceder a los objetos de negocios.


namespace WinNutricion
{
    public partial class PrincipalFrm : Form
    {
        public PrincipalFrm()
        {            
            InitializeComponent();
        }               

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            DialogResult dgresult = MessageBox.Show("Desea salir del sistema?", "salir....", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if(dgresult== System.Windows.Forms.DialogResult.Yes)
                this.Dispose();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AltaPacientesFrm frm = new AltaPacientesFrm();
            frm.Show();
        }

        private void todosLosPacientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListarPacientesFrm frm = new ListarPacientesFrm();
            frm.Show();
        }

        private void todasLasDietasDeUnPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarDietasPacienteFrm frm = new ListarDietasPacienteFrm();
            frm.Show();
        }

        private void todosLosPlatosDeUnPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarPlatosPacienteFrm frm = new ListarPlatosPacienteFrm();
            frm.Show();
        }

        private void altaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AltaPlatoFrm frm = new AltaPlatoFrm();
            frm.Show();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModificarPlatoFrm frm = new ModificarPlatoFrm();
            frm.Show();
        }

        private void modificacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModificacionDietaFrm frm = new ModificacionDietaFrm();
            frm.Show();
        }

        private void altaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            AltaIngredienteFrm frm = new AltaIngredienteFrm();
            frm.Show();
        }

        private void modificacionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ModificacionIngredienteFrm frm = new ModificacionIngredienteFrm();
            frm.Show();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaProfesionalFrm frm = new AltaProfesionalFrm();
            frm.Show();
        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificacionProfesionalFrm frm = new ModificacionProfesionalFrm();
            frm.Show();
        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AltaDietasFrm frm = new AltaDietasFrm();
            frm.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificacionPacienteFrm frm = new ModificacionPacienteFrm();
            frm.Show();
        }

        private void todosLosControlesDeUnPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarControlesPacienteFrm frm = new ListarControlesPacienteFrm();
            frm.Show();
        }

        private void todasLasDietasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarDietasFrm frm = new ListarDietasFrm();
            frm.Show();
        }

        private void todosLosPatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarPlatosFrm frm = new ListarPlatosFrm();
            frm.Show();
        }

        private void todosLosIngredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarIngredientesFrm frm = new ListarIngredientesFrm();
            frm.Show();
        }

        private void todosLosprofesionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarProfesionalesFrm frm = new ListarProfesionalesFrm();
            frm.Show();
        }

        private void todosLosProfesionalesDeUnPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarPacientesProfesionalFrm frm = new ListarPacientesProfesionalFrm();
            frm.Show();
        }

        private void PrincipalFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
