using App.CmpOperacionService;
using App.Common.Classes;
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

namespace App.Core.Compras
{
    public partial class frmCmpOperacionesList : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES
        private CmpOperacionClient srv = new CmpOperacionClient();
        private SisOperacionClient srvOperaciones = new SisOperacionClient();

        private List<CmpOperacion> lista = new List<CmpOperacion>();
        private List<SisOperacion> _listaOperaciones = new List<SisOperacion>();

        private CmpOperacion one = new CmpOperacion();

        double factor = 0;
        #endregion

        #region METODOS
        private void CrearBindings()
        {
            _listaOperaciones = srvOperaciones.GetList("11E8F22292A5ED4B8FF600270E383B06");
            cmbTipoOperacion.DataSource = _listaOperaciones;
            cmbTipoOperacion.DisplayMember = "nombre";
            cmbTipoOperacion.ValueMember = "id";
        }
        private void GetList()
        {
            if (cmbTipoOperacion.SelectedValue == null) return;

            lista = srv.GetList(Globals.logEmpresa.id, cmbTipoOperacion.SelectedValue.ToString());
            foreach (CmpOperacion item in lista)
            {
                item.total_moneda = item.total * factor;
            }
            filtrar(txtFiltro.Text);
            dgvList.Refresh();
        }

        private void ConfigGrid()
        {
            for (int i = 0; i <= dgvList.Columns.Count - 1; i++)
            {
                dgvList.Columns[i].Visible = false;
                Console.WriteLine(i.ToString() + " - " +dgvList.Columns[i].HeaderText);
            }


            dgvList.Columns[29].DisplayIndex = 0;
            
            dgvList.Columns[29].HeaderText = "NRO CONTROL";
            dgvList.Columns[29].Visible = true;
            
            dgvList.Columns[6].HeaderText = "FECHA";
            dgvList.Columns[6].Visible = true;
            dgvList.Columns[6].DefaultCellStyle.Format = "dd/MM/yy";

            dgvList.Columns[41].HeaderText = "PROVEEDOR";
            dgvList.Columns[41].Visible = true;
            dgvList.Columns[41].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvList.Columns[42].HeaderText = "RIF";
            dgvList.Columns[42].Visible = true;

            dgvList.Columns[45].HeaderText = "MONTO";
            dgvList.Columns[45].Visible = true;
            dgvList.Columns[45].DefaultCellStyle.FormatProvider = Globals.nfiVE;
            dgvList.Columns[45].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvList.Columns[45].DefaultCellStyle.Format = "N2";
        }

        private void filtrar(string filtro)
        {
            dgvList.DataSource = lista.FindAll(o =>
                String.Join("", typeof(CmpOperacion).GetProperties().Select(f => f.GetValue(o))).ToLower().Contains(filtro.ToLower())).ToList();
            lblSubTitle.Text = dgvList.RowCount.ToString() + " registros";
        }

        #endregion

        public frmCmpOperacionesList()
        {
            InitializeComponent();
            Globals.ConfigurarComboMonedas(cmbCotizacion);
            CrearBindings();
            GetList();
            btnEdit.Visible = false;
        }

        #region EVENTOS
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CmpOperacion _one = new CmpOperacion();
            _one = srv.GetOne(Globals.logEmpresa.id, cmbTipoOperacion.SelectedValue.ToString(), "0");

            Form f = new frmCmpOperacionesDetail(_one);
            ConfigUI.LaunchChildForm(f, Globals.appParentWindow);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CmpOperacion _one = new CmpOperacion();
            _one = srv.GetOne(Globals.logEmpresa.id, cmbTipoOperacion.SelectedValue.ToString(), one.id);

            Form f = new frmCmpOperacionesDetail(_one);
            ConfigUI.LaunchChildForm(f, Globals.appParentWindow);
        }

        private void cmbTipoOperacion_SelectedValueChanged(object sender, EventArgs e)
        {
            GetList();
        }

        private void cmbCotizacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            factor = Globals.cotizacion[cmbCotizacion.SelectedIndex].valor;
            GetList();
        }

        private void dgvList_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            if (dgvList.SelectedRows.Count != 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvList.SelectedRows[0];
                    one = (CmpOperacion)row.DataBoundItem;
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

        private void frmCmpOperacionesList_Activated(object sender, EventArgs e)
        {
            GetList();
        }

        private void frmCmpOperacionesList_Load(object sender, EventArgs e)
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
