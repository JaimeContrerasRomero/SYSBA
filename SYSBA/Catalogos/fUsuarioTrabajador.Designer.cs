namespace SYSBA.Catalogos
{
    partial class fUsuarioTrabajador
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label primerApellidoLabel;
            System.Windows.Forms.Label segundoApellidoLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label fechaNacimientoLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label tituloAcademicoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label passwordLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fUsuarioTrabajador));
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.usuarioSistemaCheckBox = new System.Windows.Forms.CheckBox();
            this.bsDatos = new System.Windows.Forms.BindingSource(this.components);
            this.sYSBADataSet = new SYSBA.SYSBADataSet();
            this.bachilleratoCheckBox = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.secundariaCheckBox = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tituloAcademicoTextBox = new System.Windows.Forms.TextBox();
            this.cargoComboBox = new System.Windows.Forms.ComboBox();
            this.cargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradoEstudioComboBox = new System.Windows.Forms.ComboBox();
            this.gradoEstudioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sexoComboBox = new System.Windows.Forms.ComboBox();
            this.sexoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.segundoApellidoTextBox = new System.Windows.Forms.TextBox();
            this.primerApellidoTextBox = new System.Windows.Forms.TextBox();
            this.rolComboBox = new System.Windows.Forms.ComboBox();
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.pnlRegistros = new System.Windows.Forms.Panel();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTrabajador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdGradoEstudio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradoEstudio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TituloAcademico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Secundaria = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Bachillerato = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UsuarioSistema = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UsuarioActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.vUsuarioTrabajadorTableAdapter = new SYSBA.SYSBADataSetTableAdapters.vUsuarioTrabajadorTableAdapter();
            this.rolTableAdapter = new SYSBA.SYSBADataSetTableAdapters.RolTableAdapter();
            this.tableAdapterManager = new SYSBA.SYSBADataSetTableAdapters.TableAdapterManager();
            this.cargoTableAdapter = new SYSBA.SYSBADataSetTableAdapters.CargoTableAdapter();
            this.gradoEstudioTableAdapter = new SYSBA.SYSBADataSetTableAdapters.GradoEstudioTableAdapter();
            this.sexoTableAdapter = new SYSBA.SYSBADataSetTableAdapters.SexoTableAdapter();
            nombreLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            primerApellidoLabel = new System.Windows.Forms.Label();
            segundoApellidoLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            tituloAcademicoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            this.pnlBotones.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSBADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradoEstudioBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
            this.pnlRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnDatos)).BeginInit();
            this.bnDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(9, 64);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 11;
            nombreLabel.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(9, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(26, 13);
            label1.TabIndex = 13;
            label1.Text = "Rol:";
            // 
            // primerApellidoLabel
            // 
            primerApellidoLabel.AutoSize = true;
            primerApellidoLabel.Location = new System.Drawing.Point(257, 64);
            primerApellidoLabel.Name = "primerApellidoLabel";
            primerApellidoLabel.Size = new System.Drawing.Size(79, 13);
            primerApellidoLabel.TabIndex = 13;
            primerApellidoLabel.Text = "Primer Apellido:";
            // 
            // segundoApellidoLabel
            // 
            segundoApellidoLabel.AutoSize = true;
            segundoApellidoLabel.Location = new System.Drawing.Point(9, 112);
            segundoApellidoLabel.Name = "segundoApellidoLabel";
            segundoApellidoLabel.Size = new System.Drawing.Size(93, 13);
            segundoApellidoLabel.TabIndex = 14;
            segundoApellidoLabel.Text = "Segundo Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(257, 16);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(34, 13);
            label2.TabIndex = 16;
            label2.Text = "Sexo:";
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Location = new System.Drawing.Point(258, 110);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(96, 13);
            fechaNacimientoLabel.TabIndex = 16;
            fechaNacimientoLabel.Text = "Fecha Nacimiento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 16);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(96, 13);
            label3.TabIndex = 17;
            label3.Text = "Grado de estudios:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 64);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(38, 13);
            label4.TabIndex = 18;
            label4.Text = "Cargo:";
            // 
            // tituloAcademicoLabel
            // 
            tituloAcademicoLabel.AutoSize = true;
            tituloAcademicoLabel.Location = new System.Drawing.Point(6, 112);
            tituloAcademicoLabel.Name = "tituloAcademicoLabel";
            tituloAcademicoLabel.Size = new System.Drawing.Size(92, 13);
            tituloAcademicoLabel.TabIndex = 18;
            tituloAcademicoLabel.Text = "Titulo Academico:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(9, 161);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 17;
            emailLabel.Text = "Email:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(254, 161);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 18;
            passwordLabel.Text = "Password:";
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnEliminar);
            this.pnlBotones.Controls.Add(this.btnEditar);
            this.pnlBotones.Controls.Add(this.btnInsertar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotones.Location = new System.Drawing.Point(0, 0);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(926, 68);
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
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.groupBox2);
            this.pnlDatos.Controls.Add(this.groupBox1);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDatos.Location = new System.Drawing.Point(0, 340);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(926, 215);
            this.pnlDatos.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.usuarioSistemaCheckBox);
            this.groupBox2.Controls.Add(this.bachilleratoCheckBox);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.secundariaCheckBox);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(tituloAcademicoLabel);
            this.groupBox2.Controls.Add(this.tituloAcademicoTextBox);
            this.groupBox2.Controls.Add(this.cargoComboBox);
            this.groupBox2.Controls.Add(label4);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Controls.Add(this.gradoEstudioComboBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(518, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 215);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Académicos:";
            // 
            // usuarioSistemaCheckBox
            // 
            this.usuarioSistemaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsDatos, "UsuarioSistema", true));
            this.usuarioSistemaCheckBox.Location = new System.Drawing.Point(268, 129);
            this.usuarioSistemaCheckBox.Name = "usuarioSistemaCheckBox";
            this.usuarioSistemaCheckBox.Size = new System.Drawing.Size(131, 24);
            this.usuarioSistemaCheckBox.TabIndex = 13;
            this.usuarioSistemaCheckBox.Text = "Usuario del sistema";
            this.usuarioSistemaCheckBox.UseVisualStyleBackColor = true;
            // 
            // bsDatos
            // 
            this.bsDatos.DataMember = "vUsuarioTrabajador";
            this.bsDatos.DataSource = this.sYSBADataSet;
            // 
            // sYSBADataSet
            // 
            this.sYSBADataSet.DataSetName = "SYSBADataSet";
            this.sYSBADataSet.EnforceConstraints = false;
            this.sYSBADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bachilleratoCheckBox
            // 
            this.bachilleratoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsDatos, "Bachillerato", true));
            this.bachilleratoCheckBox.Location = new System.Drawing.Point(268, 76);
            this.bachilleratoCheckBox.Name = "bachilleratoCheckBox";
            this.bachilleratoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.bachilleratoCheckBox.TabIndex = 12;
            this.bachilleratoCheckBox.Text = "Bachillerato";
            this.bachilleratoCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(334, 163);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(48, 40);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // secundariaCheckBox
            // 
            this.secundariaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsDatos, "Secundaria", true));
            this.secundariaCheckBox.Location = new System.Drawing.Point(268, 30);
            this.secundariaCheckBox.Name = "secundariaCheckBox";
            this.secundariaCheckBox.Size = new System.Drawing.Size(104, 24);
            this.secundariaCheckBox.TabIndex = 11;
            this.secundariaCheckBox.Text = "Secundaria";
            this.secundariaCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(280, 163);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(48, 40);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tituloAcademicoTextBox
            // 
            this.tituloAcademicoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tituloAcademicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDatos, "TituloAcademico", true));
            this.tituloAcademicoTextBox.Location = new System.Drawing.Point(6, 131);
            this.tituloAcademicoTextBox.Multiline = true;
            this.tituloAcademicoTextBox.Name = "tituloAcademicoTextBox";
            this.tituloAcademicoTextBox.Size = new System.Drawing.Size(229, 43);
            this.tituloAcademicoTextBox.TabIndex = 10;
            // 
            // cargoComboBox
            // 
            this.cargoComboBox.DataSource = this.cargoBindingSource;
            this.cargoComboBox.DisplayMember = "Nombre";
            this.cargoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cargoComboBox.FormattingEnabled = true;
            this.cargoComboBox.Location = new System.Drawing.Point(6, 80);
            this.cargoComboBox.Name = "cargoComboBox";
            this.cargoComboBox.Size = new System.Drawing.Size(229, 21);
            this.cargoComboBox.TabIndex = 9;
            this.cargoComboBox.ValueMember = "IdCargo";
            // 
            // cargoBindingSource
            // 
            this.cargoBindingSource.DataMember = "Cargo";
            this.cargoBindingSource.DataSource = this.sYSBADataSet;
            // 
            // gradoEstudioComboBox
            // 
            this.gradoEstudioComboBox.DataSource = this.gradoEstudioBindingSource;
            this.gradoEstudioComboBox.DisplayMember = "Nombre";
            this.gradoEstudioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gradoEstudioComboBox.FormattingEnabled = true;
            this.gradoEstudioComboBox.Location = new System.Drawing.Point(6, 33);
            this.gradoEstudioComboBox.Name = "gradoEstudioComboBox";
            this.gradoEstudioComboBox.Size = new System.Drawing.Size(229, 21);
            this.gradoEstudioComboBox.TabIndex = 8;
            this.gradoEstudioComboBox.ValueMember = "IdGradoEstudio";
            // 
            // gradoEstudioBindingSource
            // 
            this.gradoEstudioBindingSource.DataMember = "GradoEstudio";
            this.gradoEstudioBindingSource.DataSource = this.sYSBADataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(passwordLabel);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(fechaNacimientoLabel);
            this.groupBox1.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.sexoComboBox);
            this.groupBox1.Controls.Add(segundoApellidoLabel);
            this.groupBox1.Controls.Add(this.segundoApellidoTextBox);
            this.groupBox1.Controls.Add(primerApellidoLabel);
            this.groupBox1.Controls.Add(this.primerApellidoTextBox);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.rolComboBox);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 215);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDatos, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(257, 177);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(229, 20);
            this.passwordTextBox.TabIndex = 7;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDatos, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(9, 177);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(229, 20);
            this.emailTextBox.TabIndex = 6;
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsDatos, "FechaNacimiento", true));
            this.fechaNacimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(257, 128);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaNacimientoDateTimePicker.TabIndex = 5;
            // 
            // sexoComboBox
            // 
            this.sexoComboBox.DataSource = this.sexoBindingSource;
            this.sexoComboBox.DisplayMember = "Descripcion";
            this.sexoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexoComboBox.FormattingEnabled = true;
            this.sexoComboBox.Location = new System.Drawing.Point(257, 33);
            this.sexoComboBox.Name = "sexoComboBox";
            this.sexoComboBox.Size = new System.Drawing.Size(229, 21);
            this.sexoComboBox.TabIndex = 1;
            this.sexoComboBox.ValueMember = "IdSexo";
            // 
            // sexoBindingSource
            // 
            this.sexoBindingSource.DataMember = "Sexo";
            this.sexoBindingSource.DataSource = this.sYSBADataSet;
            // 
            // segundoApellidoTextBox
            // 
            this.segundoApellidoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.segundoApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDatos, "SegundoApellido", true));
            this.segundoApellidoTextBox.Location = new System.Drawing.Point(9, 128);
            this.segundoApellidoTextBox.Name = "segundoApellidoTextBox";
            this.segundoApellidoTextBox.Size = new System.Drawing.Size(229, 20);
            this.segundoApellidoTextBox.TabIndex = 4;
            // 
            // primerApellidoTextBox
            // 
            this.primerApellidoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.primerApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDatos, "PrimerApellido", true));
            this.primerApellidoTextBox.Location = new System.Drawing.Point(257, 80);
            this.primerApellidoTextBox.Name = "primerApellidoTextBox";
            this.primerApellidoTextBox.Size = new System.Drawing.Size(229, 20);
            this.primerApellidoTextBox.TabIndex = 3;
            // 
            // rolComboBox
            // 
            this.rolComboBox.DataSource = this.rolBindingSource;
            this.rolComboBox.DisplayMember = "Nombre";
            this.rolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rolComboBox.FormattingEnabled = true;
            this.rolComboBox.Location = new System.Drawing.Point(9, 33);
            this.rolComboBox.Name = "rolComboBox";
            this.rolComboBox.Size = new System.Drawing.Size(229, 21);
            this.rolComboBox.TabIndex = 0;
            this.rolComboBox.ValueMember = "IdRol";
            // 
            // rolBindingSource
            // 
            this.rolBindingSource.DataMember = "Rol";
            this.rolBindingSource.DataSource = this.sYSBADataSet;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDatos, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(9, 80);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(229, 20);
            this.nombreTextBox.TabIndex = 2;
            // 
            // pnlRegistros
            // 
            this.pnlRegistros.Controls.Add(this.dgvDatos);
            this.pnlRegistros.Controls.Add(this.bnDatos);
            this.pnlRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegistros.Location = new System.Drawing.Point(0, 68);
            this.pnlRegistros.Name = "pnlRegistros";
            this.pnlRegistros.Size = new System.Drawing.Size(926, 272);
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
            this.IdUsuario,
            this.IdRol,
            this.Rol,
            this.Sexo,
            this.Nombre,
            this.PrimerApellido,
            this.SegundoApellido,
            this.IdSexo,
            this.FechaNacimiento,
            this.Email,
            this.Password,
            this.IdTrabajador,
            this.IdGradoEstudio,
            this.GradoEstudio,
            this.IdCargo,
            this.Cargo,
            this.TituloAcademico,
            this.Secundaria,
            this.Bachillerato,
            this.UsuarioSistema,
            this.UsuarioActivo,
            this.Activo});
            this.dgvDatos.DataSource = this.bsDatos;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 25);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(926, 247);
            this.dgvDatos.TabIndex = 7;
            this.dgvDatos.SelectionChanged += new System.EventHandler(this.dgvDatos_SelectionChanged);
            // 
            // IdUsuario
            // 
            this.IdUsuario.DataPropertyName = "IdUsuario";
            this.IdUsuario.HeaderText = "IdUsuario";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            this.IdUsuario.Visible = false;
            this.IdUsuario.Width = 77;
            // 
            // IdRol
            // 
            this.IdRol.DataPropertyName = "IdRol";
            this.IdRol.HeaderText = "IdRol";
            this.IdRol.Name = "IdRol";
            this.IdRol.ReadOnly = true;
            this.IdRol.Visible = false;
            this.IdRol.Width = 57;
            // 
            // Rol
            // 
            this.Rol.DataPropertyName = "Rol";
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            this.Rol.Width = 48;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 56;
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
            this.PrimerApellido.HeaderText = "Primer Apellido";
            this.PrimerApellido.Name = "PrimerApellido";
            this.PrimerApellido.ReadOnly = true;
            this.PrimerApellido.Width = 93;
            // 
            // SegundoApellido
            // 
            this.SegundoApellido.DataPropertyName = "SegundoApellido";
            this.SegundoApellido.HeaderText = "Segundo Apellido";
            this.SegundoApellido.Name = "SegundoApellido";
            this.SegundoApellido.ReadOnly = true;
            this.SegundoApellido.Width = 105;
            // 
            // IdSexo
            // 
            this.IdSexo.DataPropertyName = "IdSexo";
            this.IdSexo.HeaderText = "IdSexo";
            this.IdSexo.Name = "IdSexo";
            this.IdSexo.ReadOnly = true;
            this.IdSexo.Visible = false;
            this.IdSexo.Width = 65;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.FechaNacimiento.HeaderText = "Fecha de nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            this.FechaNacimiento.Width = 120;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 57;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Visible = false;
            this.Password.Width = 78;
            // 
            // IdTrabajador
            // 
            this.IdTrabajador.DataPropertyName = "IdTrabajador";
            this.IdTrabajador.HeaderText = "IdTrabajador";
            this.IdTrabajador.Name = "IdTrabajador";
            this.IdTrabajador.ReadOnly = true;
            this.IdTrabajador.Visible = false;
            this.IdTrabajador.Width = 92;
            // 
            // IdGradoEstudio
            // 
            this.IdGradoEstudio.DataPropertyName = "IdGradoEstudio";
            this.IdGradoEstudio.HeaderText = "IdGradoEstudio";
            this.IdGradoEstudio.Name = "IdGradoEstudio";
            this.IdGradoEstudio.ReadOnly = true;
            this.IdGradoEstudio.Visible = false;
            this.IdGradoEstudio.Width = 105;
            // 
            // GradoEstudio
            // 
            this.GradoEstudio.DataPropertyName = "GradoEstudio";
            this.GradoEstudio.HeaderText = "Grado de estudio";
            this.GradoEstudio.Name = "GradoEstudio";
            this.GradoEstudio.ReadOnly = true;
            this.GradoEstudio.Width = 104;
            // 
            // IdCargo
            // 
            this.IdCargo.DataPropertyName = "IdCargo";
            this.IdCargo.HeaderText = "IdCargo";
            this.IdCargo.Name = "IdCargo";
            this.IdCargo.ReadOnly = true;
            this.IdCargo.Visible = false;
            this.IdCargo.Width = 69;
            // 
            // Cargo
            // 
            this.Cargo.DataPropertyName = "Cargo";
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            this.Cargo.Width = 60;
            // 
            // TituloAcademico
            // 
            this.TituloAcademico.DataPropertyName = "TituloAcademico";
            this.TituloAcademico.HeaderText = "Titulo académico";
            this.TituloAcademico.Name = "TituloAcademico";
            this.TituloAcademico.ReadOnly = true;
            this.TituloAcademico.Width = 104;
            // 
            // Secundaria
            // 
            this.Secundaria.DataPropertyName = "Secundaria";
            this.Secundaria.HeaderText = "Secundaria";
            this.Secundaria.Name = "Secundaria";
            this.Secundaria.ReadOnly = true;
            this.Secundaria.Width = 67;
            // 
            // Bachillerato
            // 
            this.Bachillerato.DataPropertyName = "Bachillerato";
            this.Bachillerato.HeaderText = "Bachillerato";
            this.Bachillerato.Name = "Bachillerato";
            this.Bachillerato.ReadOnly = true;
            this.Bachillerato.Width = 68;
            // 
            // UsuarioSistema
            // 
            this.UsuarioSistema.DataPropertyName = "UsuarioSistema";
            this.UsuarioSistema.HeaderText = "Es usuario del sistema";
            this.UsuarioSistema.Name = "UsuarioSistema";
            this.UsuarioSistema.ReadOnly = true;
            this.UsuarioSistema.Width = 74;
            // 
            // UsuarioActivo
            // 
            this.UsuarioActivo.DataPropertyName = "UsuarioActivo";
            this.UsuarioActivo.HeaderText = "UsuarioActivo";
            this.UsuarioActivo.Name = "UsuarioActivo";
            this.UsuarioActivo.ReadOnly = true;
            this.UsuarioActivo.Visible = false;
            this.UsuarioActivo.Width = 79;
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "Activo";
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Visible = false;
            this.Activo.Width = 43;
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
            this.bnDatos.Size = new System.Drawing.Size(926, 25);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // vUsuarioTrabajadorTableAdapter
            // 
            this.vUsuarioTrabajadorTableAdapter.ClearBeforeFill = true;
            // 
            // rolTableAdapter
            // 
            this.rolTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnoEscuelaProcedenciaTableAdapter = null;
            this.tableAdapterManager.AlumnoGradoGrupoTableAdapter = null;
            this.tableAdapterManager.AlumnoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CalificacionTableAdapter = null;
            this.tableAdapterManager.CargoTableAdapter = this.cargoTableAdapter;
            this.tableAdapterManager.DocenteMateriaTableAdapter = null;
            this.tableAdapterManager.DocumentoExpedienteTableAdapter = null;
            this.tableAdapterManager.EscuelaProcedenciaTableAdapter = null;
            this.tableAdapterManager.ExpedienteAlumnoTableAdapter = null;
            this.tableAdapterManager.ExpedienteDocumentoAlumnoTableAdapter = null;
            this.tableAdapterManager.ExpedienteDocumentoTrabajadorTableAdapter = null;
            this.tableAdapterManager.ExpedienteTrabajadorTableAdapter = null;
            this.tableAdapterManager.GradoEstudioTableAdapter = this.gradoEstudioTableAdapter;
            this.tableAdapterManager.GradoGrupoTableAdapter = null;
            this.tableAdapterManager.GradoTableAdapter = null;
            this.tableAdapterManager.GrupoTableAdapter = null;
            this.tableAdapterManager.HorarioTableAdapter = null;
            this.tableAdapterManager.InstitutoTableAdapter = null;
            this.tableAdapterManager.MateriaGradoTableAdapter = null;
            this.tableAdapterManager.MateriaTableAdapter = null;
            this.tableAdapterManager.PeriodoEscolarTableAdapter = null;
            this.tableAdapterManager.RolTableAdapter = this.rolTableAdapter;
            this.tableAdapterManager.SexoTableAdapter = this.sexoTableAdapter;
            this.tableAdapterManager.TrabajadorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SYSBA.SYSBADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            this.tableAdapterManager.UsuarioTrabajadorTableAdapter = null;
            this.tableAdapterManager.vUsuarioTrabajadorTableAdapter = this.vUsuarioTrabajadorTableAdapter;
            // 
            // cargoTableAdapter
            // 
            this.cargoTableAdapter.ClearBeforeFill = true;
            // 
            // gradoEstudioTableAdapter
            // 
            this.gradoEstudioTableAdapter.ClearBeforeFill = true;
            // 
            // sexoTableAdapter
            // 
            this.sexoTableAdapter.ClearBeforeFill = true;
            // 
            // fUsuarioTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(926, 555);
            this.Controls.Add(this.pnlRegistros);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlBotones);
            this.MinimumSize = new System.Drawing.Size(942, 564);
            this.Name = "fUsuarioTrabajador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario (Trabajador)";
            this.Load += new System.EventHandler(this.fUsuarioTrabajador_Load);
            this.pnlBotones.ResumeLayout(false);
            this.pnlDatos.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSBADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradoEstudioBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).EndInit();
            this.pnlRegistros.ResumeLayout(false);
            this.pnlRegistros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnDatos)).EndInit();
            this.bnDatos.ResumeLayout(false);
            this.bnDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource bsDatos;
        private SYSBADataSet sYSBADataSet;
        private SYSBADataSetTableAdapters.vUsuarioTrabajadorTableAdapter vUsuarioTrabajadorTableAdapter;
        private System.Windows.Forms.BindingSource rolBindingSource;
        private SYSBADataSetTableAdapters.RolTableAdapter rolTableAdapter;
        private SYSBADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox segundoApellidoTextBox;
        private System.Windows.Forms.TextBox primerApellidoTextBox;
        private System.Windows.Forms.ComboBox rolComboBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private SYSBADataSetTableAdapters.SexoTableAdapter sexoTableAdapter;
        private System.Windows.Forms.BindingSource sexoBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.ComboBox sexoComboBox;
        private SYSBADataSetTableAdapters.GradoEstudioTableAdapter gradoEstudioTableAdapter;
        private System.Windows.Forms.BindingSource gradoEstudioBindingSource;
        private System.Windows.Forms.ComboBox gradoEstudioComboBox;
        private SYSBADataSetTableAdapters.CargoTableAdapter cargoTableAdapter;
        private System.Windows.Forms.BindingSource cargoBindingSource;
        private System.Windows.Forms.CheckBox usuarioSistemaCheckBox;
        private System.Windows.Forms.CheckBox bachilleratoCheckBox;
        private System.Windows.Forms.CheckBox secundariaCheckBox;
        private System.Windows.Forms.TextBox tituloAcademicoTextBox;
        private System.Windows.Forms.ComboBox cargoComboBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTrabajador;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGradoEstudio;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradoEstudio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TituloAcademico;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Secundaria;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Bachillerato;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UsuarioSistema;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UsuarioActivo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
    }
}