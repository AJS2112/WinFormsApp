namespace App.Core.Inventario
{
    partial class frmInvProductosDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvProductosDetail));
            this.cmbCategoria = new MetroFramework.Controls.MetroComboBox();
            this.lblCategoria = new MetroFramework.Controls.MetroLabel();
            this.lblCosto = new MetroFramework.Controls.MetroLabel();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new MetroFramework.Controls.MetroLink();
            this.btnBack = new MetroFramework.Controls.MetroLink();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.lblCodigo = new MetroFramework.Controls.MetroLabel();
            this.txtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.cmbUnidad = new MetroFramework.Controls.MetroComboBox();
            this.lblUnidad = new MetroFramework.Controls.MetroLabel();
            this.lblExistencia = new MetroFramework.Controls.MetroLabel();
            this.lblUtilidad = new MetroFramework.Controls.MetroLabel();
            this.lblPrecio = new MetroFramework.Controls.MetroLabel();
            this.lblImpuesto = new MetroFramework.Controls.MetroLabel();
            this.txtUtilidad = new MetroFramework.Controls.MetroTextBox();
            this.txtCostoMoneda = new MetroFramework.Controls.MetroTextBox();
            this.txtPrecioMoneda = new MetroFramework.Controls.MetroTextBox();
            this.cmbImpuesto = new MetroFramework.Controls.MetroComboBox();
            this.txtExistencia = new MetroFramework.Controls.MetroTextBox();
            this.cmbCotizacion = new System.Windows.Forms.ComboBox();
            this.txtPctComision = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.checkInactivo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.ItemHeight = 23;
            this.cmbCategoria.Location = new System.Drawing.Point(285, 196);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(250, 29);
            this.cmbCategoria.TabIndex = 2;
            this.cmbCategoria.UseSelectable = true;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblCategoria.Location = new System.Drawing.Point(286, 178);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(56, 15);
            this.lblCategoria.TabIndex = 35;
            this.lblCategoria.Text = "Categoría";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblCosto.Location = new System.Drawing.Point(174, 258);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(37, 15);
            this.lblCosto.TabIndex = 34;
            this.lblCosto.Text = "Costo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblNombre.Location = new System.Drawing.Point(69, 95);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 15);
            this.lblNombre.TabIndex = 33;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(64, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(690, 43);
            this.lblTitle.TabIndex = 32;
            this.lblTitle.Text = "Producto";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.ImageSize = 32;
            this.btnSave.Location = new System.Drawing.Point(763, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnSave.NoFocusImage")));
            this.btnSave.Size = new System.Drawing.Size(56, 46);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Guardar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnBack.TabIndex = 30;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(710, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(70, 117);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PromptText = "Nombre";
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(738, 29);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMark = "Nombre";
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.General_KeyDown);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblCodigo.Location = new System.Drawing.Point(70, 178);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(44, 15);
            this.lblCodigo.TabIndex = 38;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            // 
            // 
            // 
            this.txtCodigo.CustomButton.Image = null;
            this.txtCodigo.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.txtCodigo.CustomButton.Name = "";
            this.txtCodigo.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigo.CustomButton.TabIndex = 1;
            this.txtCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigo.CustomButton.UseSelectable = true;
            this.txtCodigo.CustomButton.Visible = false;
            this.txtCodigo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCodigo.Lines = new string[0];
            this.txtCodigo.Location = new System.Drawing.Point(70, 196);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.PromptText = "Código";
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.ShortcutsEnabled = true;
            this.txtCodigo.Size = new System.Drawing.Size(209, 29);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.UseSelectable = true;
            this.txtCodigo.WaterMark = "Código";
            this.txtCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.General_KeyDown);
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.FormattingEnabled = true;
            this.cmbUnidad.ItemHeight = 23;
            this.cmbUnidad.Location = new System.Drawing.Point(541, 196);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(141, 29);
            this.cmbUnidad.TabIndex = 3;
            this.cmbUnidad.UseSelectable = true;
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblUnidad.Location = new System.Drawing.Point(542, 178);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(43, 15);
            this.lblUnidad.TabIndex = 39;
            this.lblUnidad.Text = "Unidad";
            // 
            // lblExistencia
            // 
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblExistencia.Location = new System.Drawing.Point(688, 178);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(54, 15);
            this.lblExistencia.TabIndex = 42;
            this.lblExistencia.Text = "Existencia";
            // 
            // lblUtilidad
            // 
            this.lblUtilidad.AutoSize = true;
            this.lblUtilidad.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblUtilidad.Location = new System.Drawing.Point(300, 258);
            this.lblUtilidad.Name = "lblUtilidad";
            this.lblUtilidad.Size = new System.Drawing.Size(57, 15);
            this.lblUtilidad.TabIndex = 44;
            this.lblUtilidad.Text = "% Utilidad";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblPrecio.Location = new System.Drawing.Point(402, 258);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(38, 15);
            this.lblPrecio.TabIndex = 46;
            this.lblPrecio.Text = "Precio";
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblImpuesto.Location = new System.Drawing.Point(541, 258);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(36, 15);
            this.lblImpuesto.TabIndex = 47;
            this.lblImpuesto.Text = "% IVA";
            // 
            // txtUtilidad
            // 
            // 
            // 
            // 
            this.txtUtilidad.CustomButton.Image = null;
            this.txtUtilidad.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.txtUtilidad.CustomButton.Name = "";
            this.txtUtilidad.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtUtilidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUtilidad.CustomButton.TabIndex = 1;
            this.txtUtilidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUtilidad.CustomButton.UseSelectable = true;
            this.txtUtilidad.CustomButton.Visible = false;
            this.txtUtilidad.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUtilidad.Lines = new string[0];
            this.txtUtilidad.Location = new System.Drawing.Point(300, 277);
            this.txtUtilidad.MaxLength = 32767;
            this.txtUtilidad.Name = "txtUtilidad";
            this.txtUtilidad.PasswordChar = '\0';
            this.txtUtilidad.PromptText = "0,00";
            this.txtUtilidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUtilidad.SelectedText = "";
            this.txtUtilidad.SelectionLength = 0;
            this.txtUtilidad.SelectionStart = 0;
            this.txtUtilidad.ShortcutsEnabled = true;
            this.txtUtilidad.Size = new System.Drawing.Size(80, 29);
            this.txtUtilidad.TabIndex = 7;
            this.txtUtilidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUtilidad.UseSelectable = true;
            this.txtUtilidad.WaterMark = "0,00";
            this.txtUtilidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUtilidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUtilidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.General_KeyDown);
            this.txtUtilidad.Validated += new System.EventHandler(this.txtUtilidad_Validated);
            // 
            // txtCostoMoneda
            // 
            // 
            // 
            // 
            this.txtCostoMoneda.CustomButton.Image = null;
            this.txtCostoMoneda.CustomButton.Location = new System.Drawing.Point(77, 1);
            this.txtCostoMoneda.CustomButton.Name = "";
            this.txtCostoMoneda.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtCostoMoneda.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCostoMoneda.CustomButton.TabIndex = 1;
            this.txtCostoMoneda.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCostoMoneda.CustomButton.UseSelectable = true;
            this.txtCostoMoneda.CustomButton.Visible = false;
            this.txtCostoMoneda.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCostoMoneda.Lines = new string[0];
            this.txtCostoMoneda.Location = new System.Drawing.Point(174, 277);
            this.txtCostoMoneda.MaxLength = 32767;
            this.txtCostoMoneda.Name = "txtCostoMoneda";
            this.txtCostoMoneda.PasswordChar = '\0';
            this.txtCostoMoneda.PromptText = "0,00";
            this.txtCostoMoneda.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCostoMoneda.SelectedText = "";
            this.txtCostoMoneda.SelectionLength = 0;
            this.txtCostoMoneda.SelectionStart = 0;
            this.txtCostoMoneda.ShortcutsEnabled = true;
            this.txtCostoMoneda.Size = new System.Drawing.Size(105, 29);
            this.txtCostoMoneda.TabIndex = 6;
            this.txtCostoMoneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCostoMoneda.UseSelectable = true;
            this.txtCostoMoneda.WaterMark = "0,00";
            this.txtCostoMoneda.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCostoMoneda.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCostoMoneda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.General_KeyDown);
            this.txtCostoMoneda.Validated += new System.EventHandler(this.txtCostoMoneda_Validated);
            // 
            // txtPrecioMoneda
            // 
            // 
            // 
            // 
            this.txtPrecioMoneda.CustomButton.Image = null;
            this.txtPrecioMoneda.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txtPrecioMoneda.CustomButton.Name = "";
            this.txtPrecioMoneda.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPrecioMoneda.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecioMoneda.CustomButton.TabIndex = 1;
            this.txtPrecioMoneda.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecioMoneda.CustomButton.UseSelectable = true;
            this.txtPrecioMoneda.CustomButton.Visible = false;
            this.txtPrecioMoneda.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPrecioMoneda.Lines = new string[0];
            this.txtPrecioMoneda.Location = new System.Drawing.Point(402, 277);
            this.txtPrecioMoneda.MaxLength = 32767;
            this.txtPrecioMoneda.Name = "txtPrecioMoneda";
            this.txtPrecioMoneda.PasswordChar = '\0';
            this.txtPrecioMoneda.PromptText = "0,00";
            this.txtPrecioMoneda.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecioMoneda.SelectedText = "";
            this.txtPrecioMoneda.SelectionLength = 0;
            this.txtPrecioMoneda.SelectionStart = 0;
            this.txtPrecioMoneda.ShortcutsEnabled = true;
            this.txtPrecioMoneda.Size = new System.Drawing.Size(120, 29);
            this.txtPrecioMoneda.TabIndex = 10;
            this.txtPrecioMoneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioMoneda.UseSelectable = true;
            this.txtPrecioMoneda.WaterMark = "0,00";
            this.txtPrecioMoneda.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecioMoneda.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioMoneda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.General_KeyDown);
            this.txtPrecioMoneda.Validated += new System.EventHandler(this.txtPrecioMoneda_Validated);
            // 
            // cmbImpuesto
            // 
            this.cmbImpuesto.DisplayFocus = true;
            this.cmbImpuesto.FormattingEnabled = true;
            this.cmbImpuesto.ItemHeight = 23;
            this.cmbImpuesto.Location = new System.Drawing.Point(541, 277);
            this.cmbImpuesto.Name = "cmbImpuesto";
            this.cmbImpuesto.Size = new System.Drawing.Size(80, 29);
            this.cmbImpuesto.TabIndex = 8;
            this.cmbImpuesto.UseSelectable = true;
            this.cmbImpuesto.SelectedIndexChanged += new System.EventHandler(this.cmbImpuesto_SelectedIndexChanged);
            // 
            // txtExistencia
            // 
            // 
            // 
            // 
            this.txtExistencia.CustomButton.Image = null;
            this.txtExistencia.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txtExistencia.CustomButton.Name = "";
            this.txtExistencia.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtExistencia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtExistencia.CustomButton.TabIndex = 1;
            this.txtExistencia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtExistencia.CustomButton.UseSelectable = true;
            this.txtExistencia.CustomButton.Visible = false;
            this.txtExistencia.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtExistencia.Lines = new string[0];
            this.txtExistencia.Location = new System.Drawing.Point(688, 196);
            this.txtExistencia.MaxLength = 32767;
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.PasswordChar = '\0';
            this.txtExistencia.PromptText = "0,00";
            this.txtExistencia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtExistencia.SelectedText = "";
            this.txtExistencia.SelectionLength = 0;
            this.txtExistencia.SelectionStart = 0;
            this.txtExistencia.ShortcutsEnabled = true;
            this.txtExistencia.Size = new System.Drawing.Size(120, 29);
            this.txtExistencia.TabIndex = 4;
            this.txtExistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtExistencia.UseSelectable = true;
            this.txtExistencia.WaterMark = "0,00";
            this.txtExistencia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtExistencia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtExistencia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.General_KeyDown);
            // 
            // cmbCotizacion
            // 
            this.cmbCotizacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCotizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCotizacion.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCotizacion.FormattingEnabled = true;
            this.cmbCotizacion.Location = new System.Drawing.Point(70, 277);
            this.cmbCotizacion.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCotizacion.Name = "cmbCotizacion";
            this.cmbCotizacion.Size = new System.Drawing.Size(80, 29);
            this.cmbCotizacion.TabIndex = 51;
            this.cmbCotizacion.SelectedIndexChanged += new System.EventHandler(this.cmbCotizacion_SelectedIndexChanged);
            // 
            // txtPctComision
            // 
            // 
            // 
            // 
            this.txtPctComision.CustomButton.Image = null;
            this.txtPctComision.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.txtPctComision.CustomButton.Name = "";
            this.txtPctComision.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPctComision.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPctComision.CustomButton.TabIndex = 1;
            this.txtPctComision.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPctComision.CustomButton.UseSelectable = true;
            this.txtPctComision.CustomButton.Visible = false;
            this.txtPctComision.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPctComision.Lines = new string[0];
            this.txtPctComision.Location = new System.Drawing.Point(640, 277);
            this.txtPctComision.MaxLength = 32767;
            this.txtPctComision.Name = "txtPctComision";
            this.txtPctComision.PasswordChar = '\0';
            this.txtPctComision.PromptText = "0,00";
            this.txtPctComision.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPctComision.SelectedText = "";
            this.txtPctComision.SelectionLength = 0;
            this.txtPctComision.SelectionStart = 0;
            this.txtPctComision.ShortcutsEnabled = true;
            this.txtPctComision.Size = new System.Drawing.Size(80, 29);
            this.txtPctComision.TabIndex = 52;
            this.txtPctComision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPctComision.UseSelectable = true;
            this.txtPctComision.WaterMark = "0,00";
            this.txtPctComision.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPctComision.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(640, 258);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 15);
            this.metroLabel1.TabIndex = 53;
            this.metroLabel1.Text = "% Comision";
            // 
            // checkInactivo
            // 
            this.checkInactivo.AutoSize = true;
            this.checkInactivo.Location = new System.Drawing.Point(744, 277);
            this.checkInactivo.Name = "checkInactivo";
            this.checkInactivo.Size = new System.Drawing.Size(64, 17);
            this.checkInactivo.TabIndex = 86;
            this.checkInactivo.Text = "Inactivo";
            this.checkInactivo.UseVisualStyleBackColor = true;
            // 
            // frmInvProductosDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 341);
            this.Controls.Add(this.checkInactivo);
            this.Controls.Add(this.txtPctComision);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbCotizacion);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.cmbImpuesto);
            this.Controls.Add(this.txtPrecioMoneda);
            this.Controls.Add(this.txtCostoMoneda);
            this.Controls.Add(this.txtUtilidad);
            this.Controls.Add(this.lblImpuesto);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblUtilidad);
            this.Controls.Add(this.lblExistencia);
            this.Controls.Add(this.cmbUnidad);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtNombre);
            this.Movable = false;
            this.Name = "frmInvProductosDetail";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbCategoria;
        private MetroFramework.Controls.MetroLabel lblCategoria;
        private MetroFramework.Controls.MetroLabel lblCosto;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private System.Windows.Forms.Label lblTitle;
        private MetroFramework.Controls.MetroLink btnSave;
        private MetroFramework.Controls.MetroLink btnBack;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroLabel lblCodigo;
        private MetroFramework.Controls.MetroTextBox txtCodigo;
        private MetroFramework.Controls.MetroComboBox cmbUnidad;
        private MetroFramework.Controls.MetroLabel lblUnidad;
        private MetroFramework.Controls.MetroLabel lblExistencia;
        private MetroFramework.Controls.MetroLabel lblUtilidad;
        private MetroFramework.Controls.MetroLabel lblPrecio;
        private MetroFramework.Controls.MetroLabel lblImpuesto;
        private MetroFramework.Controls.MetroTextBox txtUtilidad;
        private MetroFramework.Controls.MetroTextBox txtCostoMoneda;
        private MetroFramework.Controls.MetroTextBox txtPrecioMoneda;
        private MetroFramework.Controls.MetroComboBox cmbImpuesto;
        private MetroFramework.Controls.MetroTextBox txtExistencia;
        private System.Windows.Forms.ComboBox cmbCotizacion;
        private MetroFramework.Controls.MetroTextBox txtPctComision;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.CheckBox checkInactivo;
    }
}