using App.Common.Classes;
using App.InvCategoriaService;
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
    public partial class frmInvCategoriasList : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES
        private List<InvCategoria> lista = new List<InvCategoria>();
        private InvCategoria one = new InvCategoria();
        private InvCategoriaClient srv = new InvCategoriaClient();
        #endregion

        #region METODOS
        private void GetList()
        {
            lista = srv.GetList(Globals.logEmpresa.id);
            dgvList.DataSource = lista;
        }

        private void ConfigGrid()
        {
            for (int i = 0; i <= dgvList.Columns.Count - 1; i++)
            {
                dgvList.Columns[i].Visible = false;
            }

            dgvList.Columns[5].DisplayIndex = 0;
            dgvList.Columns[0].DisplayIndex = 1;

            dgvList.Columns[5].HeaderText = "NOMBRE";
            dgvList.Columns[5].Visible = true;
            dgvList.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvList.Columns[0].HeaderText = "DESCRIPCION";
            dgvList.Columns[0].Visible = true;
            dgvList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void Filtrar(string filtro)
        {
            dgvList.DataSource = lista.FindAll(o =>
                String.Join("", typeof(InvCategoria).GetProperties().Select(f => f.GetValue(o))).ToLower().Contains(filtro.ToLower())).ToList();
            lblSubTitle.Text = dgvList.RowCount.ToString() + " registros";
        }

        #endregion

        //CONSTRUCTOR
        public frmInvCategoriasList()
        {
            InitializeComponent();
            GetList();
            Filtrar(txtFiltro.Text);
            btnEdit.Visible = false;
        }

        #region EVENTOS
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvList_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            if (dgvList.SelectedRows.Count != 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvList.SelectedRows[0];
                    one = (InvCategoria)row.DataBoundItem;
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                btnEdit.Visible = true;
            }
            else
            {
                btnEdit.Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InvCategoria _one = new InvCategoria();
            _one = srv.GetOne(Globals.logEmpresa.id,"0");

            frmInvCategoriasDetail fDetalle = new frmInvCategoriasDetail(_one);
            if (ConfigUI.LaunchDialogForm(fDetalle) == DialogResult.OK)
            {
                GetList();
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Registro agregado con éxito", "Mensaje", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmInvCategoriasDetail fDetalle = new frmInvCategoriasDetail(one);
            if (ConfigUI.LaunchDialogForm(fDetalle) == DialogResult.OK)
            {
                GetList();
                
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Registro editado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            Filtrar(txtFiltro.Text);
        }

        private void frmInvCategoriasList_Load(object sender, EventArgs e)
        {
            ConfigGrid();
        }
        #endregion
    }
}
