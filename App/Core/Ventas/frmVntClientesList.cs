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

namespace App.Core.Ventas
{
    public partial class frmVntClientesList : MetroFramework.Forms.MetroForm

    {
        #region VARIABLES
        private VntClienteClient srv = new VntClienteClient();
        private List<VntCliente> lista = new List<VntCliente>();
        private VntCliente one = new VntCliente();

        double factor = 0;
        #endregion

        #region METODOS
        private void GetList()
        {
            lista = srv.GetList(Globals.logEmpresa.id);
            dgvList.DataSource = lista;
            MultiplicarMoneda();
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

            dgvList.Columns[3].HeaderText = "DEUDA";
            dgvList.Columns[3].Visible = true;
            dgvList.Columns[3].DefaultCellStyle.FormatProvider = Globals.nfiVE;
            dgvList.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvList.Columns[3].DefaultCellStyle.Format = "N2";

        }

        private void filtrar(string filtro)
        {
            dgvList.DataSource = lista.FindAll(o =>
                String.Join("", typeof(VntCliente).GetProperties().Select(f => f.GetValue(o))).ToLower().Contains(filtro.ToLower())).ToList();
            lblSubTitle.Text = dgvList.RowCount.ToString() + " registros";
        }

        private void MultiplicarMoneda()
        {
            foreach (VntCliente item in lista)
            {
                item.total_moneda = item.total * factor;
                item.abonos_moneda = item.abonos * factor;
                item.deuda_moneda = item.deuda * factor;
            }
            filtrar(txtFiltro.Text);
            dgvList.Refresh();
        }
        #endregion
        public frmVntClientesList()
        {
            InitializeComponent();
            Globals.ConfigurarComboMonedas(cmbCotizacion);
            GetList();
            ConfigGrid();
            btnEdit.Visible = false;
            btnDeudas.Visible = false;
        }

        #region EVENTOS
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            VntCliente _one = new VntCliente();
            _one = srv.GetOne(Globals.logEmpresa.id, "0");

            frmVntClientesDetail fDetalle = new frmVntClientesDetail(_one);
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
        private void btnDeudas_Click(object sender, EventArgs e)
        {
            VntCliente _one = new VntCliente();
            _one = srv.GetOne(Globals.logEmpresa.id, one.id);

            frmVntClientesDeudas f = new frmVntClientesDeudas(_one);
            ConfigUI.LaunchChildForm(f, Globals.appParentWindow);
                

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            VntCliente _one = new VntCliente();
            _one = srv.GetOne(Globals.logEmpresa.id, one.id);

            frmVntClientesDetail fDetalle = new frmVntClientesDetail(_one);
            if (ConfigUI.LaunchDialogForm(fDetalle) == DialogResult.OK)
            {
                GetList();

                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Registro editado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void cmbCotizacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            factor = Globals.cotizacion[cmbCotizacion.SelectedIndex].valor;
            MultiplicarMoneda();
        }
        private void dgvList_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            if (dgvList.SelectedRows.Count != 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvList.SelectedRows[0];
                    one = (VntCliente)row.DataBoundItem;

                    btnEdit.Visible = true;

                    if (one.deuda_moneda > 0) btnDeudas.Visible = true;
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                btnEdit.Visible = false;
                btnDeudas.Visible = false;
            }
        }
        private void frmVntClientesList_Activated(object sender, EventArgs e)
        {
            GetList();
        }
        private void frmVntClientesList_Load(object sender, EventArgs e)
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
