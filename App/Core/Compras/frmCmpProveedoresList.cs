using App.CmpProveedorService;
using App.Common.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Core.Compras
{
    public partial class frmCmpProveedoresList : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES
        private CmpProveedorClient srv = new CmpProveedorClient();
        private List<CmpProveedor> lista = new List<CmpProveedor>();
        private CmpProveedor one = new CmpProveedor();
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


            dgvList.Columns[7].DisplayIndex = 0;
            dgvList.Columns[12].DisplayIndex = 1;
            dgvList.Columns[13].DisplayIndex = 2;
            dgvList.Columns[0].DisplayIndex = 3;
            dgvList.Columns[8].DisplayIndex = 4;

            dgvList.Columns[7].HeaderText = "NOMBRE";
            dgvList.Columns[7].Visible = true;
            dgvList.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvList.Columns[12].HeaderText = "RIF";
            dgvList.Columns[12].Visible = true;

            dgvList.Columns[13].HeaderText = "TELEFONO";
            dgvList.Columns[13].Visible = true;

        }

        private void filtrar(string filtro)
        {
            Console.WriteLine(filtro);
            dgvList.DataSource = lista.FindAll(o =>
                String.Join("", typeof(CmpProveedor).GetProperties().Select(f => f.GetValue(o))).ToLower().Contains(filtro.ToLower())).ToList();
            lblSubTitle.Text = dgvList.RowCount.ToString() + " registros";
        }

        #endregion

        public frmCmpProveedoresList()
        {
            InitializeComponent();
            GetList();
            filtrar(txtFiltro.Text);
            
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
                    one = (CmpProveedor)row.DataBoundItem;
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                btnEdit.Visible = true;
            }
            else
            {
                btnEdit.Visible = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CmpProveedor _one = new CmpProveedor();
            _one = srv.GetOne(Globals.logEmpresa.id, one.id);

            frmCmpProveedoresDetail fDetalle = new frmCmpProveedoresDetail(_one);
            if (ConfigUI.LaunchDialogForm(fDetalle) == DialogResult.OK)
            {
                GetList();

                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Registro editado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CmpProveedor _one = new CmpProveedor();
            _one = srv.GetOne(Globals.logEmpresa.id, "0");

            frmCmpProveedoresDetail fDetalle = new frmCmpProveedoresDetail(_one);
            if (ConfigUI.LaunchDialogForm(fDetalle) == DialogResult.OK)
            {
                GetList();
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Registro agregado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void frmCmpProveedoresList_Load(object sender, EventArgs e)
        {
            ConfigGrid();
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            filtrar(txtFiltro.Text);
        }
        #endregion


    }
}
