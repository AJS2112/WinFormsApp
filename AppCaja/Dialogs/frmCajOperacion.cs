﻿using App.CajMovimientoService;
using App.CajOperacionService;
using App.CnfCuentaBancariaService;
using App.Common.Classes;
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

namespace AppCaja.Dialogs
{
    public partial class frmCajOperacion : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES
        private List<SisOperacion> _listaOperaciones = new List<SisOperacion>();
        

        private List<CnfCuentaBancaria> _listaCuentasBancarias = new List<CnfCuentaBancaria>();
        private List<SisListas> _listaBancos = new List<SisListas>();
        private List<SisListas> _listaInstrumentos = new List<SisListas>();
        private List<App.CajMovimientoService.CajMovimiento> _listaInstrumentosSeleccionados = new List<App.CajMovimientoService.CajMovimiento>();

        private CajOperacionClient srv = new CajOperacionClient();
        private SisOperacionClient srvOperaciones = new SisOperacionClient();
        private CnfCuentaBancariaClient srvCuentasBancarias = new CnfCuentaBancariaClient();
        private SisListasClient srvListas = new SisListasClient();
        private SisOperacionClient srvOperacion = new SisOperacionClient();
        private CajOperacionClient srvCaja = new CajOperacionClient();
        private CajMovimientoClient srvMovimiento = new CajMovimientoClient();

        private App.CajOperacionService.CajMovimiento instrumentoSeleccionado = new App.CajOperacionService.CajMovimiento();
        private CajOperacion one = new CajOperacion();
        private SisOperacion _tipoOperacion = new SisOperacion();

        double factor = 0;
        #endregion

        #region METODOS
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

