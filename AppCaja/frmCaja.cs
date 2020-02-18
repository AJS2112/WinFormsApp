using App.CajMovimientoService;
using App.CnfCotizacionService;
using App.ColMovimientoService;
using App.ColOperacionService;
using App.Common.Classes;
using App.SisOperacionService;
using App.VntClienteService;
using App.VntOperacionService;
using AppCaja.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using TfhkaNet.IF.VE;

namespace AppCaja
{
    public partial class frmCaja : Form
    {
        #region VARIABLES

        //SERVICIOS
        private ColOperacionClient srvCola = new ColOperacionClient();
        private CnfCotizacionClient srvCotizacion = new CnfCotizacionClient();
        private VntOperacionClient srvVenta = new VntOperacionClient();
        private ColMovimientoClient srvMovimiento = new ColMovimientoClient();
        private VntClienteClient srvCliente = new VntClienteClient();

        /*
        private InvMovimientoClient srvMovimiento = new InvMovimientoClient();
        private CajMovimientoClient srvMovimientoCaja = new CajMovimientoClient();
        
        
        private SisOperacionClient srvOperacion = new SisOperacionClient();
        private SisListasClient srvListas = new SisListasClient();
             */


        //LISTAS
        private List<CnfCotizacionDetalle> _listaCotizacion = new List<CnfCotizacionDetalle>();
        private List<App.CajMovimientoService.CajMovimiento> _listaInstrumentos = new List<App.CajMovimientoService.CajMovimiento>();
        private List<App.ColMovimientoService.ColMovimiento> _listaDetalle = new List<App.ColMovimientoService.ColMovimiento>();
        /*
        private List<SisOperacion> _listaOperaciones = new List<SisOperacion>();
        private List<App.InvMovimientoService.InvMovimiento> _listaDetalle = new List<App.InvMovimientoService.InvMovimiento>();

        */

        //OBJETOS
        private CnfCotizacionDetalle _oneCotizacion = new CnfCotizacionDetalle();
        private ColOperacion one { get; set; }
        private SisOperacion _tipoOperacion = new SisOperacion();
        private VntCliente _oneCliente { get; set; }
        private App.InvMovimientoService.InvMovimiento _movimiento { get; set; }
        //private InvProducto _productoSeleccionado { get; set; }
        // private S5PrinterData EstatusS5;
        

        //BINDINGS
        BindingSource bs = new BindingSource();
        BindingList<ColOperacion> bList;

        //VARIABLES
        private bool Respuesta;
        private string puertoCOM;
        double factor = 1;
        private string id_cotizacion = "";

        //TIMERS
        private System.Timers.Timer timerHora = new System.Timers.Timer();
        private System.Timers.Timer timerCola = new System.Timers.Timer();

        #endregion


        #region METODOS

        private void CheckImpresoraFiscal()
        {
            Globals.appParentWindow = this;

            //APP PATH
            string appPath = Application.StartupPath;
            Console.WriteLine("appPath: " + appPath);

            //READ CONFIG
            string puertoCOM = ConfigurationManager.AppSettings["puerto"];

            //Console.WriteLine("puerto COM: " + puertoCOM);
            Globals.Impresora = new Tfhka();
            S3PrinterData impresoraS3;

            //INICIALIZAR IMPRESORA
            Boolean puerto = Globals.Impresora.OpenFpCtrl(puertoCOM);
            Console.WriteLine("PuertoCOM: " + puertoCOM);
            if (puerto)
            {
                Respuesta = Globals.Impresora.CheckFPrinter();
                if (Respuesta == true)
                {
                    lblPrinterStatus.ForeColor = Color.Green;
                    lblPrinterStatus.Text = "Impresora en línea";

                    //ASIGNAR TASAS IMPRESORA
                    Console.WriteLine("Aqui es q va la vaina");
                    Console.WriteLine(Globals.TasaG);
                    Console.WriteLine(Globals.TasaR);
                    Console.WriteLine(Globals.TasaA);
                    //impresoraS3 = Globals.Impresora.GetS3PrinterData();
                    //Globals.TasaG = impresoraS3.Tax1;
                    //Globals.TasaR = impresoraS3.Tax2;
                    //Globals.TasaA = impresoraS3.Tax3;

                    //Console.WriteLine(Globals.TasaG);
                    //Console.WriteLine(Globals.TasaR);
                    //Console.WriteLine(Globals.TasaA);
                }
                else
                {
                    lblPrinterStatus.ForeColor = Color.Red;
                    lblPrinterStatus.Text = "Impresora sin conexión";
                }
            }
            else
            {
                lblPrinterStatus.ForeColor = Color.Red;
                lblPrinterStatus.Text = "No pudo abrir puerto";
            }
            
        }

