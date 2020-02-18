namespace App.Core.Reportes
{
    partial class frmRepCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepCaja));
            this.cmbInstrumento = new MetroFramework.Controls.MetroComboBox();
            this.lblInstrumento = new MetroFramework.Controls.MetroLabel();
            this.lblHasta = new MetroFramework.Controls.MetroLabel();
            this.dtHasta = new MetroFramework.Controls.MetroDateTime();
            this.lblDesde = new MetroFramework.Controls.MetroLabel();
            this.dtDesde = new MetroFramework.Controls.MetroDateTime();
            this.cmbCotizacion = new System.Windows.Forms.ComboBox();
            this.cmbReporte = new MetroFramework.Controls.MetroComboBox();
            this.lblReporte = new MetroFramework.Controls.MetroLabel();
            this.btnPrint = new MetroFramework.Controls.MetroLink();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new MetroFramework.Controls.MetroLink();
            this.cmbCuenta = new MetroFramework.Controls.MetroComboBox();
            this.lblCuenta = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // cmbInstrumento
            // 
            this.cmbInstrumento.FormattingEnabled = true;
            this.cmbInstrumento.ItemHeight = 23;
            this.cmbInstrumento.Items.AddRange(new object[] {
            "Listado de Existencias",
            "Listado de Precios",
            "Resumen de Movimientos",
            "Movimiento Detallado",
            "Inventario Monetario"});
            this.cmbInstrumento.Location = new System.Drawing.Point(341, 108);
            this.cmbInstrumento.Name = "cmbInstrumento";
            this.cmbInstrumento.Size = new System.Drawing.Size(241, 29);
            this.cmbInstrumento.TabIndex = 139;
            this.cmbInstrumento.UseSelectable = true;
            this.cmbInstrumento.Visible = false;
            // 
            // lblInstrumento
            // 
            this.lblInstrumento.AutoSize = true;
            this.lblInstrumento.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblInstrumento.Location = new System.Drawing.Point(342, 90);
            this.lblInstrumento.Name = "lblInstrumento";
            this.lblInstrumento.Size = new System.Drawing.Size(73, 15);
            this.lblInstrumento.TabIndex = 140;
            this.lblInstrumento.Text = "Instrumentos";
            this.lblInstrumento.Visible = false;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblHasta.Location = new System.Drawing.Point(225, 160);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(36, 15);
            this.lblHasta.TabIndex = 138;
            this.lblHasta.Text = "Hasta";
            // 
            // dtHasta
            // 
            this.dtHasta.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHasta.Location = new System.Drawing.Point(225, 179);
            this.dtHasta.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(89, 25);
            this.dtHasta.TabIndex = 137;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblDesde.Location = new System.Drawing.Point(73, 160);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(39, 15);
            this.lblDesde.TabIndex = 136;
            this.lblDesde.Text = "Desde";
            // 
            // dtDesde
            // 
            this.dtDesde.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDesde.Location = new System.Drawing.Point(73, 179);
            this.dtDesde.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(89, 25);
            this.dtDesde.TabIndex = 135;
            // 
            // cmbCotizacion
            // 
            this.cmbCotizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCotizacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCotizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCotizacion.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCotizacion.FormattingEnabled = true;
            this.cmbCotizacion.Location = new System.Drawing.Point(718, 108);
            this.cmbCotizacion.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCotizacion.Name = "cmbCotizacion";
            this.cmbCotizacion.Size = new System.Drawing.Size(80, 29);
            this.cmbCotizacion.TabIndex = 134;
            this.cmbCotizacion.SelectedIndexChanged += new System.EventHandler(this.cmbCotizacion_SelectedIndexChanged);
            // 
            // cmbReporte
            // 
            this.cmbReporte.FormattingEnabled = true;
            this.cmbReporte.ItemHeight = 23;
            this.cmbReporte.Items.AddRange(new object[] {
            "Instrumentos (Resumen)",
            "Instrumentos (Detalle)",
            "Cuentas Bancarias (Resumen)",
            "Cuentas Bancarias (Detalle)",
            ""});
            this.cmbReporte.Location = new System.Drawing.Point(73, 108);
            this.cmbReporte.Name = "cmbReporte";
            this.cmbReporte.Size = new System.Drawing.Size(241, 29);
            this.cmbReporte.TabIndex = 132;
            this.cmbReporte.UseSelectable = true;
            this.cmbReporte.SelectedIndexChanged += new System.EventHandler(this.cmbReporte_SelectedIndexChanged);
            // 
            // lblReporte
            // 
            this.lblReporte.AutoSize = true;
            this.lblReporte.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblReporte.Location = new System.Drawing.Point(74, 90);
            this.lblReporte.Name = "lblReporte";
            this.lblReporte.Size = new System.Drawing.Size(49, 15);
            this.lblReporte.TabIndex = 133;
            this.lblReporte.Text = "Reporte";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrint.ImageSize = 32;
            this.btnPrint.Location = new System.Drawing.Point(733, 24);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.NoFocusImage")));
            this.btnPrint.Size = new System.Drawing.Size(65, 46);
            this.btnPrint.TabIndex = 131;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(69, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(590, 43);
            this.lblTitle.TabIndex = 130;
            this.lblTitle.Text = "Reportes de Caja";
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.ImageSize = 32;
            this.btnBack.Location = new System.Drawing.Point(25, 25);
            this.btnBack.Name = "btnBack";
            this.btnBack.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnBack.NoFocusImage")));
            this.btnBack.Size = new System.Drawing.Size(38, 46);
            this.btnBack.TabIndex = 129;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbCuenta
            // 
            this.cmbCuenta.FormattingEnabled = true;
            this.cmbCuenta.ItemHeight = 23;
            this.cmbCuenta.Items.AddRange(new object[] {
            "Listado de Existencias",
            "Listado de Precios",
            "Resumen de Movimientos",
            "Movimiento Detallado",
            "Inventario Monetario"});
            this.cmbCuenta.Location = new System.Drawing.Point(341, 175);
            this.cmbCuenta.Name = "cmbCuenta";
            this.cmbCuenta.Size = new System.Drawing.Size(241, 29);
            this.cmbCuenta.TabIndex = 141;
            this.cmbCuenta.UseSelectable = true;
            this.cmbCuenta.Visible = false;
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblCuenta.Location = new System.Drawing.Point(342, 157);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(97, 15);
            this.lblCuenta.TabIndex = 142;
            this.lblCuenta.Text = "Cuentas Bancarias";
            this.lblCuenta.Visible = false;
            // 
            // frmRepCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 488);
            this.Controls.Add(this.cmbCuenta);
            this.Controls.Add(this.lblCuenta);
            this.Controls.Add(this.cmbInstrumento);
            this.Controls.Add(this.lblInstrumento);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.cmbCotizacion);
            this.Controls.Add(this.cmbReporte);
            this.Controls.Add(this.lblReporte);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBack);
            this.Name = "frmRepCaja";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbInstrumento;
        private MetroFramework.Controls.MetroLabel lblInstrumento;
        private MetroFramework.Controls.MetroLabel lblHasta;
        private MetroFramework.Controls.MetroDateTime dtHasta;
        private MetroFramework.Controls.MetroLabel lblDesde;
        private MetroFramework.Controls.MetroDateTime dtDesde;
        private System.Windows.Forms.ComboBox cmbCotizacion;
        private MetroFramework.Controls.MetroComboBox cmbReporte;
        private MetroFramework.Controls.MetroLabel lblReporte;
        private MetroFramework.Controls.MetroLink btnPrint;
        private System.Windows.Forms.Label lblTitle;
        private MetroFramework.Controls.MetroLink btnBack;
        private MetroFramework.Controls.MetroComboBox cmbCuenta;
        private MetroFramework.Controls.MetroLabel lblCuenta;
    }
}