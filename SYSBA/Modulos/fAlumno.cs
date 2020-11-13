using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYSBA.Modulos
{
    public partial class fAlumno : Form
    {

        public fAlumno()
        {
            InitializeComponent();
        }

        public int IdUsuarioLog { get; set; }
        private int Id { get; set; }
        string Mensaje = "";
        string Titulo = "";
        public bool vSecundaria { get; set; }
        public bool vBachillerato { get; set; }
        MessageBoxIcon Icono;
        Helper h = new Helper();

        private void fAlumno_Load(object sender, EventArgs e)
        {
            this.CargaDatos();
        }

        private void CargaDatos()
        {
            try
            {
                this.alumnoTableAdapter.Fill(this.sYSBADataSet.Alumno, null, this.txtBuscar.Text.Trim(), this.vSecundaria, this.vBachillerato, true);
                this.dgvDatos.DataSource = this.sYSBADataSet.Alumno;

                this.btnEditar.Enabled = this.dgvDatos.Rows.Count > 0;
                this.btnEliminar.Enabled = this.dgvDatos.Rows.Count > 0;

                this.h.ModoEdicion("L", this.pnlBotones, this.pnlRegistros, this.pnlDatos);
                this.errorProvider1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Carga Datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.h.ModoEdicion("I", this.pnlBotones, this.pnlRegistros, this.pnlDatos);
            this.h.LimpiaControles(this.tabPage1);
            this.tcDatos.SelectedIndex = 1;
            this.tcDatosAlumno.SelectedIndex = 0;
            this.btnAnterior.Enabled = false;
            this.btnGuardar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.tcDatos.SelectedIndex = 1;
            this.tcDatosAlumno.SelectedIndex = 0;
            this.HabilitaBotones();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                CargaDatos();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.CargaDatos();
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.CargaDatos();
            this.tcDatos.SelectedIndex = 0;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.SiguienteAtras(this.tcDatosAlumno.SelectedIndex + 1);
            this.HabilitaBotones();
        }

        private void HabilitaBotones()
        {
            switch (this.tcDatosAlumno.SelectedTab.Name)
            {
                case "tabPage1":
                    this.btnAnterior.Enabled = false;
                    this.btnSiguiente.Enabled = true;
                    this.btnGuardar.Enabled = false;
                    break;
                case "tabPage2":
                    this.btnAnterior.Enabled = true;
                    this.btnSiguiente.Enabled = true;
                    this.btnGuardar.Enabled = false;
                    break;
                case "tabPage3":
                    this.btnAnterior.Enabled = true;
                    this.btnSiguiente.Enabled = false;
                    this.btnGuardar.Enabled = true;
                    break;
            }
        }

        private void SiguienteAtras( int index)
        {
            this.tcDatosAlumno.SelectedIndex = index;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            this.SiguienteAtras(this.tcDatosAlumno.SelectedIndex - 1);
            this.HabilitaBotones();
        }
    }
}
