using App.CnfCotizacionService;
using App.Common.Classes;
using App.InvMovimientoService;
using App.SisOperacionService;
using App.VntOperacionService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPV.frmSelection
{
    public partial class frmVntOperacionSelection : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES
        private VntOperacionClient srv = new VntOperacionClient();
        private SisOperacionClient srvOperaciones = new SisOperacionClient();
        private InvMovimientoClient srvMovimiento = new InvMovimientoClient();

        private List<VntOperacion> lista = new List<VntOperacion>();
        private List<SisOperacion> _listaOperaciones = new List<SisOperacion>();

        public VntOperacion selectedOperacion = new VntOperacion();

        double factor = 1;
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
        private string FillString(string cadena, int espacios)
        {
            string miStr = "";

            int miEspacio = espacios - cadena.Length;
            for (int i = 0; i <= miEspacio; i++)
            {
                miStr += " ";
            }
            miStr += cadena;
            return miStr;
        }
        private void filtrar(string filtro)
        {
            btnPrint.Visible = false;

            dgvList.DataSource = lista.FindAll(o =>
                String.Join("", typeof(VntOperacion).GetProperties().Select(f => f.GetValue(o))).ToLower().Contains(filtro.ToLower())).ToList();
            lblSubTitle.Text = dgvList.RowCount.ToString() + " registros";
            if (dgvList.RowCount > 0)
            {
                btnPrint.Visible = true;
            }
        }
        private void SelKey(Keys tecla)
        {
            switch (tecla)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.F9:
                    this.DialogResult = DialogResult.OK;
                    break;
            }
        }

        #endregion


        public frmVntOperacionSelection()
        {
            InitializeComponent();
            //Globals.ConfigurarComboMonedas(cmbCotizacion);
            CrearBindings();
            factor = Globals.valorCotizacion;
            GetList();

            this.KeyPreview = true;
            this.KeyDown +=
                new KeyEventHandler(frmVntOperacionSelection_KeyDown);
        }

        #region EVENTOS

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnNullify_Click(object sender, EventArgs e)
        {
            //ONE
            VntOperacion one = selectedOperacion;

            frmDevolucion fDialog = new frmDevolucion(one);
            if (ConfigUI.LaunchDialogForm(fDialog) == DialogResult.OK)
            {

            }


        }
        private void btnSel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //ONE
            VntOperacion one = selectedOperacion;
            //DETAIL
            BindingList<App.InvMovimientoService.InvMovimiento>  bList = new BindingList<App.InvMovimientoService.InvMovimiento>(srvMovimiento.GetList(one.id));
            List<App.VntOperacionService.InvMovimiento> _detail = Globals.ConvertirDetalle(bList);
            //COTIZACION
            double _factor = 1;
            CnfCotizacionClient srvCotizacion = new CnfCotizacionClient();
            List<CnfCotizacionDetalle> _cotizacion = srvCotizacion.GetListDetail(one.id_cotizacion);
            foreach (CnfCotizacionDetalle item in _cotizacion)
            {
                if (item.id_moneda == Globals.logEmpresa.moneda_defecto)
                {
                    _factor = item.valor;
                }
            }

            //PRINT
            Globals.ImprimirTicketVenta(one, _detail, _factor);
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
                    selectedOperacion = (VntOperacion)row.DataBoundItem;
                    btnPrint.Visible = true;
                    btnNullify.Visible = true;
                }
                catch (Exception ex)
                {
                    btnPrint.Visible = false;
                    btnNullify.Visible = false;
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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

        private void frmVntOperacionSelection_KeyDown(object sender, KeyEventArgs e)
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
