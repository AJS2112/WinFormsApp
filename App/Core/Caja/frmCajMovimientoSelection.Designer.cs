namespace App.Core.Caja
{
    partial class frmCajMovimientoSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCajMovimientoSelection));
            this.btnSel = new MetroFramework.Controls.MetroLink();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new MetroFramework.Controls.MetroLink();
            this.cmbCotizacion = new System.Windows.Forms.ComboBox();
            this.txtTasa = new MetroFramework.Controls.MetroTextBox();
            this.lblTasa = new MetroFramework.Controls.MetroLabel();
            this.cmbInstrumento = new MetroFramework.Controls.MetroComboBox();
            this.lblInstrumento = new MetroFramework.Controls.MetroLabel();
            this.txtMonto = new MetroFramework.Controls.MetroTextBox();
            this.lblMonto = new MetroFramework.Controls.MetroLabel();
            this.cmbBanco = new MetroFramework.Controls.MetroComboBox();
            this.lblBanco = new MetroFramework.Controls.MetroLabel();
            this.lblNroOperacion = new MetroFramework.Controls.MetroLabel();
            this.txtNroOperacion = new MetroFramework.Controls.MetroTextBox();
            this.lblMoneda = new MetroFramework.Controls.MetroLabel();
            this.cmbCuenta = new MetroFramework.Controls.MetroComboBox();
            this.lblCuenta = new MetroFramework.Controls.MetroLabel();
            this.btnAdd = new MetroFramework.Controls.MetroLink();
            this.lblTotalDocumento = new System.Windows.Forms.Label();
            this.lblTotalSeleccionado = new System.Windows.Forms.Label();
            this.lblTotalResta = new System.Windows.Forms.Label();
            this.txtTotalResta = new System.Windows.Forms.Label();
            this.txtTotalSeleccionado = new System.Windows.Forms.Label();
            this.txtTotalDocumento = new System.Windows.Forms.Label();
            this.lblInstrumento0 = new System.Windows.Forms.Label();
            this.lblMonto0 = new System.Windows.Forms.Label();
            this.lblEliminar0 = new System.Windows.Forms.Label();
            this.lblEliminar1 = new System.Windows.Forms.Label();
            this.lblMonto1 = new System.Windows.Forms.Label();
            this.lblInstrumento1 = new System.Windows.Forms.Label();
            this.lblEliminar2 = new System.Windows.Forms.Label();
            this.lblMonto2 = new System.Windows.Forms.Label();
            this.lblInstrumento2 = new System.Windows.Forms.Label();
            this.lblEliminar3 = new System.Windows.Forms.Label();
            this.lblMonto3 = new System.Windows.Forms.Label();
            this.lblInstrumento3 = new System.Windows.Forms.Label();
            this.lblEliminar4 = new System.Windows.Forms.Label();
            this.lblMonto4 = new System.Windows.Forms.Label();
            this.lblInstrumento4 = new System.Windows.Forms.Label();
            this.lblEliminar5 = new System.Windows.Forms.Label();
            this.lblMonto5 = new System.Windows.Forms.Label();
            this.lblInstrumento5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSel
            // 
            this.btnSel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSel.Image = ((System.Drawing.Image)(resources.GetObject("btnSel.Image")));
            this.btnSel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSel.ImageSize = 32;
            this.btnSel.Location = new System.Drawing.Point(819, 20);
            this.btnSel.Name = "btnSel";
            this.btnSel.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnSel.NoFocusImage")));
            this.btnSel.Size = new System.Drawing.Size(77, 46);
            this.btnSel.TabIndex = 37;
            this.btnSel.Text = "Seleccionar";
            this.btnSel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSel.UseSelectable = true;
            this.btnSel.Click += new System.EventHandler(this.btnSel_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(64, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(392, 43);
            this.lblTitle.TabIndex = 36;
            this.lblTitle.Text = "Selección de Instrumento de Pago";
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
            this.btnBack.TabIndex = 35;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbCotizacion
            // 
            this.cmbCotizacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCotizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCotizacion.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCotizacion.FormattingEnabled = true;
            this.cmbCotizacion.Location = new System.Drawing.Point(70, 112);
            this.cmbCotizacion.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCotizacion.Name = "cmbCotizacion";
            this.cmbCotizacion.Size = new System.Drawing.Size(80, 29);
            this.cmbCotizacion.TabIndex = 52;
            this.cmbCotizacion.SelectedIndexChanged += new System.EventHandler(this.cmbCotizacion_SelectedIndexChanged);
            // 
            // txtTasa
            // 
            // 
            // 
            // 
            this.txtTasa.CustomButton.Image = null;
            this.txtTasa.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txtTasa.CustomButton.Name = "";
            this.txtTasa.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtTasa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTasa.CustomButton.TabIndex = 1;
            this.txtTasa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTasa.CustomButton.UseSelectable = true;
            this.txtTasa.CustomButton.Visible = false;
            this.txtTasa.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTasa.Lines = new string[0];
            this.txtTasa.Location = new System.Drawing.Point(165, 112);
            this.txtTasa.MaxLength = 32767;
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.PasswordChar = '\0';
            this.txtTasa.PromptText = "0,00";
            this.txtTasa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTasa.SelectedText = "";
            this.txtTasa.SelectionLength = 0;
            this.txtTasa.SelectionStart = 0;
            this.txtTasa.ShortcutsEnabled = true;
            this.txtTasa.Size = new System.Drawing.Size(120, 29);
            this.txtTasa.TabIndex = 53;
            this.txtTasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTasa.UseSelectable = true;
            this.txtTasa.WaterMark = "0,00";
            this.txtTasa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTasa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblTasa
            // 
            this.lblTasa.AutoSize = true;
            this.lblTasa.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblTasa.Location = new System.Drawing.Point(165, 93);
            this.lblTasa.Name = "lblTasa";
            this.lblTasa.Size = new System.Drawing.Size(28, 15);
            this.lblTasa.TabIndex = 54;
            this.lblTasa.Text = "Tasa";
            // 
            // cmbInstrumento
            // 
            this.cmbInstrumento.FormattingEnabled = true;
            this.cmbInstrumento.ItemHeight = 23;
            this.cmbInstrumento.Location = new System.Drawing.Point(70, 184);
            this.cmbInstrumento.Name = "cmbInstrumento";
            this.cmbInstrumento.Size = new System.Drawing.Size(215, 29);
            this.cmbInstrumento.TabIndex = 55;
            this.cmbInstrumento.UseSelectable = true;
            this.cmbInstrumento.SelectedValueChanged += new System.EventHandler(this.cmbInstrumento_SelectedValueChanged);
            // 
            // lblInstrumento
            // 
            this.lblInstrumento.AutoSize = true;
            this.lblInstrumento.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblInstrumento.Location = new System.Drawing.Point(71, 166);
            this.lblInstrumento.Name = "lblInstrumento";
            this.lblInstrumento.Size = new System.Drawing.Size(113, 15);
            this.lblInstrumento.TabIndex = 56;
            this.lblInstrumento.Text = "Instrumento de Pago";
            // 
            // txtMonto
            // 
            // 
            // 
            // 
            this.txtMonto.CustomButton.Image = null;
            this.txtMonto.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txtMonto.CustomButton.Name = "";
            this.txtMonto.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtMonto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMonto.CustomButton.TabIndex = 1;
            this.txtMonto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMonto.CustomButton.UseSelectable = true;
            this.txtMonto.CustomButton.Visible = false;
            this.txtMonto.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtMonto.Lines = new string[0];
            this.txtMonto.Location = new System.Drawing.Point(71, 249);
            this.txtMonto.MaxLength = 32767;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.PasswordChar = '\0';
            this.txtMonto.PromptText = "0,00";
            this.txtMonto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMonto.SelectedText = "";
            this.txtMonto.SelectionLength = 0;
            this.txtMonto.SelectionStart = 0;
            this.txtMonto.ShortcutsEnabled = true;
            this.txtMonto.Size = new System.Drawing.Size(120, 29);
            this.txtMonto.TabIndex = 57;
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonto.UseSelectable = true;
            this.txtMonto.WaterMark = "0,00";
            this.txtMonto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMonto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblMonto.Location = new System.Drawing.Point(71, 230);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(41, 15);
            this.lblMonto.TabIndex = 58;
            this.lblMonto.Text = "Monto";
            // 
            // cmbBanco
            // 
            this.cmbBanco.FormattingEnabled = true;
            this.cmbBanco.ItemHeight = 23;
            this.cmbBanco.Location = new System.Drawing.Point(70, 313);
            this.cmbBanco.Name = "cmbBanco";
            this.cmbBanco.Size = new System.Drawing.Size(215, 29);
            this.cmbBanco.TabIndex = 59;
            this.cmbBanco.UseSelectable = true;
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblBanco.Location = new System.Drawing.Point(71, 295);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(38, 15);
            this.lblBanco.TabIndex = 60;
            this.lblBanco.Text = "Banco";
            // 
            // lblNroOperacion
            // 
            this.lblNroOperacion.AutoSize = true;
            this.lblNroOperacion.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblNroOperacion.Location = new System.Drawing.Point(70, 360);
            this.lblNroOperacion.Name = "lblNroOperacion";
            this.lblNroOperacion.Size = new System.Drawing.Size(82, 15);
            this.lblNroOperacion.TabIndex = 62;
            this.lblNroOperacion.Text = "Nro Operación";
            // 
            // txtNroOperacion
            // 
            // 
            // 
            // 
            this.txtNroOperacion.CustomButton.Image = null;
            this.txtNroOperacion.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.txtNroOperacion.CustomButton.Name = "";
            this.txtNroOperacion.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNroOperacion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNroOperacion.CustomButton.TabIndex = 1;
            this.txtNroOperacion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNroOperacion.CustomButton.UseSelectable = true;
            this.txtNroOperacion.CustomButton.Visible = false;
            this.txtNroOperacion.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNroOperacion.Lines = new string[0];
            this.txtNroOperacion.Location = new System.Drawing.Point(70, 378);
            this.txtNroOperacion.MaxLength = 32767;
            this.txtNroOperacion.Name = "txtNroOperacion";
            this.txtNroOperacion.PasswordChar = '\0';
            this.txtNroOperacion.PromptText = "Código";
            this.txtNroOperacion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNroOperacion.SelectedText = "";
            this.txtNroOperacion.SelectionLength = 0;
            this.txtNroOperacion.SelectionStart = 0;
            this.txtNroOperacion.ShortcutsEnabled = true;
            this.txtNroOperacion.Size = new System.Drawing.Size(209, 29);
            this.txtNroOperacion.TabIndex = 61;
            this.txtNroOperacion.UseSelectable = true;
            this.txtNroOperacion.WaterMark = "Código";
            this.txtNroOperacion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNroOperacion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblMoneda.Location = new System.Drawing.Point(70, 93);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(49, 15);
            this.lblMoneda.TabIndex = 63;
            this.lblMoneda.Text = "Moneda";
            // 
            // cmbCuenta
            // 
            this.cmbCuenta.FormattingEnabled = true;
            this.cmbCuenta.ItemHeight = 23;
            this.cmbCuenta.Location = new System.Drawing.Point(71, 313);
            this.cmbCuenta.Name = "cmbCuenta";
            this.cmbCuenta.Size = new System.Drawing.Size(214, 29);
            this.cmbCuenta.TabIndex = 64;
            this.cmbCuenta.UseSelectable = true;
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblCuenta.Location = new System.Drawing.Point(72, 295);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(87, 15);
            this.lblCuenta.TabIndex = 65;
            this.lblCuenta.Text = "Cuenta Bancaria";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.ImageSize = 32;
            this.btnAdd.Location = new System.Drawing.Point(422, 112);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.NoFocusImage")));
            this.btnAdd.Size = new System.Drawing.Size(56, 46);
            this.btnAdd.TabIndex = 66;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTotalDocumento
            // 
            this.lblTotalDocumento.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDocumento.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTotalDocumento.Location = new System.Drawing.Point(536, 112);
            this.lblTotalDocumento.Name = "lblTotalDocumento";
            this.lblTotalDocumento.Size = new System.Drawing.Size(192, 43);
            this.lblTotalDocumento.TabIndex = 73;
            this.lblTotalDocumento.Text = "Total Documento";
            // 
            // lblTotalSeleccionado
            // 
            this.lblTotalSeleccionado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSeleccionado.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblTotalSeleccionado.Location = new System.Drawing.Point(536, 158);
            this.lblTotalSeleccionado.Name = "lblTotalSeleccionado";
            this.lblTotalSeleccionado.Size = new System.Drawing.Size(192, 43);
            this.lblTotalSeleccionado.TabIndex = 74;
            this.lblTotalSeleccionado.Text = "Total Seleccionado";
            // 
            // lblTotalResta
            // 
            this.lblTotalResta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalResta.ForeColor = System.Drawing.Color.Crimson;
            this.lblTotalResta.Location = new System.Drawing.Point(536, 205);
            this.lblTotalResta.Name = "lblTotalResta";
            this.lblTotalResta.Size = new System.Drawing.Size(192, 43);
            this.lblTotalResta.TabIndex = 75;
            this.lblTotalResta.Text = "Resta";
            // 
            // txtTotalResta
            // 
            this.txtTotalResta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalResta.ForeColor = System.Drawing.Color.Crimson;
            this.txtTotalResta.Location = new System.Drawing.Point(734, 205);
            this.txtTotalResta.Name = "txtTotalResta";
            this.txtTotalResta.Size = new System.Drawing.Size(162, 43);
            this.txtTotalResta.TabIndex = 78;
            this.txtTotalResta.Text = "0,00";
            this.txtTotalResta.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTotalSeleccionado
            // 
            this.txtTotalSeleccionado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSeleccionado.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtTotalSeleccionado.Location = new System.Drawing.Point(734, 158);
            this.txtTotalSeleccionado.Name = "txtTotalSeleccionado";
            this.txtTotalSeleccionado.Size = new System.Drawing.Size(162, 43);
            this.txtTotalSeleccionado.TabIndex = 77;
            this.txtTotalSeleccionado.Text = "0,00";
            this.txtTotalSeleccionado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTotalDocumento
            // 
            this.txtTotalDocumento.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDocumento.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtTotalDocumento.Location = new System.Drawing.Point(729, 112);
            this.txtTotalDocumento.Name = "txtTotalDocumento";
            this.txtTotalDocumento.Size = new System.Drawing.Size(167, 43);
            this.txtTotalDocumento.TabIndex = 76;
            this.txtTotalDocumento.Text = "0,00";
            this.txtTotalDocumento.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblInstrumento0
            // 
            this.lblInstrumento0.AutoSize = true;
            this.lblInstrumento0.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrumento0.Location = new System.Drawing.Point(538, 268);
            this.lblInstrumento0.Name = "lblInstrumento0";
            this.lblInstrumento0.Size = new System.Drawing.Size(98, 17);
            this.lblInstrumento0.TabIndex = 79;
            this.lblInstrumento0.Text = "lblInstrumento";
            this.lblInstrumento0.Visible = false;
            // 
            // lblMonto0
            // 
            this.lblMonto0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonto0.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto0.Location = new System.Drawing.Point(750, 268);
            this.lblMonto0.Name = "lblMonto0";
            this.lblMonto0.Size = new System.Drawing.Size(98, 17);
            this.lblMonto0.TabIndex = 80;
            this.lblMonto0.Text = "0,00";
            this.lblMonto0.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblMonto0.Visible = false;
            // 
            // lblEliminar0
            // 
            this.lblEliminar0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEliminar0.AutoSize = true;
            this.lblEliminar0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEliminar0.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar0.Location = new System.Drawing.Point(880, 268);
            this.lblEliminar0.Name = "lblEliminar0";
            this.lblEliminar0.Size = new System.Drawing.Size(16, 17);
            this.lblEliminar0.TabIndex = 81;
            this.lblEliminar0.Text = "X";
            this.lblEliminar0.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblEliminar0.Visible = false;
            this.lblEliminar0.Click += new System.EventHandler(this.lblEliminar0_Click);
            // 
            // lblEliminar1
            // 
            this.lblEliminar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEliminar1.AutoSize = true;
            this.lblEliminar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEliminar1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar1.Location = new System.Drawing.Point(880, 301);
            this.lblEliminar1.Name = "lblEliminar1";
            this.lblEliminar1.Size = new System.Drawing.Size(16, 17);
            this.lblEliminar1.TabIndex = 84;
            this.lblEliminar1.Text = "X";
            this.lblEliminar1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblEliminar1.Visible = false;
            this.lblEliminar1.Click += new System.EventHandler(this.lblEliminar1_Click);
            // 
            // lblMonto1
            // 
            this.lblMonto1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonto1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto1.Location = new System.Drawing.Point(750, 301);
            this.lblMonto1.Name = "lblMonto1";
            this.lblMonto1.Size = new System.Drawing.Size(98, 17);
            this.lblMonto1.TabIndex = 83;
            this.lblMonto1.Text = "0,00";
            this.lblMonto1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblMonto1.Visible = false;
            // 
            // lblInstrumento1
            // 
            this.lblInstrumento1.AutoSize = true;
            this.lblInstrumento1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrumento1.Location = new System.Drawing.Point(538, 301);
            this.lblInstrumento1.Name = "lblInstrumento1";
            this.lblInstrumento1.Size = new System.Drawing.Size(98, 17);
            this.lblInstrumento1.TabIndex = 82;
            this.lblInstrumento1.Text = "lblInstrumento";
            this.lblInstrumento1.Visible = false;
            // 
            // lblEliminar2
            // 
            this.lblEliminar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEliminar2.AutoSize = true;
            this.lblEliminar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEliminar2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar2.Location = new System.Drawing.Point(880, 332);
            this.lblEliminar2.Name = "lblEliminar2";
            this.lblEliminar2.Size = new System.Drawing.Size(16, 17);
            this.lblEliminar2.TabIndex = 87;
            this.lblEliminar2.Text = "X";
            this.lblEliminar2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblEliminar2.Visible = false;
            this.lblEliminar2.Click += new System.EventHandler(this.lblEliminar2_Click);
            // 
            // lblMonto2
            // 
            this.lblMonto2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonto2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto2.Location = new System.Drawing.Point(750, 332);
            this.lblMonto2.Name = "lblMonto2";
            this.lblMonto2.Size = new System.Drawing.Size(98, 17);
            this.lblMonto2.TabIndex = 86;
            this.lblMonto2.Text = "0,00";
            this.lblMonto2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblMonto2.Visible = false;
            // 
            // lblInstrumento2
            // 
            this.lblInstrumento2.AutoSize = true;
            this.lblInstrumento2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrumento2.Location = new System.Drawing.Point(538, 332);
            this.lblInstrumento2.Name = "lblInstrumento2";
            this.lblInstrumento2.Size = new System.Drawing.Size(98, 17);
            this.lblInstrumento2.TabIndex = 85;
            this.lblInstrumento2.Text = "lblInstrumento";
            this.lblInstrumento2.Visible = false;
            // 
            // lblEliminar3
            // 
            this.lblEliminar3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEliminar3.AutoSize = true;
            this.lblEliminar3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEliminar3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar3.Location = new System.Drawing.Point(880, 366);
            this.lblEliminar3.Name = "lblEliminar3";
            this.lblEliminar3.Size = new System.Drawing.Size(16, 17);
            this.lblEliminar3.TabIndex = 90;
            this.lblEliminar3.Text = "X";
            this.lblEliminar3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblEliminar3.Visible = false;
            this.lblEliminar3.Click += new System.EventHandler(this.lblEliminar3_Click);
            // 
            // lblMonto3
            // 
            this.lblMonto3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonto3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto3.Location = new System.Drawing.Point(750, 366);
            this.lblMonto3.Name = "lblMonto3";
            this.lblMonto3.Size = new System.Drawing.Size(98, 17);
            this.lblMonto3.TabIndex = 89;
            this.lblMonto3.Text = "0,00";
            this.lblMonto3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblMonto3.Visible = false;
            // 
            // lblInstrumento3
            // 
            this.lblInstrumento3.AutoSize = true;
            this.lblInstrumento3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrumento3.Location = new System.Drawing.Point(538, 366);
            this.lblInstrumento3.Name = "lblInstrumento3";
            this.lblInstrumento3.Size = new System.Drawing.Size(98, 17);
            this.lblInstrumento3.TabIndex = 88;
            this.lblInstrumento3.Text = "lblInstrumento";
            this.lblInstrumento3.Visible = false;
            // 
            // lblEliminar4
            // 
            this.lblEliminar4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEliminar4.AutoSize = true;
            this.lblEliminar4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEliminar4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar4.Location = new System.Drawing.Point(880, 397);
            this.lblEliminar4.Name = "lblEliminar4";
            this.lblEliminar4.Size = new System.Drawing.Size(16, 17);
            this.lblEliminar4.TabIndex = 93;
            this.lblEliminar4.Text = "X";
            this.lblEliminar4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblEliminar4.Visible = false;
            this.lblEliminar4.Click += new System.EventHandler(this.lblEliminar4_Click);
            // 
            // lblMonto4
            // 
            this.lblMonto4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonto4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto4.Location = new System.Drawing.Point(750, 397);
            this.lblMonto4.Name = "lblMonto4";
            this.lblMonto4.Size = new System.Drawing.Size(98, 17);
            this.lblMonto4.TabIndex = 92;
            this.lblMonto4.Text = "0,00";
            this.lblMonto4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblMonto4.Visible = false;
            // 
            // lblInstrumento4
            // 
            this.lblInstrumento4.AutoSize = true;
            this.lblInstrumento4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrumento4.Location = new System.Drawing.Point(538, 397);
            this.lblInstrumento4.Name = "lblInstrumento4";
            this.lblInstrumento4.Size = new System.Drawing.Size(98, 17);
            this.lblInstrumento4.TabIndex = 91;
            this.lblInstrumento4.Text = "lblInstrumento";
            this.lblInstrumento4.Visible = false;
            // 
            // lblEliminar5
            // 
            this.lblEliminar5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEliminar5.AutoSize = true;
            this.lblEliminar5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEliminar5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar5.Location = new System.Drawing.Point(880, 431);
            this.lblEliminar5.Name = "lblEliminar5";
            this.lblEliminar5.Size = new System.Drawing.Size(16, 17);
            this.lblEliminar5.TabIndex = 96;
            this.lblEliminar5.Text = "X";
            this.lblEliminar5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblEliminar5.Visible = false;
            this.lblEliminar5.Click += new System.EventHandler(this.lblEliminar5_Click);
            // 
            // lblMonto5
            // 
            this.lblMonto5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonto5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto5.Location = new System.Drawing.Point(750, 431);
            this.lblMonto5.Name = "lblMonto5";
            this.lblMonto5.Size = new System.Drawing.Size(98, 17);
            this.lblMonto5.TabIndex = 95;
            this.lblMonto5.Text = "0,00";
            this.lblMonto5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblMonto5.Visible = false;
            // 
            // lblInstrumento5
            // 
            this.lblInstrumento5.AutoSize = true;
            this.lblInstrumento5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrumento5.Location = new System.Drawing.Point(538, 431);
            this.lblInstrumento5.Name = "lblInstrumento5";
            this.lblInstrumento5.Size = new System.Drawing.Size(98, 17);
            this.lblInstrumento5.TabIndex = 94;
            this.lblInstrumento5.Text = "lblInstrumento";
            this.lblInstrumento5.Visible = false;
            // 
            // frmCajMovimientoSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 515);
            this.Controls.Add(this.lblEliminar5);
            this.Controls.Add(this.lblMonto5);
            this.Controls.Add(this.lblInstrumento5);
            this.Controls.Add(this.lblEliminar4);
            this.Controls.Add(this.lblMonto4);
            this.Controls.Add(this.lblInstrumento4);
            this.Controls.Add(this.lblEliminar3);
            this.Controls.Add(this.lblMonto3);
            this.Controls.Add(this.lblInstrumento3);
            this.Controls.Add(this.lblEliminar2);
            this.Controls.Add(this.lblMonto2);
            this.Controls.Add(this.lblInstrumento2);
            this.Controls.Add(this.lblEliminar1);
            this.Controls.Add(this.lblMonto1);
            this.Controls.Add(this.lblInstrumento1);
            this.Controls.Add(this.lblEliminar0);
            this.Controls.Add(this.lblMonto0);
            this.Controls.Add(this.lblInstrumento0);
            this.Controls.Add(this.txtTotalResta);
            this.Controls.Add(this.txtTotalSeleccionado);
            this.Controls.Add(this.txtTotalDocumento);
            this.Controls.Add(this.lblTotalResta);
            this.Controls.Add(this.lblTotalSeleccionado);
            this.Controls.Add(this.lblTotalDocumento);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbCuenta);
            this.Controls.Add(this.lblCuenta);
            this.Controls.Add(this.lblMoneda);
            this.Controls.Add(this.lblNroOperacion);
            this.Controls.Add(this.txtNroOperacion);
            this.Controls.Add(this.cmbBanco);
            this.Controls.Add(this.lblBanco);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.cmbInstrumento);
            this.Controls.Add(this.lblInstrumento);
            this.Controls.Add(this.txtTasa);
            this.Controls.Add(this.lblTasa);
            this.Controls.Add(this.cmbCotizacion);
            this.Controls.Add(this.btnSel);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBack);
            this.Name = "frmCajMovimientoSelection";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink btnSel;
        private System.Windows.Forms.Label lblTitle;
        private MetroFramework.Controls.MetroLink btnBack;
        private System.Windows.Forms.ComboBox cmbCotizacion;
        private MetroFramework.Controls.MetroTextBox txtTasa;
        private MetroFramework.Controls.MetroLabel lblTasa;
        private MetroFramework.Controls.MetroComboBox cmbInstrumento;
        private MetroFramework.Controls.MetroLabel lblInstrumento;
        private MetroFramework.Controls.MetroTextBox txtMonto;
        private MetroFramework.Controls.MetroLabel lblMonto;
        private MetroFramework.Controls.MetroComboBox cmbBanco;
        private MetroFramework.Controls.MetroLabel lblBanco;
        private MetroFramework.Controls.MetroLabel lblNroOperacion;
        private MetroFramework.Controls.MetroTextBox txtNroOperacion;
        private MetroFramework.Controls.MetroLabel lblMoneda;
        private MetroFramework.Controls.MetroComboBox cmbCuenta;
        private MetroFramework.Controls.MetroLabel lblCuenta;
        private MetroFramework.Controls.MetroLink btnAdd;
        private System.Windows.Forms.Label lblTotalDocumento;
        private System.Windows.Forms.Label lblTotalSeleccionado;
        private System.Windows.Forms.Label lblTotalResta;
        private System.Windows.Forms.Label txtTotalResta;
        private System.Windows.Forms.Label txtTotalSeleccionado;
        private System.Windows.Forms.Label txtTotalDocumento;
        private System.Windows.Forms.Label lblInstrumento0;
        private System.Windows.Forms.Label lblMonto0;
        private System.Windows.Forms.Label lblEliminar0;
        private System.Windows.Forms.Label lblEliminar1;
        private System.Windows.Forms.Label lblMonto1;
        private System.Windows.Forms.Label lblInstrumento1;
        private System.Windows.Forms.Label lblEliminar2;
        private System.Windows.Forms.Label lblMonto2;
        private System.Windows.Forms.Label lblInstrumento2;
        private System.Windows.Forms.Label lblEliminar3;
        private System.Windows.Forms.Label lblMonto3;
        private System.Windows.Forms.Label lblInstrumento3;
        private System.Windows.Forms.Label lblEliminar4;
        private System.Windows.Forms.Label lblMonto4;
        private System.Windows.Forms.Label lblInstrumento4;
        private System.Windows.Forms.Label lblEliminar5;
        private System.Windows.Forms.Label lblMonto5;
        private System.Windows.Forms.Label lblInstrumento5;
    }
}