using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYSBA.Catalogos
{
    public partial class fUsuarioTrabajador : Form
    {
        public int IdUsuarioLog { get; set; }
        private int Id { get; set; }
        string Mensaje = "";
        string Titulo = "";
        MessageBoxIcon Icono;
        Helper h = new Helper();

        public fUsuarioTrabajador()
        {
            InitializeComponent();
        }

        private void fUsuarioTrabajador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sYSBADataSet.Sexo' Puede moverla o quitarla según sea necesario.
            
            this.CargaDatos();
        }

        private void CargaDatos()
        {
            try
            {
                this.vUsuarioTrabajadorTableAdapter.Fill(this.sYSBADataSet.vUsuarioTrabajador, null, null, null, null, null, null, null, null, null, this.txtBuscar.Text.Trim(), true);
                this.dgvDatos.DataSource = this.sYSBADataSet.vUsuarioTrabajador;

                this.btnEditar.Enabled = this.dgvDatos.Rows.Count > 0;
                this.btnEliminar.Enabled = this.dgvDatos.Rows.Count > 0;

                this.sexoTableAdapter.Fill(this.sYSBADataSet.Sexo);
                this.rolTableAdapter.Fill(this.sYSBADataSet.Rol, "", true);
                this.gradoEstudioTableAdapter.Fill(this.sYSBADataSet.GradoEstudio, null, "", true);
                this.cargoTableAdapter.Fill(this.sYSBADataSet.Cargo, null, "", true);

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
            this.h.LimpiaControles(this.pnlDatos);
            this.rolComboBox.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.h.ModoEdicion("M", this.pnlBotones, this.pnlRegistros, this.pnlDatos);
            this.rolComboBox.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int? resultado = 0;
                this.vUsuarioTrabajadorTableAdapter.Delete(this.Id, ref resultado);
                this.CargaDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Borrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.CargaDatos();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.CargaDatos();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.CargaDatos();
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvDatos.Rows.Count == 0)
                    return;
                this.Id = int.Parse(this.dgvDatos.CurrentRow.Cells["IdUsuario"].Value.ToString());
                this.rolComboBox.SelectedValue = this.dgvDatos.CurrentRow.Cells["IdRol"].Value.ToString();
                this.sexoComboBox.SelectedValue = this.dgvDatos.CurrentRow.Cells["IdSexo"].Value.ToString();                
                //this.nombreTextBox.Text = this.dgvDatos.CurrentRow.Cells["Nombre"].Value.ToString();
                //this.primerApellidoTextBox.Text = this.dgvDatos.CurrentRow.Cells["PrimerApellido"].Value.ToString();
                //this.segundoApellidoTextBox.Text = this.dgvDatos.CurrentRow.Cells["SegundoApellido"].Value.ToString();
                //this.fechaNacimientoDateTimePicker.Value = DateTime.Parse(this.dgvDatos.CurrentRow.Cells["FechaNacimiento"].Value.ToString());
                //this.emailTextBox.Text = this.dgvDatos.CurrentRow.Cells["Email"].Value.ToString();
                //this.passwordTextBox.Text = this.dgvDatos.CurrentRow.Cells["Password"].Value.ToString();
                this.gradoEstudioComboBox.SelectedValue = this.dgvDatos.CurrentRow.Cells["IdGradoEstudio"].Value.ToString();
                this.cargoComboBox.SelectedValue = this.dgvDatos.CurrentRow.Cells["IdCargo"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Sincroniza Datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
