using App.CajMovimientoService;
using App.CnfCuentaBancariaService;
using App.Common.Classes;
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

namespace App.Core.Caja
{
    public partial class frmCajMovimientoSelection : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES
        private CnfCuentaBancariaClient srvCuentasBancarias = new CnfCuentaBancariaClient();
        private SisListasClient srvListas = new SisListasClient();

        private List<CnfCuentaBancaria> _listaCuentasBancarias = new List<CnfCuentaBancaria>();
        private List<SisListas> _listaBancos = new List<SisListas>();
        private List<SisListas> _listaInstrumentos = new List<SisListas>();

        public List<CajMovimiento> instrumentosSeleccionados = new List<CajMovimiento>();

        private double _totalDocumento=0;
        private double _totalSeleccionado = 0;
        private double _totalResta = 0;

        double factor = 0;
        string _padre = "";
        #endregion

        #region METODOS
        private void AgregarListaInstrumentos()
        {
            int items = 0;
            foreach (CajMovimiento item in instrumentosSeleccionados)
            {
                switch (items)
                {
                    case 0:
                        lblInstrumento0.Visible = true;
                        lblMonto0.Visible = true;
                        lblEliminar0.Visible = true;

                        lblInstrumento0.Text = item.instrumento_nombre;
                        lblMonto0.Text = item.monto_moneda.ToString("N2", Globals.nfiVE);
                        break;
                    case 1:
                        lblInstrumento1.Visible = true;
                        lblMonto1.Visible = true;
                        lblEliminar1.Visible = true;

                        lblInstrumento1.Text = item.instrumento_nombre;
                        lblMonto1.Text = item.monto_moneda.ToString("N2", Globals.nfiVE);
                        break;
                    case 2:
                        lblInstrumento2.Visible = true;
                        lblMonto2.Visible = true;
                        lblEliminar2.Visible = true;

                        lblInstrumento2.Text = item.instrumento_nombre;
                        lblMonto2.Text = item.monto_moneda.ToString("N2", Globals.nfiVE);
                        break;

                    case 3:
                        lblInstrumento3.Visible = true;
                        lblMonto3.Visible = true;
                        lblEliminar3.Visible = true;

                        lblInstrumento3.Text = item.instrumento_nombre;
                        lblMonto3.Text = item.monto_moneda.ToString("N2", Globals.nfiVE);
                        break;

                    case 4:
                        lblInstrumento4.Visible = true;
                        lblMonto4.Visible = true;
                        lblEliminar4.Visible = true;

                        lblInstrumento4.Text = item.instrumento_nombre;
                        lblMonto4.Text = item.monto_moneda.ToString("N2", Globals.nfiVE);
                        break;

                    case 5:
                        lblInstrumento5.Visible = true;
                        lblMonto5.Visible = true;
                        lblEliminar5.Visible = true;

                        lblInstrumento5.Text = item.instrumento_nombre;
                        lblMonto5.Text = item.monto_moneda.ToString("N2", Globals.nfiVE);
                        break;
                }
                items += 1;

            }
        }
        private void CalcularTotales()
        {
            Console.WriteLine("CalcularTotales");
            btnSel.Visible = false;
            _totalSeleccionado = 0;
            txtTotalDocumento.Text = (_totalDocumento * factor).ToString("N2", Globals.nfiVE);

            if (instrumentosSeleccionados.Count>0)
            {
                for (var i = 0; i < instrumentosSeleccionados.Count; i++)
                {
                    _totalSeleccionado += instrumentosSeleccionados[i].monto;
                }
            }

            _totalResta = _totalDocumento - _totalSeleccionado;

            txtMonto.Text = (_totalResta * factor).ToString("N2", Globals.nfiVE);
            txtTotalSeleccionado.Text = (_totalSeleccionado * factor).ToString("N2", Globals.nfiVE);
            txtTotalResta.Text = (_totalResta * factor).ToString("N2", Globals.nfiVE);
            Console.WriteLine("_totalSeleccionado: " + _totalSeleccionado.ToString());
            Console.WriteLine("_totalDocumento: " + _totalDocumento.ToString());

            if (_padre == "venta")
            {
                if (Convert.ToDouble(txtTotalResta.Text) <= 0) btnSel.Visible = true;
                
            } else
            {
                if (Convert.ToDouble(txtTotalSeleccionado.Text) > 0)  btnSel.Visible = true;
            }


        }

