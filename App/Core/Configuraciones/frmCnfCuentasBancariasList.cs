using App.CnfCuentaBancariaService;
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

namespace App.Core.Configuraciones
{
    public partial class frmCnfCuentasBancariasList : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES
        private CnfCuentaBancariaClient srv = new CnfCuentaBancariaClient();
        private List<CnfCuentaBancaria> lista = new List<CnfCuentaBancaria>();
        private CnfCuentaBancaria one = new CnfCuentaBancaria();
        #endregion

        #region METODOS
        private void GetList()
        {
            lista = srv.GetList(Globals.logEmpresa.id);
            filtrar(txtFiltro.Text);
            dgvList.Refresh();
        }

        private void ConfigGrid()
        {
            for (int i = 0; i <= dgvList.Columns.Count - 1; i++)
            {
                dgvList.Columns[i].Visible = false;
                Console.WriteLine(i.ToString() + dgvList.Columns[i].HeaderText);
            }
            dgvList.Columns[0].HeaderText = "BANCO";
            dgvList.Columns[0].Visible = true;
            dgvList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dgvList.Columns[5].HeaderText = "NUMERO";
            dgvList.Columns[5].Visible = true;
            dgvList.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void filtrar(string filtro)
        {
            dgvList.DataSource = lista.FindAll(o =>
                String.Join("", typeof(CnfCuentaBancaria).GetProperties().Select(f => f.GetValue(o))).ToLower().Contains(filtro.ToLower())).ToList();
            lblSubTitle.Text = dgvList.RowCount.ToString() + " registros";
        }

        #endregion

        public frmCnfCuentasBancariasList()
        {
            InitializeComponent();
            GetList();
        }

        #region EVENTOS
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CnfCuentaBancaria _one = new CnfCuentaBancaria();
            _one = srv.GetOne(Globals.logEmpresa.id, "0");

            frmCnfCuentasBancariasDetail fDetalle = new frmCnfCuentasBancariasDetail(_one);
            if (ConfigUI.LaunchDialogForm(fDetalle) == DialogResult.OK)
            {
                GetList();
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Registro agregado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CnfCuentaBancaria _one = new CnfCuentaBancaria();
            _one = srv.GetOne(Globals.logEmpresa.id, one.id);

            frmCnfCuentasBancariasDetail fDetalle = new frmCnfCuentasBancariasDetail(_one);
            if (ConfigUI.LaunchDialogForm(fDetalle) == DialogResult.OK)
            {
                GetList();

                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Registro editado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    one = (CnfCuentaBancaria)row.DataBoundItem;
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
        private void frmCnfCuentasBancariasList_Load(object sender, EventArgs e)
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