        private void CargarListas()
        {
        }

        private void CargarCola()
        {

            bList = new BindingList<ColOperacion>(srvCola.GetList(Globals.logEmpresa.id, "11E7C39A0EACD9A08F1A00E04C6F7E24", 1));
            bs.DataSource = bList;
            dgvList.DataSource = bs;

            lblDocumentosCola.Text = "Documentos en Cola: "+ bList.Count.ToString();
            Totalizar();
        }

        private void ConfigGrid()
        {
            for (int i = 0; i <= dgvList.Columns.Count - 1; i++)
            {
                dgvList.Columns[i].Visible = false;
                //Console.WriteLine(i.ToString() + " - " + dgvList.Columns[i].HeaderText);
            }

            dgvList.Columns[47].DisplayIndex = 0;
            /*dgvList.Columns[17].DisplayIndex = 0;
            dgvList.Columns[18].DisplayIndex = 1;
            dgvList.Columns[19].DisplayIndex = 2;
            dgvList.Columns[16].DisplayIndex = 3;*/
            
            
            dgvList.Columns[47].HeaderText = "OPERACION";
            dgvList.Columns[47].Visible = true;
            //dgvList.Columns[17].Width = 140;
            dgvList.Columns[47].ReadOnly = true;
            

            dgvList.Columns[8].HeaderText = "CLIENTE";
            dgvList.Columns[8].Visible = true;
            dgvList.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvList.Columns[8].ReadOnly = true;

            dgvList.Columns[9].HeaderText = "RIF";
            dgvList.Columns[9].Visible = true;
            //dgvList.Columns[19].Width = 80;
            dgvList.Columns[9].ReadOnly = true;

            dgvList.Columns[49].HeaderText = "MONTO";
            dgvList.Columns[49].Visible = true;
            dgvList.Columns[49].DefaultCellStyle.FormatProvider = Globals.nfiVE;
            dgvList.Columns[49].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvList.Columns[49].DefaultCellStyle.Format = "N2";
            dgvList.Columns[49].ReadOnly = true;
            //dgvList.Columns[2].Width = 90;

            /*
            dgvList.Columns[0].HeaderText = "CANTIDAD";
            dgvList.Columns[0].Visible = true;
            dgvList.Columns[0].DefaultCellStyle.FormatProvider = Globals.nfiVE;
            dgvList.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvList.Columns[0].DefaultCellStyle.Format = "N2";
            //dgvList.Columns[0].Width = 90;

            dgvList.Columns[13].HeaderText = "MONTO";
            dgvList.Columns[13].Visible = true;
            dgvList.Columns[13].DefaultCellStyle.FormatProvider = Globals.nfiVE;
            dgvList.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvList.Columns[13].DefaultCellStyle.Format = "N2";
            //dgvList.Columns[13].Width = 134;
            dgvList.Columns[13].ReadOnly = true;
            */
        }

