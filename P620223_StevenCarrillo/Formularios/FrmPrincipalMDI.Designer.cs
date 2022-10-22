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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.impuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.galeríaReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorRangoDeFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.listadoDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeInventarioActualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.reimpresiónDeFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.galeríaReportesToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(811, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.toolStripSeparator1,
            this.clientesToolStripMenuItem,
            this.toolStripSeparator2,
            this.impuestosToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.categoriasDeInventarioToolStripMenuItem,
            this.toolStripSeparator3,
            this.proveedoresToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.mantenimientosToolStripMenuItem.Image = global::P620223_StevenCarrillo.Properties.Resources.llave;
            this.mantenimientosToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(164, 25);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(271, 6);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(271, 6);
            // 
            // impuestosToolStripMenuItem
            // 
            this.impuestosToolStripMenuItem.Name = "impuestosToolStripMenuItem";
            this.impuestosToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.impuestosToolStripMenuItem.Text = "Impuestos";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.inventarioToolStripMenuItem.Text = "Inventarios";
            // 
            // categoriasDeInventarioToolStripMenuItem
            // 
            this.categoriasDeInventarioToolStripMenuItem.Name = "categoriasDeInventarioToolStripMenuItem";
            this.categoriasDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.categoriasDeInventarioToolStripMenuItem.Text = "Categorias de Inventarios";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(271, 6);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaciónToolStripMenuItem});
            this.procesosToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.procesosToolStripMenuItem.Image = global::P620223_StevenCarrillo.Properties.Resources.procesos;
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(105, 25);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // facturaciónToolStripMenuItem
            // 
            this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.facturaciónToolStripMenuItem.Text = "Facturación";
            // 
            // galeríaReportesToolStripMenuItem
            // 
            this.galeríaReportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasPorRangoDeFechasToolStripMenuItem,
            this.ventasPorClienteToolStripMenuItem,
            this.ventasPorUsuarioToolStripMenuItem,
            this.toolStripSeparator4,
            this.listadoDeClienteToolStripMenuItem,
            this.listadoDeProveedoresToolStripMenuItem,
            this.listaDeInventarioActualToolStripMenuItem,
            this.toolStripSeparator5,
            this.reimpresiónDeFacturaToolStripMenuItem});
            this.galeríaReportesToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.galeríaReportesToolStripMenuItem.Image = global::P620223_StevenCarrillo.Properties.Resources.reportes;
            this.galeríaReportesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.galeríaReportesToolStripMenuItem.Name = "galeríaReportesToolStripMenuItem";
            this.galeríaReportesToolStripMenuItem.Size = new System.Drawing.Size(163, 25);
            this.galeríaReportesToolStripMenuItem.Text = "Galería Reportes";
            // 
            // ventasPorRangoDeFechasToolStripMenuItem
            // 
            this.ventasPorRangoDeFechasToolStripMenuItem.Name = "ventasPorRangoDeFechasToolStripMenuItem";
            this.ventasPorRangoDeFechasToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.ventasPorRangoDeFechasToolStripMenuItem.Text = "Ventas por Rango de Fechas";
            // 
            // ventasPorClienteToolStripMenuItem
            // 
            this.ventasPorClienteToolStripMenuItem.Name = "ventasPorClienteToolStripMenuItem";
            this.ventasPorClienteToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.ventasPorClienteToolStripMenuItem.Text = "Ventas por Cliente";
            // 
            // ventasPorUsuarioToolStripMenuItem
            // 
            this.ventasPorUsuarioToolStripMenuItem.Name = "ventasPorUsuarioToolStripMenuItem";
            this.ventasPorUsuarioToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.ventasPorUsuarioToolStripMenuItem.Text = "Ventas por Usuario";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(291, 6);
            // 
            // listadoDeClienteToolStripMenuItem
            // 
            this.listadoDeClienteToolStripMenuItem.Name = "listadoDeClienteToolStripMenuItem";
            this.listadoDeClienteToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.listadoDeClienteToolStripMenuItem.Text = "Listado de Cliente";
            // 
            // listadoDeProveedoresToolStripMenuItem
            // 
            this.listadoDeProveedoresToolStripMenuItem.Name = "listadoDeProveedoresToolStripMenuItem";
            this.listadoDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.listadoDeProveedoresToolStripMenuItem.Text = "Listado de Proveedores";
            // 
            // listaDeInventarioActualToolStripMenuItem
            // 
            this.listaDeInventarioActualToolStripMenuItem.Name = "listaDeInventarioActualToolStripMenuItem";
            this.listaDeInventarioActualToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.listaDeInventarioActualToolStripMenuItem.Text = "Listado de Inventario Actual";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(291, 6);
            // 
            // reimpresiónDeFacturaToolStripMenuItem
            // 
            this.reimpresiónDeFacturaToolStripMenuItem.Name = "reimpresiónDeFacturaToolStripMenuItem";
            this.reimpresiónDeFacturaToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.reimpresiónDeFacturaToolStripMenuItem.Text = "Reimpresión de Factura";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(811, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FrmPrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(811, 440);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipalMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P5 Facturación";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipalMDI_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem impuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem galeríaReportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPorRangoDeFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPorClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPorUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeInventarioActualToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem reimpresiónDeFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}