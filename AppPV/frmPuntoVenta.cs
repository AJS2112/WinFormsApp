using App.CajMovimientoService;
using App.CnfCotizacionService;
using App.ColOperacionService;
using App.Common.Classes;
using App.Common.Reports.Operaciones;
using App.InvMovimientoService;
using App.InvProductoService;
using App.SisEmpresaService;
using App.SisListasService;
using App.SisOperacionService;
using App.VntClienteService;
using App.VntOperacionService;
using AppPV.frmSelection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TfhkaNet.IF.VE;

namespace AppPV
{
    public partial class frmPuntoVenta : Form
    {
        #region VARIABLES

        //SERVICIOS
        private VntOperacionClient srvVenta = new VntOperacionClient();
        private ColOperacionClient srvCola = new ColOperacionClient();
        private SisListasClient srvListas = new SisListasClient();
        private SisOperacionClient srvOperacion = new SisOperacionClient();
        private InvMovimientoClient srvMovimiento = new InvMovimientoClient();
        private CajMovimientoClient srvMovimientoCaja = new CajMovimientoClient();
        private VntClienteClient srvCliente = new VntClienteClient();
        private CnfCotizacionClient srvCotizacion = new CnfCotizacionClient();


        //LISTAS
        private List<CnfCotizacionDetalle> _listaCotizacion = new List<CnfCotizacionDetalle>();
        private List<SisOperacion> _listaOperaciones = new List<SisOperacion>();
        private List<App.InvMovimientoService.InvMovimiento> _listaDetalle = new List<App.InvMovimientoService.InvMovimiento>();
        private List<App.CajMovimientoService.CajMovimiento> _listaInstrumentos = new List<App.CajMovimientoService.CajMovimiento>();

        //OBJETOS
        private SisOperacion _tipoOperacion = new SisOperacion();
        private CnfCotizacionDetalle _oneCotizacion = new CnfCotizacionDetalle();
        private VntCliente _oneCliente { get; set; }
        private App.InvMovimientoService.InvMovimiento _movimiento { get; set; }
        private InvProducto _productoSeleccionado { get; set; }
        private VntOperacion one { get; set; }
       // private S5PrinterData EstatusS5;

        //BINDINGS
        BindingSource bs = new BindingSource();
        BindingList<App.InvMovimientoService.InvMovimiento> bList;

        //VARIABLES
        private bool Respuesta;
        private string puertoCOM;
        double factor = 1;

        #endregion


        #region METODOS
        private void CheckImpresoraFiscal()
        {
            Globals.Impresora = new Tfhka();
            S3PrinterData impresoraS3;
            string puertoCOM = ConfigurationManager.AppSettings["puerto"];
            //if (leerConfiguraciones())
            //{
            //INICIALIZAR IMPRESORA
            Boolean puerto = Globals.Impresora.OpenFpCtrl(puertoCOM);
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
                        /*impresoraS3 = Globals.Impresora.GetS3PrinterData();
                        Globals.TasaG = impresoraS3.Tax1;
                        Globals.TasaR = impresoraS3.Tax2;
                        Globals.TasaA = impresoraS3.Tax3;

                        Console.WriteLine(Globals.TasaG);
                        Console.WriteLine(Globals.TasaR);
                        Console.WriteLine(Globals.TasaA);*/
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
            //}
            //else
            //{
            //    //MessageBox.Show("No se pudieron leer las configuraciones");

            //    lblPrinterStatus.ForeColor = Color.Red;
            //    lblPrinterStatus.Text = "No se pudieron leer las configuraciones";
            //}
        }

