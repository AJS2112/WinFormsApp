using App.CnfCuentaBancariaService;
using App.Common.Classes;
using App.Common.Reports.Caja;
using App.RepCajaService;
using App.SisEmpresaService;
using App.SisListasService;
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
    public partial class frmRepCaja : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES

        //private VntClienteClient srvVntCliente = new VntClienteClient();
        private RepCajaClient srvRepCaja = new RepCajaClient();
        private CnfCuentaBancariaClient srvCuentasBancarias = new CnfCuentaBancariaClient();
        private SisListasClient srvListas = new SisListasClient();

        private List<RepCaja> listaCaja = new List<RepCaja>();
        private List<CnfCuentaBancaria> _listaCuentasBancarias = new List<CnfCuentaBancaria>();
        private List<SisListas> _listaInstrumentos = new List<SisListas>();

        SisEmpresa miEmpresa = new SisEmpresa();
        double factor = 0;
        #endregion

        #region METODOS
        private void CargarListas()
        {
            _listaCuentasBancarias = srvCuentasBancarias.GetList(Globals.logEmpresa.id);
            cmbCuenta.DataSource = _listaCuentasBancarias;
            cmbCuenta.DisplayMember = "numero";
            cmbCuenta.ValueMember = "id";


            _listaInstrumentos = srvListas.GetList(Globals.logEmpresa.instrumentos_pago);
            cmbInstrumento.DataSource = _listaInstrumentos;
            cmbInstrumento.DisplayMember = "nombre";
            cmbInstrumento.ValueMember = "id";

        }

        private string crearFecha(DateTime _fecha)
        {
            string fecha = _fecha.ToString("yy/M/d HH:mm:ss");
            return fecha;
        }

        private void SeleccionarReporte()
        {

            CrystalDecisions.Windows.Forms.CrystalReportViewer crView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();

            string id_moneda = Globals.cotizacion[cmbCotizacion.SelectedIndex].id_moneda;
            string id_cuenta = "";
            if (_listaCuentasBancarias.Count>0) id_cuenta = cmbCuenta.SelectedValue.ToString();
            string id_instrumento = cmbInstrumento.SelectedValue.ToString();

            switch (cmbReporte.SelectedIndex)
            {
                case 0: //INstrumento Resumen
                    listaCaja = srvRepCaja.GetInstrumentosResumen(miEmpresa.id, id_moneda, crearFecha(dtDesde.Value), crearFecha(dtHasta.Value));
                    crCajInstrumentoResumen repInstrumentosResumen = new crCajInstrumentoResumen();
                    repInstrumentosResumen.SetDataSource(listaCaja);
                    repInstrumentosResumen.SetParameterValue("empresaNombre", miEmpresa.nombre);
                    repInstrumentosResumen.SetParameterValue("empresaRif", miEmpresa.rif);
                    repInstrumentosResumen.SetParameterValue("titulo", "RESUMEN INSTRUMENTOS DE PAGO (" + cmbCotizacion.Text + ")");
                    repInstrumentosResumen.SetParameterValue("intervaloFecha", dtDesde.Value.ToString("dd/MM/yyyy") + " - " + dtHasta.Value.ToString("dd/MM/yyyy"));
                    crView.ReportSource = repInstrumentosResumen;

                    break;
                case 1: //Instrumento Detallado

                    listaCaja = srvRepCaja.GetInstrumentosDetalle(miEmpresa.id, id_moneda, id_instrumento, crearFecha(dtDesde.Value), crearFecha(dtHasta.Value));
                    crCajInstrumentosDetalle repDetalleOperaciones = new crCajInstrumentosDetalle();
                    repDetalleOperaciones.SetDataSource(listaCaja);
                    repDetalleOperaciones.SetParameterValue("empresaNombre", miEmpresa.nombre);
                    repDetalleOperaciones.SetParameterValue("empresaRif", miEmpresa.rif);
                    repDetalleOperaciones.SetParameterValue("titulo", "DETALLE INSTRUMENTO DE PAGO (" + cmbCotizacion.Text + ")");
                    repDetalleOperaciones.SetParameterValue("intervaloFecha", dtDesde.Value.ToString("dd/MM/yyyy") + " - " + dtHasta.Value.ToString("dd/MM/yyyy"));
                    crView.ReportSource = repDetalleOperaciones;

                    break;
                case 2: //Cuentas Resumen
                    listaCaja = srvRepCaja.GetCuentasResumen(miEmpresa.id, id_moneda, crearFecha(dtDesde.Value), crearFecha(dtHasta.Value));
                    crCajCuentaResumen repCuentaResumen = new crCajCuentaResumen();
                    repCuentaResumen.SetDataSource(listaCaja);
                    repCuentaResumen.SetParameterValue("empresaNombre", miEmpresa.nombre);
                    repCuentaResumen.SetParameterValue("empresaRif", miEmpresa.rif);
                    repCuentaResumen.SetParameterValue("titulo", "RESUMEN CUENTAS BANCARIAS (" + cmbCotizacion.Text + ")");
                    repCuentaResumen.SetParameterValue("intervaloFecha", dtDesde.Value.ToString("dd/MM/yyyy") + " - " + dtHasta.Value.ToString("dd/MM/yyyy"));
                    crView.ReportSource = repCuentaResumen;

                    break;
                case 3: //Cuentas Detalle
                    listaCaja = srvRepCaja.GetCuentasDetalle (miEmpresa.id, id_moneda, id_cuenta, crearFecha(dtDesde.Value), crearFecha(dtHasta.Value));
                    crCajCuentaDetalle repCuentaDetalle = new crCajCuentaDetalle();
                    repCuentaDetalle.SetDataSource(listaCaja);
                    repCuentaDetalle.SetParameterValue("empresaNombre", miEmpresa.nombre);
                    repCuentaDetalle.SetParameterValue("empresaRif", miEmpresa.rif);
                    repCuentaDetalle.SetParameterValue("titulo", "DETALLE DE CUENTAS BANCARIAS (" + cmbCotizacion.Text + ")");
                    crView.ReportSource = repCuentaDetalle;

                    break;


            }

            Form f = new frmReportViewer(crView);
            ConfigUI.LaunchChildForm(f, Globals.appParentWindow);
        }


        #endregion
        public frmRepCaja()
        {
            InitializeComponent();
            miEmpresa = Globals.logEmpresa;
            Globals.ConfigurarComboMonedas(cmbCotizacion);
            dtDesde.Value = dtDesde.Value.AddMonths(-1);

            CargarListas();

            cmbReporte.SelectedIndex = 0;
        }

        #region EVENTOS

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbInstrumento.Visible = false;
            cmbCuenta.Visible = false;
            lblCuenta.Visible = false;
            lblInstrumento.Visible = false;

            switch (cmbReporte.SelectedIndex)
            {
                case 0: //Instrumento Resumen 
                    break;
                case 1: //Instrumento Detalle
                    cmbInstrumento.Visible = true;
                    break;
                case 2: //Cuenta Resumen
                    break;
                case 3: //Cuenta Detalle
                    cmbCuenta.Visible = true;
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

        
        #endregion
    }
}
