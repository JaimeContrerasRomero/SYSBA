namespace SYSBA.Catalogos
{
    partial class fDocumentoExpediente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDocumentoExpediente));
            System.Windows.Forms.Label nombreLabel;
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.chkParaTrabajador = new System.Windows.Forms.CheckBox();
            this.chkObligatorio = new System.Windows.Forms.CheckBox();
            this.chkParaAlumno = new System.Windows.Forms.CheckBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bsDatos = new System.Windows.Forms.BindingSource(this.components);
            this.pnlRegistros = new System.Windows.Forms.Panel();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.bnDatos = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.sYSBADataSet = new SYSBA.SYSBADataSet();
            this.documentoExpedienteTableAdapter = new SYSBA.SYSBADataSetTableAdapters.DocumentoExpedienteTableAdapter();
            this.IdDocumentoExpediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParaTrabajador = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ParaAlumno = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Obligatorio = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            nombreLabel = new System.Windows.Forms.Label();
            this.pnlBotones.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDatos)).BeginInit();
            this.pnlRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnDatos)).BeginInit();
            this.bnDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sYSBADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnEliminar);
            this.pnlBotones.Controls.Add(this.btnEditar);
            this.pnlBotones.Controls.Add(this.btnInsertar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotones.Location = new System.Drawing.Point(0, 0);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(549, 68);
            this.pnlBotones.TabIndex = 8;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(120, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(48, 40);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(66, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(48, 40);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertar.Image")));
            this.btnInsertar.Location = new System.Drawing.Point(12, 12);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(48, 40);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.chkParaTrabajador);
            this.pnlDatos.Controls.Add(this.chkObligatorio);
            this.pnlDatos.Controls.Add(this.chkParaAlumno);
            this.pnlDatos.Controls.Add(nombreLabel);
            this.pnlDatos.Controls.Add(this.nombreTextBox);
            this.pnlDatos.Controls.Add(this.btnCancelar);
            this.pnlDatos.Controls.Add(this.btnGuardar);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDatos.Location = new System.Drawing.Point(0, 310);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(549, 105);
            this.pnlDatos.TabIndex = 9;
            // 
            // chkParaTrabajador
            // 
            this.chkParaTrabajador.AutoSize = true;
            this.chkParaTrabajador.Location = new System.Drawing.Point(66, 58);
            this.chkParaTrabajador.Name = "chkParaTrabajador";
            this.chkParaTrabajador.Size = new System.Drawing.Size(116, 17);
            this.chkParaTrabajador.TabIndex = 2;
            this.chkParaTrabajador.Text = "Es para Trabajador";
            this.chkParaTrabajador.UseVisualStyleBackColor = true;
            // 
            // chkObligatorio
            // 
            this.chkObligatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkObligatorio.AutoSize = true;
            this.chkObligatorio.Location = new System.Drawing.Point(371, 58);
            this.chkObligatorio.Name = "chkObligatorio";
            this.chkObligatorio.Size = new System.Drawing.Size(91, 17);
            this.chkObligatorio.TabIndex = 4;
            this.chkObligatorio.Text = "Es Obligatorio";
            this.chkObligatorio.UseVisualStyleBackColor = true;
            // 
            // chkParaAlumno
            // 
            this.chkParaAlumno.AutoSize = true;
            this.chkParaAlumno.Location = new System.Drawing.Point(209, 58);
            this.chkParaAlumno.Name = "chkParaAlumno";
            this.chkParaAlumno.Size = new System.Drawing.Size(100, 17);
            this.chkParaAlumno.TabIndex = 3;
            this.chkParaAlumno.Text = "Es para Alumno";
            this.chkParaAlumno.UseVisualStyleBackColor = true;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(13, 20);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 11;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextBox.Location = new System.Drawing.Point(66, 17);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(396, 20);
            this.nombreTextBox.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(489, 52);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(48, 40);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(489, 6);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(48, 40);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bsDatos
            // 
            this.bsDatos.DataMember = "DocumentoExpediente";
            this.bsDatos.DataSource = this.sYSBADataSet;
            // 
            // pnlRegistros
            // 
            this.pnlRegistros.Controls.Add(this.dgvDatos);
            this.pnlRegistros.Controls.Add(this.bnDatos);
            this.pnlRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegistros.Location = new System.Drawing.Point(0, 68);
            this.pnlRegistros.Name = "pnlRegistros";
            this.pnlRegistros.Size = new System.Drawing.Size(549, 242);
            this.pnlRegistros.TabIndex = 10;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToOrderColumns = true;
            this.dgvDatos.AutoGenerateColumns = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDocumentoExpediente,
            this.Nombre,
            this.ParaTrabajador,
            this.ParaAlumno,
            this.Obligatorio,
            this.activoDataGridViewCheckBoxColumn});
            this.dgvDatos.DataSource = this.bsDatos;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 25);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(549, 217);
            this.dgvDatos.TabIndex = 7;
            this.dgvDatos.SelectionChanged += new System.EventHandler(this.dgvDatos_SelectionChanged);
            // 
            // bnDatos
            // 
            this.bnDatos.AddNewItem = null;
            this.bnDatos.BindingSource = this.bsDatos;
            this.bnDatos.CountItem = this.bindingNavigatorCountItem;
            this.bnDatos.DeleteItem = null;
            this.bnDatos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.txtBuscar,
            this.btnBuscar});
            this.bnDatos.Location = new System.Drawing.Point(0, 0);
            this.bnDatos.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnDatos.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnDatos.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnDatos.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnDatos.Name = "bnDatos";
            this.bnDatos.PositionItem = this.bindingNavigatorPositionItem;
            this.bnDatos.Size = new System.Drawing.Size(549, 25);
            this.bnDatos.TabIndex = 6;
            this.bnDatos.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(300, 25);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(23, 22);
            this.btnBuscar.Text = "toolStripButton1";
            this.btnBuscar.ToolTipText = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // sYSBADataSet
            // 
            this.sYSBADataSet.DataSetName = "SYSBADataSet";
            this.sYSBADataSet.EnforceConstraints = false;
            this.sYSBADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentoExpedienteTableAdapter
            // 
            this.documentoExpedienteTableAdapter.ClearBeforeFill = true;
            // 
            // IdDocumentoExpediente
            // 
            this.IdDocumentoExpediente.DataPropertyName = "IdDocumentoExpediente";
            this.IdDocumentoExpediente.HeaderText = "Folio";
            this.IdDocumentoExpediente.Name = "IdDocumentoExpediente";
            this.IdDocumentoExpediente.ReadOnly = true;
            this.IdDocumentoExpediente.Width = 54;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 69;
            // 
            // ParaTrabajador
            // 
            this.ParaTrabajador.DataPropertyName = "ParaTrabajador";
            this.ParaTrabajador.HeaderText = "Es Para Trabajador";
            this.ParaTrabajador.Name = "ParaTrabajador";
            this.ParaTrabajador.ReadOnly = true;
            this.ParaTrabajador.Width = 94;
            // 
            // ParaAlumno
            // 
            this.ParaAlumno.DataPropertyName = "ParaAlumno";
            this.ParaAlumno.HeaderText = "Es Para Alumno";
            this.ParaAlumno.Name = "ParaAlumno";
            this.ParaAlumno.ReadOnly = true;
            this.ParaAlumno.Width = 79;
            // 
            // Obligatorio
            // 
            this.Obligatorio.DataPropertyName = "Obligatorio";
            this.Obligatorio.HeaderText = "Es Obligatorio";
            this.Obligatorio.Name = "Obligatorio";
            this.Obligatorio.ReadOnly = true;
            this.Obligatorio.Width = 70;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activoDataGridViewCheckBoxColumn.Visible = false;
            this.activoDataGridViewCheckBoxColumn.Width = 43;
            // 
            // fDocumentoExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 415);
            this.Controls.Add(this.pnlRegistros);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlBotones);
            this.MinimumSize = new System.Drawing.Size(565, 454);
            this.Name = "fDocumentoExpediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentos para Expediente";
            this.Load += new System.EventHandler(this.fDocumentoExpediente_Load);
            this.pnlBotones.ResumeLayout(false);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDatos)).EndInit();
            this.pnlRegistros.ResumeLayout(false);
            this.pnlRegistros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnDatos)).EndInit();
            this.bnDatos.ResumeLayout(false);
            this.bnDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sYSBADataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.CheckBox chkParaTrabajador;
        private System.Windows.Forms.CheckBox chkObligatorio;
        private System.Windows.Forms.CheckBox chkParaAlumno;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource bsDatos;
        private System.Windows.Forms.Panel pnlRegistros;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.BindingNavigator bnDatos;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripTextBox txtBuscar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private SYSBADataSet sYSBADataSet;
        private SYSBADataSetTableAdapters.DocumentoExpedienteTableAdapter documentoExpedienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDocumentoExpediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ParaTrabajador;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ParaAlumno;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Obligatorio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
    }
}