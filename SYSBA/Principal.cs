using SYSBA.Catalogos;
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
    public partial class Principal : Form
    {
        public int IdUsuarioLog { get; set; }
        public int IdRol { get; set; }
        public string NombreCompleto { get; set; }
        public string Rol { get; set; }

        public Principal()
        {
            InitializeComponent();
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            fCargo x = new fCargo();
            x.MdiParent = this;
            x.Show();
        }

        private void btnDocumentoExpediente_Click(object sender, EventArgs e)
        {
            fDocumentoExpediente x = new fDocumentoExpediente();
            x.MdiParent = this;
            x.Show();
        }

        private void btnEscuelaProcedencia_Click(object sender, EventArgs e)
        {
            fEscuelaProcedencia x = new fEscuelaProcedencia();
            x.MdiParent = this;
            x.Show();
        }

        private void btnGrado_Click(object sender, EventArgs e)
        {
            fGrado x = new fGrado();
            x.MdiParent = this;
            x.Show();
        }

        private void btnGradoEstudio_Click(object sender, EventArgs e)
        {
            fGradoEstudio x = new fGradoEstudio();
            x.MdiParent = this;
            x.Show();
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            fRol f = new fRol();
            f.IdUsuarioLog = this.IdUsuarioLog;
            f.MdiParent = this;
            f.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            fUsuarioTrabajador f = new fUsuarioTrabajador();
            f.IdUsuarioLog = this.IdUsuarioLog;
            f.MdiParent = this;
            f.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        
    }
}
