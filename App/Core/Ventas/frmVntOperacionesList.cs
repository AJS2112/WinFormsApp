using App.Common.Classes;
using App.SisOperacionService;
using App.VntOperacionService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Core.Ventas
{
    public partial class frmVntOperacionesList : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES
        private VntOperacionClient srv = new VntOperacionClient();
        private SisOperacionClient srvOperaciones = new SisOperacionClient();

        private List<VntOperacion> lista = new List<VntOperacion>();
        private List<SisOperacion> _listaOperaciones = new List<SisOperacion>();

        private VntOperacion one = new VntOperacion();

        double factor = 0;
        #endregion

        #region METODOS
        private void CrearBindings()
        {
            _listaOperaciones = srvOperaciones.GetList("11E7C39A0EACD9A08F1A00E04C6F7E24");
            cmbTipoOperacion.DataSource = _listaOperaciones;
            cmbTipoOperacion.DisplayMember = "nombre";
            cmbTipoOperacion.ValueMember = "id";
        }
        private void ConfigGrid()
        {
            for (int i = 0; i <= dgvList.Columns.Count - 1; i++)
            {
                dgvList.Columns[i].Visible = false;
                Console.WriteLine(i.ToString() + " - " + dgvList.Columns[i].HeaderText);
            }


            dgvList.Columns[35].DisplayIndex = 0;
            dgvList.Columns[35].HeaderText = "NRO CONTROL";
            dgvList.Columns[35].Visible = true;

            dgvList.Columns[12].DisplayIndex = 1;
            dgvList.Columns[12].HeaderText = "FECHA";
            dgvList.Columns[12].Visible = true;
            dgvList.Columns[12].DefaultCellStyle.Format = "dd/MM/yy";

            dgvList.Columns[8].HeaderText = "CLIENTE";
            dgvList.Columns[8].Visible = true;
            dgvList.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvList.Columns[9].HeaderText = "RIF";
            dgvList.Columns[9].Visible = true;

            dgvList.Columns[49].HeaderText = "MONTO";
            dgvList.Columns[49].Visible = true;
            dgvList.Columns[49].DefaultCellStyle.FormatProvider = Globals.nfiVE;
            dgvList.Columns[49].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvList.Columns[49].DefaultCellStyle.Format = "N2";
        }
        private void GetList()
        {
            if (cmbTipoOperacion.SelectedValue == null) return;
            lista = srv.GetList(Globals.logEmpresa.id, cmbTipoOperacion.SelectedValue.ToString());

            foreach (VntOperacion item in lista)
            {
                item.total_moneda = item.total * factor;
            }
            filtrar(txtFiltro.Text);
            dgvList.Refresh();

        }
        private void filtrar(string filtro)
        {
            dgvList.DataSource = lista.FindAll(o =>
                String.Join("", typeof(VntOperacion).GetProperties().Select(f => f.GetValue(o))).ToLower().Contains(filtro.ToLower())).ToList();
            lblSubTitle.Text = dgvList.RowCount.ToString() + " registros";
        }

        #endregion
        public frmVntOperacionesList()
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
            VntOperacion _one = new VntOperacion();
            _one = srv.GetOne(Globals.logEmpresa.id, cmbTipoOperacion.SelectedValue.ToString(), "0");
            Form f = new frmVntOperacionesDetail(_one);
            ConfigUI.LaunchChildForm(f, Globals.appParentWindow);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            VntOperacion _one = new VntOperacion();
            _one = srv.GetOne(Globals.logEmpresa.id, cmbTipoOperacion.SelectedValue.ToString(), one.id);

            Form f = new frmVntOperacionesDetail(_one);
            ConfigUI.LaunchChildForm(f, Globals.appParentWindow);
        }



        private void cmbCotizacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            factor = Globals.cotizacion[cmbCotizacion.SelectedIndex].valor;
            GetList();
        }

        private void cmbTipoOperacion_SelectedValueChanged(object sender, EventArgs e)
        {
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
                    one = (VntOperacion)row.DataBoundItem;
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

        private void frmVntOperacionesList_Activated(object sender, EventArgs e)
        {
            GetList();
        }

        private void frmVntOperacionesList_Load(object sender, EventArgs e)
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
