namespace App.Common.Forms
{
    partial class frmMainMenu
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
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invOperacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmpProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmpOperacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vntClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vntOperacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajOperacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cnfCotizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cnfCuentasBancariasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cnfAjustesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripMain
            // 
            this.statusStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLblUsuario});
            this.statusStripMain.Location = new System.Drawing.Point(0, 539);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(884, 22);
            this.statusStripMain.TabIndex = 1;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLblUsuario
            // 
            this.toolStripStatusLblUsuario.Name = "toolStripStatusLblUsuario";
            this.toolStripStatusLblUsuario.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLblUsuario.Text = "Usuario:";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.cajaToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.configuracionesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(884, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invCategoriasToolStripMenuItem,
            this.invProductosToolStripMenuItem,
            this.invOperacionesToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "&Inventario";
            // 
            // invCategoriasToolStripMenuItem
            // 
            this.invCategoriasToolStripMenuItem.Name = "invCategoriasToolStripMenuItem";
            this.invCategoriasToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.invCategoriasToolStripMenuItem.Text = "&Categorías";
            this.invCategoriasToolStripMenuItem.Click += new System.EventHandler(this.invCategoriasToolStripMenuItem_Click);
            // 
            // invProductosToolStripMenuItem
            // 
            this.invProductosToolStripMenuItem.Name = "invProductosToolStripMenuItem";
            this.invProductosToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.invProductosToolStripMenuItem.Text = "&Productos";
            this.invProductosToolStripMenuItem.Click += new System.EventHandler(this.invProductosToolStripMenuItem_Click);
            // 
            // invOperacionesToolStripMenuItem
            // 
            this.invOperacionesToolStripMenuItem.Name = "invOperacionesToolStripMenuItem";
            this.invOperacionesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.invOperacionesToolStripMenuItem.Text = "&Operaciones";
            this.invOperacionesToolStripMenuItem.Click += new System.EventHandler(this.invOperacionesToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmpProveedoresToolStripMenuItem,
            this.cmpOperacionesToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.comprasToolStripMenuItem.Text = "&Compras";
            // 
            // cmpProveedoresToolStripMenuItem
            // 
            this.cmpProveedoresToolStripMenuItem.Name = "cmpProveedoresToolStripMenuItem";
            this.cmpProveedoresToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.cmpProveedoresToolStripMenuItem.Text = "&Proveedores";
            this.cmpProveedoresToolStripMenuItem.Click += new System.EventHandler(this.cmpProveedoresToolStripMenuItem_Click);
            // 
            // cmpOperacionesToolStripMenuItem
            // 
            this.cmpOperacionesToolStripMenuItem.Name = "cmpOperacionesToolStripMenuItem";
            this.cmpOperacionesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.cmpOperacionesToolStripMenuItem.Text = "&Operaciones";
            this.cmpOperacionesToolStripMenuItem.Click += new System.EventHandler(this.cmpOperacionesToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vntClientesToolStripMenuItem,
            this.vntOperacionesToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // vntClientesToolStripMenuItem
            // 
            this.vntClientesToolStripMenuItem.Name = "vntClientesToolStripMenuItem";
            this.vntClientesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.vntClientesToolStripMenuItem.Text = "&Clientes";
            this.vntClientesToolStripMenuItem.Click += new System.EventHandler(this.vntClientesToolStripMenuItem_Click);
            // 
            // vntOperacionesToolStripMenuItem
            // 
            this.vntOperacionesToolStripMenuItem.Name = "vntOperacionesToolStripMenuItem";
            this.vntOperacionesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.vntOperacionesToolStripMenuItem.Text = "&Operaciones";
            this.vntOperacionesToolStripMenuItem.Click += new System.EventHandler(this.vntOperacionesToolStripMenuItem_Click);
            // 
            // cajaToolStripMenuItem
            // 
            this.cajaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cajOperacionesToolStripMenuItem});
            this.cajaToolStripMenuItem.Name = "cajaToolStripMenuItem";
            this.cajaToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.cajaToolStripMenuItem.Text = "C&aja";
            // 
            // cajOperacionesToolStripMenuItem
            // 
            this.cajOperacionesToolStripMenuItem.Name = "cajOperacionesToolStripMenuItem";
            this.cajOperacionesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.cajOperacionesToolStripMenuItem.Text = "&Operaciones";
            this.cajOperacionesToolStripMenuItem.Click += new System.EventHandler(this.cajOperacionesToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repInventarioToolStripMenuItem,
            this.repComprasToolStripMenuItem,
            this.repVentasToolStripMenuItem,
            this.repCajaToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "&Reportes";
            // 
            // repInventarioToolStripMenuItem
            // 
            this.repInventarioToolStripMenuItem.Name = "repInventarioToolStripMenuItem";
            this.repInventarioToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.repInventarioToolStripMenuItem.Text = "&Inventario";
            this.repInventarioToolStripMenuItem.Click += new System.EventHandler(this.repInventarioToolStripMenuItem_Click);
            // 
            // repComprasToolStripMenuItem
            // 
            this.repComprasToolStripMenuItem.Name = "repComprasToolStripMenuItem";
            this.repComprasToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.repComprasToolStripMenuItem.Text = "&Compras";
            this.repComprasToolStripMenuItem.Click += new System.EventHandler(this.repComprasToolStripMenuItem_Click);
            // 
            // repVentasToolStripMenuItem
            // 
            this.repVentasToolStripMenuItem.Name = "repVentasToolStripMenuItem";
            this.repVentasToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.repVentasToolStripMenuItem.Text = "&Ventas";
            this.repVentasToolStripMenuItem.Click += new System.EventHandler(this.repVentasToolStripMenuItem_Click);
            // 
            // repCajaToolStripMenuItem
            // 
            this.repCajaToolStripMenuItem.Name = "repCajaToolStripMenuItem";
            this.repCajaToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.repCajaToolStripMenuItem.Text = "&Caja";
            this.repCajaToolStripMenuItem.Click += new System.EventHandler(this.repCajaToolStripMenuItem_Click);
            // 
            // configuracionesToolStripMenuItem
            // 
            this.configuracionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cnfCotizacionesToolStripMenuItem,
            this.cnfCuentasBancariasToolStripMenuItem,
            this.cnfAjustesToolStripMenuItem});
            this.configuracionesToolStripMenuItem.Name = "configuracionesToolStripMenuItem";
            this.configuracionesToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.configuracionesToolStripMenuItem.Text = "Con&figuraciones";
            // 
            // cnfCotizacionesToolStripMenuItem
            // 
            this.cnfCotizacionesToolStripMenuItem.Name = "cnfCotizacionesToolStripMenuItem";
            this.cnfCotizacionesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.cnfCotizacionesToolStripMenuItem.Text = "&Cotizaciones";
            this.cnfCotizacionesToolStripMenuItem.Click += new System.EventHandler(this.cnfCotizacionesToolStripMenuItem_Click);
            // 
            // cnfCuentasBancariasToolStripMenuItem
            // 
            this.cnfCuentasBancariasToolStripMenuItem.Name = "cnfCuentasBancariasToolStripMenuItem";
            this.cnfCuentasBancariasToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.cnfCuentasBancariasToolStripMenuItem.Text = "Cuentas &Bancarias";
            this.cnfCuentasBancariasToolStripMenuItem.Click += new System.EventHandler(this.cnfCuentasBancariasToolStripMenuItem_Click);
            // 
            // cnfAjustesToolStripMenuItem
            // 
            this.cnfAjustesToolStripMenuItem.Name = "cnfAjustesToolStripMenuItem";
            this.cnfAjustesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.cnfAjustesToolStripMenuItem.Text = "&Ajustes";
            this.cnfAjustesToolStripMenuItem.Click += new System.EventHandler(this.cnfAjustesToolStripMenuItem_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inversiones ARA, C.A.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblUsuario;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invOperacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmpProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmpOperacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vntClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vntOperacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajOperacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cnfCotizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cnfCuentasBancariasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cnfAjustesToolStripMenuItem;
    }
}