        private void CrearBindings()
        {
            dtFecha.DataBindings.Add("Value", one, "fecha", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDescripcion.DataBindings.Add("Text", one, "descripcion", true, DataSourceUpdateMode.OnPropertyChanged);

            _listaOperaciones = srvOperaciones.GetList("11E8FA24BAAD31B9AC3D00270E383B06");
            cmbTipoOperacion.DataSource = _listaOperaciones;
            cmbTipoOperacion.DisplayMember = "nombre";
            cmbTipoOperacion.ValueMember = "id";
        }

        private void ConfigurarInstrumento(List<App.CajMovimientoService.CajMovimiento> _lista)
        {
            if (_lista.Count > 0)
            {
                instrumentoSeleccionado.id = _lista[0].id;
                instrumentoSeleccionado.order_id = _lista[0].order_id;
                instrumentoSeleccionado.last_update = _lista[0].last_update;
                instrumentoSeleccionado.id_empresa = _lista[0].id_empresa;
                instrumentoSeleccionado.fecha = _lista[0].fecha;
                instrumentoSeleccionado.id_tipo_operacion = _lista[0].id_tipo_operacion;
                instrumentoSeleccionado.id_operacion = _lista[0].id_operacion;
                instrumentoSeleccionado.monto = _lista[0].monto;
                instrumentoSeleccionado.monto_moneda = _lista[0].monto_moneda;
                instrumentoSeleccionado.id_moneda = _lista[0].id_moneda;
                instrumentoSeleccionado.moneda_nombre = _lista[0].moneda_nombre;
                instrumentoSeleccionado.moneda_descrip = _lista[0].moneda_descrip;
                instrumentoSeleccionado.factor = _lista[0].factor;
                instrumentoSeleccionado.id_instrumento = _lista[0].id_instrumento;
                instrumentoSeleccionado.instrumento_nombre = _lista[0].instrumento_nombre;
                instrumentoSeleccionado.id_cuenta = _lista[0].id_cuenta;
                instrumentoSeleccionado.cuenta_numero = _lista[0].cuenta_numero;
                instrumentoSeleccionado.cuenta_banco = _lista[0].cuenta_banco;
                instrumentoSeleccionado.id_banco = _lista[0].id_banco;
                instrumentoSeleccionado.banco_nombre = _lista[0].banco_nombre;
                instrumentoSeleccionado.numero_operacion = _lista[0].numero_operacion;

                txtMonto.Text = (_lista[0].monto * factor).ToString("N2", Globals.nfiVE);
            }
            else
            {
                instrumentoSeleccionado.id = "0";
                instrumentoSeleccionado.order_id = 0;
                instrumentoSeleccionado.last_update = 0;
                instrumentoSeleccionado.id_empresa = Globals.logEmpresa.id;
                instrumentoSeleccionado.fecha = new DateTime();
                instrumentoSeleccionado.id_tipo_operacion = "";
                instrumentoSeleccionado.id_operacion = "";
                instrumentoSeleccionado.monto = Convert.ToDouble(txtMonto.Text) / factor;
                instrumentoSeleccionado.monto_moneda = Convert.ToDouble(txtMonto.Text);
                instrumentoSeleccionado.id_moneda = Globals.cotizacion[cmbCotizacion.SelectedIndex].id_moneda;
                instrumentoSeleccionado.moneda_nombre = Globals.cotizacion[cmbCotizacion.SelectedIndex].moneda_nombre;
                instrumentoSeleccionado.moneda_descrip = Globals.cotizacion[cmbCotizacion.SelectedIndex].moneda_descrip;
                instrumentoSeleccionado.factor = factor;
                instrumentoSeleccionado.id_instrumento = cmbInstrumento.SelectedValue.ToString();
                instrumentoSeleccionado.instrumento_nombre = cmbInstrumento.Text;
                instrumentoSeleccionado.id_cuenta = "";
                instrumentoSeleccionado.cuenta_numero = "";
                instrumentoSeleccionado.cuenta_banco = "";
                instrumentoSeleccionado.id_banco = "";
                instrumentoSeleccionado.banco_nombre = "";
                instrumentoSeleccionado.numero_operacion = "";
            }
        }
        #endregion

        

        public frmCajOperacion()
        {
            InitializeComponent();
            CrearBindings();
            CargarListas();
            Globals.ConfigurarComboMonedas(cmbCotizacion);
            txtMonto.Text = "0,00";

            //DETALLE
            _listaInstrumentosSeleccionados = srvMovimiento.GetList(one.id);
            ConfigurarInstrumento(_listaInstrumentosSeleccionados);
        }

        #region EVENTOS
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            CajOperacion _one = new CajOperacion();
            _one = srv.GetOne(Globals.logEmpresa.id, cmbTipoOperacion.SelectedValue.ToString(), "0");
            Console.WriteLine("A GUARDAR MOVIMIENTO");


            btnSave.Enabled = false;
            try
            {
                //DETALLE
                instrumentoSeleccionado.monto = Convert.ToDouble(txtMonto.Text) / factor;
                instrumentoSeleccionado.monto_moneda = Convert.ToDouble(txtMonto.Text);
                instrumentoSeleccionado.id_moneda = Globals.cotizacion[cmbCotizacion.SelectedIndex].id_moneda;
                instrumentoSeleccionado.moneda_nombre = Globals.cotizacion[cmbCotizacion.SelectedIndex].moneda_nombre;
                instrumentoSeleccionado.moneda_descrip = Globals.cotizacion[cmbCotizacion.SelectedIndex].moneda_descrip;
                instrumentoSeleccionado.factor = factor;
                instrumentoSeleccionado.id_instrumento = cmbInstrumento.SelectedValue.ToString();
                instrumentoSeleccionado.instrumento_nombre = cmbInstrumento.Text;
                instrumentoSeleccionado.id_cuenta = "";
                instrumentoSeleccionado.cuenta_numero = "";
                instrumentoSeleccionado.cuenta_banco = "";
                instrumentoSeleccionado.id_banco = "";
                instrumentoSeleccionado.banco_nombre = "";
                instrumentoSeleccionado.numero_operacion = "";

                if (cmbCuenta.Visible) instrumentoSeleccionado.id_cuenta = cmbCuenta.SelectedValue.ToString();
                if (cmbBanco.Visible) instrumentoSeleccionado.id_banco = cmbBanco.SelectedValue.ToString();
                if (txtNroOperacion.Visible) instrumentoSeleccionado.numero_operacion = txtNroOperacion.Text;

                List<App.CajOperacionService.CajMovimiento> _listaPago = new List<App.CajOperacionService.CajMovimiento>();
                _listaPago.Add(instrumentoSeleccionado);

                _one.monto = Convert.ToDouble(txtMonto.Text) / factor;
                _one.descripcion = txtDescripcion.Text;
                _one.id_cotizacion = Globals.cotizacion[0].id_cotizacion;
                _one.id_usuario = Globals.logUser.id;
                _one.id_status = 1;
                _one.id_estado = 1;

                string res = srvCaja.SetOne(_one, _listaPago);
                Console.WriteLine("HUBO RESPUESTA");
                if (res.Length > 1)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    Console.WriteLine("res: " + res);
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "No se guardó el registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ex: " + ex.Message);
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Se produjeron errores intentando procesar el registro, por favor revise los valores e intente nuevamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSave.Enabled = true;
            }
        }

        private void cmbCotizacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCotizacion.SelectedIndex > -1)
            {
                factor = Globals.cotizacion[cmbCotizacion.SelectedIndex].valor;
                txtTasa.Text = factor.ToString();
                instrumentoSeleccionado.monto_moneda = instrumentoSeleccionado.monto * factor;
            }
        }

        private void cmbInstrumento_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cmbInstrumento.SelectedValue.ToString())
            {
                case "11E8F78E1E002ADFB23400270E383B06": //EFECTIVO
                    lblBanco.Visible = false;
                    cmbBanco.Visible = false;
                    cmbCuenta.Visible = false;
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

        #endregion
    }
}
