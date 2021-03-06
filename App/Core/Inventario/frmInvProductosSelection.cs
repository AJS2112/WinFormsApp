﻿using App.Common.Classes;
using App.InvProductoService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Core.Inventario
{
    public partial class frmInvProductosSelection : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES
        private InvProductoClient srv = new InvProductoClient();
        private List<InvProducto> lista = new List<InvProducto>();
        public InvProducto selectedProducto = new InvProducto();
        double factor = 1;
        #endregion

        #region METODOS
        private void GetList()
        {
            lista = srv.GetList(Globals.logEmpresa.id);
            foreach (InvProducto item in lista)
            {
                item.costo_moneda = item.costo * factor;
                item.precio_moneda = item.precio * factor;
            }
            filtrar(txtFiltro.Text);
            dgvList.Refresh();
        }

        private void ConfigGrid()
        {
            for (int i = 0; i <= dgvList.Columns.Count - 1; i++)
            {
                dgvList.Columns[i].Visible = false;
                //Console.WriteLine(i.ToString() + dgvList.Columns[i].HeaderText);
            }

            dgvList.Columns[17].DisplayIndex = 2;
            dgvList.Columns[24].DisplayIndex = 3;
            dgvList.Columns[2].DisplayIndex = 4;
            dgvList.Columns[23].DisplayIndex = 5;
            dgvList.Columns[8].DisplayIndex = 7;


            dgvList.Columns[1].HeaderText = "CATEGORIA";
            dgvList.Columns[1].Visible = true;

            dgvList.Columns[2].HeaderText = "CODIGO";
            dgvList.Columns[2].Visible = true;

            dgvList.Columns[17].HeaderText = "NOMBRE";
            dgvList.Columns[17].Visible = true;
            dgvList.Columns[17].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvList.Columns[24].HeaderText = "UNIDAD";
            dgvList.Columns[24].Visible = true;

            dgvList.Columns[23].HeaderText = "PRECIO";
            dgvList.Columns[23].Visible = true;
            dgvList.Columns[23].DefaultCellStyle.FormatProvider = Globals.nfiVE;
            dgvList.Columns[23].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvList.Columns[23].DefaultCellStyle.Format = "N2";


            dgvList.Columns[8].HeaderText = "EXISTENCIA";
            dgvList.Columns[8].Visible = true;
            dgvList.Columns[8].DefaultCellStyle.FormatProvider = Globals.nfiVE;
            dgvList.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvList.Columns[8].DefaultCellStyle.Format = "N2";
        }

        private void filtrar(string filtro)
        {
            dgvList.DataSource = lista.FindAll(o =>
                String.Join("", typeof(InvProducto).GetProperties().Select(f => f.GetValue(o))).ToLower().Contains(filtro.ToLower())).ToList();
            lblSubTitle.Text = dgvList.RowCount.ToString() + " registros";
        }

        #endregion

        //CONSTRUCTOR
        public frmInvProductosSelection()
        {
            InitializeComponent();
            Globals.ConfigurarComboMonedas(cmbCotizacion);
            ConfigGrid();
        }

        #region EVENTOS
        private void btnAdd_Click(object sender, EventArgs e)
        {
            InvProducto _one = new InvProducto();
            _one = srv.GetOne(Globals.logEmpresa.id, "0");

            frmInvProductosDetail fDetalle = new frmInvProductosDetail(_one);
            if (ConfigUI.LaunchDialogForm(fDetalle) == DialogResult.OK)
            {
                GetList();
                MessageBox.Show("Registro agregado con éxito!");
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSel_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Seleccion: " + selectedProducto.nombre);
            this.DialogResult = DialogResult.OK;
        }
        private void cmbCotizacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCotizacion.SelectedIndex > -1)
            {
                factor = Globals.cotizacion[cmbCotizacion.SelectedIndex].valor;
                GetList();

            }
        }
        private void dgvList_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            if (dgvList.SelectedRows.Count != 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvList.SelectedRows[0];
                    selectedProducto = (InvProducto)row.DataBoundItem;
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            filtrar(txtFiltro.Text);
        }
        #endregion
    }
}
