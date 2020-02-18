using App.CmpProveedorService;
using App.Common.Classes;
using App.Common.Reports.Compras;
using App.RepCompraService;
using App.SisEmpresaService;
using App.SisListasService;
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

namespace App.Core.Reportes
{
    public partial class frmRepCompra : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES

        private CmpProveedorClient srvCmpProveedor = new CmpProveedorClient();
        private RepCompraClient srvRepCompra = new RepCompraClient();
        private SisOperacionClient srvSisOperaciones = new SisOperacionClient();

        private List<RepCompra> listaCompra = new List<RepCompra>();
        List<CmpProveedor> lista = new List<CmpProveedor>();
        List<SisOperacion> listaOperaciones = new List<SisOperacion>();
        private CmpProveedor one = new CmpProveedor();

        SisEmpresa miEmpresa = new SisEmpresa();
        double factor = 0;
        #endregion

        #region METODOS
        private void CargarListas()
        {
            listaOperaciones = srvSisOperaciones.GetList("11E8F22292A5ED4B8FF600270E383B06");
            cmbOperaciones.DataSource = listaOperaciones;
            cmbOperaciones.DisplayMember = "nombre";
            cmbOperaciones.ValueMember = "id";

            lista = srvCmpProveedor.GetList(Globals.logEmpresa.id);
            filtrar(txtFiltro.Text);
            dgvList.Refresh();
        }

        private string crearFecha(DateTime _fecha)
        {
            string fecha = _fecha.ToString("yy/M/d HH:mm:ss");
            return fecha;
        }

        private void ConfigGrid()
        {
            for (int i = 0; i <= dgvList.Columns.Count - 1; i++)
            {
                dgvList.Columns[i].Visible = false;
                //Console.WriteLine(i.ToString() + dgvList.Columns[i].HeaderText);
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
        }

        private void filtrar(string filtro)
        {
            Console.WriteLine(filtro);
            dgvList.DataSource = lista.FindAll(o =>
                String.Join("", typeof(CmpProveedor).GetProperties().Select(f => f.GetValue(o))).ToLower().Contains(filtro.ToLower())).ToList();
        }
        private void SeleccionarReporte()
        {
            
            CrystalDecisions.Windows.Forms.CrystalReportViewer crView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            string id_moneda= Globals.cotizacion[cmbCotizacion.SelectedIndex].id_moneda;
            string id_operacion = cmbOperaciones.SelectedValue.ToString();
            switch (cmbReporte.SelectedIndex)
            {
                case 0: //"Resumen Operaciones
                    listaCompra = srvRepCompra.GetResumenOperaciones(miEmpresa.id, id_moneda, crearFecha(dtDesde.Value), crearFecha(dtHasta.Value));
                    crCmpOperacionesResumen repResumenOperaciones = new crCmpOperacionesResumen();
                    repResumenOperaciones.SetDataSource(listaCompra);
                    repResumenOperaciones.SetParameterValue("empresaNombre", miEmpresa.nombre);
                    repResumenOperaciones.SetParameterValue("empresaRif", miEmpresa.rif);
                    repResumenOperaciones.SetParameterValue("titulo", "RESUMEN OPERACIONES DE COMPRA (" + cmbCotizacion.Text + ")");
                    repResumenOperaciones.SetParameterValue("intervaloFecha", dtDesde.Value.ToString("dd/MM/yyyy") + " - " + dtHasta.Value.ToString("dd/MM/yyyy"));
                    crView.ReportSource = repResumenOperaciones;

                    break;
                case 1: //Operaciones Detallado
                    
                    listaCompra = srvRepCompra.GetDetalleOperaciones(miEmpresa.id, id_moneda, id_operacion, crearFecha(dtDesde.Value), crearFecha(dtHasta.Value));
                    crCmpOperacionesDetalle repDetalleOperaciones = new crCmpOperacionesDetalle();
                    repDetalleOperaciones.SetDataSource(listaCompra);
                    repDetalleOperaciones.SetParameterValue("empresaNombre", miEmpresa.nombre);
                    repDetalleOperaciones.SetParameterValue("empresaRif", miEmpresa.rif);
                    repDetalleOperaciones.SetParameterValue("titulo", "DETALLE OPERACIONES DE COMPRA (" + cmbCotizacion.Text + ")");
                    repDetalleOperaciones.SetParameterValue("intervaloFecha", dtDesde.Value.ToString("dd/MM/yyyy") + " - " + dtHasta.Value.ToString("dd/MM/yyyy"));
                    crView.ReportSource = repDetalleOperaciones;

                    break;
                case 2: //Operaciones Proveedor
                    listaCompra = srvRepCompra.GetProveedorOperaciones(miEmpresa.id, id_moneda, one.id, crearFecha(dtDesde.Value), crearFecha(dtHasta.Value));
                    crCmpOperacionesProveedor repProveedorOperaciones = new crCmpOperacionesProveedor();
                    repProveedorOperaciones.SetDataSource(listaCompra);
                    repProveedorOperaciones.SetParameterValue("empresaNombre", miEmpresa.nombre);
                    repProveedorOperaciones.SetParameterValue("empresaRif", miEmpresa.rif);
                    repProveedorOperaciones.SetParameterValue("titulo", "DETALLE OPERACIONES DE COMPRA (" + cmbCotizacion.Text + ")");
                    repProveedorOperaciones.SetParameterValue("intervaloFecha", dtDesde.Value.ToString("dd/MM/yyyy") + " - " + dtHasta.Value.ToString("dd/MM/yyyy"));
                    crView.ReportSource = repProveedorOperaciones;

                    break;
            }

            Form f = new frmReportViewer(crView);
            ConfigUI.LaunchChildForm(f, Globals.appParentWindow);
        }


        #endregion
        public frmRepCompra()
        {
            InitializeComponent();
            miEmpresa = Globals.logEmpresa;
            Globals.ConfigurarComboMonedas(cmbCotizacion);
            dtDesde.Value = dtDesde.Value.AddMonths(-1);

            CargarListas();
            ConfigGrid();

            cmbReporte.SelectedIndex = 0;
        }

        #region EVENTOS

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbOperaciones.Visible = false;
            dgvList.Visible = false;
            txtFiltro.Visible = false;

            switch (cmbReporte.SelectedIndex)
            {
                case 1: //Detalle Operaciones
                    cmbOperaciones.Visible = true;
                    break;
                case 2: //Listado de Proveedores
                    dgvList.Visible = true;
                    txtFiltro.Visible = true;
                    break;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SeleccionarReporte();
        }

        private void cmbCotizacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            factor = Globals.cotizacion[cmbCotizacion.SelectedIndex].valor;
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
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                btnPrint.Visible = true;
            }
            else
            {
                btnPrint.Visible = false;
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            filtrar(txtFiltro.Text);
        }
        #endregion
    }
}
