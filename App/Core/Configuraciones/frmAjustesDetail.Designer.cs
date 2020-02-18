namespace App.Core.Configuraciones
{
    partial class frmAjustesDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjustesDetail));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new MetroFramework.Controls.MetroLink();
            this.btnBack = new MetroFramework.Controls.MetroLink();
            this.lstMonedas = new System.Windows.Forms.ListBox();
            this.lstInstrumentos = new System.Windows.Forms.ListBox();
            this.cmbMonedaDefecto = new MetroFramework.Controls.MetroComboBox();
            this.lblUnidad = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(69, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(576, 43);
            this.lblTitle.TabIndex = 35;
            this.lblTitle.Text = "Ajustes";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.ImageSize = 32;
            this.btnSave.Location = new System.Drawing.Point(728, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnSave.NoFocusImage")));
            this.btnSave.Size = new System.Drawing.Size(56, 46);
            this.btnSave.TabIndex = 34;
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
            this.btnBack.Location = new System.Drawing.Point(25, 25);
            this.btnBack.Name = "btnBack";
            this.btnBack.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("btnBack.NoFocusImage")));
            this.btnBack.Size = new System.Drawing.Size(38, 46);
            this.btnBack.TabIndex = 33;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lstMonedas
            // 
            this.lstMonedas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMonedas.FormattingEnabled = true;
            this.lstMonedas.ItemHeight = 17;
            this.lstMonedas.Location = new System.Drawing.Point(326, 125);
            this.lstMonedas.Name = "lstMonedas";
            this.lstMonedas.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstMonedas.Size = new System.Drawing.Size(214, 123);
            this.lstMonedas.TabIndex = 36;
            // 
            // lstInstrumentos
            // 
            this.lstInstrumentos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInstrumentos.FormattingEnabled = true;
            this.lstInstrumentos.ItemHeight = 17;
            this.lstInstrumentos.Location = new System.Drawing.Point(75, 125);
            this.lstInstrumentos.Name = "lstInstrumentos";
            this.lstInstrumentos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstInstrumentos.Size = new System.Drawing.Size(219, 123);
            this.lstInstrumentos.TabIndex = 37;
            // 
            // cmbMonedaDefecto
            // 
            this.cmbMonedaDefecto.FormattingEnabled = true;
            this.cmbMonedaDefecto.ItemHeight = 23;
            this.cmbMonedaDefecto.Location = new System.Drawing.Point(567, 125);
            this.cmbMonedaDefecto.Name = "cmbMonedaDefecto";
            this.cmbMonedaDefecto.Size = new System.Drawing.Size(141, 29);
            this.cmbMonedaDefecto.TabIndex = 40;
            this.cmbMonedaDefecto.UseSelectable = true;
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblUnidad.Location = new System.Drawing.Point(568, 107);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(112, 15);
            this.lblUnidad.TabIndex = 41;
            this.lblUnidad.Text = "Moneda por Defecto";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(326, 107);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 15);
            this.metroLabel1.TabIndex = 42;
            this.metroLabel1.Text = "Monedas";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.Location = new System.Drawing.Point(75, 107);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(124, 15);
            this.metroLabel2.TabIndex = 43;
            this.metroLabel2.Text = "Instrumentos de Pago  ";
            // 
            // frmAjustesDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 416);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbMonedaDefecto);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.lstInstrumentos);
            this.Controls.Add(this.lstMonedas);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Name = "frmAjustesDetail";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private MetroFramework.Controls.MetroLink btnSave;
        private MetroFramework.Controls.MetroLink btnBack;
        private System.Windows.Forms.ListBox lstMonedas;
        private System.Windows.Forms.ListBox lstInstrumentos;
        private MetroFramework.Controls.MetroComboBox cmbMonedaDefecto;
        private MetroFramework.Controls.MetroLabel lblUnidad;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}