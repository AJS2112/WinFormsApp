namespace App.Core.Caja
{
    partial class frmCajOperacionesDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCajOperacionesDetail));
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new MetroFramework.Controls.MetroLink();
            this.btnNullify = new MetroFramework.Controls.MetroLink();
            this.btnPrint = new MetroFramework.Controls.MetroLink();
            this.btnSave = new MetroFramework.Controls.MetroLink();
            this.lblFechaDocumento = new MetroFramework.Controls.MetroLabel();
            this.dtFecha = new MetroFramework.Controls.MetroDateTime();
            this.lblDescripcion = new MetroFramework.Controls.MetroLabel();
            this.txtDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.txtMonto = new MetroFramework.Controls.MetroTextBox();
            this.lblMonto = new MetroFramework.Controls.MetroLabel();
            this.cmbInstrumento = new MetroFramework.Controls.MetroComboBox();
            this.lblInstrumento = new MetroFramework.Controls.MetroLabel();
            this.cmbCuenta = new MetroFramework.Controls.MetroComboBox();
            this.lblCuenta = new MetroFramework.Controls.MetroLabel();
            this.lblNroOperacion = new MetroFramework.Controls.MetroLabel();
            this.txtNroOperacion = new MetroFramework.Controls.MetroTextBox();
            this.cmbBanco = new MetroFramework.Controls.MetroComboBox();
            this.lblBanco = new MetroFramework.Controls.MetroLabel();
            this.lblMoneda = new MetroFramework.Controls.MetroLabel();
            this.txtTasa = new MetroFramework.Controls.MetroTextBox();
            this.lblTasa = new MetroFramework.Controls.MetroLabel();
            this.cmbCotizacion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSubTitle.Location = new System.Drawing.Point(71, 54);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(186, 24);
            this.lblSubTitle.TabIndex = 71;
            this.lblSubTitle.Text = "Operacion Nro";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(64, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(517, 35);
            this.lblTitle.TabIndex = 70;
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
            this.btnBack.TabIndex = 69;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNullify
            // 
            this.btnNullify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNullify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNullify.Image = ((System.Drawing.Image)(resources.GetObject("btnNullify.Image")));
            this.btnNullify.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNullify.ImageSize = 32;
            this.btnNullify.Location = new System.Drawing.Point(724, 20);
            this.btnNullify.Name = "btnNullify";
            this.btnNullify.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnNullify.NoFocusImage")));
            this.btnNullify.Size = new System.Drawing.Size(65, 46);
            this.btnNullify.TabIndex = 74;
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
            this.btnPrint.Location = new System.Drawing.Point(795, 20);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.NoFocusImage")));
            this.btnPrint.Size = new System.Drawing.Size(65, 46);
            this.btnPrint.TabIndex = 73;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.ImageSize = 32;
            this.btnSave.Location = new System.Drawing.Point(866, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnSave.NoFocusImage")));
            this.btnSave.Size = new System.Drawing.Size(65, 46);
            this.btnSave.TabIndex = 72;
            this.btnSave.Text = "Guardar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblFechaDocumento
            // 
            this.lblFechaDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaDocumento.AutoSize = true;
            this.lblFechaDocumento.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblFechaDocumento.Location = new System.Drawing.Point(818, 112);
            this.lblFechaDocumento.Name = "lblFechaDocumento";
            this.lblFechaDocumento.Size = new System.Drawing.Size(36, 15);
            this.lblFechaDocumento.TabIndex = 76;
            this.lblFechaDocumento.Text = "Fecha";
            // 
            // dtFecha
            // 
            this.dtFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFecha.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(818, 130);
            this.dtFecha.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(89, 25);
            this.dtFecha.TabIndex = 75;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblDescripcion.Location = new System.Drawing.Point(70, 182);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(64, 15);
            this.lblDescripcion.TabIndex = 78;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            // 
            // 
            // 
            this.txtDescripcion.CustomButton.Image = null;
            this.txtDescripcion.CustomButton.Location = new System.Drawing.Point(815, 1);
            this.txtDescripcion.CustomButton.Name = "";
            this.txtDescripcion.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescripcion.CustomButton.TabIndex = 1;
            this.txtDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescripcion.CustomButton.UseSelectable = true;
            this.txtDescripcion.CustomButton.Visible = false;
            this.txtDescripcion.Lines = new string[0];
            this.txtDescripcion.Location = new System.Drawing.Point(70, 200);
            this.txtDescripcion.MaxLength = 20;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.SelectionLength = 0;
            this.txtDescripcion.SelectionStart = 0;
            this.txtDescripcion.ShortcutsEnabled = true;
            this.txtDescripcion.Size = new System.Drawing.Size(839, 25);
            this.txtDescripcion.TabIndex = 77;
            this.txtDescripcion.UseSelectable = true;
            this.txtDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtMonto.Location = new System.Drawing.Point(70, 271);
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
            this.txtMonto.TabIndex = 81;
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
            this.lblMonto.Location = new System.Drawing.Point(70, 252);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(41, 15);
            this.lblMonto.TabIndex = 82;
            this.lblMonto.Text = "Monto";
            // 
            // cmbInstrumento
            // 
            this.cmbInstrumento.FormattingEnabled = true;
            this.cmbInstrumento.ItemHeight = 23;
            this.cmbInstrumento.Location = new System.Drawing.Point(217, 271);
            this.cmbInstrumento.Name = "cmbInstrumento";
            this.cmbInstrumento.Size = new System.Drawing.Size(215, 29);
            this.cmbInstrumento.TabIndex = 79;
            this.cmbInstrumento.UseSelectable = true;
            this.cmbInstrumento.SelectedValueChanged += new System.EventHandler(this.cmbInstrumento_SelectedValueChanged);
            // 
            // lblInstrumento
            // 
            this.lblInstrumento.AutoSize = true;
            this.lblInstrumento.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblInstrumento.Location = new System.Drawing.Point(218, 253);
            this.lblInstrumento.Name = "lblInstrumento";
            this.lblInstrumento.Size = new System.Drawing.Size(113, 15);
            this.lblInstrumento.TabIndex = 80;
            this.lblInstrumento.Text = "Instrumento de Pago";
            // 
            // cmbCuenta
            // 
            this.cmbCuenta.FormattingEnabled = true;
            this.cmbCuenta.ItemHeight = 23;
            this.cmbCuenta.Location = new System.Drawing.Point(458, 271);
            this.cmbCuenta.Name = "cmbCuenta";
            this.cmbCuenta.Size = new System.Drawing.Size(214, 29);
            this.cmbCuenta.TabIndex = 87;
            this.cmbCuenta.UseSelectable = true;
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblCuenta.Location = new System.Drawing.Point(459, 253);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(87, 15);
            this.lblCuenta.TabIndex = 88;
            this.lblCuenta.Text = "Cuenta Bancaria";
            // 
            // lblNroOperacion
            // 
            this.lblNroOperacion.AutoSize = true;
            this.lblNroOperacion.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblNroOperacion.Location = new System.Drawing.Point(700, 252);
            this.lblNroOperacion.Name = "lblNroOperacion";
            this.lblNroOperacion.Size = new System.Drawing.Size(82, 15);
            this.lblNroOperacion.TabIndex = 86;
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
            this.txtNroOperacion.Location = new System.Drawing.Point(698, 271);
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
            this.txtNroOperacion.TabIndex = 85;
            this.txtNroOperacion.UseSelectable = true;
            this.txtNroOperacion.WaterMark = "Código";
            this.txtNroOperacion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNroOperacion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbBanco
            // 
            this.cmbBanco.FormattingEnabled = true;
            this.cmbBanco.ItemHeight = 23;
            this.cmbBanco.Location = new System.Drawing.Point(457, 271);
            this.cmbBanco.Name = "cmbBanco";
            this.cmbBanco.Size = new System.Drawing.Size(215, 29);
            this.cmbBanco.TabIndex = 83;
            this.cmbBanco.UseSelectable = true;
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblBanco.Location = new System.Drawing.Point(458, 253);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(38, 15);
            this.lblBanco.TabIndex = 84;
            this.lblBanco.Text = "Banco";
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblMoneda.Location = new System.Drawing.Point(70, 111);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(49, 15);
            this.lblMoneda.TabIndex = 92;
            this.lblMoneda.Text = "Moneda";
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
            this.txtTasa.Location = new System.Drawing.Point(165, 130);
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
            this.txtTasa.TabIndex = 90;
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
            this.lblTasa.Location = new System.Drawing.Point(165, 111);
            this.lblTasa.Name = "lblTasa";
            this.lblTasa.Size = new System.Drawing.Size(28, 15);
            this.lblTasa.TabIndex = 91;
            this.lblTasa.Text = "Tasa";
            // 
            // cmbCotizacion
            // 
            this.cmbCotizacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCotizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCotizacion.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCotizacion.FormattingEnabled = true;
            this.cmbCotizacion.Location = new System.Drawing.Point(70, 130);
            this.cmbCotizacion.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCotizacion.Name = "cmbCotizacion";
            this.cmbCotizacion.Size = new System.Drawing.Size(80, 29);
            this.cmbCotizacion.TabIndex = 89;
            this.cmbCotizacion.SelectedIndexChanged += new System.EventHandler(this.cmbCotizacion_SelectedIndexChanged);
            // 
            // frmCajOperacionesDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 338);
            this.Controls.Add(this.lblMoneda);
            this.Controls.Add(this.txtTasa);
            this.Controls.Add(this.lblTasa);
            this.Controls.Add(this.cmbCotizacion);
            this.Controls.Add(this.cmbCuenta);
            this.Controls.Add(this.lblCuenta);
            this.Controls.Add(this.lblNroOperacion);
            this.Controls.Add(this.txtNroOperacion);
            this.Controls.Add(this.cmbBanco);
            this.Controls.Add(this.lblBanco);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.cmbInstrumento);
            this.Controls.Add(this.lblInstrumento);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblFechaDocumento);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.btnNullify);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBack);
            this.Name = "frmCajOperacionesDetail";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
        private MetroFramework.Controls.MetroLink btnBack;
        private MetroFramework.Controls.MetroLink btnNullify;
        private MetroFramework.Controls.MetroLink btnPrint;
        private MetroFramework.Controls.MetroLink btnSave;
        private MetroFramework.Controls.MetroLabel lblFechaDocumento;
        private MetroFramework.Controls.MetroDateTime dtFecha;
        private MetroFramework.Controls.MetroLabel lblDescripcion;
        private MetroFramework.Controls.MetroTextBox txtDescripcion;
        private MetroFramework.Controls.MetroTextBox txtMonto;
        private MetroFramework.Controls.MetroLabel lblMonto;
        private MetroFramework.Controls.MetroComboBox cmbInstrumento;
        private MetroFramework.Controls.MetroLabel lblInstrumento;
        private MetroFramework.Controls.MetroComboBox cmbCuenta;
        private MetroFramework.Controls.MetroLabel lblCuenta;
        private MetroFramework.Controls.MetroLabel lblNroOperacion;
        private MetroFramework.Controls.MetroTextBox txtNroOperacion;
        private MetroFramework.Controls.MetroComboBox cmbBanco;
        private MetroFramework.Controls.MetroLabel lblBanco;
        private MetroFramework.Controls.MetroLabel lblMoneda;
        private MetroFramework.Controls.MetroTextBox txtTasa;
        private MetroFramework.Controls.MetroLabel lblTasa;
        private System.Windows.Forms.ComboBox cmbCotizacion;
    }
}