namespace App.Core.Configuraciones
{
    partial class frmCnfCuentasBancariasDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCnfCuentasBancariasDetail));
            this.cmbBanco = new MetroFramework.Controls.MetroComboBox();
            this.lblBanco = new MetroFramework.Controls.MetroLabel();
            this.lblNumero = new MetroFramework.Controls.MetroLabel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new MetroFramework.Controls.MetroLink();
            this.btnBack = new MetroFramework.Controls.MetroLink();
            this.txtNumero = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // cmbBanco
            // 
            this.cmbBanco.FormattingEnabled = true;
            this.cmbBanco.ItemHeight = 23;
            this.cmbBanco.Location = new System.Drawing.Point(72, 113);
            this.cmbBanco.Name = "cmbBanco";
            this.cmbBanco.Size = new System.Drawing.Size(250, 29);
            this.cmbBanco.TabIndex = 36;
            this.cmbBanco.UseSelectable = true;
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblBanco.Location = new System.Drawing.Point(73, 95);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(38, 15);
            this.lblBanco.TabIndex = 35;
            this.lblBanco.Text = "Banco";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblNumero.Location = new System.Drawing.Point(72, 155);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(49, 15);
            this.lblNumero.TabIndex = 33;
            this.lblNumero.Text = "Número";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(67, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(446, 43);
            this.lblTitle.TabIndex = 32;
            this.lblTitle.Text = "Cuenta Bancaria";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.ImageSize = 32;
            this.btnSave.Location = new System.Drawing.Point(519, 23);
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
            // txtNumero
            // 
            // 
            // 
            // 
            this.txtNumero.CustomButton.Image = null;
            this.txtNumero.CustomButton.Location = new System.Drawing.Point(382, 1);
            this.txtNumero.CustomButton.Name = "";
            this.txtNumero.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNumero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumero.CustomButton.TabIndex = 1;
            this.txtNumero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumero.CustomButton.UseSelectable = true;
            this.txtNumero.CustomButton.Visible = false;
            this.txtNumero.Lines = new string[0];
            this.txtNumero.Location = new System.Drawing.Point(73, 178);
            this.txtNumero.MaxLength = 32767;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.PromptText = "Nombre";
            this.txtNumero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumero.SelectedText = "";
            this.txtNumero.SelectionLength = 0;
            this.txtNumero.SelectionStart = 0;
            this.txtNumero.ShortcutsEnabled = true;
            this.txtNumero.Size = new System.Drawing.Size(410, 29);
            this.txtNumero.TabIndex = 28;
            this.txtNumero.UseSelectable = true;
            this.txtNumero.WaterMark = "Nombre";
            this.txtNumero.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumero.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmCnfCuentasBancariasDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 273);
            this.Controls.Add(this.cmbBanco);
            this.Controls.Add(this.lblBanco);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtNumero);
            this.Name = "frmCnfCuentasBancariasDetail";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbBanco;
        private MetroFramework.Controls.MetroLabel lblBanco;
        private MetroFramework.Controls.MetroLabel lblNumero;
        private System.Windows.Forms.Label lblTitle;
        private MetroFramework.Controls.MetroLink btnSave;
        private MetroFramework.Controls.MetroLink btnBack;
        private MetroFramework.Controls.MetroTextBox txtNumero;
    }
}