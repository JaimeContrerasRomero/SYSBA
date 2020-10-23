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
    public partial class fRol : Form
    {
        public fRol()
        {
            InitializeComponent();
        }

        private void fRol_Load(object sender, EventArgs e)
        {
            this.CargaDatos();
        }

        public int IdUsuarioLog { get; set; }
        private int Id { get; set; }
        string Mensaje = "";
        string Titulo = "";
        MessageBoxIcon Icono;
        Helper h = new Helper();

        private void CargaDatos()
        {
            try
            {
                this.rolTableAdapter.Fill(this.sYSBADataSet.Rol, this.txtBuscar.Text.Trim(), true );
                this.dgvDatos.DataSource = this.sYSBADataSet.Rol;

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.CargaDatos();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.h.ModoEdicion("I", this.pnlBotones, this.pnlRegistros, this.pnlDatos);
            this.h.LimpiaControles(this.pnlDatos);
            this.nombreTextBox.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.h.ModoEdicion("M", this.pnlBotones, this.pnlRegistros, this.pnlDatos);
            this.nombreTextBox.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro de borrar éste registro?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Eliminar();
            }
        }

        private void Eliminar()
        {
            try
            {                
                this.rolTableAdapter.Delete(this.Id);
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
                this.Guardar();
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
                        this.rolTableAdapter.Insert(this.nombreTextBox.Text.Trim(), true);
                        this.Mensaje = "El registro de guardó correctamente.";
                        this.Titulo = "Guardar";
                        this.Icono = MessageBoxIcon.Information;
                        break;
                    case "M":
                        this.rolTableAdapter.Update(this.nombreTextBox.Text.Trim(), true, this.Id);
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

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                CargaDatos();
            }
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvDatos.Rows.Count == 0)
                    return;
                this.Id = int.Parse(this.dgvDatos.CurrentRow.Cells["IdRol"].Value.ToString());
                this.nombreTextBox.Text = this.dgvDatos.CurrentRow.Cells["Nombre"].Value.ToString();
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
            if (this.nombreTextBox.Text.Trim() == string.Empty)
            {
                this.errorProvider1.SetError(this.nombreTextBox, "Éste campo es requerido");
                resultado = false;
            }
            return resultado;
        }

    }
}