        private void ConfigGrid()
        {
            for (int i = 0; i <= dgvList.Columns.Count - 1; i++)
            {
                dgvList.Columns[i].Visible = false;
                Console.WriteLine(i.ToString() + " - " + dgvList.Columns[i].HeaderText);
            }

            dgvList.Columns[0].DisplayIndex = 7;
            dgvList.Columns[18].DisplayIndex = 0;
            dgvList.Columns[19].DisplayIndex = 1;
            dgvList.Columns[20].DisplayIndex = 2;
            dgvList.Columns[17].DisplayIndex = 3;

            dgvList.Columns[18].HeaderText = "CODIGO";
            dgvList.Columns[18].Visible = true;
            //dgvList.Columns[17].Width = 140;
            dgvList.Columns[18].ReadOnly = true;

            dgvList.Columns[19].HeaderText = "DESCRIPCION";
            dgvList.Columns[19].Visible = true;
            dgvList.Columns[19].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvList.Columns[19].ReadOnly = true;

            dgvList.Columns[20].HeaderText = "UNIDAD";
            dgvList.Columns[20].Visible = true;
            //dgvList.Columns[19].Width = 80;
            dgvList.Columns[20].ReadOnly = true;

            dgvList.Columns[17].HeaderText = "PRECIO";
            dgvList.Columns[17].Visible = true;
            dgvList.Columns[17].DefaultCellStyle.FormatProvider = Globals.nfiVE;
            dgvList.Columns[17].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvList.Columns[17].DefaultCellStyle.Format = "N2";
            dgvList.Columns[17].ReadOnly = true;
            //dgvList.Columns[2].Width = 90;

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

                        App.InvMovimientoService.InvMovimiento obj = (App.InvMovimientoService.InvMovimiento)dgvList.CurrentRow.DataBoundItem;
                        bList.Remove(obj);
                        Totalizar();
                    }
                }
            }

            btnDel.Visible = false;
            if (bList.Count > 0)
            {
                btnDel.Visible = true;
            }
            Totalizar();
        }

        private SisOperacion GetTipoOperacion(string idTipoOperacion)
        {
            SisOperacion _operacion = new SisOperacion();
            foreach (SisOperacion item in _listaOperaciones)
            {
                if (item.id == idTipoOperacion)
                {
                    _operacion = item;
                }
            }
            return _operacion;
        }

        private void imprimirOperacion()
        {
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
        }

        private void InicializarOperacion()
        {

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

        private void SelCliente()
        {
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
        }

        private void SelConfirmacion()
        {
            frmPvConfirmar fDialog = new frmPvConfirmar(one, bList);
            if (ConfigUI.LaunchDialogForm(fDialog) == DialogResult.OK)
            {
                one.id_usuario= fDialog.selectedUsuario.id;
                one.id_cotizacion = _oneCotizacion.id_cotizacion;
                one.id_tipo_operacion = "11E8F22493F0CDBC8FF600270E383B06";
                _tipoOperacion = GetTipoOperacion(one.id_tipo_operacion);
                one.tipo_documento_nombre = _tipoOperacion.nombre;

                ColOperacion _oneCola =  Globals.ConvertirHeadCola(one);
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
        }

        private void SelKey(Keys tecla)
        {
            switch (tecla)
            {
                case Keys.F2:
                    SelProducto();
                    break;
                case Keys.F3:
                    SelCliente();
                    break;
                case Keys.F4:
                    SelOperacion();
                    break;
                case Keys.F5:
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
                        //SelPago();
                        SelConfirmacion();
                    }
                    break;
            }
        }

        private void SelOperacion()
        {
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
        }

        private void SelPago()
        {
            frmCajMovimientoSelection fDialog = new frmCajMovimientoSelection(one, _listaInstrumentos, "venta");
            if (ConfigUI.LaunchDialogForm(fDialog) == DialogResult.OK)
            {
                one.id_cotizacion = _oneCotizacion.id_cotizacion;
                one.id_tipo_operacion = fDialog.idTipoOperacion;
                _tipoOperacion = GetTipoOperacion(one.id_tipo_operacion);
                one.tipo_documento_nombre = _tipoOperacion.nombre;
                _listaInstrumentos = fDialog.instrumentosSeleccionados;

                List<App.VntOperacionService.InvMovimiento> _detail = Globals.ConvertirDetalle(bList);
                List<App.VntOperacionService.CajMovimiento> _pago = Globals.ConvertirPago(_listaInstrumentos);

                //SAVE
                try
                {
                    string res = srvVenta.SetOne(one, _detail, _pago);
                    if (res.Length > 1)
                    {
                        if (one.id_tipo_operacion == "11E8F22493F0CDBC8FF600270E383B06")
                        {
                            Globals.ImprimirFacturaFiscal(_oneCliente, one, _detail, lblProgreso);
                        }
                        else
                        {
                            //imprimirOperacion();
                            Globals.ImprimirTicketVenta(one,_detail,factor);
                        }
                        MetroFramework.MetroMessageBox.Show(this.MdiParent, "Operación registrada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InicializarOperacion();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this.MdiParent, "No se guardó la operaación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception)
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Se produjeron errores intentando procesar la operación, por favor revise los valores e intente nuevamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                
            }
        }

        private void SelProducto()
        {
            frmInvProductoSelection fDialog = new frmInvProductoSelection();
            if (ConfigUI.LaunchDialogForm(fDialog) == DialogResult.OK)
            {
                _productoSeleccionado = fDialog.selectedProducto;

                _movimiento = new App.InvMovimientoService.InvMovimiento();

                _movimiento.cantidad = 1;
                _movimiento.costo = _productoSeleccionado.costo;
                _movimiento.costo_moneda = _productoSeleccionado.costo_moneda;
                _movimiento.id = "0";
                _movimiento.id_empresa = Globals.logEmpresa.id;
                _movimiento.id_impuesto = _productoSeleccionado.id_impuesto;
                _movimiento.id_operacion = one.id;
                _movimiento.id_producto = _productoSeleccionado.id;
                _movimiento.id_tipo_operacion = one.id_tipo_operacion;
                _movimiento.last_update = 0;
                _movimiento.monto = _productoSeleccionado.precio;
                _movimiento.monto_impuesto = (_productoSeleccionado.precio * _productoSeleccionado.impuesto_valor)/100 ;
                _movimiento.monto_impuesto_moneda = _movimiento.monto_impuesto* factor;
                _movimiento.monto_moneda = _productoSeleccionado.precio_moneda;
                _movimiento.order_id = 0;
                _movimiento.precio = _productoSeleccionado.precio;
                _movimiento.precio_moneda = _productoSeleccionado.precio_moneda;
                _movimiento.producto_codigo = _productoSeleccionado.codigo;
                _movimiento.producto_nombre = _productoSeleccionado.nombre;
                _movimiento.producto_unidad = _productoSeleccionado.unidad_nombre;
                _movimiento.valor_impuesto = _productoSeleccionado.impuesto_valor;
                bList.Add(_movimiento);

                Console.WriteLine("Asignar");
                Console.WriteLine(_movimiento.costo.ToString() + ", " + _movimiento.precio.ToString() + ", " + _movimiento.monto_impuesto.ToString());
                Totalizar();

                /*ValidarBotones();*/
            }
        }

        private void Totalizar()
        {

            int items = 0;
            one.base_imponible_ta = 0;
            one.base_imponible_tg = 0;
            one.base_imponible_tr = 0;

            one.monto_exento = 0;
            one.monto_iva_ta = 0;
            one.monto_iva_tg = 0;
            one.monto_iva_tr = 0;

            one.total = 0;
            one.total_moneda = 0;
            foreach (App.InvMovimientoService.InvMovimiento item in bList)
            {
                items += 1;
                item.precio_moneda = item.precio * factor;
                item.monto = item.precio * item.cantidad;
                item.monto_moneda = item.monto * factor;
                item.monto_impuesto = (item.monto * item.valor_impuesto)/100 ;
                item.monto_impuesto_moneda = item.monto_impuesto * factor;

                Console.WriteLine("Monto: " + item.monto.ToString());
                switch (item.id_impuesto)
                {
                    case "11E8F23EDF0D15388FF600270E383B06": //EXENTO
                        one.monto_exento += item.monto;
                        break;
                    case "11E7E1D6570F9A40AC8A00E04C6F7E24": //GENERAL
                        one.base_imponible_tg += item.monto;
                        one.monto_iva_tg += item.monto_impuesto ;
                        break;
                    case "11E8F23EEF10FE9E8FF600270E383B06": //REDUCIDA
                        one.base_imponible_tr += item.monto;
                        one.monto_iva_tr += item.monto_impuesto;
                        break;
                    case "11E8F23EF76C98758FF600270E383B06": //AMPLIADA
                        one.base_imponible_ta += item.monto;
                        one.monto_iva_ta += item.monto_impuesto;
                        break;
                }

                one.total += item.monto + item.monto_impuesto;
            }

            one.total_moneda = one.total*factor;

            lblItems.Text = "(" + items.ToString() + ")";

            lblTotal.Text = "Total: " + one.total_moneda.ToString("N2", Globals.nfiVE);

            if (bList.Count == 0) btnDel.Visible = false;
        }

        private bool ValidarBotones()
        {
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
            }
            return true;
        }
        #endregion

        
        

        //CONSTRUCTOR
        public frmPuntoVenta()
        {

            InitializeComponent();
            Globals.appParentWindow = this;

            //APP PATH
            string appPath = Application.StartupPath;
            Console.WriteLine("appPath: " + appPath);

            //READ CONFIG
            

            //Console.WriteLine("puerto COM: " + puertoCOM);

            Globals.cotizacion = srvCotizacion.GetLast(Globals.logEmpresa.id);
            _listaOperaciones = srvOperacion.GetList("11E7C39A0EACD9A08F1A00E04C6F7E24");
            foreach (CnfCotizacionDetalle item in Globals.cotizacion)
            {
                if (item.id_moneda == Globals.logEmpresa.moneda_defecto)
                {
                    Globals.valorCotizacion = item.valor;
                    _oneCotizacion = item;
                }
            }
            
            factor = Globals.valorCotizacion;

            CheckImpresoraFiscal();

            InicializarOperacion();

            this.KeyPreview = true;
            this.KeyDown +=
                new KeyEventHandler(frmPuntoVenta_KeyDown);
        }

        

        #region EVENTOS
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            SelKey(Keys.F2);
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            SelKey(Keys.F3);
        }

        private void btnBuscarDocumento_Click(object sender, EventArgs e)
        {
            SelKey(Keys.F4);
        }

        private void btnDel_Click(object sender, EventArgs e)
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
        

        private void dgvList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            App.InvMovimientoService.InvMovimiento obj = (App.InvMovimientoService.InvMovimiento)dgvList.CurrentRow.DataBoundItem;

            obj.monto_moneda = obj.precio_moneda * obj.cantidad;
            obj.precio = obj.precio_moneda / factor;
            obj.monto = obj.precio * obj.cantidad;

            Totalizar();

        }
        private void dgvList_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            if (dgvList.SelectedRows.Count != 0)
            {
                btnDel.Visible = true;
            }
            else
            {
                btnDel.Visible = false;
            }
        }

        void frmPuntoVenta_KeyDown(object sender, KeyEventArgs e)
        {
            SelKey(e.KeyCode);
        }

        private void frmPuntoVenta_Load(object sender, EventArgs e)
        {
            ConfigGrid();
            //this.BringToFront();
            //this.Activate();
        }

        #endregion
    }
}
