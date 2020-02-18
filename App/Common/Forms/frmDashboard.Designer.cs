namespace App.Common.Forms
{
    partial class frmDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblEmpresa = new MetroFramework.Controls.MetroLabel();
            this.lblRIF = new MetroFramework.Controls.MetroLabel();
            this.cmbCotizacion = new System.Windows.Forms.ComboBox();
            this.lblStatusPrinter = new System.Windows.Forms.Label();
            this.dgvListCotizacion = new MetroFramework.Controls.MetroGrid();
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.lblCaja = new System.Windows.Forms.Label();
            this.dgvListCaja = new MetroFramework.Controls.MetroGrid();
            this.panelInventario = new System.Windows.Forms.Panel();
            this.lblInventarioCantidad = new System.Windows.Forms.Label();
            this.lblInventarioMonto = new System.Windows.Forms.Label();
            this.lblInventario = new System.Windows.Forms.Label();
            this.panelVentas = new System.Windows.Forms.Panel();
            this.lblVentasCantidad = new System.Windows.Forms.Label();
            this.lblVentasMonto = new System.Windows.Forms.Label();
            this.lblVentas = new System.Windows.Forms.Label();
            this.panelCompras = new System.Windows.Forms.Panel();
            this.lblComprasCantidad = new System.Windows.Forms.Label();
            this.lblComprasMonto = new System.Windows.Forms.Label();
            this.lblCompras = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCotizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCaja)).BeginInit();
            this.panelInventario.SuspendLayout();
            this.panelVentas.SuspendLayout();
            this.panelCompras.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEmpresa.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblEmpresa.Location = new System.Drawing.Point(23, 28);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(84, 25);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Empresa";
            // 
            // lblRIF
            // 
            this.lblRIF.AutoSize = true;
            this.lblRIF.Location = new System.Drawing.Point(23, 60);
            this.lblRIF.Name = "lblRIF";
            this.lblRIF.Size = new System.Drawing.Size(27, 19);
            this.lblRIF.TabIndex = 1;
            this.lblRIF.Text = "RIF";
            // 
            // cmbCotizacion
            // 
            this.cmbCotizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCotizacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCotizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCotizacion.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCotizacion.FormattingEnabled = true;
            this.cmbCotizacion.Location = new System.Drawing.Point(816, 28);
            this.cmbCotizacion.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCotizacion.Name = "cmbCotizacion";
            this.cmbCotizacion.Size = new System.Drawing.Size(98, 29);
            this.cmbCotizacion.TabIndex = 42;
            this.cmbCotizacion.SelectedIndexChanged += new System.EventHandler(this.cmbCotizacion_SelectedIndexChanged);
            // 
            // lblStatusPrinter
            // 
            this.lblStatusPrinter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusPrinter.Location = new System.Drawing.Point(717, 589);
            this.lblStatusPrinter.Name = "lblStatusPrinter";
            this.lblStatusPrinter.Size = new System.Drawing.Size(196, 13);
            this.lblStatusPrinter.TabIndex = 44;
            this.lblStatusPrinter.Text = "Estado de la impresora fiscal";
            this.lblStatusPrinter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dgvListCotizacion
            // 
            this.dgvListCotizacion.AllowUserToAddRows = false;
            this.dgvListCotizacion.AllowUserToDeleteRows = false;
            this.dgvListCotizacion.AllowUserToOrderColumns = true;
            this.dgvListCotizacion.AllowUserToResizeRows = false;
            this.dgvListCotizacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListCotizacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListCotizacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListCotizacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListCotizacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListCotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListCotizacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListCotizacion.Enabled = false;
            this.dgvListCotizacion.EnableHeadersVisualStyles = false;
            this.dgvListCotizacion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvListCotizacion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListCotizacion.Location = new System.Drawing.Point(27, 328);
            this.dgvListCotizacion.Name = "dgvListCotizacion";
            this.dgvListCotizacion.ReadOnly = true;
            this.dgvListCotizacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListCotizacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListCotizacion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListCotizacion.RowTemplate.Height = 30;
            this.dgvListCotizacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListCotizacion.Size = new System.Drawing.Size(563, 180);
            this.dgvListCotizacion.Style = MetroFramework.MetroColorStyle.Orange;
            this.dgvListCotizacion.TabIndex = 55;
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCotizacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCotizacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCotizacion.Location = new System.Drawing.Point(23, 296);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(342, 29);
            this.lblCotizacion.TabIndex = 56;
            this.lblCotizacion.Text = "Cotizacion";
            // 
            // lblCaja
            // 
            this.lblCaja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCaja.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCaja.Location = new System.Drawing.Point(23, 101);
            this.lblCaja.Name = "lblCaja";
            this.lblCaja.Size = new System.Drawing.Size(364, 29);
            this.lblCaja.TabIndex = 58;
            this.lblCaja.Text = "Caja";
            // 
            // dgvListCaja
            // 
            this.dgvListCaja.AllowUserToAddRows = false;
            this.dgvListCaja.AllowUserToDeleteRows = false;
            this.dgvListCaja.AllowUserToOrderColumns = true;
            this.dgvListCaja.AllowUserToResizeRows = false;
            this.dgvListCaja.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListCaja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListCaja.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListCaja.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListCaja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListCaja.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListCaja.Enabled = false;
            this.dgvListCaja.EnableHeadersVisualStyles = false;
            this.dgvListCaja.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvListCaja.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListCaja.Location = new System.Drawing.Point(23, 133);
            this.dgvListCaja.Name = "dgvListCaja";
            this.dgvListCaja.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListCaja.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListCaja.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListCaja.RowTemplate.Height = 30;
            this.dgvListCaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListCaja.Size = new System.Drawing.Size(567, 148);
            this.dgvListCaja.Style = MetroFramework.MetroColorStyle.Orange;
            this.dgvListCaja.TabIndex = 57;
            // 
            // panelInventario
            // 
            this.panelInventario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInventario.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelInventario.Controls.Add(this.lblInventarioCantidad);
            this.panelInventario.Controls.Add(this.lblInventarioMonto);
            this.panelInventario.Controls.Add(this.lblInventario);
            this.panelInventario.Location = new System.Drawing.Point(612, 133);
            this.panelInventario.Name = "panelInventario";
            this.panelInventario.Size = new System.Drawing.Size(302, 120);
            this.panelInventario.TabIndex = 59;
            // 
            // lblInventarioCantidad
            // 
            this.lblInventarioCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInventarioCantidad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventarioCantidad.ForeColor = System.Drawing.Color.White;
            this.lblInventarioCantidad.Location = new System.Drawing.Point(3, 90);
            this.lblInventarioCantidad.Name = "lblInventarioCantidad";
            this.lblInventarioCantidad.Size = new System.Drawing.Size(287, 29);
            this.lblInventarioCantidad.TabIndex = 61;
            this.lblInventarioCantidad.Text = "Productos en stock: 0,00";
            // 
            // lblInventarioMonto
            // 
            this.lblInventarioMonto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInventarioMonto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventarioMonto.ForeColor = System.Drawing.Color.White;
            this.lblInventarioMonto.Location = new System.Drawing.Point(1, 45);
            this.lblInventarioMonto.Name = "lblInventarioMonto";
            this.lblInventarioMonto.Size = new System.Drawing.Size(287, 29);
            this.lblInventarioMonto.TabIndex = 60;
            this.lblInventarioMonto.Text = "0,00";
            // 
            // lblInventario
            // 
            this.lblInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInventario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventario.ForeColor = System.Drawing.Color.White;
            this.lblInventario.Location = new System.Drawing.Point(3, 3);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(285, 29);
            this.lblInventario.TabIndex = 59;
            this.lblInventario.Text = "Inventario Neto:";
            // 
            // panelVentas
            // 
            this.panelVentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVentas.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelVentas.Controls.Add(this.lblVentasCantidad);
            this.panelVentas.Controls.Add(this.lblVentasMonto);
            this.panelVentas.Controls.Add(this.lblVentas);
            this.panelVentas.Location = new System.Drawing.Point(612, 275);
            this.panelVentas.Name = "panelVentas";
            this.panelVentas.Size = new System.Drawing.Size(302, 120);
            this.panelVentas.TabIndex = 60;
            // 
            // lblVentasCantidad
            // 
            this.lblVentasCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVentasCantidad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasCantidad.ForeColor = System.Drawing.Color.White;
            this.lblVentasCantidad.Location = new System.Drawing.Point(3, 90);
            this.lblVentasCantidad.Name = "lblVentasCantidad";
            this.lblVentasCantidad.Size = new System.Drawing.Size(285, 29);
            this.lblVentasCantidad.TabIndex = 61;
            this.lblVentasCantidad.Text = "Ventas emitidas: 0,00";
            // 
            // lblVentasMonto
            // 
            this.lblVentasMonto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVentasMonto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasMonto.ForeColor = System.Drawing.Color.White;
            this.lblVentasMonto.Location = new System.Drawing.Point(3, 45);
            this.lblVentasMonto.Name = "lblVentasMonto";
            this.lblVentasMonto.Size = new System.Drawing.Size(285, 29);
            this.lblVentasMonto.TabIndex = 60;
            this.lblVentasMonto.Text = "0,00";
            // 
            // lblVentas
            // 
            this.lblVentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVentas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.ForeColor = System.Drawing.Color.White;
            this.lblVentas.Location = new System.Drawing.Point(3, 3);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(285, 29);
            this.lblVentas.TabIndex = 59;
            this.lblVentas.Text = "Ventas del Mes";
            // 
            // panelCompras
            // 
            this.panelCompras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCompras.BackColor = System.Drawing.Color.Orange;
            this.panelCompras.Controls.Add(this.lblComprasCantidad);
            this.panelCompras.Controls.Add(this.lblComprasMonto);
            this.panelCompras.Controls.Add(this.lblCompras);
            this.panelCompras.Location = new System.Drawing.Point(611, 419);
            this.panelCompras.Name = "panelCompras";
            this.panelCompras.Size = new System.Drawing.Size(302, 120);
            this.panelCompras.TabIndex = 61;
            // 
            // lblComprasCantidad
            // 
            this.lblComprasCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComprasCantidad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComprasCantidad.ForeColor = System.Drawing.Color.White;
            this.lblComprasCantidad.Location = new System.Drawing.Point(3, 90);
            this.lblComprasCantidad.Name = "lblComprasCantidad";
            this.lblComprasCantidad.Size = new System.Drawing.Size(288, 29);
            this.lblComprasCantidad.TabIndex = 61;
            this.lblComprasCantidad.Text = "Compras realizadas: 0,00";
            // 
            // lblComprasMonto
            // 
            this.lblComprasMonto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComprasMonto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComprasMonto.ForeColor = System.Drawing.Color.White;
            this.lblComprasMonto.Location = new System.Drawing.Point(3, 45);
            this.lblComprasMonto.Name = "lblComprasMonto";
            this.lblComprasMonto.Size = new System.Drawing.Size(286, 29);
            this.lblComprasMonto.TabIndex = 60;
            this.lblComprasMonto.Text = "0,00";
            // 
            // lblCompras
            // 
            this.lblCompras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompras.ForeColor = System.Drawing.Color.White;
            this.lblCompras.Location = new System.Drawing.Point(3, 3);
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(286, 29);
            this.lblCompras.TabIndex = 59;
            this.lblCompras.Text = "Compras del Mes";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFecha.Location = new System.Drawing.Point(611, 101);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(303, 29);
            this.lblFecha.TabIndex = 62;
            this.lblFecha.Text = "Caja";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 622);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.panelCompras);
            this.Controls.Add(this.panelVentas);
            this.Controls.Add(this.panelInventario);
            this.Controls.Add(this.lblCaja);
            this.Controls.Add(this.dgvListCaja);
            this.Controls.Add(this.lblCotizacion);
            this.Controls.Add(this.dgvListCotizacion);
            this.Controls.Add(this.lblStatusPrinter);
            this.Controls.Add(this.cmbCotizacion);
            this.Controls.Add(this.lblRIF);
            this.Controls.Add(this.lblEmpresa);
            this.Name = "frmDashboard";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCotizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCaja)).EndInit();
            this.panelInventario.ResumeLayout(false);
            this.panelVentas.ResumeLayout(false);
            this.panelCompras.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblEmpresa;
        private MetroFramework.Controls.MetroLabel lblRIF;
        private System.Windows.Forms.ComboBox cmbCotizacion;
        private System.Windows.Forms.Label lblStatusPrinter;
        private MetroFramework.Controls.MetroGrid dgvListCotizacion;
        private System.Windows.Forms.Label lblCotizacion;
        private System.Windows.Forms.Label lblCaja;
        private MetroFramework.Controls.MetroGrid dgvListCaja;
        private System.Windows.Forms.Panel panelInventario;
        private System.Windows.Forms.Label lblInventarioCantidad;
        private System.Windows.Forms.Label lblInventarioMonto;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.Panel panelVentas;
        private System.Windows.Forms.Label lblVentasCantidad;
        private System.Windows.Forms.Label lblVentasMonto;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Panel panelCompras;
        private System.Windows.Forms.Label lblComprasCantidad;
        private System.Windows.Forms.Label lblComprasMonto;
        private System.Windows.Forms.Label lblCompras;
        private System.Windows.Forms.Label lblFecha;
    }
}