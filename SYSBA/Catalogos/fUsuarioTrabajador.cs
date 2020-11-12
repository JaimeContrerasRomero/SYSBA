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
            this.CargaDatos();
        }

        private void CargaDatos()
        {
            try
            {

                this.sexoTableAdapter.Fill(this.sYSBADataSet.Sexo);
                this.rolTableAdapter.Fill(this.sYSBADataSet.Rol, "", true);
                this.gradoEstudioTableAdapter.Fill(this.sYSBADataSet.GradoEstudio, null, "", true);
                this.cargoTableAdapter.Fill(this.sYSBADataSet.Cargo, null, "", true);
                this.vUsuarioTrabajadorTableAdapter.Fill(this.sYSBADataSet.vUsuarioTrabajador, null, null, null, null, null, null, null, null, null, this.txtBuscar.Text.Trim(), true);
                this.dgvDatos.DataSource = this.sYSBADataSet.vUsuarioTrabajador;
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
            this.h.LimpiaControles(this.groupBox1);
            this.h.LimpiaControles(this.groupBox2);
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
            if (this.Valida())
            {
                this.Guardar();
                MessageBox.Show(this.Mensaje, this.Titulo, MessageBoxButtons.OK, this.Icono);
            }
        }

        private void Guardar()
        {
            try
            {
                int? Resultado = 0;
                switch (h.Modo)
                {
                    case "I":
                        this.vUsuarioTrabajadorTableAdapter.Insert((int)this.rolComboBox.SelectedValue, this.nombreTextBox.Text.Trim(), this.primerApellidoTextBox.Text.Trim(), this.segundoApellidoTextBox.Text.Trim(), (int)this.sexoComboBox.SelectedValue, this.emailTextBox.Text.Trim(), this.passwordTextBox.Text.Trim(), this.usuarioSistemaCheckBox.Checked, (int)this.gradoEstudioComboBox.SelectedValue, (int)this.cargoComboBox.SelectedValue, this.tituloAcademicoTextBox.Text.Trim(), this.fechaNacimientoDateTimePicker.Value, this.secundariaCheckBox.Checked, this.bachilleratoCheckBox.Checked, ref Resultado);
                        this.Mensaje = "El registro de guardó correctamente.";
                        this.Titulo = "Guardar";
                        this.Icono = MessageBoxIcon.Information;
                        break;
                    case "M":
                        this.vUsuarioTrabajadorTableAdapter.Update(this.Id, (int)this.rolComboBox.SelectedValue, this.nombreTextBox.Text.Trim(), this.primerApellidoTextBox.Text.Trim(), this.segundoApellidoTextBox.Text.Trim(), (int)this.sexoComboBox.SelectedValue, this.emailTextBox.Text.Trim(), this.passwordTextBox.Text.Trim(), this.usuarioSistemaCheckBox.Checked, (int)this.gradoEstudioComboBox.SelectedValue, (int)this.cargoComboBox.SelectedValue, this.tituloAcademicoTextBox.Text.Trim(), this.fechaNacimientoDateTimePicker.Value, this.secundariaCheckBox.Checked, this.bachilleratoCheckBox.Checked, ref Resultado);
                        this.Mensaje = "El registro se actualizó correctamente.";
                        this.Titulo = "Actualizar";
                        this.Icono = MessageBoxIcon.Information;
                        break;
                }
                this.CargaDatos();
            }
            catch (Exception ex)
            {
                this.Titulo = "Error";
                this.Mensaje = "Error Guardar: " + ex.Message;
                this.Icono = MessageBoxIcon.Error;
            }
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
                this.gradoEstudioComboBox.SelectedValue = this.dgvDatos.CurrentRow.Cells["IdGradoEstudio"].Value.ToString();
                this.cargoComboBox.SelectedValue = this.dgvDatos.CurrentRow.Cells["IdCargo"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Sincroniza Datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Valida()
        {
            this.errorProvider1.Clear();
            bool valido = true;
            if (this.nombreTextBox.Text.Trim() == "")
            {
                valido = false;
                this.errorProvider1.SetError(this.nombreTextBox, "Éste campo es requerido");
            }
            if (this.primerApellidoTextBox.Text.Trim() == "")
            {
                valido = false;
                this.errorProvider1.SetError(this.primerApellidoTextBox, "Éste campo es requerido");
            }
            if(this.usuarioSistemaCheckBox.Checked)
            {
                if (this.emailTextBox.Text.Trim() == "")
                {
                    valido = false;
                    this.errorProvider1.SetError(this.emailTextBox, "Éste campo es requerido");
                }
                if (this.passwordTextBox.Text.Trim() == "")
                {
                    valido = false;
                    this.errorProvider1.SetError(this.passwordTextBox, "Éste campo es requerido");
                }
            }
            return valido;
        }
    }
}
