namespace SYSBA.Modulos
{
    partial class fAlumno
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label primerApellidoLabel;
            System.Windows.Forms.Label segundoApellidoLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label cURPLabel;
            System.Windows.Forms.Label fechaNacimientoLabel;
            System.Windows.Forms.Label fechaIngresoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAlumno));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcDatos = new System.Windows.Forms.TabControl();
            this.tpDatos = new System.Windows.Forms.TabPage();
            this.pnlRegistros = new System.Windows.Forms.Panel();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.IdAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CURP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlumnoSecundaria = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AlumnoBachillerato = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDatos = new System.Windows.Forms.BindingSource(this.components);
            this.sYSBADataSet = new SYSBA.SYSBADataSet();
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
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.tpRegistros = new System.Windows.Forms.TabPage();
            this.tcDatosAlumno = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.fechaIngresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cURPTextBox = new System.Windows.Forms.TextBox();
            this.sexoComboBox = new System.Windows.Forms.ComboBox();
            this.segundoApellidoTextBox = new System.Windows.Forms.TextBox();
            this.primerApellidoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.alumnoTableAdapter = new SYSBA.SYSBADataSetTableAdapters.AlumnoTableAdapter();
            this.tableAdapterManager = new SYSBA.SYSBADataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_tipo_documento = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pnl_datos = new System.Windows.Forms.Panel();
            this.dgv_coleccion = new System.Windows.Forms.DataGridView();
            this.bn_datos = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_insertar = new System.Windows.Forms.ToolStripButton();
            this.btn_eliminar = new System.Windows.Forms.ToolStripButton();
            this.pb_documento = new System.Windows.Forms.PictureBox();
            this.btnScanner = new System.Windows.Forms.Button();
            this.txt_nombre_archivo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_borrar_documento = new System.Windows.Forms.Button();
            this.btn_abrir_documento = new System.Windows.Forms.Button();
            this.lsv_expedientes = new System.Windows.Forms.ListView();
            nombreLabel = new System.Windows.Forms.Label();
            primerApellidoLabel = new System.Windows.Forms.Label();
            segundoApellidoLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            cURPLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            fechaIngresoLabel = new System.Windows.Forms.Label();
            this.tcDatos.SuspendLayout();
            this.tpDatos.SuspendLayout();
            this.pnlRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSBADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnDatos)).BeginInit();
            this.bnDatos.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.tpRegistros.SuspendLayout();
            this.tcDatosAlumno.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnl_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_coleccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_datos)).BeginInit();
            this.bn_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_documento)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(222, 65);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre:";
            // 
            // primerApellidoLabel
            // 
            primerApellidoLabel.AutoSize = true;
            primerApellidoLabel.Location = new System.Drawing.Point(190, 110);
            primerApellidoLabel.Name = "primerApellidoLabel";
            primerApellidoLabel.Size = new System.Drawing.Size(79, 13);
            primerApellidoLabel.TabIndex = 3;
            primerApellidoLabel.Text = "Primer Apellido:";
            // 
            // segundoApellidoLabel
            // 
            segundoApellidoLabel.AutoSize = true;
            segundoApellidoLabel.Location = new System.Drawing.Point(176, 155);
            segundoApellidoLabel.Name = "segundoApellidoLabel";
            segundoApellidoLabel.Size = new System.Drawing.Size(93, 13);
            segundoApellidoLabel.TabIndex = 5;
            segundoApellidoLabel.Text = "Segundo Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(235, 200);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(34, 13);
            label2.TabIndex = 18;
            label2.Text = "Sexo:";
            // 
            // cURPLabel
            // 
            cURPLabel.AutoSize = true;
            cURPLabel.Location = new System.Drawing.Point(229, 245);
            cURPLabel.Name = "cURPLabel";
            cURPLabel.Size = new System.Drawing.Size(40, 13);
            cURPLabel.TabIndex = 18;
            cURPLabel.Text = "CURP:";
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Location = new System.Drawing.Point(173, 290);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(96, 13);
            fechaNacimientoLabel.TabIndex = 19;
            fechaNacimientoLabel.Text = "Fecha Nacimiento:";
            // 
            // fechaIngresoLabel
            // 
            fechaIngresoLabel.AutoSize = true;
            fechaIngresoLabel.Location = new System.Drawing.Point(191, 335);
            fechaIngresoLabel.Name = "fechaIngresoLabel";
            fechaIngresoLabel.Size = new System.Drawing.Size(78, 13);
            fechaIngresoLabel.TabIndex = 20;
            fechaIngresoLabel.Text = "Fecha Ingreso:";
            // 
            // tcDatos
            // 
            this.tcDatos.Controls.Add(this.tpDatos);
            this.tcDatos.Controls.Add(this.tpRegistros);
            this.tcDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcDatos.Location = new System.Drawing.Point(0, 0);
            this.tcDatos.Name = "tcDatos";
            this.tcDatos.SelectedIndex = 0;
            this.tcDatos.Size = new System.Drawing.Size(773, 570);
            this.tcDatos.TabIndex = 0;
            // 
            // tpDatos
            // 
            this.tpDatos.Controls.Add(this.pnlRegistros);
            this.tpDatos.Controls.Add(this.pnlBotones);
            this.tpDatos.Location = new System.Drawing.Point(4, 22);
            this.tpDatos.Name = "tpDatos";
            this.tpDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tpDatos.Size = new System.Drawing.Size(765, 477);
            this.tpDatos.TabIndex = 0;
            this.tpDatos.Text = "tabPage1";
            this.tpDatos.UseVisualStyleBackColor = true;
            // 
            // pnlRegistros
            // 
            this.pnlRegistros.Controls.Add(this.dgvDatos);
            this.pnlRegistros.Controls.Add(this.bnDatos);
            this.pnlRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegistros.Location = new System.Drawing.Point(3, 71);
            this.pnlRegistros.Name = "pnlRegistros";
            this.pnlRegistros.Size = new System.Drawing.Size(759, 403);
            this.pnlRegistros.TabIndex = 5;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToOrderColumns = true;
            this.dgvDatos.AutoGenerateColumns = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAlumno,
            this.Nombre,
            this.PrimerApellido,
            this.SegundoApellido,
            this.IdSexo,
            this.FechaNacimiento,
            this.CURP,
            this.AlumnoSecundaria,
            this.AlumnoBachillerato,
            this.Activo,
            this.FechaIngreso,
            this.Sexo});
            this.dgvDatos.DataSource = this.bsDatos;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 25);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(759, 378);
            this.dgvDatos.TabIndex = 7;
            this.dgvDatos.SelectionChanged += new System.EventHandler(this.dgvDatos_SelectionChanged);
            // 
            // IdAlumno
            // 
            this.IdAlumno.DataPropertyName = "IdAlumno";
            this.IdAlumno.HeaderText = "IdAlumno";
            this.IdAlumno.Name = "IdAlumno";
            this.IdAlumno.ReadOnly = true;
            this.IdAlumno.Width = 76;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 69;
            // 
            // PrimerApellido
            // 
            this.PrimerApellido.DataPropertyName = "PrimerApellido";
            this.PrimerApellido.HeaderText = "PrimerApellido";
            this.PrimerApellido.Name = "PrimerApellido";
            this.PrimerApellido.ReadOnly = true;
            this.PrimerApellido.Width = 98;
            // 
            // SegundoApellido
            // 
            this.SegundoApellido.DataPropertyName = "SegundoApellido";
            this.SegundoApellido.HeaderText = "SegundoApellido";
            this.SegundoApellido.Name = "SegundoApellido";
            this.SegundoApellido.ReadOnly = true;
            this.SegundoApellido.Width = 112;
            // 
            // IdSexo
            // 
            this.IdSexo.DataPropertyName = "IdSexo";
            this.IdSexo.HeaderText = "IdSexo";
            this.IdSexo.Name = "IdSexo";
            this.IdSexo.ReadOnly = true;
            this.IdSexo.Width = 65;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.FechaNacimiento.HeaderText = "FechaNacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            this.FechaNacimiento.Width = 115;
            // 
            // CURP
            // 
            this.CURP.DataPropertyName = "CURP";
            this.CURP.HeaderText = "CURP";
            this.CURP.Name = "CURP";
            this.CURP.ReadOnly = true;
            this.CURP.Width = 62;
            // 
            // AlumnoSecundaria
            // 
            this.AlumnoSecundaria.DataPropertyName = "AlumnoSecundaria";
            this.AlumnoSecundaria.HeaderText = "AlumnoSecundaria";
            this.AlumnoSecundaria.Name = "AlumnoSecundaria";
            this.AlumnoSecundaria.ReadOnly = true;
            this.AlumnoSecundaria.Width = 102;
            // 
            // AlumnoBachillerato
            // 
            this.AlumnoBachillerato.DataPropertyName = "AlumnoBachillerato";
            this.AlumnoBachillerato.HeaderText = "AlumnoBachillerato";
            this.AlumnoBachillerato.Name = "AlumnoBachillerato";
            this.AlumnoBachillerato.ReadOnly = true;
            this.AlumnoBachillerato.Width = 103;
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "Activo";
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Width = 43;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.DataPropertyName = "FechaIngreso";
            this.FechaIngreso.HeaderText = "FechaIngreso";
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.ReadOnly = true;
            this.FechaIngreso.Width = 97;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 56;
            // 
            // bsDatos
            // 
            this.bsDatos.DataMember = "Alumno";
            this.bsDatos.DataSource = this.sYSBADataSet;
            // 
            // sYSBADataSet
            // 
            this.sYSBADataSet.DataSetName = "SYSBADataSet";
            this.sYSBADataSet.EnforceConstraints = false;
            this.sYSBADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.bnDatos.Size = new System.Drawing.Size(759, 25);
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
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnEliminar);
            this.pnlBotones.Controls.Add(this.btnEditar);
            this.pnlBotones.Controls.Add(this.btnInsertar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotones.Location = new System.Drawing.Point(3, 3);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(759, 68);
            this.pnlBotones.TabIndex = 3;
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
            // tpRegistros
            // 
            this.tpRegistros.Controls.Add(this.tcDatosAlumno);
            this.tpRegistros.Controls.Add(this.pnlDatos);
            this.tpRegistros.Location = new System.Drawing.Point(4, 22);
            this.tpRegistros.Name = "tpRegistros";
            this.tpRegistros.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegistros.Size = new System.Drawing.Size(765, 544);
            this.tpRegistros.TabIndex = 1;
            this.tpRegistros.Text = "tabPage2";
            this.tpRegistros.UseVisualStyleBackColor = true;
            // 
            // tcDatosAlumno
            // 
            this.tcDatosAlumno.Controls.Add(this.tabPage1);
            this.tcDatosAlumno.Controls.Add(this.tabPage2);
            this.tcDatosAlumno.Controls.Add(this.tabPage3);
            this.tcDatosAlumno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcDatosAlumno.Location = new System.Drawing.Point(3, 3);
            this.tcDatosAlumno.Name = "tcDatosAlumno";
            this.tcDatosAlumno.SelectedIndex = 0;
            this.tcDatosAlumno.Size = new System.Drawing.Size(759, 478);
            this.tcDatosAlumno.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(fechaIngresoLabel);
            this.tabPage1.Controls.Add(this.fechaIngresoDateTimePicker);
            this.tabPage1.Controls.Add(fechaNacimientoLabel);
            this.tabPage1.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.tabPage1.Controls.Add(cURPLabel);
            this.tabPage1.Controls.Add(this.cURPTextBox);
            this.tabPage1.Controls.Add(label2);
            this.tabPage1.Controls.Add(this.sexoComboBox);
            this.tabPage1.Controls.Add(segundoApellidoLabel);
            this.tabPage1.Controls.Add(this.segundoApellidoTextBox);
            this.tabPage1.Controls.Add(primerApellidoLabel);
            this.tabPage1.Controls.Add(this.primerApellidoTextBox);
            this.tabPage1.Controls.Add(nombreLabel);
            this.tabPage1.Controls.Add(this.nombreTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(751, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // fechaIngresoDateTimePicker
            // 
            this.fechaIngresoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsDatos, "FechaIngreso", true));
            this.fechaIngresoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaIngresoDateTimePicker.Location = new System.Drawing.Point(275, 332);
            this.fechaIngresoDateTimePicker.Name = "fechaIngresoDateTimePicker";
            this.fechaIngresoDateTimePicker.Size = new System.Drawing.Size(229, 20);
            this.fechaIngresoDateTimePicker.TabIndex = 21;
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsDatos, "FechaNacimiento", true));
            this.fechaNacimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(275, 287);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(229, 20);
            this.fechaNacimientoDateTimePicker.TabIndex = 20;
            // 
            // cURPTextBox
            // 
            this.cURPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDatos, "CURP", true));
            this.cURPTextBox.Location = new System.Drawing.Point(275, 242);
            this.cURPTextBox.Name = "cURPTextBox";
            this.cURPTextBox.Size = new System.Drawing.Size(229, 20);
            this.cURPTextBox.TabIndex = 19;
            // 
            // sexoComboBox
            // 
            this.sexoComboBox.DisplayMember = "Descripcion";
            this.sexoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexoComboBox.FormattingEnabled = true;
            this.sexoComboBox.Location = new System.Drawing.Point(275, 197);
            this.sexoComboBox.Name = "sexoComboBox";
            this.sexoComboBox.Size = new System.Drawing.Size(229, 21);
            this.sexoComboBox.TabIndex = 17;
            this.sexoComboBox.ValueMember = "IdSexo";
            // 
            // segundoApellidoTextBox
            // 
            this.segundoApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDatos, "SegundoApellido", true));
            this.segundoApellidoTextBox.Location = new System.Drawing.Point(275, 152);
            this.segundoApellidoTextBox.Name = "segundoApellidoTextBox";
            this.segundoApellidoTextBox.Size = new System.Drawing.Size(229, 20);
            this.segundoApellidoTextBox.TabIndex = 6;
            // 
            // primerApellidoTextBox
            // 
            this.primerApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDatos, "PrimerApellido", true));
            this.primerApellidoTextBox.Location = new System.Drawing.Point(275, 107);
            this.primerApellidoTextBox.Name = "primerApellidoTextBox";
            this.primerApellidoTextBox.Size = new System.Drawing.Size(229, 20);
            this.primerApellidoTextBox.TabIndex = 4;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDatos, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(275, 62);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(229, 20);
            this.nombreTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(750, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "DATOS DEL ALUMNO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_nombre_archivo);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.btnScanner);
            this.tabPage2.Controls.Add(this.pb_documento);
            this.tabPage2.Controls.Add(this.pnl_datos);
            this.tabPage2.Controls.Add(this.cbo_tipo_documento);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(751, 452);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lsv_expedientes);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(751, 452);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.btnSiguiente);
            this.pnlDatos.Controls.Add(this.btnAnterior);
            this.pnlDatos.Controls.Add(this.btnCancelar);
            this.pnlDatos.Controls.Add(this.btnGuardar);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDatos.Location = new System.Drawing.Point(3, 481);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(759, 60);
            this.pnlDatos.TabIndex = 4;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.Location = new System.Drawing.Point(695, 10);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(48, 40);
            this.btnSiguiente.TabIndex = 13;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Location = new System.Drawing.Point(641, 10);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(48, 40);
            this.btnAnterior.TabIndex = 12;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(587, 10);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(48, 40);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(533, 10);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(48, 40);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // alumnoTableAdapter
            // 
            this.alumnoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnoEscuelaProcedenciaTableAdapter = null;
            this.tableAdapterManager.AlumnoGradoGrupoTableAdapter = null;
            this.tableAdapterManager.AlumnoTableAdapter = this.alumnoTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CalificacionTableAdapter = null;
            this.tableAdapterManager.CargoTableAdapter = null;
            this.tableAdapterManager.DocenteMateriaTableAdapter = null;
            this.tableAdapterManager.DocumentoExpedienteTableAdapter = null;
            this.tableAdapterManager.EscuelaProcedenciaTableAdapter = null;
            this.tableAdapterManager.ExpedienteAlumnoTableAdapter = null;
            this.tableAdapterManager.ExpedienteDocumentoAlumnoTableAdapter = null;
            this.tableAdapterManager.ExpedienteDocumentoTrabajadorTableAdapter = null;
            this.tableAdapterManager.ExpedienteTrabajadorTableAdapter = null;
            this.tableAdapterManager.GradoEstudioTableAdapter = null;
            this.tableAdapterManager.GradoGrupoTableAdapter = null;
            this.tableAdapterManager.GradoTableAdapter = null;
            this.tableAdapterManager.GrupoTableAdapter = null;
            this.tableAdapterManager.HorarioTableAdapter = null;
            this.tableAdapterManager.InstitutoTableAdapter = null;
            this.tableAdapterManager.MateriaGradoTableAdapter = null;
            this.tableAdapterManager.MateriaTableAdapter = null;
            this.tableAdapterManager.PeriodoEscolarTableAdapter = null;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.SexoTableAdapter = null;
            this.tableAdapterManager.TrabajadorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SYSBA.SYSBADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            this.tableAdapterManager.UsuarioTrabajadorTableAdapter = null;
            this.tableAdapterManager.vUsuarioTrabajadorTableAdapter = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 32);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(750, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "DOCUMENTOS DEL ALUMNO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_tipo_documento
            // 
            this.cbo_tipo_documento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_tipo_documento.DisplayMember = "nombre";
            this.cbo_tipo_documento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipo_documento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_tipo_documento.FormattingEnabled = true;
            this.cbo_tipo_documento.Location = new System.Drawing.Point(9, 66);
            this.cbo_tipo_documento.Name = "cbo_tipo_documento";
            this.cbo_tipo_documento.Size = new System.Drawing.Size(412, 25);
            this.cbo_tipo_documento.TabIndex = 14;
            this.cbo_tipo_documento.ValueMember = "id_documento";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(144, 17);
            this.label15.TabIndex = 13;
            this.label15.Text = "TIPO DE DOCUMENTO";
            // 
            // pnl_datos
            // 
            this.pnl_datos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_datos.Controls.Add(this.dgv_coleccion);
            this.pnl_datos.Controls.Add(this.bn_datos);
            this.pnl_datos.Location = new System.Drawing.Point(10, 157);
            this.pnl_datos.Name = "pnl_datos";
            this.pnl_datos.Size = new System.Drawing.Size(411, 262);
            this.pnl_datos.TabIndex = 20;
            // 
            // dgv_coleccion
            // 
            this.dgv_coleccion.AllowUserToAddRows = false;
            this.dgv_coleccion.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_coleccion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_coleccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_coleccion.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_coleccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_coleccion.Location = new System.Drawing.Point(0, 25);
            this.dgv_coleccion.Name = "dgv_coleccion";
            this.dgv_coleccion.ReadOnly = true;
            this.dgv_coleccion.RowTemplate.Height = 120;
            this.dgv_coleccion.Size = new System.Drawing.Size(411, 237);
            this.dgv_coleccion.TabIndex = 17;
            // 
            // bn_datos
            // 
            this.bn_datos.AddNewItem = null;
            this.bn_datos.CountItem = this.toolStripLabel1;
            this.bn_datos.DeleteItem = null;
            this.bn_datos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.btn_insertar,
            this.btn_eliminar});
            this.bn_datos.Location = new System.Drawing.Point(0, 0);
            this.bn_datos.MoveFirstItem = this.toolStripButton1;
            this.bn_datos.MoveLastItem = this.toolStripButton4;
            this.bn_datos.MoveNextItem = this.toolStripButton3;
            this.bn_datos.MovePreviousItem = this.toolStripButton2;
            this.bn_datos.Name = "bn_datos";
            this.bn_datos.PositionItem = this.toolStripTextBox1;
            this.bn_datos.Size = new System.Drawing.Size(411, 25);
            this.bn_datos.TabIndex = 18;
            this.bn_datos.Text = "bindingNavigator1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel1.Text = "de {0}";
            this.toolStripLabel1.ToolTipText = "Número total de elementos";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Mover primero";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Mover anterior";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Posición";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Posición actual";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Mover siguiente";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Mover último";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_insertar
            // 
            this.btn_insertar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_insertar.Image = ((System.Drawing.Image)(resources.GetObject("btn_insertar.Image")));
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.RightToLeftAutoMirrorImage = true;
            this.btn_insertar.Size = new System.Drawing.Size(23, 22);
            this.btn_insertar.Text = "Agregar nuevo";
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.RightToLeftAutoMirrorImage = true;
            this.btn_eliminar.Size = new System.Drawing.Size(23, 22);
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // pb_documento
            // 
            this.pb_documento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_documento.BackColor = System.Drawing.Color.White;
            this.pb_documento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_documento.Image = ((System.Drawing.Image)(resources.GetObject("pb_documento.Image")));
            this.pb_documento.Location = new System.Drawing.Point(475, 66);
            this.pb_documento.Name = "pb_documento";
            this.pb_documento.Size = new System.Drawing.Size(264, 307);
            this.pb_documento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_documento.TabIndex = 23;
            this.pb_documento.TabStop = false;
            // 
            // btnScanner
            // 
            this.btnScanner.Image = ((System.Drawing.Image)(resources.GetObject("btnScanner.Image")));
            this.btnScanner.Location = new System.Drawing.Point(583, 379);
            this.btnScanner.Name = "btnScanner";
            this.btnScanner.Size = new System.Drawing.Size(48, 40);
            this.btnScanner.TabIndex = 24;
            this.btnScanner.UseVisualStyleBackColor = true;
            this.btnScanner.Click += new System.EventHandler(this.btnScanner_Click);
            // 
            // txt_nombre_archivo
            // 
            this.txt_nombre_archivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nombre_archivo.Enabled = false;
            this.txt_nombre_archivo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_archivo.Location = new System.Drawing.Point(9, 125);
            this.txt_nombre_archivo.Name = "txt_nombre_archivo";
            this.txt_nombre_archivo.Size = new System.Drawing.Size(413, 23);
            this.txt_nombre_archivo.TabIndex = 26;
            this.txt_nombre_archivo.Text = "TIPO DE DOCUMENTO_SEMESTRE";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(7, 106);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(153, 17);
            this.label16.TabIndex = 25;
            this.label16.Text = "NOMBRE DEL ARCHIVO";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_borrar_documento);
            this.panel2.Controls.Add(this.btn_abrir_documento);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(751, 82);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(756, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "DOCUMENTOS ESCANEADOS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_borrar_documento
            // 
            this.btn_borrar_documento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_borrar_documento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrar_documento.Location = new System.Drawing.Point(459, 49);
            this.btn_borrar_documento.Name = "btn_borrar_documento";
            this.btn_borrar_documento.Size = new System.Drawing.Size(75, 23);
            this.btn_borrar_documento.TabIndex = 7;
            this.btn_borrar_documento.Text = "&Borrar";
            this.btn_borrar_documento.UseVisualStyleBackColor = true;
            this.btn_borrar_documento.Click += new System.EventHandler(this.btn_borrar_documento_Click);
            // 
            // btn_abrir_documento
            // 
            this.btn_abrir_documento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abrir_documento.Location = new System.Drawing.Point(217, 49);
            this.btn_abrir_documento.Name = "btn_abrir_documento";
            this.btn_abrir_documento.Size = new System.Drawing.Size(75, 23);
            this.btn_abrir_documento.TabIndex = 6;
            this.btn_abrir_documento.Text = "&Abrir";
            this.btn_abrir_documento.UseVisualStyleBackColor = true;
            this.btn_abrir_documento.Click += new System.EventHandler(this.btn_abrir_documento_Click);
            // 
            // lsv_expedientes
            // 
            this.lsv_expedientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsv_expedientes.HideSelection = false;
            this.lsv_expedientes.Location = new System.Drawing.Point(0, 82);
            this.lsv_expedientes.MultiSelect = false;
            this.lsv_expedientes.Name = "lsv_expedientes";
            this.lsv_expedientes.Size = new System.Drawing.Size(751, 370);
            this.lsv_expedientes.TabIndex = 2;
            this.lsv_expedientes.UseCompatibleStateImageBehavior = false;
            this.lsv_expedientes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lsv_expedientes_KeyPress);
            this.lsv_expedientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsv_expedientes_MouseDoubleClick);
            // 
            // fAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 570);
            this.Controls.Add(this.tcDatos);
            this.MinimumSize = new System.Drawing.Size(789, 542);
            this.Name = "fAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.fAlumno_Load);
            this.tcDatos.ResumeLayout(false);
            this.tpDatos.ResumeLayout(false);
            this.pnlRegistros.ResumeLayout(false);
            this.pnlRegistros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSBADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnDatos)).EndInit();
            this.bnDatos.ResumeLayout(false);
            this.bnDatos.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.tpRegistros.ResumeLayout(false);
            this.tcDatosAlumno.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.pnlDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnl_datos.ResumeLayout(false);
            this.pnl_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_coleccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bn_datos)).EndInit();
            this.bn_datos.ResumeLayout(false);
            this.bn_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_documento)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcDatos;
        private System.Windows.Forms.TabPage tpDatos;
        private System.Windows.Forms.TabPage tpRegistros;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInsertar;
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
        private System.Windows.Forms.BindingSource bsDatos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tcDatosAlumno;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CURP;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AlumnoSecundaria;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AlumnoBachillerato;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private SYSBADataSet sYSBADataSet;
        private SYSBADataSetTableAdapters.AlumnoTableAdapter alumnoTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox segundoApellidoTextBox;
        private System.Windows.Forms.TextBox primerApellidoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private SYSBADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker fechaIngresoDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.TextBox cURPTextBox;
        private System.Windows.Forms.ComboBox sexoComboBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnScanner;
        private System.Windows.Forms.PictureBox pb_documento;
        private System.Windows.Forms.Panel pnl_datos;
        private System.Windows.Forms.DataGridView dgv_coleccion;
        private System.Windows.Forms.BindingNavigator bn_datos;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_insertar;
        private System.Windows.Forms.ToolStripButton btn_eliminar;
        private System.Windows.Forms.ComboBox cbo_tipo_documento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_nombre_archivo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListView lsv_expedientes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_borrar_documento;
        private System.Windows.Forms.Button btn_abrir_documento;
        private System.Windows.Forms.Label label4;
    }
}