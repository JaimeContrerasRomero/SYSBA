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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidaCampos())
                {
                    this.sp_LoginTableAdapter.Fill(this.dsDatos.sp_Login, this.txtNombre.Text.Trim(), this.txtPassword.Text.Trim());
                    if (this.dsDatos.sp_Login.Rows.Count > 0)
                    {
                        DataRow row = this.dsDatos.sp_Login.Rows[0];
                        Principal p = new Principal();
                        p.IdUsuarioLog = int.Parse(row["IdUsuario"].ToString());
                        p.IdRol = int.Parse(row["IdRol"].ToString());
                        p.Rol = row["Rol"].ToString();
                        p.NombreCompleto = row["NombreCompleto"].ToString();
                        //abre el form principal

                        this.Hide();
                        p.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El usuario y/o contraseña que ingresó, no son correctos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidaCampos()
        {
            this.errorProvider1.Clear();
            bool resultado = true;
            if (this.txtNombre.Text.Trim() == string.Empty)
            {
                this.errorProvider1.SetError(this.txtNombre, "Éste campo es requerido");
                resultado = false;
            }
            if (this.txtPassword.Text.Trim() == string.Empty)
            {
                this.errorProvider1.SetError(this.txtPassword, "Éste campo es requerido");
            }
            return resultado;
        }

    }
}
