using App.CajOperacionService;
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

namespace App.Core.Caja
{
    public partial class frmCajOperacionesList : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES
        private List<CajOperacion> lista = new List<CajOperacion>();
        private List<SisOperacion> _listaOperaciones = new List<SisOperacion>();

        private CajOperacion one = new CajOperacion();
        //private SisOperacion selectedTipoOperacion = new SisOperacion();

        private CajOperacionClient srv = new CajOperacionClient();
        private SisOperacionClient srvOperaciones = new SisOperacionClient();

        double factor = 0;
        #endregion

        #region METODOS
        private void CrearBindings()
        {
            _listaOperaciones = srvOperaciones.GetList("11E8FA24BAAD31B9AC3D00270E383B06");
            cmbTipoOperacion.DataSource = _listaOperaciones;
            cmbTipoOperacion.DisplayMember = "nombre";
            cmbTipoOperacion.ValueMember = "id";
        }
        private void GetList()
        {
            if (cmbTipoOperacion.SelectedValue == null) return;

            lista = srv.GetList(Globals.logEmpresa.id, cmbTipoOperacion.SelectedValue.ToString());
            foreach (CajOperacion item in lista)
            {
                item.monto_moneda = item.monto * factor;
            }
            filtrar(txtFiltro.Text);
            dgvList.Refresh();
            Console.WriteLine("PROCEDURE GetList");
        }

        private void ConfigGrid()
        {
            for (int i = 0; i <= dgvList.Columns.Count - 1; i++)
            {
                dgvList.Columns[i].Visible = false;
                Console.WriteLine(i.ToString() + " - " + dgvList.Columns[i].HeaderText);
            }

            dgvList.Columns[1].DisplayIndex = 0;
            dgvList.Columns[13].DisplayIndex = 1;
            dgvList.Columns[0].DisplayIndex = 2;


            dgvList.Columns[13].HeaderText = "NRO CONTROL";
            dgvList.Columns[13].Visible = true;

            dgvList.Columns[1].HeaderText = "FECHA";
            dgvList.Columns[1].Visible = true;
            dgvList.Columns[1].DefaultCellStyle.Format = "dd/MM/yy";

            dgvList.Columns[0].HeaderText = "DESCRIPCION";
            dgvList.Columns[0].Visible = true;
            dgvList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dgvList.Columns[12].HeaderText = "MONTO";
            dgvList.Columns[12].Visible = true;
            dgvList.Columns[12].DefaultCellStyle.FormatProvider = Globals.nfiVE;
            dgvList.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvList.Columns[12].DefaultCellStyle.Format = "N2";
        }

        private void filtrar(string filtro)
        {
            Console.WriteLine(filtro);
            dgvList.DataSource = lista.FindAll(o =>
                String.Join("", typeof(CajOperacion).GetProperties().Select(f => f.GetValue(o))).ToLower().Contains(filtro.ToLower())).ToList();
            lblSubTitle.Text = dgvList.RowCount.ToString() + " registros";
        }

        #endregion
        public frmCajOperacionesList()
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
            CajOperacion _one = new CajOperacion();
            _one = srv.GetOne(Globals.logEmpresa.id, cmbTipoOperacion.SelectedValue.ToString(), "0");

            frmCajOperacionesDetail fDetalle = new frmCajOperacionesDetail(_one);
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
            CajOperacion _one = new CajOperacion();
            _one = srv.GetOne(Globals.logEmpresa.id, cmbTipoOperacion.SelectedValue.ToString(), one.id);

            frmCajOperacionesDetail fDetalle = new frmCajOperacionesDetail(_one);
            if (ConfigUI.LaunchDialogForm(fDetalle) == DialogResult.OK)
            {
                GetList();
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Registro agregado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                    one = (CajOperacion)row.DataBoundItem;
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

        private void frmCajOperacionesList_Activated(object sender, EventArgs e)
        {
            GetList();
        }

        private void frmCajOperacionesList_Load(object sender, EventArgs e)
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
