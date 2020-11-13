using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYSBA
{
    public class Helper
    {

        public string Modo { get; set; }

        public void ModoEdicion(string modo, Panel pnlBotones, Panel pnlRegistros, Panel pnlDatos)
        {
            this.Modo = modo;
            pnlBotones.Enabled = modo == "L";
            pnlRegistros.Enabled = modo == "L";
            pnlDatos.Enabled = modo != "L";
        }

        public void ModoEdicionTab(string modo, TabControl tab, int index, Panel pnlBotones, Panel pnlRegistros, Panel pnlDatos)
        {
            this.Modo = modo;
            tab.SelectedIndex = index;
            pnlBotones.Enabled = modo == "L";
            pnlRegistros.Enabled = modo == "L";
            pnlDatos.Enabled = true;//modo != "L";
        }

        public void CargaCombo(ComboBox comboBox, string Texto, string Valor, DataTable dt)
        {
            //if (comboBox.Items.Count > 0)
            //    comboBox.Items.Clear();
            comboBox.DisplayMember = Texto;
            comboBox.ValueMember = Valor;
            comboBox.DataSource = dt;
        }

        public void LimpiaControles(Control control, int value = 0, bool validaND = true)
        {
            foreach (var ctl in control.Controls)
            {
                if (ctl is TextBox)
                {
                    ((TextBox)ctl).Clear();
                }
                if (ctl is MaskedTextBox)
                {
                    ((MaskedTextBox)ctl).Clear();
                }
                if (ctl is DateTimePicker)
                {
                    ((DateTimePicker)ctl).Value = DateTime.Now;
                }
                if (validaND)
                {
                    if (ctl is NumericUpDown)
                    {
                        ((NumericUpDown)ctl).Value = value;
                    }
                }
                if (ctl is ComboBox)
                {
                    if (((ComboBox)ctl).Items.Count > 0)
                        ((ComboBox)ctl).SelectedIndex = 0;
                }
                if (ctl is RadioButton)
                {
                    ((RadioButton)ctl).Checked = false;
                }
                if (ctl is CheckBox)
                {
                    ((CheckBox)ctl).Checked = false;
                }
                if (ctl is PictureBox)
                {
                    //((PictureBox)ctl).Image = Properties.Resources.icons8_libros_100;
                }
            }
        }
    }
}
