namespace AppPV
{
    partial class frmPuntoVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuntoVenta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnBuscarDocumento = new System.Windows.Forms.Button();
            this.btnNuevoDocumento = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.dgvList = new MetroFramework.Controls.MetroGrid();
            this.btnDel = new MetroFramework.Controls.MetroLink();
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            this.lblItems = new MetroFramework.Controls.MetroLabel();
            this.lblClienteRif = new System.Windows.Forms.Label();
            this.lblClienteNombre = new System.Windows.Forms.Label();
            this.lblPrinterStatus = new System.Windows.Forms.Label();
            this.lblProgreso = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnBuscarCliente);
            this.panel1.Controls.Add(this.btnBuscarProducto);
            this.panel1.Controls.Add(this.btnBuscarDocumento);
            this.panel1.Controls.Add(this.btnNuevoDocumento);
            this.panel1.Controls.Add(this.btnFactura);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 111);
            this.panel1.TabIndex = 1;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarCliente.Location = new System.Drawing.Point(599, 0);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btnBuscarCliente.Size = new System.Drawing.Size(120, 111);
            this.btnBuscarCliente.TabIndex = 7;
            this.btnBuscarCliente.Text = "Buscar Cliente    (F3)";
            this.btnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBuscarProducto.FlatAppearance.BorderSize = 0;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProducto.Image")));
            this.btnBuscarProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarProducto.Location = new System.Drawing.Point(473, 0);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btnBuscarProducto.Size = new System.Drawing.Size(120, 111);
            this.btnBuscarProducto.TabIndex = 6;
            this.btnBuscarProducto.Text = "Buscar Producto (F2)";
            this.btnBuscarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnBuscarDocumento
            // 
            this.btnBuscarDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarDocumento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarDocumento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBuscarDocumento.FlatAppearance.BorderSize = 0;
            this.btnBuscarDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDocumento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDocumento.ForeColor = System.Drawing.Color.White;
            this.btnBuscarDocumento.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarDocumento.Image")));
            this.btnBuscarDocumento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarDocumento.Location = new System.Drawing.Point(725, 0);
            this.btnBuscarDocumento.Name = "btnBuscarDocumento";
            this.btnBuscarDocumento.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btnBuscarDocumento.Size = new System.Drawing.Size(120, 111);
            this.btnBuscarDocumento.TabIndex = 5;
            this.btnBuscarDocumento.Text = "Buscar Venta   (F4)";
            this.btnBuscarDocumento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarDocumento.UseVisualStyleBackColor = true;
            this.btnBuscarDocumento.Click += new System.EventHandler(this.btnBuscarDocumento_Click);
            // 
            // btnNuevoDocumento
            // 
            this.btnNuevoDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoDocumento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoDocumento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNuevoDocumento.FlatAppearance.BorderSize = 0;
            this.btnNuevoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoDocumento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoDocumento.ForeColor = System.Drawing.Color.White;
            this.btnNuevoDocumento.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoDocumento.Image")));
            this.btnNuevoDocumento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevoDocumento.Location = new System.Drawing.Point(851, 0);
            this.btnNuevoDocumento.Name = "btnNuevoDocumento";
            this.btnNuevoDocumento.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btnNuevoDocumento.Size = new System.Drawing.Size(120, 111);
            this.btnNuevoDocumento.TabIndex = 4;
            this.btnNuevoDocumento.Text = "Reiniciar Venta (F5)";
            this.btnNuevoDocumento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevoDocumento.UseVisualStyleBackColor = true;
            this.btnNuevoDocumento.Click += new System.EventHandler(this.btnNuevoDocumento_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFactura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFactura.FlatAppearance.BorderSize = 0;
            this.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactura.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactura.ForeColor = System.Drawing.Color.White;
            this.btnFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnFactura.Image")));
            this.btnFactura.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFactura.Location = new System.Drawing.Point(977, 0);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btnFactura.Size = new System.Drawing.Size(120, 111);
            this.btnFactura.TabIndex = 3;
            this.btnFactura.Text = "Continuar       (F9)";
            this.btnFactura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToOrderColumns = true;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvList.Location = new System.Drawing.Point(12, 247);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvList.RowTemplate.Height = 40;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(1075, 238);
            this.dgvList.Style = MetroFramework.MetroColorStyle.Orange;
            this.dgvList.TabIndex = 23;
            this.dgvList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellEndEdit);
            this.dgvList.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvList_RowStateChanged);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.ImageSize = 24;
            this.btnDel.Location = new System.Drawing.Point(957, 212);
            this.btnDel.Name = "btnDel";
            this.btnDel.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnDel.NoFocusImage")));
            this.btnDel.Size = new System.Drawing.Size(130, 32);
            this.btnDel.TabIndex = 77;
            this.btnDel.Text = "(F7) Eliminar";
            this.btnDel.UseSelectable = true;
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTotal.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTotal.Location = new System.Drawing.Point(51, 219);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(92, 25);
            this.lblTotal.TabIndex = 92;
            this.lblTotal.Text = "Total: 0,00";
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblItems.Location = new System.Drawing.Point(14, 219);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(31, 25);
            this.lblItems.TabIndex = 91;
            this.lblItems.Text = "(0)";
            this.lblItems.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblClienteRif
            // 
            this.lblClienteRif.AutoSize = true;
            this.lblClienteRif.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteRif.Location = new System.Drawing.Point(12, 164);
            this.lblClienteRif.Name = "lblClienteRif";
            this.lblClienteRif.Size = new System.Drawing.Size(31, 21);
            this.lblClienteRif.TabIndex = 94;
            this.lblClienteRif.Text = "RIF";
            // 
            // lblClienteNombre
            // 
            this.lblClienteNombre.AutoSize = true;
            this.lblClienteNombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteNombre.Location = new System.Drawing.Point(12, 137);
            this.lblClienteNombre.Name = "lblClienteNombre";
            this.lblClienteNombre.Size = new System.Drawing.Size(71, 25);
            this.lblClienteNombre.TabIndex = 93;
            this.lblClienteNombre.Text = "Cliente";
            // 
            // lblPrinterStatus
            // 
            this.lblPrinterStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrinterStatus.Location = new System.Drawing.Point(14, 488);
            this.lblPrinterStatus.Name = "lblPrinterStatus";
            this.lblPrinterStatus.Size = new System.Drawing.Size(276, 21);
            this.lblPrinterStatus.TabIndex = 95;
            this.lblPrinterStatus.Text = "Estatus Impresora Fiscal";
            this.lblPrinterStatus.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblProgreso
            // 
            this.lblProgreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProgreso.Location = new System.Drawing.Point(811, 488);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.Size = new System.Drawing.Size(276, 21);
            this.lblProgreso.TabIndex = 96;
            this.lblProgreso.Text = "Progreso";
            this.lblProgreso.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // frmPuntoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1099, 510);
            this.Controls.Add(this.lblProgreso);
            this.Controls.Add(this.lblPrinterStatus);
            this.Controls.Add(this.lblClienteRif);
            this.Controls.Add(this.lblClienteNombre);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.panel1);
            this.Name = "frmPuntoVenta";
            this.Load += new System.EventHandler(this.frmPuntoVenta_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Button btnBuscarDocumento;
        private System.Windows.Forms.Button btnNuevoDocumento;
        private System.Windows.Forms.Button btnFactura;
        private MetroFramework.Controls.MetroGrid dgvList;
        private MetroFramework.Controls.MetroLink btnDel;
        private MetroFramework.Controls.MetroLabel lblTotal;
        private MetroFramework.Controls.MetroLabel lblItems;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblClienteRif;
        private System.Windows.Forms.Label lblClienteNombre;
        private System.Windows.Forms.Label lblPrinterStatus;
        private System.Windows.Forms.Label lblProgreso;
    }
}