namespace App.Core.Configuraciones
{
    partial class frmCnfCotizacionesDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCnfCotizacionesDetail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new MetroFramework.Controls.MetroLink();
            this.btnBack = new MetroFramework.Controls.MetroLink();
            this.dgvList = new MetroFramework.Controls.MetroGrid();
            this.cmbMonedas = new MetroFramework.Controls.MetroComboBox();
            this.btnAdd = new MetroFramework.Controls.MetroLink();
            this.lblMoneda = new MetroFramework.Controls.MetroLabel();
            this.lblValorActual = new MetroFramework.Controls.MetroLabel();
            this.txtValorActual = new MetroFramework.Controls.MetroTextBox();
            this.txtFecha = new System.Windows.Forms.Label();
            this.bntDel = new MetroFramework.Controls.MetroLink();
            this.lblSubTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(63, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(404, 46);
            this.lblTitle.TabIndex = 53;
            this.lblTitle.Text = "Cotizacion";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.ImageSize = 32;
            this.btnSave.Location = new System.Drawing.Point(482, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnSave.NoFocusImage")));
            this.btnSave.Size = new System.Drawing.Size(56, 46);
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "Guardar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseSelectable = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.ImageSize = 32;
            this.btnBack.Location = new System.Drawing.Point(19, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnBack.NoFocusImage")));
            this.btnBack.Size = new System.Drawing.Size(38, 46);
            this.btnBack.TabIndex = 51;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvList.Location = new System.Drawing.Point(69, 228);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvList.RowTemplate.Height = 30;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(470, 186);
            this.dgvList.TabIndex = 54;
            // 
            // cmbMonedas
            // 
            this.cmbMonedas.FormattingEnabled = true;
            this.cmbMonedas.ItemHeight = 23;
            this.cmbMonedas.Location = new System.Drawing.Point(69, 142);
            this.cmbMonedas.Name = "cmbMonedas";
            this.cmbMonedas.Size = new System.Drawing.Size(231, 29);
            this.cmbMonedas.TabIndex = 55;
            this.cmbMonedas.UseSelectable = true;
            this.cmbMonedas.SelectedValueChanged += new System.EventHandler(this.cmbMonedas_SelectedValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.ImageSize = 24;
            this.btnAdd.Location = new System.Drawing.Point(185, 194);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.NoFocusImage")));
            this.btnAdd.Size = new System.Drawing.Size(115, 28);
            this.btnAdd.TabIndex = 56;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblMoneda.Location = new System.Drawing.Point(68, 125);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(49, 15);
            this.lblMoneda.TabIndex = 68;
            this.lblMoneda.Text = "Moneda";
            // 
            // lblValorActual
            // 
            this.lblValorActual.AutoSize = true;
            this.lblValorActual.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblValorActual.Location = new System.Drawing.Point(305, 125);
            this.lblValorActual.Name = "lblValorActual";
            this.lblValorActual.Size = new System.Drawing.Size(66, 15);
            this.lblValorActual.TabIndex = 67;
            this.lblValorActual.Text = "Valor Actual";
            // 
            // txtValorActual
            // 
            // 
            // 
            // 
            this.txtValorActual.CustomButton.Image = null;
            this.txtValorActual.CustomButton.Location = new System.Drawing.Point(85, 2);
            this.txtValorActual.CustomButton.Name = "";
            this.txtValorActual.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtValorActual.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValorActual.CustomButton.TabIndex = 1;
            this.txtValorActual.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValorActual.CustomButton.UseSelectable = true;
            this.txtValorActual.CustomButton.Visible = false;
            this.txtValorActual.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtValorActual.Lines = new string[] {
        "0,00"};
            this.txtValorActual.Location = new System.Drawing.Point(305, 142);
            this.txtValorActual.MaxLength = 20;
            this.txtValorActual.Name = "txtValorActual";
            this.txtValorActual.PasswordChar = '\0';
            this.txtValorActual.PromptText = "0";
            this.txtValorActual.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValorActual.SelectedText = "";
            this.txtValorActual.SelectionLength = 0;
            this.txtValorActual.SelectionStart = 0;
            this.txtValorActual.ShortcutsEnabled = true;
            this.txtValorActual.Size = new System.Drawing.Size(107, 24);
            this.txtValorActual.TabIndex = 66;
            this.txtValorActual.Text = "0,00";
            this.txtValorActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorActual.UseSelectable = true;
            this.txtValorActual.WaterMark = "0";
            this.txtValorActual.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValorActual.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFecha.Location = new System.Drawing.Point(65, 89);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(139, 24);
            this.txtFecha.TabIndex = 70;
            this.txtFecha.Text = "Cotizacion";
            // 
            // bntDel
            // 
            this.bntDel.Image = ((System.Drawing.Image)(resources.GetObject("bntDel.Image")));
            this.bntDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntDel.ImageSize = 24;
            this.bntDel.Location = new System.Drawing.Point(69, 192);
            this.bntDel.Margin = new System.Windows.Forms.Padding(2);
            this.bntDel.Name = "bntDel";
            this.bntDel.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("bntDel.NoFocusImage")));
            this.bntDel.Size = new System.Drawing.Size(111, 30);
            this.bntDel.TabIndex = 71;
            this.bntDel.Text = "Eliminar";
            this.bntDel.UseSelectable = true;
            this.bntDel.Visible = false;
            this.bntDel.Click += new System.EventHandler(this.bntDel_Click);
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSubTitle.Location = new System.Drawing.Point(66, 54);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(186, 24);
            this.lblSubTitle.TabIndex = 74;
            this.lblSubTitle.Text = "n registro";
            // 
            // frmCnfCotizacionesDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 433);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.bntDel);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblMoneda);
            this.Controls.Add(this.lblValorActual);
            this.Controls.Add(this.txtValorActual);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbMonedas);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCnfCotizacionesDetail";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private MetroFramework.Controls.MetroLink btnSave;
        private MetroFramework.Controls.MetroLink btnBack;
        private MetroFramework.Controls.MetroGrid dgvList;
        private MetroFramework.Controls.MetroComboBox cmbMonedas;
        private MetroFramework.Controls.MetroLink btnAdd;
        private MetroFramework.Controls.MetroLabel lblMoneda;
        private MetroFramework.Controls.MetroLabel lblValorActual;
        private MetroFramework.Controls.MetroTextBox txtValorActual;
        private System.Windows.Forms.Label txtFecha;
        private MetroFramework.Controls.MetroLink bntDel;
        private System.Windows.Forms.Label lblSubTitle;
    }
}