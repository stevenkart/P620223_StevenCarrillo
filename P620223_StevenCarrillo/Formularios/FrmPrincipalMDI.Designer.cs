namespace P620223_StevenCarrillo.Formularios
{
    partial class FrmPrincipalMDI
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
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuariosGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuClientesGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuImpuestosGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInventariosGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCategoriasGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuProveedoresGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFacturacion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVentasRangoFechas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVentasCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVentasUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuListadoClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListadoProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListaInventarioActual = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFacturasReimpresion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuarioLogueado = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFechaHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrFechaHora = new System.Windows.Forms.Timer(this.components);
            this.mnuPrincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.BackColor = System.Drawing.Color.DimGray;
            this.mnuPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMantenimientos,
            this.mnuProcesos,
            this.mnuReportes,
            this.mnuAcercaDe,
            this.mnuCerrarSesion});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuPrincipal.Size = new System.Drawing.Size(811, 29);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuMantenimientos
            // 
            this.mnuMantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsuariosGestion,
            this.toolStripSeparator1,
            this.mnuClientesGestion,
            this.toolStripSeparator2,
            this.mnuImpuestosGestion,
            this.mnuInventariosGestion,
            this.mnuCategoriasGestion,
            this.toolStripSeparator3,
            this.mnuProveedoresGestion});
            this.mnuMantenimientos.ForeColor = System.Drawing.Color.Gainsboro;
            this.mnuMantenimientos.Image = global::P620223_StevenCarrillo.Properties.Resources.llave;
            this.mnuMantenimientos.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuMantenimientos.Name = "mnuMantenimientos";
            this.mnuMantenimientos.Size = new System.Drawing.Size(164, 25);
            this.mnuMantenimientos.Text = "Mantenimientos";
            // 
            // mnuUsuariosGestion
            // 
            this.mnuUsuariosGestion.Name = "mnuUsuariosGestion";
            this.mnuUsuariosGestion.Size = new System.Drawing.Size(274, 26);
            this.mnuUsuariosGestion.Text = "Usuarios";
            this.mnuUsuariosGestion.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(271, 6);
            // 
            // mnuClientesGestion
            // 
            this.mnuClientesGestion.Name = "mnuClientesGestion";
            this.mnuClientesGestion.Size = new System.Drawing.Size(274, 26);
            this.mnuClientesGestion.Text = "Clientes";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(271, 6);
            // 
            // mnuImpuestosGestion
            // 
            this.mnuImpuestosGestion.Name = "mnuImpuestosGestion";
            this.mnuImpuestosGestion.Size = new System.Drawing.Size(274, 26);
            this.mnuImpuestosGestion.Text = "Impuestos";
            // 
            // mnuInventariosGestion
            // 
            this.mnuInventariosGestion.Name = "mnuInventariosGestion";
            this.mnuInventariosGestion.Size = new System.Drawing.Size(274, 26);
            this.mnuInventariosGestion.Text = "Inventarios";
            // 
            // mnuCategoriasGestion
            // 
            this.mnuCategoriasGestion.Name = "mnuCategoriasGestion";
            this.mnuCategoriasGestion.Size = new System.Drawing.Size(274, 26);
            this.mnuCategoriasGestion.Text = "Categorias de Inventarios";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(271, 6);
            // 
            // mnuProveedoresGestion
            // 
            this.mnuProveedoresGestion.Name = "mnuProveedoresGestion";
            this.mnuProveedoresGestion.Size = new System.Drawing.Size(274, 26);
            this.mnuProveedoresGestion.Text = "Proveedores";
            // 
            // mnuProcesos
            // 
            this.mnuProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFacturacion});
            this.mnuProcesos.ForeColor = System.Drawing.Color.Gainsboro;
            this.mnuProcesos.Image = global::P620223_StevenCarrillo.Properties.Resources.procesos;
            this.mnuProcesos.Name = "mnuProcesos";
            this.mnuProcesos.Size = new System.Drawing.Size(105, 25);
            this.mnuProcesos.Text = "Procesos";
            // 
            // mnuFacturacion
            // 
            this.mnuFacturacion.Name = "mnuFacturacion";
            this.mnuFacturacion.Size = new System.Drawing.Size(180, 26);
            this.mnuFacturacion.Text = "Facturación";
            this.mnuFacturacion.Click += new System.EventHandler(this.mnuFacturacion_Click);
            // 
            // mnuReportes
            // 
            this.mnuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVentasRangoFechas,
            this.mnuVentasCliente,
            this.mnuVentasUsuario,
            this.toolStripSeparator4,
            this.mnuListadoClientes,
            this.mnuListadoProveedores,
            this.mnuListaInventarioActual,
            this.toolStripSeparator5,
            this.mnuFacturasReimpresion});
            this.mnuReportes.ForeColor = System.Drawing.Color.Gainsboro;
            this.mnuReportes.Image = global::P620223_StevenCarrillo.Properties.Resources.reportes;
            this.mnuReportes.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuReportes.Name = "mnuReportes";
            this.mnuReportes.Size = new System.Drawing.Size(163, 25);
            this.mnuReportes.Text = "Galería Reportes";
            // 
            // mnuVentasRangoFechas
            // 
            this.mnuVentasRangoFechas.Name = "mnuVentasRangoFechas";
            this.mnuVentasRangoFechas.Size = new System.Drawing.Size(294, 26);
            this.mnuVentasRangoFechas.Text = "Ventas por Rango de Fechas";
            // 
            // mnuVentasCliente
            // 
            this.mnuVentasCliente.Name = "mnuVentasCliente";
            this.mnuVentasCliente.Size = new System.Drawing.Size(294, 26);
            this.mnuVentasCliente.Text = "Ventas por Cliente";
            // 
            // mnuVentasUsuario
            // 
            this.mnuVentasUsuario.Name = "mnuVentasUsuario";
            this.mnuVentasUsuario.Size = new System.Drawing.Size(294, 26);
            this.mnuVentasUsuario.Text = "Ventas por Usuario";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(291, 6);
            // 
            // mnuListadoClientes
            // 
            this.mnuListadoClientes.Name = "mnuListadoClientes";
            this.mnuListadoClientes.Size = new System.Drawing.Size(294, 26);
            this.mnuListadoClientes.Text = "Listado de Cliente";
            // 
            // mnuListadoProveedores
            // 
            this.mnuListadoProveedores.Name = "mnuListadoProveedores";
            this.mnuListadoProveedores.Size = new System.Drawing.Size(294, 26);
            this.mnuListadoProveedores.Text = "Listado de Proveedores";
            // 
            // mnuListaInventarioActual
            // 
            this.mnuListaInventarioActual.Name = "mnuListaInventarioActual";
            this.mnuListaInventarioActual.Size = new System.Drawing.Size(294, 26);
            this.mnuListaInventarioActual.Text = "Listado de Inventario Actual";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(291, 6);
            // 
            // mnuFacturasReimpresion
            // 
            this.mnuFacturasReimpresion.Name = "mnuFacturasReimpresion";
            this.mnuFacturasReimpresion.Size = new System.Drawing.Size(294, 26);
            this.mnuFacturasReimpresion.Text = "Reimpresión de Factura";
            // 
            // mnuAcercaDe
            // 
            this.mnuAcercaDe.ForeColor = System.Drawing.Color.Gainsboro;
            this.mnuAcercaDe.Name = "mnuAcercaDe";
            this.mnuAcercaDe.Size = new System.Drawing.Size(96, 25);
            this.mnuAcercaDe.Text = "Acerca de";
            // 
            // mnuCerrarSesion
            // 
            this.mnuCerrarSesion.ForeColor = System.Drawing.Color.Gainsboro;
            this.mnuCerrarSesion.Name = "mnuCerrarSesion";
            this.mnuCerrarSesion.Size = new System.Drawing.Size(122, 25);
            this.mnuCerrarSesion.Text = "Cerrar Sesión";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblUsuarioLogueado,
            this.lblFechaHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 416);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(811, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 19);
            this.toolStripStatusLabel1.Text = "USUARIO:";
            // 
            // lblUsuarioLogueado
            // 
            this.lblUsuarioLogueado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogueado.Name = "lblUsuarioLogueado";
            this.lblUsuarioLogueado.Size = new System.Drawing.Size(53, 19);
            this.lblUsuarioLogueado.Text = "Nombre";
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Padding = new System.Windows.Forms.Padding(2);
            this.lblFechaHora.Size = new System.Drawing.Size(684, 19);
            this.lblFechaHora.Spring = true;
            this.lblFechaHora.Text = "FechaHora";
            this.lblFechaHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tmrFechaHora
            // 
            this.tmrFechaHora.Interval = 1000;
            this.tmrFechaHora.Tick += new System.EventHandler(this.tmrFechaHora_Tick);
            // 
            // FrmPrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(811, 440);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "FrmPrincipalMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P5 Facturación";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipalMDI_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipalMDI_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuariosGestion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuClientesGestion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuInventariosGestion;
        private System.Windows.Forms.ToolStripMenuItem mnuCategoriasGestion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuProveedoresGestion;
        private System.Windows.Forms.ToolStripMenuItem mnuProcesos;
        private System.Windows.Forms.ToolStripMenuItem mnuFacturacion;
        private System.Windows.Forms.ToolStripMenuItem mnuReportes;
        private System.Windows.Forms.ToolStripMenuItem mnuVentasRangoFechas;
        private System.Windows.Forms.ToolStripMenuItem mnuVentasCliente;
        private System.Windows.Forms.ToolStripMenuItem mnuVentasUsuario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnuListadoClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuListadoProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuListaInventarioActual;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mnuFacturasReimpresion;
        private System.Windows.Forms.ToolStripMenuItem mnuAcercaDe;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuarioLogueado;
        private System.Windows.Forms.ToolStripMenuItem mnuCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem mnuImpuestosGestion;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaHora;
        private System.Windows.Forms.Timer tmrFechaHora;
    }
}