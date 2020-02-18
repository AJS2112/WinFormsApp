namespace App.Core.Ventas
{
    partial class frmVntOperacionesDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVntOperacionesDetail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbCotizacion = new System.Windows.Forms.ComboBox();
            this.lblFechaDocumento = new MetroFramework.Controls.MetroLabel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            this.lblItems = new MetroFramework.Controls.MetroLabel();
            this.lblClienteRif = new System.Windows.Forms.Label();
            this.lblClienteNombre = new System.Windows.Forms.Label();
            this.dtFecha = new MetroFramework.Controls.MetroDateTime();
            this.btnSeleccionarCliente = new MetroFramework.Controls.MetroLink();
            this.btnSend = new MetroFramework.Controls.MetroLink();
            this.btnPrint = new MetroFramework.Controls.MetroLink();
            this.btnSave = new MetroFramework.Controls.MetroLink();
            this.btnDel = new MetroFramework.Controls.MetroLink();
            this.btnAdd = new MetroFramework.Controls.MetroLink();
            this.dgvList = new MetroFramework.Controls.MetroGrid();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new MetroFramework.Controls.MetroLink();
            this.btnPay = new MetroFramework.Controls.MetroLink();
            this.lblProgreso = new MetroFramework.Controls.MetroLabel();
            this.btnNullify = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCotizacion
            // 
            this.cmbCotizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCotizacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCotizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCotizacion.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCotizacion.FormattingEnabled = true;
            this.cmbCotizacion.Location = new System.Drawing.Point(942, 96);
            this.cmbCotizacion.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCotizacion.Name = "cmbCotizacion";
            this.cmbCotizacion.Size = new System.Drawing.Size(80, 29);
            this.cmbCotizacion.TabIndex = 95;
            this.cmbCotizacion.SelectedIndexChanged += new System.EventHandler(this.cmbCotizacion_SelectedIndexChanged);
            // 
            // lblFechaDocumento
            // 
            this.lblFechaDocumento.AutoSize = true;
            this.lblFechaDocumento.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblFechaDocumento.Location = new System.Drawing.Point(70, 145);
            this.lblFechaDocumento.Name = "lblFechaDocumento";
            this.lblFechaDocumento.Size = new System.Drawing.Size(98, 15);
            this.lblFechaDocumento.TabIndex = 94;
            this.lblFechaDocumento.Text = "Fecha Documento";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSubTitle.Location = new System.Drawing.Point(69, 54);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(186, 24);
            this.lblSubTitle.TabIndex = 93;
            this.lblSubTitle.Text = "Operacion Nro";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTotal.Location = new System.Drawing.Point(100, 215);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(72, 19);
            this.lblTotal.TabIndex = 90;
            this.lblTotal.Text = "Total: 0,00";
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(70, 215);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(24, 19);
            this.lblItems.TabIndex = 89;
            this.lblItems.Text = "(0)";
            this.lblItems.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblClienteRif
            // 
            this.lblClienteRif.AutoSize = true;
            this.lblClienteRif.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteRif.Location = new System.Drawing.Point(70, 123);
            this.lblClienteRif.Name = "lblClienteRif";
            this.lblClienteRif.Size = new System.Drawing.Size(23, 13);
            this.lblClienteRif.TabIndex = 82;
            this.lblClienteRif.Text = "RIF";
            // 
            // lblClienteNombre
            // 
            this.lblClienteNombre.AutoSize = true;
            this.lblClienteNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteNombre.Location = new System.Drawing.Point(70, 96);
            this.lblClienteNombre.Name = "lblClienteNombre";
            this.lblClienteNombre.Size = new System.Drawing.Size(47, 17);
            this.lblClienteNombre.TabIndex = 81;
            this.lblClienteNombre.Text = "Cliente";
            // 
            // dtFecha
            // 
            this.dtFecha.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(70, 163);
            this.dtFecha.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(89, 25);
            this.dtFecha.TabIndex = 80;
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarCliente.Image")));
            this.btnSeleccionarCliente.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSeleccionarCliente.ImageSize = 24;
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(29, 96);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarCliente.NoFocusImage")));
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(35, 28);
            this.btnSeleccionarCliente.TabIndex = 79;
            this.btnSeleccionarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarCliente.UseSelectable = true;
            this.btnSeleccionarCliente.Click += new System.EventHandler(this.btnSeleccionarCliente_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSend.ImageSize = 32;
            this.btnSend.Location = new System.Drawing.Point(886, 20);
            this.btnSend.Name = "btnSend";
            this.btnSend.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnSend.NoFocusImage")));
            this.btnSend.Size = new System.Drawing.Size(65, 46);
            this.btnSend.TabIndex = 78;
            this.btnSend.Text = "Enviar";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSend.UseSelectable = true;
            this.btnSend.Click += new System.EventHandler(this.btnNullify_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrint.ImageSize = 32;
            this.btnPrint.Location = new System.Drawing.Point(747, 20);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.NoFocusImage")));
            this.btnPrint.Size = new System.Drawing.Size(65, 46);
            this.btnPrint.TabIndex = 77;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.ImageSize = 32;
            this.btnSave.Location = new System.Drawing.Point(957, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnSave.NoFocusImage")));
            this.btnSave.Size = new System.Drawing.Size(65, 46);
            this.btnSave.TabIndex = 76;
            this.btnSave.Text = "Guardar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.ImageSize = 24;
            this.btnDel.Location = new System.Drawing.Point(814, 202);
            this.btnDel.Name = "btnDel";
            this.btnDel.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnDel.NoFocusImage")));
            this.btnDel.Size = new System.Drawing.Size(97, 32);
            this.btnDel.TabIndex = 75;
            this.btnDel.Text = "Eliminar";
            this.btnDel.UseSelectable = true;
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.ImageSize = 24;
            this.btnAdd.Location = new System.Drawing.Point(916, 202);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.NoFocusImage")));
            this.btnAdd.Size = new System.Drawing.Size(106, 32);
            this.btnAdd.TabIndex = 74;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvList.Location = new System.Drawing.Point(70, 240);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvList.RowTemplate.Height = 30;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(958, 231);
            this.dgvList.Style = MetroFramework.MetroColorStyle.Orange;
            this.dgvList.TabIndex = 73;
            this.dgvList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellEndEdit);
            this.dgvList.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvList_RowStateChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(64, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(517, 35);
            this.lblTitle.TabIndex = 72;
            this.lblTitle.Text = "Operacion Nro";
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.ImageSize = 32;
            this.btnBack.Location = new System.Drawing.Point(20, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnBack.NoFocusImage")));
            this.btnBack.Size = new System.Drawing.Size(38, 46);
            this.btnBack.TabIndex = 71;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPay.ImageSize = 32;
            this.btnPay.Location = new System.Drawing.Point(814, 20);
            this.btnPay.Name = "btnPay";
            this.btnPay.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnPay.NoFocusImage")));
            this.btnPay.Size = new System.Drawing.Size(65, 46);
            this.btnPay.TabIndex = 96;
            this.btnPay.Text = "Pagar";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPay.UseSelectable = true;
            this.btnPay.Visible = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblProgreso
            // 
            this.lblProgreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProgreso.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblProgreso.Location = new System.Drawing.Point(29, 474);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.Size = new System.Drawing.Size(220, 20);
            this.lblProgreso.TabIndex = 97;
            this.lblProgreso.Text = "progreso";
            // 
            // btnNullify
            // 
            this.btnNullify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNullify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNullify.Image = ((System.Drawing.Image)(resources.GetObject("btnNullify.Image")));
            this.btnNullify.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNullify.ImageSize = 32;
            this.btnNullify.Location = new System.Drawing.Point(676, 23);
            this.btnNullify.Name = "btnNullify";
            this.btnNullify.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnNullify.NoFocusImage")));
            this.btnNullify.Size = new System.Drawing.Size(65, 43);
            this.btnNullify.TabIndex = 98;
            this.btnNullify.Text = "Anular";
            this.btnNullify.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNullify.UseSelectable = true;
            this.btnNullify.Visible = false;
            this.btnNullify.Click += new System.EventHandler(this.btnNullify_Click_1);
            // 
            // frmVntOperacionesDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 500);
            this.Controls.Add(this.btnNullify);
            this.Controls.Add(this.lblProgreso);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.cmbCotizacion);
            this.Controls.Add(this.lblFechaDocumento);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.lblClienteRif);
            this.Controls.Add(this.lblClienteNombre);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.btnSeleccionarCliente);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBack);
            this.Name = "frmVntOperacionesDetail";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Load += new System.EventHandler(this.frmVntOperacionesDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCotizacion;
        private MetroFramework.Controls.MetroLabel lblFechaDocumento;
        private System.Windows.Forms.Label lblSubTitle;
        private MetroFramework.Controls.MetroLabel lblTotal;
        private MetroFramework.Controls.MetroLabel lblItems;
        private System.Windows.Forms.Label lblClienteRif;
        private System.Windows.Forms.Label lblClienteNombre;
        private MetroFramework.Controls.MetroDateTime dtFecha;
        private MetroFramework.Controls.MetroLink btnSeleccionarCliente;
        private MetroFramework.Controls.MetroLink btnSend;
        private MetroFramework.Controls.MetroLink btnPrint;
        private MetroFramework.Controls.MetroLink btnSave;
        private MetroFramework.Controls.MetroLink btnDel;
        private MetroFramework.Controls.MetroLink btnAdd;
        private MetroFramework.Controls.MetroGrid dgvList;
        private System.Windows.Forms.Label lblTitle;
        private MetroFramework.Controls.MetroLink btnBack;
        private MetroFramework.Controls.MetroLink btnPay;
        private MetroFramework.Controls.MetroLabel lblProgreso;
        private MetroFramework.Controls.MetroLink btnNullify;
    }
}