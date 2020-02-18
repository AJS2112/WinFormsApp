namespace App.Core.Compras
{
    partial class frmCmpOperacionesDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCmpOperacionesDetail));
            this.dgvList = new MetroFramework.Controls.MetroGrid();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new MetroFramework.Controls.MetroLink();
            this.btnDel = new MetroFramework.Controls.MetroLink();
            this.btnAdd = new MetroFramework.Controls.MetroLink();
            this.btnNullify = new MetroFramework.Controls.MetroLink();
            this.btnPrint = new MetroFramework.Controls.MetroLink();
            this.btnSave = new MetroFramework.Controls.MetroLink();
            this.btnSeleccionarProveedor = new MetroFramework.Controls.MetroLink();
            this.dtFecha = new MetroFramework.Controls.MetroDateTime();
            this.lblProveedorNombre = new System.Windows.Forms.Label();
            this.lblProveedorRif = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new MetroFramework.Controls.MetroComboBox();
            this.lblNroDocumento = new MetroFramework.Controls.MetroLabel();
            this.txtNroDocumento = new MetroFramework.Controls.MetroTextBox();
            this.lblNroControl = new MetroFramework.Controls.MetroLabel();
            this.txtNroControl = new MetroFramework.Controls.MetroTextBox();
            this.lblTipoDocumento = new MetroFramework.Controls.MetroLabel();
            this.lblItems = new MetroFramework.Controls.MetroLabel();
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            this.lblNroFacturaAfectada = new MetroFramework.Controls.MetroLabel();
            this.txtNroFacturaAfectada = new MetroFramework.Controls.MetroTextBox();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblFechaDocumento = new MetroFramework.Controls.MetroLabel();
            this.cmbCotizacion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
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
            this.dgvList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvList.Location = new System.Drawing.Point(70, 240);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvList.RowTemplate.Height = 30;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(952, 236);
            this.dgvList.Style = MetroFramework.MetroColorStyle.Orange;
            this.dgvList.TabIndex = 27;
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
            this.lblTitle.TabIndex = 25;
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
            this.btnBack.TabIndex = 23;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.btnDel.TabIndex = 40;
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
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNullify
            // 
            this.btnNullify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNullify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNullify.Image = ((System.Drawing.Image)(resources.GetObject("btnNullify.Image")));
            this.btnNullify.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNullify.ImageSize = 32;
            this.btnNullify.Location = new System.Drawing.Point(818, 20);
            this.btnNullify.Name = "btnNullify";
            this.btnNullify.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnNullify.NoFocusImage")));
            this.btnNullify.Size = new System.Drawing.Size(65, 46);
            this.btnNullify.TabIndex = 52;
            this.btnNullify.Text = "Anular";
            this.btnNullify.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNullify.UseSelectable = true;
            this.btnNullify.Visible = false;
            this.btnNullify.Click += new System.EventHandler(this.btnNullify_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrint.ImageSize = 32;
            this.btnPrint.Location = new System.Drawing.Point(889, 20);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.NoFocusImage")));
            this.btnPrint.Size = new System.Drawing.Size(65, 46);
            this.btnPrint.TabIndex = 51;
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
            this.btnSave.Location = new System.Drawing.Point(960, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnSave.NoFocusImage")));
            this.btnSave.Size = new System.Drawing.Size(65, 46);
            this.btnSave.TabIndex = 50;
            this.btnSave.Text = "Guardar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSeleccionarProveedor
            // 
            this.btnSeleccionarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarProveedor.Image")));
            this.btnSeleccionarProveedor.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSeleccionarProveedor.ImageSize = 24;
            this.btnSeleccionarProveedor.Location = new System.Drawing.Point(29, 96);
            this.btnSeleccionarProveedor.Name = "btnSeleccionarProveedor";
            this.btnSeleccionarProveedor.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarProveedor.NoFocusImage")));
            this.btnSeleccionarProveedor.Size = new System.Drawing.Size(35, 28);
            this.btnSeleccionarProveedor.TabIndex = 53;
            this.btnSeleccionarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarProveedor.UseSelectable = true;
            this.btnSeleccionarProveedor.Click += new System.EventHandler(this.btnSeleccionarProveedor_Click);
            // 
            // dtFecha
            // 
            this.dtFecha.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(74, 164);
            this.dtFecha.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(89, 25);
            this.dtFecha.TabIndex = 54;
            // 
            // lblProveedorNombre
            // 
            this.lblProveedorNombre.AutoSize = true;
            this.lblProveedorNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedorNombre.Location = new System.Drawing.Point(70, 96);
            this.lblProveedorNombre.Name = "lblProveedorNombre";
            this.lblProveedorNombre.Size = new System.Drawing.Size(69, 17);
            this.lblProveedorNombre.TabIndex = 56;
            this.lblProveedorNombre.Text = "Proveedor";
            // 
            // lblProveedorRif
            // 
            this.lblProveedorRif.AutoSize = true;
            this.lblProveedorRif.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedorRif.Location = new System.Drawing.Point(70, 123);
            this.lblProveedorRif.Name = "lblProveedorRif";
            this.lblProveedorRif.Size = new System.Drawing.Size(23, 13);
            this.lblProveedorRif.TabIndex = 57;
            this.lblProveedorRif.Text = "RIF";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.ItemHeight = 19;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(169, 162);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(113, 25);
            this.cmbTipoDocumento.TabIndex = 58;
            this.cmbTipoDocumento.UseSelectable = true;
            this.cmbTipoDocumento.SelectedValueChanged += new System.EventHandler(this.cmbTipoDocumento_SelectedValueChanged);
            // 
            // lblNroDocumento
            // 
            this.lblNroDocumento.AutoSize = true;
            this.lblNroDocumento.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblNroDocumento.Location = new System.Drawing.Point(288, 145);
            this.lblNroDocumento.Name = "lblNroDocumento";
            this.lblNroDocumento.Size = new System.Drawing.Size(89, 15);
            this.lblNroDocumento.TabIndex = 60;
            this.lblNroDocumento.Text = "Nro Documento";
            // 
            // txtNroDocumento
            // 
            // 
            // 
            // 
            this.txtNroDocumento.CustomButton.Image = null;
            this.txtNroDocumento.CustomButton.Location = new System.Drawing.Point(83, 1);
            this.txtNroDocumento.CustomButton.Name = "";
            this.txtNroDocumento.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtNroDocumento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNroDocumento.CustomButton.TabIndex = 1;
            this.txtNroDocumento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNroDocumento.CustomButton.UseSelectable = true;
            this.txtNroDocumento.CustomButton.Visible = false;
            this.txtNroDocumento.Lines = new string[0];
            this.txtNroDocumento.Location = new System.Drawing.Point(288, 162);
            this.txtNroDocumento.MaxLength = 20;
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.PasswordChar = '\0';
            this.txtNroDocumento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNroDocumento.SelectedText = "";
            this.txtNroDocumento.SelectionLength = 0;
            this.txtNroDocumento.SelectionStart = 0;
            this.txtNroDocumento.ShortcutsEnabled = true;
            this.txtNroDocumento.Size = new System.Drawing.Size(107, 25);
            this.txtNroDocumento.TabIndex = 59;
            this.txtNroDocumento.UseSelectable = true;
            this.txtNroDocumento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNroDocumento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNroControl
            // 
            this.lblNroControl.AutoSize = true;
            this.lblNroControl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblNroControl.Location = new System.Drawing.Point(400, 145);
            this.lblNroControl.Name = "lblNroControl";
            this.lblNroControl.Size = new System.Drawing.Size(67, 15);
            this.lblNroControl.TabIndex = 62;
            this.lblNroControl.Text = "Nro Control";
            // 
            // txtNroControl
            // 
            // 
            // 
            // 
            this.txtNroControl.CustomButton.Image = null;
            this.txtNroControl.CustomButton.Location = new System.Drawing.Point(83, 1);
            this.txtNroControl.CustomButton.Name = "";
            this.txtNroControl.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtNroControl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNroControl.CustomButton.TabIndex = 1;
            this.txtNroControl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNroControl.CustomButton.UseSelectable = true;
            this.txtNroControl.CustomButton.Visible = false;
            this.txtNroControl.Lines = new string[0];
            this.txtNroControl.Location = new System.Drawing.Point(400, 162);
            this.txtNroControl.MaxLength = 20;
            this.txtNroControl.Name = "txtNroControl";
            this.txtNroControl.PasswordChar = '\0';
            this.txtNroControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNroControl.SelectedText = "";
            this.txtNroControl.SelectionLength = 0;
            this.txtNroControl.SelectionStart = 0;
            this.txtNroControl.ShortcutsEnabled = true;
            this.txtNroControl.Size = new System.Drawing.Size(107, 25);
            this.txtNroControl.TabIndex = 61;
            this.txtNroControl.UseSelectable = true;
            this.txtNroControl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNroControl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblTipoDocumento.Location = new System.Drawing.Point(169, 145);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(91, 15);
            this.lblTipoDocumento.TabIndex = 63;
            this.lblTipoDocumento.Text = "Tipo Documento";
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(74, 215);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(24, 19);
            this.lblItems.TabIndex = 64;
            this.lblItems.Text = "(0)";
            this.lblItems.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTotal.Location = new System.Drawing.Point(104, 215);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(72, 19);
            this.lblTotal.TabIndex = 65;
            this.lblTotal.Text = "Total: 0,00";
            // 
            // lblNroFacturaAfectada
            // 
            this.lblNroFacturaAfectada.AutoSize = true;
            this.lblNroFacturaAfectada.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblNroFacturaAfectada.Location = new System.Drawing.Point(514, 145);
            this.lblNroFacturaAfectada.Name = "lblNroFacturaAfectada";
            this.lblNroFacturaAfectada.Size = new System.Drawing.Size(114, 15);
            this.lblNroFacturaAfectada.TabIndex = 67;
            this.lblNroFacturaAfectada.Text = "Nro Factura Afectada";
            // 
            // txtNroFacturaAfectada
            // 
            // 
            // 
            // 
            this.txtNroFacturaAfectada.CustomButton.Image = null;
            this.txtNroFacturaAfectada.CustomButton.Location = new System.Drawing.Point(83, 1);
            this.txtNroFacturaAfectada.CustomButton.Name = "";
            this.txtNroFacturaAfectada.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtNroFacturaAfectada.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNroFacturaAfectada.CustomButton.TabIndex = 1;
            this.txtNroFacturaAfectada.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNroFacturaAfectada.CustomButton.UseSelectable = true;
            this.txtNroFacturaAfectada.CustomButton.Visible = false;
            this.txtNroFacturaAfectada.Lines = new string[0];
            this.txtNroFacturaAfectada.Location = new System.Drawing.Point(514, 162);
            this.txtNroFacturaAfectada.MaxLength = 20;
            this.txtNroFacturaAfectada.Name = "txtNroFacturaAfectada";
            this.txtNroFacturaAfectada.PasswordChar = '\0';
            this.txtNroFacturaAfectada.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNroFacturaAfectada.SelectedText = "";
            this.txtNroFacturaAfectada.SelectionLength = 0;
            this.txtNroFacturaAfectada.SelectionStart = 0;
            this.txtNroFacturaAfectada.ShortcutsEnabled = true;
            this.txtNroFacturaAfectada.Size = new System.Drawing.Size(107, 25);
            this.txtNroFacturaAfectada.TabIndex = 66;
            this.txtNroFacturaAfectada.UseSelectable = true;
            this.txtNroFacturaAfectada.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNroFacturaAfectada.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSubTitle.Location = new System.Drawing.Point(70, 54);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(186, 24);
            this.lblSubTitle.TabIndex = 68;
            this.lblSubTitle.Text = "Operacion Nro";
            // 
            // lblFechaDocumento
            // 
            this.lblFechaDocumento.AutoSize = true;
            this.lblFechaDocumento.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblFechaDocumento.Location = new System.Drawing.Point(74, 145);
            this.lblFechaDocumento.Name = "lblFechaDocumento";
            this.lblFechaDocumento.Size = new System.Drawing.Size(98, 15);
            this.lblFechaDocumento.TabIndex = 69;
            this.lblFechaDocumento.Text = "Fecha Documento";
            // 
            // cmbCotizacion
            // 
            this.cmbCotizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCotizacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCotizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCotizacion.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCotizacion.FormattingEnabled = true;
            this.cmbCotizacion.Location = new System.Drawing.Point(946, 95);
            this.cmbCotizacion.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCotizacion.Name = "cmbCotizacion";
            this.cmbCotizacion.Size = new System.Drawing.Size(80, 29);
            this.cmbCotizacion.TabIndex = 70;
            this.cmbCotizacion.SelectedIndexChanged += new System.EventHandler(this.cmbCotizacion_SelectedIndexChanged);
            // 
            // frmCmpOperacionesDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 500);
            this.Controls.Add(this.cmbCotizacion);
            this.Controls.Add(this.lblFechaDocumento);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblNroFacturaAfectada);
            this.Controls.Add(this.txtNroFacturaAfectada);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.lblNroControl);
            this.Controls.Add(this.txtNroControl);
            this.Controls.Add(this.lblNroDocumento);
            this.Controls.Add(this.txtNroDocumento);
            this.Controls.Add(this.cmbTipoDocumento);
            this.Controls.Add(this.lblProveedorRif);
            this.Controls.Add(this.lblProveedorNombre);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.btnSeleccionarProveedor);
            this.Controls.Add(this.btnNullify);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBack);
            this.Name = "frmCmpOperacionesDetail";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvList;
        private System.Windows.Forms.Label lblTitle;
        private MetroFramework.Controls.MetroLink btnBack;
        private MetroFramework.Controls.MetroLink btnDel;
        private MetroFramework.Controls.MetroLink btnAdd;
        private MetroFramework.Controls.MetroLink btnNullify;
        private MetroFramework.Controls.MetroLink btnPrint;
        private MetroFramework.Controls.MetroLink btnSave;
        private MetroFramework.Controls.MetroLink btnSeleccionarProveedor;
        private MetroFramework.Controls.MetroDateTime dtFecha;
        private System.Windows.Forms.Label lblProveedorNombre;
        private System.Windows.Forms.Label lblProveedorRif;
        private MetroFramework.Controls.MetroComboBox cmbTipoDocumento;
        private MetroFramework.Controls.MetroLabel lblNroDocumento;
        private MetroFramework.Controls.MetroTextBox txtNroDocumento;
        private MetroFramework.Controls.MetroLabel lblNroControl;
        private MetroFramework.Controls.MetroTextBox txtNroControl;
        private MetroFramework.Controls.MetroLabel lblTipoDocumento;
        private MetroFramework.Controls.MetroLabel lblItems;
        private MetroFramework.Controls.MetroLabel lblTotal;
        private MetroFramework.Controls.MetroLabel lblNroFacturaAfectada;
        private MetroFramework.Controls.MetroTextBox txtNroFacturaAfectada;
        private System.Windows.Forms.Label lblSubTitle;
        private MetroFramework.Controls.MetroLabel lblFechaDocumento;
        private System.Windows.Forms.ComboBox cmbCotizacion;
    }
}