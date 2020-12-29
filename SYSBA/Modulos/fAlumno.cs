using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        public int scan = 0;
        List<string> file = new List<string>(); //Lista de archivos
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

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            try
            {
                //if (this.txt_nombre_archivo.Text != "TIPO DE DOCUMENTO_SEMESTRE" && this.scan == 1)
                //{

                //    if (this.txt_nombre_archivo.Text == "FOTO")
                //        this.establecer_foto();
                //    else
                //        this.establecer_documento();

                //}
            }
            catch (Exception)
            {

                //throw;
            }
        }

        bool foto = false;

        public void establecer_foto()
        {
            foto = false;
            if (this.dgv_coleccion.RowCount > 0)
                this.existe_foto();

            if (foto == false)
            {
                this.dgv_coleccion.Rows.Add();
                MemoryStream ms = new MemoryStream();
                pb_documento.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] pb_array = ms.ToArray();
                //this.expedienteDataSet.dt_escaneado.Adddt_escaneadoRow(int.Parse(this.cbo_tipo_documento.SelectedValue.ToString()), 1, this.txt_nombre_archivo.Text, pb_array);
                //this.txt_nombre_archivo.Text = "TIPO DE DOCUMENTO_SEMESTRE";
                //this.td = "TIPO DE DOCUMENTO";
                //this.s = "SEMESTRE";
                this.scan = 0;

                //this.cbo_semestre_documento.SelectedIndex = -1;
                this.cbo_tipo_documento.SelectedIndex = -1;
                //this.dgv_coleccion.Sort(this.nombreDataGridViewTextBoxColumn, ListSortDirection.Ascending);
                //this.pb_alumno.Image = global::MetroPanelSlide.Properties.Resources.documento1;
            }
        }

        public void existe_foto()
        {
            for (int index = 0; index < this.dgv_coleccion.Rows.Count; index++)
            {
                string nombre = this.dgv_coleccion.Rows[index].Cells[0].Value.ToString();

                if (nombre == "FOTO")
                {
                    foto = true;
                    break;
                }

            }
        }

        public void establecer_documento()
        {

            MemoryStream ms = new MemoryStream();
            pb_documento.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] pb_array = ms.ToArray();
            //this.expedienteDataSet.dt_escaneado.Adddt_escaneadoRow(int.Parse(this.cbo_tipo_documento.SelectedValue.ToString()), 1, this.txt_nombre_archivo.Text, pb_array);
            //this.txt_nombre_archivo.Text = "TIPO DE DOCUMENTO_SEMESTRE";
            //this.td = "TIPO DE DOCUMENTO";
            //this.s = "SEMESTRE";
            this.scan = 0;

            //this.cbo_semestre_documento.SelectedIndex = -1;
            this.cbo_tipo_documento.SelectedIndex = -1;
            //this.dgv_coleccion.Sort(this.nombreDataGridViewTextBoxColumn, ListSortDirection.Ascending);
            //this.pb_documento.Image = global::MetroPanelSlide.Properties.Resources.documento1;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
                this.dgv_coleccion.Rows.Remove(this.dgv_coleccion.CurrentRow);
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void btnScanner_Click(object sender, EventArgs e)
        {
            Scanner documento = new Scanner();
            if (documento.mensaje == 0)
            {
                Image temporal = documento.Scann();
                if (documento.mensaje == 0)
                {
                    this.pb_documento.Image = temporal;
                    this.scan = 1;
                }
            }
        }

        private void btn_abrir_documento_Click(object sender, EventArgs e)
        {
            if (this.lsv_expedientes.SelectedItems.Count > 0)
            {
                Process.Start(this.file[this.lsv_expedientes.FocusedItem.Index]);
            }
        }

        private void btn_borrar_documento_Click(object sender, EventArgs e)
        {
            if (this.lsv_expedientes.SelectedItems.Count > 0)
            {
                this.eliminar_archivo();
            }
        }

        public void eliminar_archivo()
        {
            try
            {
                DialogResult result = MessageBox.Show("¿ESTA SEGURO QUE DESEA ELIMINAR EL REGISTRO?", "SDE ", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    global::System.Nullable<int> id;
                    //this.spTableAdapter.sp_alumno_documento_de(this.file[this.lsv_expedientes.FocusedItem.Index].ToString(), out id);

                    //if (id > 0)
                    //{
                    //    File.Delete(this.file[this.lsv_expedientes.FocusedItem.Index].ToString());
                    //    this.directorio();
                    //}

                }

            }
            catch (Exception)
            {

            }
        }

        private void lsv_expedientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.lsv_expedientes.SelectedItems.Count > 0)
            {
                Process.Start(this.file[this.lsv_expedientes.FocusedItem.Index]);
            }
        }

        private void lsv_expedientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return && this.lsv_expedientes.SelectedItems.Count > 0)
            {
                Process.Start(this.file[this.lsv_expedientes.FocusedItem.Index]);
            }
            else if (e.KeyChar == (char)Keys.Delete && this.lsv_expedientes.SelectedItems.Count > 0)
            {
                this.eliminar_archivo();
            }
        }
    }
}
