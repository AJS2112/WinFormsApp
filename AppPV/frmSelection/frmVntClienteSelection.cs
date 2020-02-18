using App.Common.Classes;
using App.VntClienteService;
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
    public partial class frmVntClienteSelection : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES
        private VntClienteClient srv = new VntClienteClient();
        private List<VntCliente> lista = new List<VntCliente>();
        public VntCliente selectedCliente = new VntCliente();
        #endregion

        #region METODOS
        private void AddCliente()
        {
            VntCliente _one = new VntCliente();
            _one = srv.GetOne(Globals.logEmpresa.id, "0");

            frmVntClienteDetail fDetalle = new frmVntClienteDetail(_one);
            if (ConfigUI.LaunchDialogForm(fDetalle) == DialogResult.OK)
            {
                GetList();
                MessageBox.Show("Registro agregado con éxito!");
            }
        }
        private void GetList()
        {
            lista = srv.GetList(Globals.logEmpresa.id);
            dgvList.DataSource = lista;
            filtrar(txtFiltro.Text);
            dgvList.Refresh();
        }

        private void ConfigGrid()
        {
            for (int i = 0; i <= dgvList.Columns.Count - 1; i++)
            {
                dgvList.Columns[i].Visible = false;
                Console.WriteLine(i.ToString() + " - " + dgvList.Columns[i].HeaderText);
            }


            dgvList.Columns[10].DisplayIndex = 0;
            dgvList.Columns[13].DisplayIndex = 1;

            dgvList.Columns[10].HeaderText = "NOMBRE";
            dgvList.Columns[10].Visible = true;
            dgvList.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvList.Columns[13].HeaderText = "RIF";
            dgvList.Columns[13].Visible = true;

        }

        private void filtrar(string filtro)
        {
            dgvList.DataSource = lista.FindAll(o =>
                String.Join("", typeof(VntCliente).GetProperties().Select(f => f.GetValue(o))).ToLower().Contains(filtro.ToLower())).ToList();
            lblSubTitle.Text = dgvList.RowCount.ToString() + " registros";
        }

        private void SelKey(Keys tecla)
        {
            switch (tecla)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.F5:
                    AddCliente();
                    break;
                case Keys.F9:
                    this.DialogResult = DialogResult.OK;
                    break;
            }
        }

        #endregion
        public frmVntClienteSelection()
        {
            InitializeComponent();
            GetList();
            this.KeyPreview = true;
            this.KeyDown +=
                new KeyEventHandler(frmVntClienteSelection_KeyDown);
        }

        #region EVENTOS
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCliente();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void dgvList_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            if (dgvList.SelectedRows.Count != 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvList.SelectedRows[0];
                    selectedCliente = (VntCliente)row.DataBoundItem;
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void frmVntClientesSelection_Load(object sender, EventArgs e)
        {
            ConfigGrid();
        }

        private void frmVntClienteSelection_KeyDown(object sender, KeyEventArgs e)
        {
            SelKey(e.KeyCode);
        }


        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            filtrar(txtFiltro.Text);
        }
        #endregion

    }
}
