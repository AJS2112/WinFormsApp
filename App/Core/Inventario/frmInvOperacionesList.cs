using App.Common.Classes;
using App.InvOperacionService;
using App.SisOperacionService;
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
    public partial class frmInvOperacionesList : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES
        private InvOperacionClient srv = new InvOperacionClient();
        private SisOperacionClient srvOperaciones = new SisOperacionClient();

        private List<InvOperacion> lista = new List<InvOperacion>();
        private List<SisOperacion> _listaOperaciones = new List<SisOperacion>();

        private InvOperacion one = new InvOperacion();
        #endregion

        #region METODOS
        private void CrearBindings()
        {
            _listaOperaciones = srvOperaciones.GetList("11E8F2229B16CA478FF600270E383B06");
            cmbTipoOperacion.DataSource = _listaOperaciones;
            cmbTipoOperacion.DisplayMember = "nombre";
            cmbTipoOperacion.ValueMember = "id";
        }
        private void GetList()
        {
            if (cmbTipoOperacion.SelectedValue == null) return;

            lista = srv.GetList(Globals.logEmpresa.id, cmbTipoOperacion.SelectedValue.ToString());
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

            dgvList.Columns[10].HeaderText = "NRO CONTROL";
            dgvList.Columns[10].Visible = true;

            dgvList.Columns[0].HeaderText = "FECHA";
            dgvList.Columns[0].Visible = true;
            dgvList.Columns[0].DefaultCellStyle.Format = "dd/MM/yy";

            dgvList.Columns[12].HeaderText = "OBSERVACION";
            dgvList.Columns[12].Visible = true;
            dgvList.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void filtrar(string filtro)
        {
            Console.WriteLine(filtro);
            dgvList.DataSource = lista.FindAll(o =>
                String.Join("", typeof(InvOperacion).GetProperties().Select(f => f.GetValue(o))).ToLower().Contains(filtro.ToLower())).ToList();
            lblSubTitle.Text = dgvList.RowCount.ToString() + " registros";
        }

        #endregion
        public frmInvOperacionesList()
        {
            InitializeComponent();
            CrearBindings();
            GetList();
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
                    one = (InvOperacion)row.DataBoundItem;
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
            InvOperacion _one = new InvOperacion();
            _one = srv.GetOne(Globals.logEmpresa.id, cmbTipoOperacion.SelectedValue.ToString(), one.id);

            Form f = new frmInvOperacionesDetail(_one);
            ConfigUI.LaunchChildForm(f, Globals.appParentWindow);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InvOperacion _one = new InvOperacion();
            _one = srv.GetOne(Globals.logEmpresa.id, cmbTipoOperacion.SelectedValue.ToString(), "0");

            Form f = new frmInvOperacionesDetail(_one);
            ConfigUI.LaunchChildForm(f, Globals.appParentWindow);
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            filtrar(txtFiltro.Text);
        }

        private void cmbTipoOperacion_SelectedValueChanged(object sender, EventArgs e)
        {
            GetList();
        }



        private void frmInvOperacionesList_Activated(object sender, EventArgs e)
        {
            GetList();
        }
        private void frmInvOperacionesList_Load(object sender, EventArgs e)
        {
            ConfigGrid();
        }
        #endregion


    }
}
