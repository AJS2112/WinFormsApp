using App.Common.Classes;
using App.Common.Reports.Ventas;
using App.RepVentaService;
using App.SisEmpresaService;
using App.SisOperacionService;
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

namespace App.Core.Reportes
{
    public partial class frmRepVenta : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES

        private VntClienteClient srvVntCliente = new VntClienteClient();
        private RepVentaClient srvRepVenta = new RepVentaClient();
        private SisOperacionClient srvSisOperaciones = new SisOperacionClient();

        private List<RepVenta> listaVenta = new List<RepVenta>();
        List<VntCliente> lista = new List<VntCliente>();
        List<SisOperacion> listaOperaciones = new List<SisOperacion>();
        private VntCliente one = new VntCliente();

        SisEmpresa miEmpresa = new SisEmpresa();
        double factor = 0;
        #endregion

        #region METODOS
        private void CargarListas()
        {
            listaOperaciones = srvSisOperaciones.GetList("11E7C39A0EACD9A08F1A00E04C6F7E24");
            cmbOperaciones.DataSource = listaOperaciones;
            cmbOperaciones.DisplayMember = "nombre";
            cmbOperaciones.ValueMember = "id";

            lista = srvVntCliente.GetList(Globals.logEmpresa.id);
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

            dgvList.Columns[6].DisplayIndex = 0;
            dgvList.Columns[9].DisplayIndex = 1;

            dgvList.Columns[6].HeaderText = "NOMBRE";
            dgvList.Columns[6].Visible = true;
            dgvList.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvList.Columns[9].HeaderText = "RIF";
            dgvList.Columns[9].Visible = true;

        }