        private void CargarListas()
        {
            _listaCuentasBancarias = srvCuentasBancarias.GetList(Globals.logEmpresa.id);
            cmbCuenta.DataSource = _listaCuentasBancarias;
            cmbCuenta.DisplayMember = "numero";
            cmbCuenta.ValueMember = "id";

            _listaBancos = srvListas.GetListByCampo("bancos");
            cmbBanco.DataSource = _listaBancos;
            cmbBanco.DisplayMember = "nombre";
            cmbBanco.ValueMember = "id";

            _listaInstrumentos = srvListas.GetList(Globals.logEmpresa.instrumentos_pago);
            cmbInstrumento.DataSource = _listaInstrumentos;
            cmbInstrumento.DisplayMember = "nombre";
            cmbInstrumento.ValueMember = "id";

        }

        private void OcultarListaInstrumentos()
        {
            lblInstrumento0.Visible = false;
            lblInstrumento1.Visible = false;
            lblInstrumento2.Visible = false;
            lblInstrumento3.Visible = false;
            lblInstrumento4.Visible = false;
            lblInstrumento5.Visible = false;

            lblMonto0.Visible = false;
            lblMonto1.Visible = false;
            lblMonto2.Visible = false;
            lblMonto3.Visible = false;
            lblMonto4.Visible = false;
            lblMonto5.Visible = false;

            lblEliminar0.Visible = false;
            lblEliminar1.Visible = false;
            lblEliminar2.Visible = false;
            lblEliminar3.Visible = false;
            lblEliminar4.Visible = false;
            lblEliminar5.Visible = false;

            lblInstrumento0.Text = "";
            lblInstrumento1.Text = "";
            lblInstrumento2.Text = "";
            lblInstrumento3.Text = "";
            lblInstrumento4.Text = "";
            lblInstrumento5.Text = "";

            lblMonto0.Text = "0,00";
            lblMonto1.Text = "0,00";
            lblMonto2.Text = "0,00";
            lblMonto3.Text = "0,00";
            lblMonto4.Text = "0,00";
            lblMonto5.Text = "0,00";
        }
        #endregion

        //CONSTRUCTORES
        public frmCajMovimientoSelection()
        {
            InitializeComponent();
        }

        public frmCajMovimientoSelection(double _total, List<CajMovimiento> _instrumentos, string padre)
        {
            _totalDocumento = _total;
            _padre = padre;

            InitializeComponent();
            CargarListas();
            Globals.ConfigurarComboMonedas(cmbCotizacion);
            instrumentosSeleccionados = _instrumentos;
            foreach (CajMovimiento item in instrumentosSeleccionados)
            {
                item.monto_moneda = item.monto * factor;
            }
            OcultarListaInstrumentos();
            AgregarListaInstrumentos();
            CalcularTotales();
        }

        #region EVENTOS
        private void btnAdd_Click(object sender, EventArgs e)
        {

            CajMovimiento _instrumento = new CajMovimiento();

            _instrumento.id = "0";
            _instrumento.order_id = 0;
            _instrumento.last_update = 0;
            _instrumento.id_empresa = Globals.logEmpresa.id;
            _instrumento.fecha = new DateTime();
            _instrumento.id_tipo_operacion = "";
            _instrumento.id_operacion = "";
            _instrumento.monto = Convert.ToDouble(txtMonto.Text) / factor;
            _instrumento.monto_moneda = Convert.ToDouble(txtMonto.Text);
            _instrumento.id_moneda = Globals.cotizacion[cmbCotizacion.SelectedIndex].id_moneda;
            _instrumento.moneda_nombre = Globals.cotizacion[cmbCotizacion.SelectedIndex].moneda_nombre;
            _instrumento.moneda_descrip = Globals.cotizacion[cmbCotizacion.SelectedIndex].moneda_descrip;
            _instrumento.factor = factor;
            _instrumento.id_instrumento = cmbInstrumento.SelectedValue.ToString();
            _instrumento.instrumento_nombre = cmbInstrumento.Text;
            _instrumento.id_cuenta = "";
            _instrumento.cuenta_numero = "";
            _instrumento.cuenta_banco = "";
            _instrumento.id_banco = "";
            _instrumento.banco_nombre = "";
            _instrumento.numero_operacion = "";
            if (cmbCuenta.Visible) _instrumento.id_cuenta = cmbCuenta.SelectedValue.ToString();
            if (cmbBanco.Visible) _instrumento.id_banco = cmbBanco.SelectedValue.ToString();
            if (txtNroOperacion.Visible) _instrumento.numero_operacion = txtNroOperacion.Text;
            instrumentosSeleccionados.Add(_instrumento);

            OcultarListaInstrumentos();

            AgregarListaInstrumentos();

            CalcularTotales();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSel_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Seleccion: " );
            this.DialogResult = DialogResult.OK;
        }


