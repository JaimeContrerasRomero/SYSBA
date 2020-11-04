using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYSBA
{
    public partial class Plantilla : Form
    {
        public int IdUsuarioLog { get; set; }
        string Mensaje = "";
        string Titulo = "";
        MessageBoxIcon Icono;
        Helper h = new Helper();

        public Plantilla()
        {
            InitializeComponent();
        }

        private void Plantilla_Load(object sender, EventArgs e)
        {
            //LoadingAsyc(CargaDatos);
            CargaDatos();
        }

        private void CargaDatos()
        {
            try
            {
                //this.usuarioTableAdapter.Fill(this.dsDatos.Usuario, null, this.txtBuscar.Text.Trim(), true);
                //this.dgvDatos.DataSource = this.dsDatos.Usuario;

                //this.rolTableAdapter.Fill(this.dsDatos.Rol, true);
                //h.CargaCombo(this.cboRol, "Rol", "IdRol", this.dsDatos.Rol);

                this.btnEditar.Enabled = this.dgvDatos.Rows.Count > 0;
                this.btnEliminar.Enabled = this.dgvDatos.Rows.Count > 0;

                h.ModoEdicion("L", this.pnlBotones, this.pnlRegistros, this.pnlDatos);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Carga Datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //LoadingAsyc(CargaDatos);
            CargaDatos();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            h.ModoEdicion("I", this.pnlBotones, this.pnlRegistros, this.pnlDatos);
            h.LimpiaControles(this.pnlDatos);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            h.ModoEdicion("M", this.pnlBotones, this.pnlRegistros, this.pnlDatos);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro de borrar éste registro?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //LoadingAsyc(Eliminar);
                Eliminar();
            }
        }

        private void Eliminar()
        {
            try
            {
                int? result = 0;
                //int idUsuario = int.Parse(this.idUsuarioTextBox.Text.Trim());
                //this.usuarioTableAdapter.Delete(idUsuario, this.IdUsuarioLog, ref result);
                this.CargaDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Borrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.ValidaControles())
            {
                //LoadingAsyc(Guardar);
                Guardar();
                MessageBox.Show(this.Mensaje, this.Titulo, MessageBoxButtons.OK, this.Icono);
            }
        }

        private void Guardar()
        {
            try
            {
                switch (h.Modo)
                {
                    case "I":
                        //this.usuarioTableAdapter.Insert(int.Parse(this.cboRol.SelectedValue.ToString()), this.nombreTextBox.Text.Trim(), this.apellidosTextBox.Text.Trim(), this.usuarioTextBox.Text.Trim(), this.passwordTextBox.Text.Trim(), true, this.IdUsuarioLog, ref this.Resultado);
                        this.Mensaje = "El registro de guardó correctamente.";
                        this.Titulo = "Guardar";
                        this.Icono = MessageBoxIcon.Information;
                        break;
                    case "M":
                        //int idUsuario = int.Parse(this.idUsuarioTextBox.Text.Trim());
                        //this.usuarioTableAdapter.Update(idUsuario, int.Parse(this.cboRol.SelectedValue.ToString()), this.nombreTextBox.Text.Trim(), this.apellidosTextBox.Text.Trim(), this.usuarioTextBox.Text.Trim(), this.passwordTextBox.Text.Trim(), true, this.IdUsuarioLog, ref this.Resultado);
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
            //LoadingAsyc(CargaDatos);
            CargaDatos();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //LoadingAsyc(CargaDatos);
                CargaDatos();
            }
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvDatos.Rows.Count == 0)
                    return;

                //this.cboRol.SelectedValue = this.dgvDatos.CurrentRow.Cells["IdProducto"].Value.ToString();
                //this.txtIdCliente.Text = this.dgvDatos.CurrentRow.Cells["IdProducto"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Sincroniza Datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidaControles()
        {
            this.errorProvider1.Clear();
            bool resultado = true;
            //if (this.nombreTextBox.Text.Trim() == string.Empty)
            //{
            //    this.errorProvider1.SetError(this.nombreTextBox, "Éste campo es requerido");
            //    resultado = false;
            //}
            //if (this.apellidosTextBox.Text.Trim() == string.Empty)
            //{
            //    this.errorProvider1.SetError(this.apellidosTextBox, "Éste campo es requerido");
            //    resultado = false;
            //}
            //if (this.usuarioTextBox.Text.Trim() == string.Empty)
            //{
            //    this.errorProvider1.SetError(this.usuarioTextBox, "Éste campo es requerido");
            //    resultado = false;
            //}
            //if (this.passwordTextBox.Text.Trim() == string.Empty)
            //{
            //    this.errorProvider1.SetError(this.passwordTextBox, "Éste campo es requerido");
            //}
            return resultado;
        }

        private void Plantilla_Load_1(object sender, EventArgs e)
        {

        }
    }
}
