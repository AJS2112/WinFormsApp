﻿using App.VntClienteService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPV
{
    public partial class frmVntClienteDetail : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES
        private VntClienteClient srv = new VntClienteClient();
        private List<VntCliente> _listaCategorias = new List<VntCliente>();
        private VntCliente one { get; set; }
        #endregion

        private void SelKey(Keys tecla)
        {
            switch (tecla)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.F9:
                    SaveCliente();
                    break;
            }
        }


        private void SaveCliente()
        {
            btnSave.Enabled = false;
            try
            {
                string _id = srv.SetOne(one);
                if (_id.Length > 0)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "No se guardó el registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnSave.Enabled = true;
                }
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Se produjeron errores intentando procesar el registro, por favor revise los valores e intente nuevamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSave.Enabled = true;
            }
        }
        //CONSTRUCTORES
        public frmVntClienteDetail()
        {
            InitializeComponent();
        }

        public frmVntClienteDetail(VntCliente obj)
        {
            InitializeComponent();
            one = obj;
            lblTitle.Text = obj.nombre;

            txtNombre.DataBindings.Add("Text", one, "nombre", true, DataSourceUpdateMode.OnPropertyChanged);
            txtRif.DataBindings.Add("Text", one, "rif", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDireccion.DataBindings.Add("Text", one, "direccion", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTelefono.DataBindings.Add("Text", one, "telefono", true, DataSourceUpdateMode.OnPropertyChanged);

            this.KeyPreview = true;
            this.KeyDown +=
                new KeyEventHandler(frmVntClienteDetail_KeyDown);
        }

        #region EVENTOS
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveCliente();
        }

        private void frmVntClienteDetail_KeyDown(object sender, KeyEventArgs e)
        {
            SelKey(e.KeyCode);
        }

        // GENERAL KEYDOWN //
        private void General_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
        #endregion
    }
}