        private void cmbCotizacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCotizacion.SelectedIndex > -1)
            {
                factor = Globals.cotizacion[cmbCotizacion.SelectedIndex].valor;
                txtTasa.Text = factor.ToString();
                foreach (CajMovimiento item in instrumentosSeleccionados)
                {
                    item.monto_moneda = item.monto * factor;
                }
                OcultarListaInstrumentos();
                AgregarListaInstrumentos();
                CalcularTotales();
            }
        }
        #endregion

        private void cmbInstrumento_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cmbInstrumento.SelectedValue.ToString())
            {
                case "11E8F78E1E002ADFB23400270E383B06": //EFECTIVO
                    lblBanco.Visible = false;
                    cmbBanco.Visible = false;
                    cmbCuenta.Visible= false;
                    lblCuenta.Visible = false;
                    lblNroOperacion.Visible = false;
                    txtNroOperacion.Visible = false;
                    break;
                case "11E8F78E51460978B23400270E383B06": //CHEQUE
                    lblBanco.Visible = true;
                    cmbBanco.Visible = true;
                    lblCuenta.Visible = false;
                    cmbCuenta.Visible = false;
                    lblNroOperacion.Visible = true;
                    txtNroOperacion.Visible = true;
                    break;
                case "11E8F78E5F7F6327B23400270E383B06": //DEPOSITO
                    lblBanco.Visible = false;
                    cmbBanco.Visible = false;
                    lblCuenta.Visible = true;
                    cmbCuenta.Visible = true;
                    lblNroOperacion.Visible = true;
                    txtNroOperacion.Visible = true;
                    break;
                case "11E8F78E66E6B6F5B23400270E383B06": //PUNTO VENTA
                    lblBanco.Visible = false;
                    cmbBanco.Visible = false;
                    lblCuenta.Visible = true;
                    cmbCuenta.Visible = true;
                    lblNroOperacion.Visible = false;
                    txtNroOperacion.Visible = false;
                    break;
                case "11E93E7A9E776D889B0D00E04C6F7E24": //CREDITO
                    lblBanco.Visible = false;
                    cmbBanco.Visible = false;
                    lblCuenta.Visible = false;
                    cmbCuenta.Visible = false;
                    lblNroOperacion.Visible = false;
                    txtNroOperacion.Visible = false;
                    break;
            }
        }


        private void lblEliminar0_Click(object sender, EventArgs e)
        {
            instrumentosSeleccionados.RemoveAt(0);

            OcultarListaInstrumentos();

            AgregarListaInstrumentos();

            CalcularTotales();
        }

        private void lblEliminar1_Click(object sender, EventArgs e)
        {
            instrumentosSeleccionados.RemoveAt(1);

            OcultarListaInstrumentos();

            AgregarListaInstrumentos();

            CalcularTotales();
        }

        private void lblEliminar2_Click(object sender, EventArgs e)
        {
            instrumentosSeleccionados.RemoveAt(2);

            OcultarListaInstrumentos();

            AgregarListaInstrumentos();

            CalcularTotales();
        }

        private void lblEliminar3_Click(object sender, EventArgs e)
        {
            instrumentosSeleccionados.RemoveAt(3);

            OcultarListaInstrumentos();

            AgregarListaInstrumentos();

            CalcularTotales();
        }

        private void lblEliminar4_Click(object sender, EventArgs e)
        {
            instrumentosSeleccionados.RemoveAt(4);

            OcultarListaInstrumentos();

            AgregarListaInstrumentos();

            CalcularTotales();
        }

        private void lblEliminar5_Click(object sender, EventArgs e)
        {
            instrumentosSeleccionados.RemoveAt(5);

            OcultarListaInstrumentos();

            AgregarListaInstrumentos();

            CalcularTotales();
        }
    }
}