        private void EliminarItem()
        {
            if (dgvList.RowCount > 0)
            {
                string item = dgvList[dgvList.CurrentCell.ColumnIndex, dgvList.CurrentCell.RowIndex].Value.ToString();
                if (item != null)
                {
                    System.Windows.Forms.DialogResult resDel = MetroFramework.MetroMessageBox.Show(this.MdiParent, "¿Desea eliminar el item seleccionado?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resDel == DialogResult.Yes)
                    {

                        ColOperacion obj = (ColOperacion)dgvList.CurrentRow.DataBoundItem;
                        bList.Remove(obj);
                        //Totalizar();
                    }
                }
            }

            /*btnDel.Visible = false;
            if (bList.Count > 0)
            {
                btnDel.Visible = true;
            }*/
            //Totalizar();
        }
        
        private SisOperacion GetTipoOperacion(string idTipoOperacion)
        {
            
            SisOperacion _operacion = new SisOperacion();
            /*foreach (SisOperacion item in _listaOperaciones)
            {
                if (item.id == idTipoOperacion)
                {
                    _operacion = item;
                }
            }*/
            return _operacion;
            
        }
            
        private void imprimirOperacion()
        {
            /*
            double montoExento = (one.monto_exento) * factor;
            double montoBase = (one.base_imponible_ta + one.base_imponible_tg + one.base_imponible_tr) * factor;
            double montoIva = (one.monto_iva_ta + one.monto_iva_tg + one.monto_iva_tr) * factor;

            CrystalDecisions.Windows.Forms.CrystalReportViewer crView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            crVntOperacion repOperacion = new crVntOperacion();
            repOperacion.SetDataSource(_listaDetalle);
            repOperacion.SetParameterValue("empresaNombre", Globals.logEmpresa.nombre);
            repOperacion.SetParameterValue("empresaRif", Globals.logEmpresa.rif);
            repOperacion.SetParameterValue("titulo", _tipoOperacion.nombre);
            repOperacion.SetParameterValue("nroControl", one.nro_control);
            repOperacion.SetParameterValue("fecha", one.fecha);
            repOperacion.SetParameterValue("clienteNombre", _oneCliente.nombre);
            repOperacion.SetParameterValue("clienteRif", _oneCliente.rif);
            repOperacion.SetParameterValue("clienteDireccion", _oneCliente.direccion);
            repOperacion.SetParameterValue("clienteTelefono", _oneCliente.telefono);
            repOperacion.SetParameterValue("moneda", _oneCotizacion.moneda_descrip);
            repOperacion.SetParameterValue("montoExento", montoExento);
            repOperacion.SetParameterValue("montoBase", montoBase);
            repOperacion.SetParameterValue("montoIva", montoIva);
            repOperacion.SetParameterValue("montoTotal", one.total_moneda);
            repOperacion.PrintToPrinter(1, true, 1, 1);
            */
        }
        
        private void InicializarOperacion()
        {
            /*
            lblProgreso.Text = "";
            one = srvVenta.GetOne(Globals.logEmpresa.id, "11E8F22493F0CDBC8FF600270E383B06", "0");

            _oneCliente = srvCliente.GetOne(Globals.logEmpresa.id, "11E94E4F862A74768EFE00E04C6F7E24");

            one.id_cliente = _oneCliente.id;
            one.cliente_nombre = _oneCliente.nombre;
            one.cliente_rif = _oneCliente.rif;

            lblClienteNombre.Text = one.cliente_nombre;
            lblClienteRif.Text = one.cliente_rif;

            //DETALLE
            _listaDetalle = srvMovimiento.GetList(one.id);
            bList = new BindingList<App.InvMovimientoService.InvMovimiento>(_listaDetalle);

            //PAGO
            _listaInstrumentos = srvMovimientoCaja.GetList(one.id);


            bs.DataSource = bList;
            dgvList.DataSource = bs;
            Totalizar();
            //ValidarBotones();
            */
        }

        private void InicializarTimers()
        {
            timerHora.Elapsed += new ElapsedEventHandler(OnTimerHora);
            timerHora.Interval = 60000;
            timerHora.Enabled = true;

            timerCola.Elapsed += new ElapsedEventHandler(OnTimerCola);
            timerCola.Interval = 5000;
            timerCola.Enabled = true;
        }

        Boolean leerConfiguraciones()
        {
            string archivo = @"C:\GidsStartUp\AppPV\config.txt";
            //MessageBox.Show(archivo);
            if (System.IO.File.Exists(archivo))
            {
                int counter = 0;
                string line;

                // Read the file and display it line by line.
                System.IO.StreamReader file = new System.IO.StreamReader(archivo);
                while ((line = file.ReadLine()) != null)
                {
                    //Console.WriteLine(line);
                    counter++;
                    //Console.WriteLine(counter);
                    if (counter == 1)
                    {
                        puertoCOM = line;
                    }
                }

                file.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void LoadCotizacion()
        {
            string miMoneda = Globals.logEmpresa.moneda_defecto;
            if (Globals.logEmpresa.es_modo_fiscal)
            {
                miMoneda = "11E93A6F6D57549E838500E04C6F7E24";
            }

            Globals.cotizacion = srvCotizacion.GetLast(Globals.logEmpresa.id);
            Globals.ConfigurarComboMonedas(cmbCotizacion);
            foreach (CnfCotizacionDetalle item in Globals.cotizacion)
            {
                if (item.id_moneda == miMoneda)
                {
                    id_cotizacion = item.id;
                    factor = item.valor;
                    Globals.valorCotizacion = factor;
                }
            }
        }
        private void MovimientoCaja()
        {
            frmCajOperacion fDialog = new frmCajOperacion();
            if (ConfigUI.LaunchDialogForm(fDialog) == DialogResult.OK)
            {
            }
        }
        private void SelCliente()
        {
            /*
            frmVntClienteSelection fDialog = new frmVntClienteSelection();
            if (ConfigUI.LaunchDialogForm(fDialog) == DialogResult.OK)
            {
                _oneCliente = fDialog.selectedCliente;
                one.id_cliente = _oneCliente.id;
                one.cliente_nombre = _oneCliente.nombre;
                one.cliente_rif = _oneCliente.rif;

                lblClienteNombre.Text = one.cliente_nombre;
                lblClienteRif.Text = one.cliente_rif;
                //ValidarBotones();
            }
            */
        }

        private void SelConfirmacion()
        {
            /*
            frmPvConfirmar fDialog = new frmPvConfirmar(one, bList);
            if (ConfigUI.LaunchDialogForm(fDialog) == DialogResult.OK)
            {
                one.id_usuario = fDialog.selectedUsuario.id;
                one.id_cotizacion = _oneCotizacion.id_cotizacion;
                one.id_tipo_operacion = "11E8F22493F0CDBC8FF600270E383B06";
                _tipoOperacion = GetTipoOperacion(one.id_tipo_operacion);
                one.tipo_documento_nombre = _tipoOperacion.nombre;

                ColOperacion _oneCola = Globals.ConvertirHeadCola(one);
                List<App.ColOperacionService.ColMovimiento> _detail = Globals.ConvertirDetalleCola(bList);


                //SAVE
                try
                {
                    string res = srvCola.SetOne(_oneCola, _detail);
                    if (res.Length > 1)
                    {
                        MetroFramework.MetroMessageBox.Show(this.MdiParent, "Documento enviado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InicializarOperacion();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this.MdiParent, "No se guardó la operación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception)
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Se produjeron errores intentando procesar la operación, por favor revise los valores e intente nuevamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            */
        }

        private void SelKey(Keys tecla)
        {
            switch (tecla)
            {
                case Keys.F2:
                    Console.WriteLine("SelKeyF2");
                    VistaPrevia();
                    break;
                case Keys.F3:
                    SelCliente();
                    break;
                case Keys.F5:
                    MovimientoCaja();
                    break;
                case Keys.F6:
                    System.Windows.Forms.DialogResult res = MetroFramework.MetroMessageBox.Show(this.MdiParent, "¿Desea reiniciar la venta?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        InicializarOperacion();
                    }
                    break;
                case Keys.F7:
                    EliminarItem();
                    break;
                case Keys.F9:
                    bool miRes = ValidarBotones();
                    if (miRes)
                    {
                        SelPago();
                        //SelConfirmacion();
                    }
                    break;
            }
        }

        private void SelOperacion()
        {
            /*
            frmVntOperacionSelection fDialog = new frmVntOperacionSelection();
            if (ConfigUI.LaunchDialogForm(fDialog) == DialogResult.OK)
            {
                one = fDialog.selectedOperacion;
                _oneCliente = srvCliente.GetOne(Globals.logEmpresa.id, one.id_cliente);

                lblClienteNombre.Text = _oneCliente.nombre;
                lblClienteRif.Text = _oneCliente.rif;

                //DETALLE
                _listaDetalle = srvMovimiento.GetList(one.id);
                bList = new BindingList<App.InvMovimientoService.InvMovimiento>(_listaDetalle);
                bs.DataSource = bList;
                dgvList.DataSource = bs;
                Totalizar();
                //ValidarBotones();
            }
            */
        }

        private void SelPago()
        {
            _listaInstrumentos.Clear();
            frmCajMovimientoSelection fDialog = new frmCajMovimientoSelection(one, _listaInstrumentos, "venta");
            if (ConfigUI.LaunchDialogForm(fDialog) == DialogResult.OK)
            {
                
                one.id_cotizacion = _oneCotizacion.id_cotizacion;
                one.id_tipo_operacion = fDialog.idTipoOperacion;

                _tipoOperacion = GetTipoOperacion(one.id_tipo_operacion);
                one.tipo_documento_nombre = _tipoOperacion.nombre;

                _oneCliente = srvCliente.GetOne(Globals.logEmpresa.id, one.id_cliente);

                _listaInstrumentos = fDialog.instrumentosSeleccionados;
                _listaDetalle = srvMovimiento.GetList(one.id);

                //CONVERSIONES
                VntOperacion _one = Globals.ConvertirHeadVenta(one);
                _one.id = "0";
                List<App.VntOperacionService.InvMovimiento> _detail = Globals.ConvertirDetalleVenta(_listaDetalle);
                List<App.VntOperacionService.CajMovimiento> _pago = Globals.ConvertirPago(_listaInstrumentos);

                //SAVE
                try
                {
                    string res = srvVenta.SetOne(_one, _detail, _pago);
                    if (res.Length > 1)
                    {
                        if (one.id_tipo_operacion == "11E8F22493F0CDBC8FF600270E383B06")
                        {
                            Globals.ImprimirFacturaFiscal(_oneCliente, _one, _detail, lblProgreso);
                        }
                        else
                        {
                            //imprimirOperacion();
                            Globals.ImprimirTicketVenta(_one, _detail, factor);
                        }

                        srvCola.UpdateOne(one, 3);
                        MetroFramework.MetroMessageBox.Show(this.MdiParent, "Operación registrada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InicializarOperacion();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this.MdiParent, "No se guardó la operación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception)
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Se produjeron errores intentando procesar la operación, por favor revise los valores e intente nuevamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                
            }
            
        }

       
        private void Totalizar()
        {
            foreach (ColOperacion item in bList)
            {
                Console.WriteLine(item.total_moneda);
                item.total_moneda = item.total * factor;
            }
            
            //dgvList.Refresh();
        }

        private bool ValidarBotones()
        {/*
            if (_oneCliente == null)
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Seleccione un cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (_oneCliente.id == "0")
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Seleccione un cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (_listaDetalle.Count == 0)
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Seleccione al menos un producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }*/
            return true;
        }

        private void VistaPrevia()
        {
            Form f = new frmCajVistaPrevia(one);
            //ConfigUI.LaunchChildForm(f, Globals.appParentWindow);
            ConfigUI.LaunchDialogForm(f);
        }

        #endregion


        #region METODOS ASYNC
        public async Task<bool> CheckCola()
        {
            return await srvCola.ActualizarColaAsync();
        }

        #endregion
        //CONSTRUCTOR
        public frmCaja()
        {
            InitializeComponent();

            
            //CargarListas();

            CargarCola();

            //COTIZACION
            LoadCotizacion();



            /*
            InicializarOperacion();
            */

            CheckImpresoraFiscal();
            /*
            this.KeyPreview = true;
            this.KeyDown +=
                new KeyEventHandler(frmCaja_KeyDown);
                */
        }

        #region EVENTOS
        
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            SelKey(Keys.F9);
        }
        
        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btnVistaPreviaClickEvent");
            SelKey(Keys.F2);
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            SelKey(Keys.F5);
        }

        /*private void btnDel_Click(object sender, EventArgs e)
        {
            SelKey(Keys.F7);
        }

        private void btnNuevoDocumento_Click(object sender, EventArgs e)
        {
            SelKey(Keys.F5);
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            SelKey(Keys.F9);
        }
        */
        
        /*
        private void dgvList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            App.InvMovimientoService.InvMovimiento obj = (App.InvMovimientoService.InvMovimiento)dgvList.CurrentRow.DataBoundItem;

            obj.monto_moneda = obj.precio_moneda * obj.cantidad;
            obj.precio = obj.precio_moneda / factor;
            obj.monto = obj.precio * obj.cantidad;

            Totalizar();

        }
        */
        private void dgvList_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            if (dgvList.SelectedRows.Count != 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvList.SelectedRows[0];
                    one = (ColOperacion)row.DataBoundItem;
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //btnEdit.Visible = true;
            }
            else
            {
                //btnEdit.Visible = false;
            }
        }

        #endregion
        private void cmbCotizacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCotizacion.SelectedIndex > -1)
            {
                _oneCotizacion = Globals.cotizacion[cmbCotizacion.SelectedIndex];
                factor = Globals.cotizacion[cmbCotizacion.SelectedIndex].valor;
                Globals.valorCotizacion = factor;
                Console.WriteLine("Factor: " + factor);
                Totalizar();

            }
        }
        private void frmCaja_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            string fecha = DateTime.Now.ToString("d/M/yyyy");
            string hora= DateTime.Now.ToString("HH:mm");
            lblFecha.Text = fecha;
            lblHora.Text = hora;

            InicializarTimers();

            ConfigGrid();
            cmbCotizacion.SelectedValue = id_cotizacion;
            Totalizar();
        }

        

        

        private void frmCaja_Activated(object sender, EventArgs e)
        {
            //CargarListas();
            //Totalizar();
        }

        private void OnTimerHora(object source, ElapsedEventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm");
            Console.WriteLine("Factor: " + DateTime.Now.ToString("HH:mm:ss"));            
        }

        private async void OnTimerCola(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Check Actualizacion!");
            Task<bool> TBool = CheckCola();
            bool hayActualizacion = await TBool;
            if (hayActualizacion)
            {
                Console.WriteLine("Hello Actualizacion!");
                CargarCola();
            }
        }
    }
}