        private void filtrar(string filtro)
        {
            Console.WriteLine(filtro);
            dgvList.DataSource = lista.FindAll(o =>
                String.Join("", typeof(VntCliente).GetProperties().Select(f => f.GetValue(o))).ToLower().Contains(filtro.ToLower())).ToList();
        }
        private void SeleccionarReporte()
        {

            CrystalDecisions.Windows.Forms.CrystalReportViewer crView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            string id_moneda = Globals.cotizacion[cmbCotizacion.SelectedIndex].id_moneda;
            string id_operacion = cmbOperaciones.SelectedValue.ToString();
            switch (cmbReporte.SelectedIndex)
            {
                case 0: //"Resumen Operaciones
                    listaVenta = srvRepVenta.GetResumenOperaciones(miEmpresa.id, id_moneda, crearFecha(dtDesde.Value), crearFecha(dtHasta.Value));
                    crVntOperacionesResumen repResumenOperaciones = new crVntOperacionesResumen();
                    repResumenOperaciones.SetDataSource(listaVenta);
                    repResumenOperaciones.SetParameterValue("empresaNombre", miEmpresa.nombre);
                    repResumenOperaciones.SetParameterValue("empresaRif", miEmpresa.rif);
                    repResumenOperaciones.SetParameterValue("titulo", "RESUMEN OPERACIONES DE VENTA (" + cmbCotizacion.Text + ")");
                    repResumenOperaciones.SetParameterValue("intervaloFecha", dtDesde.Value.ToString("dd/MM/yyyy") + " - " + dtHasta.Value.ToString("dd/MM/yyyy"));
                    crView.ReportSource = repResumenOperaciones;

                    break;
                case 1: //Operaciones Detallado

                    listaVenta = srvRepVenta.GetDetalleOperaciones(miEmpresa.id, id_moneda, id_operacion, crearFecha(dtDesde.Value), crearFecha(dtHasta.Value));
                    crVntOperacionesDetalle repDetalleOperaciones = new crVntOperacionesDetalle();
                    repDetalleOperaciones.SetDataSource(listaVenta);
                    repDetalleOperaciones.SetParameterValue("empresaNombre", miEmpresa.nombre);
                    repDetalleOperaciones.SetParameterValue("empresaRif", miEmpresa.rif);
                    repDetalleOperaciones.SetParameterValue("titulo", "DETALLE OPERACIONES DE VENTA (" + cmbCotizacion.Text + ")");
                    repDetalleOperaciones.SetParameterValue("intervaloFecha", dtDesde.Value.ToString("dd/MM/yyyy") + " - " + dtHasta.Value.ToString("dd/MM/yyyy"));
                    crView.ReportSource = repDetalleOperaciones;

                    break;
                case 2: //Operaciones Cliente 
                    listaVenta = srvRepVenta.GetClienteOperaciones(miEmpresa.id, id_moneda, one.id, crearFecha(dtDesde.Value), crearFecha(dtHasta.Value));
                    crVntOperacionesCliente repClienteOperaciones = new crVntOperacionesCliente();
                    repClienteOperaciones.SetDataSource(listaVenta);
                    repClienteOperaciones.SetParameterValue("empresaNombre", miEmpresa.nombre);
                    repClienteOperaciones.SetParameterValue("empresaRif", miEmpresa.rif);
                    repClienteOperaciones.SetParameterValue("titulo", "DETALLE OPERACIONES DE VENTA (" + cmbCotizacion.Text + ")");
                    repClienteOperaciones.SetParameterValue("intervaloFecha", dtDesde.Value.ToString("dd/MM/yyyy") + " - " + dtHasta.Value.ToString("dd/MM/yyyy"));
                    crView.ReportSource = repClienteOperaciones;

                    break;
                case 3: //Deudas Cliente Resumen
                    listaVenta = srvRepVenta.GetClienteDeudasResumen(miEmpresa.id, id_moneda);
                    crVntClientesDeudasResumen repClientesDeudasResumen = new crVntClientesDeudasResumen();
                    repClientesDeudasResumen.SetDataSource(listaVenta);
                    repClientesDeudasResumen.SetParameterValue("empresaNombre", miEmpresa.nombre);
                    repClientesDeudasResumen.SetParameterValue("empresaRif", miEmpresa.rif);
                    repClientesDeudasResumen.SetParameterValue("titulo", "DETALLE DE CUENTAS POR COBRAR (" + cmbCotizacion.Text + ")");
                    crView.ReportSource = repClientesDeudasResumen;

                    break;
                case 4: //Deudas Cliente Detalle
                    listaVenta = srvRepVenta.GetClienteDeudasDetalle(miEmpresa.id, id_moneda, one.id);
                    crVntClientesDeudasDetalle repClientesDeudasDetalle = new crVntClientesDeudasDetalle();
                    repClientesDeudasDetalle.SetDataSource(listaVenta);
                    repClientesDeudasDetalle.SetParameterValue("empresaNombre", miEmpresa.nombre);
                    repClientesDeudasDetalle.SetParameterValue("empresaRif", miEmpresa.rif);
                    repClientesDeudasDetalle.SetParameterValue("titulo", "DETALLE DE CUENTAS POR COBRAR (" + cmbCotizacion.Text + ")");
                    crView.ReportSource = repClientesDeudasDetalle;

                    break;
                case 5: //Pagos Recibidos
                    listaVenta = srvRepVenta.GetClientePagosRecibidos(miEmpresa.id, one.id, crearFecha(dtDesde.Value), crearFecha(dtHasta.Value));
                    crVntClientesPagosRecibidos repClientesPagosRecibidos = new crVntClientesPagosRecibidos();
                    repClientesPagosRecibidos.SetDataSource(listaVenta);
                    repClientesPagosRecibidos.SetParameterValue("empresaNombre", miEmpresa.nombre);
                    repClientesPagosRecibidos.SetParameterValue("empresaRif", miEmpresa.rif);
                    repClientesPagosRecibidos.SetParameterValue("titulo", "PAGOS RECIBIDOS");
                    repClientesPagosRecibidos.SetParameterValue("intervaloFecha", dtDesde.Value.ToString("dd/MM/yyyy") + " - " + dtHasta.Value.ToString("dd/MM/yyyy"));
                    crView.ReportSource = repClientesPagosRecibidos;

                    break;

            }

            Form f = new frmReportViewer(crView);
            ConfigUI.LaunchChildForm(f, Globals.appParentWindow);
        }


        #endregion
        public frmRepVenta()
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
                case 2: //Listado de Clientes
                    dgvList.Visible = true;
                    txtFiltro.Visible = true;
                    break;
                case 4: //Deudas de Clientes
                    dgvList.Visible = true;
                    txtFiltro.Visible = true;
                    break;
                case 5: //Pagos Recibidos
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
                    one = (VntCliente)row.DataBoundItem;
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
