namespace SYSBA
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mCatalogos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCargo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDocumentoExpediente = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEscuelaProcedencia = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGrado = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGradoEstudio = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRol = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mSecundaria = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExpedienteTrabajador = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGruposSec = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAlumnos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExpedienteAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.mBachillerato = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBaseDatos = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.btnCerrarSesion = new System.Windows.Forms.ToolStripSplitButton();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCatalogos,
            this.mSecundaria,
            this.mBachillerato,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(847, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mCatalogos
            // 
            this.mCatalogos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCargo,
            this.btnDocumentoExpediente,
            this.btnEscuelaProcedencia,
            this.btnGrado,
            this.btnGradoEstudio,
            this.btnRol,
            this.btnUsuarios,
            this.toolStripSeparator3,
            this.btnSalir});
            this.mCatalogos.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.mCatalogos.Name = "mCatalogos";
            this.mCatalogos.Size = new System.Drawing.Size(72, 20);
            this.mCatalogos.Text = "&Catálogos";
            // 
            // btnCargo
            // 
            this.btnCargo.Image = ((System.Drawing.Image)(resources.GetObject("btnCargo.Image")));
            this.btnCargo.Name = "btnCargo";
            this.btnCargo.Size = new System.Drawing.Size(234, 22);
            this.btnCargo.Text = "&Cargo";
            this.btnCargo.Click += new System.EventHandler(this.btnCargo_Click);
            // 
            // btnDocumentoExpediente
            // 
            this.btnDocumentoExpediente.Image = ((System.Drawing.Image)(resources.GetObject("btnDocumentoExpediente.Image")));
            this.btnDocumentoExpediente.Name = "btnDocumentoExpediente";
            this.btnDocumentoExpediente.Size = new System.Drawing.Size(234, 22);
            this.btnDocumentoExpediente.Text = "&Documentos para Expedientes";
            this.btnDocumentoExpediente.Click += new System.EventHandler(this.btnDocumentoExpediente_Click);
            // 
            // btnEscuelaProcedencia
            // 
            this.btnEscuelaProcedencia.Image = ((System.Drawing.Image)(resources.GetObject("btnEscuelaProcedencia.Image")));
            this.btnEscuelaProcedencia.Name = "btnEscuelaProcedencia";
            this.btnEscuelaProcedencia.Size = new System.Drawing.Size(234, 22);
            this.btnEscuelaProcedencia.Text = "&Escuelas de Procedencia";
            this.btnEscuelaProcedencia.Click += new System.EventHandler(this.btnEscuelaProcedencia_Click);
            // 
            // btnGrado
            // 
            this.btnGrado.Image = ((System.Drawing.Image)(resources.GetObject("btnGrado.Image")));
            this.btnGrado.Name = "btnGrado";
            this.btnGrado.Size = new System.Drawing.Size(234, 22);
            this.btnGrado.Text = "&Grados/Semetres Escolares";
            this.btnGrado.Click += new System.EventHandler(this.btnGrado_Click);
            // 
            // btnGradoEstudio
            // 
            this.btnGradoEstudio.Image = ((System.Drawing.Image)(resources.GetObject("btnGradoEstudio.Image")));
            this.btnGradoEstudio.Name = "btnGradoEstudio";
            this.btnGradoEstudio.Size = new System.Drawing.Size(234, 22);
            this.btnGradoEstudio.Text = "&Grado de Estudios";
            this.btnGradoEstudio.Click += new System.EventHandler(this.btnGradoEstudio_Click);
            // 
            // btnRol
            // 
            this.btnRol.Image = ((System.Drawing.Image)(resources.GetObject("btnRol.Image")));
            this.btnRol.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnRol.Name = "btnRol";
            this.btnRol.Size = new System.Drawing.Size(234, 22);
            this.btnRol.Text = "&Rol";
            this.btnRol.Click += new System.EventHandler(this.btnRol_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(234, 22);
            this.btnUsuarios.Text = "&Usuario (Trabajador)";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(231, 6);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(234, 22);
            this.btnSalir.Text = "&Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // mSecundaria
            // 
            this.mSecundaria.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExpedienteTrabajador,
            this.btnGruposSec,
            this.btnAlumnos,
            this.btnExpedienteAlumno});
            this.mSecundaria.Name = "mSecundaria";
            this.mSecundaria.Size = new System.Drawing.Size(77, 20);
            this.mSecundaria.Text = "&Secundaria";
            // 
            // btnExpedienteTrabajador
            // 
            this.btnExpedienteTrabajador.Image = ((System.Drawing.Image)(resources.GetObject("btnExpedienteTrabajador.Image")));
            this.btnExpedienteTrabajador.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnExpedienteTrabajador.Name = "btnExpedienteTrabajador";
            this.btnExpedienteTrabajador.Size = new System.Drawing.Size(190, 22);
            this.btnExpedienteTrabajador.Text = "&Expediente Trabajador";
            this.btnExpedienteTrabajador.Click += new System.EventHandler(this.btnExpedienteTrabajador_Click);
            // 
            // btnGruposSec
            // 
            this.btnGruposSec.Image = ((System.Drawing.Image)(resources.GetObject("btnGruposSec.Image")));
            this.btnGruposSec.Name = "btnGruposSec";
            this.btnGruposSec.Size = new System.Drawing.Size(190, 22);
            this.btnGruposSec.Text = "Grupos";
            this.btnGruposSec.Click += new System.EventHandler(this.btnGruposSec_Click);
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Image = ((System.Drawing.Image)(resources.GetObject("btnAlumnos.Image")));
            this.btnAlumnos.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(190, 22);
            this.btnAlumnos.Text = "&Alumnos";
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // btnExpedienteAlumno
            // 
            this.btnExpedienteAlumno.Image = ((System.Drawing.Image)(resources.GetObject("btnExpedienteAlumno.Image")));
            this.btnExpedienteAlumno.Name = "btnExpedienteAlumno";
            this.btnExpedienteAlumno.Size = new System.Drawing.Size(190, 22);
            this.btnExpedienteAlumno.Text = "&Expediente Alumnos";
            // 
            // mBachillerato
            // 
            this.mBachillerato.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBaseDatos});
            this.mBachillerato.Name = "mBachillerato";
            this.mBachillerato.Size = new System.Drawing.Size(81, 20);
            this.mBachillerato.Text = "&Bachillerato";
            // 
            // btnBaseDatos
            // 
            this.btnBaseDatos.Image = ((System.Drawing.Image)(resources.GetObject("btnBaseDatos.Image")));
            this.btnBaseDatos.Name = "btnBaseDatos";
            this.btnBaseDatos.Size = new System.Drawing.Size(247, 22);
            this.btnBaseDatos.Text = "&Administracion de Base de Datos";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRVentas,
            this.btnRClientes,
            this.toolStripSeparator8,
            this.btnRInventario,
            this.btnRCompras});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(65, 20);
            this.helpMenu.Text = "&Reportes";
            // 
            // btnRVentas
            // 
            this.btnRVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnRVentas.Image")));
            this.btnRVentas.Name = "btnRVentas";
            this.btnRVentas.Size = new System.Drawing.Size(178, 22);
            this.btnRVentas.Text = "&Reporte de Ingresos";
            // 
            // btnRClientes
            // 
            this.btnRClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnRClientes.Image")));
            this.btnRClientes.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnRClientes.Name = "btnRClientes";
            this.btnRClientes.Size = new System.Drawing.Size(178, 22);
            this.btnRClientes.Text = "&Reporte de Abonos";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(175, 6);
            // 
            // btnRInventario
            // 
            this.btnRInventario.Image = ((System.Drawing.Image)(resources.GetObject("btnRInventario.Image")));
            this.btnRInventario.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnRInventario.Name = "btnRInventario";
            this.btnRInventario.Size = new System.Drawing.Size(178, 22);
            this.btnRInventario.Text = "&Invetario";
            // 
            // btnRCompras
            // 
            this.btnRCompras.Image = ((System.Drawing.Image)(resources.GetObject("btnRCompras.Image")));
            this.btnRCompras.Name = "btnRCompras";
            this.btnRCompras.Size = new System.Drawing.Size(178, 22);
            this.btnRCompras.Text = "&Compras";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCerrarSesion,
            this.lblUsuario});
            this.statusStrip.Location = new System.Drawing.Point(0, 409);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip.Size = new System.Drawing.Size(847, 54);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "StatusStrip";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCerrarSesion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(64, 52);
            this.btnCerrarSesion.Text = "toolStripSplitButton1";
            this.btnCerrarSesion.ToolTipText = "Cerrar Sesión";
            this.btnCerrarSesion.ButtonClick += new System.EventHandler(this.btnCerrarSesion_ButtonClick);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(69, 49);
            this.lblUsuario.Text = "Usuario";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SYSBA.Properties.Resources.LogoAbierta;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(847, 463);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SYSBA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mCatalogos;
        private System.Windows.Forms.ToolStripMenuItem btnUsuarios;
        private System.Windows.Forms.ToolStripMenuItem btnRol;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem btnSalir;
        private System.Windows.Forms.ToolStripMenuItem mSecundaria;
        private System.Windows.Forms.ToolStripMenuItem btnExpedienteTrabajador;
        private System.Windows.Forms.ToolStripMenuItem btnAlumnos;
        private System.Windows.Forms.ToolStripMenuItem btnExpedienteAlumno;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem btnRVentas;
        private System.Windows.Forms.ToolStripMenuItem btnRClientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem btnRInventario;
        private System.Windows.Forms.ToolStripMenuItem btnRCompras;
        private System.Windows.Forms.ToolStripMenuItem mBachillerato;
        private System.Windows.Forms.ToolStripMenuItem btnBaseDatos;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSplitButton btnCerrarSesion;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripMenuItem btnCargo;
        private System.Windows.Forms.ToolStripMenuItem btnGradoEstudio;
        private System.Windows.Forms.ToolStripMenuItem btnGrado;
        private System.Windows.Forms.ToolStripMenuItem btnEscuelaProcedencia;
        private System.Windows.Forms.ToolStripMenuItem btnDocumentoExpediente;
        private System.Windows.Forms.ToolStripMenuItem btnGruposSec;
    }
}