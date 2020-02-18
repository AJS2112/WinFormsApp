using App.CajMovimientoService;
using App.ColOperacionService;
using App.Common.Classes;
using App.Common.Reports;
using App.Common.Reports.Operaciones;
using App.Core.Caja;
using App.Core.Inventario;
using App.InvMovimientoService;
using App.InvProductoService;
using App.SisListasService;
using App.SisOperacionService;
using App.VntClienteService;
using App.VntOperacionService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TfhkaNet.IF.VE;

namespace App.Core.Ventas
{
    public partial class frmVntOperacionesDetail : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES
        //SERVICIOS
        private VntOperacionClient srvVenta = new VntOperacionClient();
        private SisListasClient srvListas = new SisListasClient();
        private SisOperacionClient srvOperacion = new SisOperacionClient();
        private InvMovimientoClient srvMovimiento = new InvMovimientoClient();
        private CajMovimientoClient srvMovimientoCaja = new CajMovimientoClient();
        private VntClienteClient srvCliente = new VntClienteClient();
        private ColOperacionClient srvCola = new ColOperacionClient();

        //LISTAS
        private List<SisListas> _listaTipoDocumentos = new List<SisListas>();
        private List<InvMovimientoService.InvMovimiento> _listaDetalle = new List<InvMovimientoService.InvMovimiento>();
        private List<CajMovimientoService.CajMovimiento> _listaInstrumentos = new List<CajMovimientoService.CajMovimiento>();

        //OBJETOS
        private SisOperacion _tipoOperacion = new SisOperacion();
        private VntCliente _oneCliente { get; set; }
        private InvMovimientoService.InvMovimiento _movimiento { get; set; }
        private InvProducto _productoSeleccionado { get; set; }
        private VntOperacion one { get; set; }
        private S5PrinterData EstatusS5;

        //BINDINGS
        BindingSource bs = new BindingSource();
        BindingList<InvMovimientoService.InvMovimiento> bList;


        double factor = 1;

        #endregion

        #region METODOS
        private void AsignarCliente(VntCliente _cliente)
        {
            _oneCliente = _cliente;
            lblClienteNombre.Text = _oneCliente.nombre;
            lblClienteRif.Text = _oneCliente.rif;
        }
        private void CargarListas()
        {
            /*_listaTipoDocumentos = srvListas.GetListByCampo("tipo_documento");
            cmbTipoDocumento.DataSource = _listaTipoDocumentos;
            cmbTipoDocumento.DisplayMember = "nombre";
            cmbTipoDocumento.ValueMember = "id";*/
        }
        private void CrearBindings()
        {
            dtFecha.DataBindings.Add("Value", one, "fecha_documento", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void ConfigGrid()
        {
            Console.WriteLine("CONFIG GRID");
            dgvList.Columns.Add("pct_utilidad", "% UTIL");

            
            for (int i = 0; i <= dgvList.Columns.Count - 1; i++)
            {
                dgvList.Columns[i].Visible = false;
                Console.WriteLine(i.ToString() + " - " +dgvList.Columns[i].HeaderText);
            }

            dgvList.Columns[0].DisplayIndex = 5;
            dgvList.Columns[18].DisplayIndex = 0;
            dgvList.Columns[19].DisplayIndex = 1;
            dgvList.Columns[20].DisplayIndex = 2;
            dgvList.Columns[17].DisplayIndex = 3;
            dgvList.Columns[22].DisplayIndex = 4;

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

            dgvList.Columns[22].HeaderText = "% UTIL";
            dgvList.Columns[22].Visible = true;
            dgvList.Columns[22].DefaultCellStyle.FormatProvider = Globals.nfiVE;
            dgvList.Columns[22].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvList.Columns[22].DefaultCellStyle.Format = "N2";

        }
        private List<VntOperacionService.InvMovimiento> ConvertirDetalle(BindingList<InvMovimientoService.InvMovimiento> listaBinding)
        {
            List<VntOperacionService.InvMovimiento> _listaDetalle = new List<VntOperacionService.InvMovimiento>();

            foreach (InvMovimientoService.InvMovimiento item in listaBinding)
            {
                VntOperacionService.InvMovimiento mov = new VntOperacionService.InvMovimiento();
                mov.cantidad = item.cantidad;
                mov.costo = item.costo;
                mov.costo_moneda = item.costo_moneda;
                mov.id = item.id;
                mov.id_empresa = item.id_empresa;
                mov.id_impuesto = item.id_impuesto;
                mov.id_operacion = item.id_operacion;
                mov.id_producto = item.id_producto;
                mov.id_tipo_operacion = item.id_tipo_operacion;
                mov.last_update = item.last_update;
                mov.monto = item.monto;
                mov.monto_impuesto = item.monto_impuesto;
                mov.monto_impuesto_moneda = item.monto_impuesto_moneda;
                mov.monto_moneda = item.monto_moneda;
                mov.order_id = item.order_id;
                mov.precio = item.precio;
                mov.precio_moneda = item.precio_moneda;
                mov.producto_codigo = item.producto_codigo;
                mov.producto_nombre = item.producto_nombre;
                mov.producto_unidad = item.producto_unidad;
                mov.valor_impuesto = item.valor_impuesto;
                Console.WriteLine("Convertir");
                Console.WriteLine(mov.costo.ToString() + ", " + mov.precio.ToString() + ", " + mov.monto.ToString());
                _listaDetalle.Add(mov);
            }

            return _listaDetalle;
        }
        private List<VntOperacionService.CajMovimiento> ConvertirPago(List<CajMovimientoService.CajMovimiento> lista)
        {
            List<VntOperacionService.CajMovimiento> _listaPago = new List<VntOperacionService.CajMovimiento>();

            foreach (CajMovimientoService.CajMovimiento item in lista)
            {
                VntOperacionService.CajMovimiento mov = new VntOperacionService.CajMovimiento();

                mov.banco_nombre = item.banco_nombre;
                mov.cuenta_banco = item.cuenta_banco;
                mov.cuenta_numero = item.cuenta_numero;
                mov.factor = item.factor;
                mov.fecha = item.fecha;
                mov.id = item.id;
                mov.id_banco = item.id_banco;
                mov.id_cuenta = item.id_cuenta;
                mov.id_empresa = item.id_empresa;
                mov.id_instrumento = item.id_instrumento;
                mov.id_moneda = item.id_moneda;
                mov.id_operacion = item.id_operacion;
                mov.id_tipo_operacion = item.id_tipo_operacion;
                mov.instrumento_nombre = item.instrumento_nombre;
                mov.last_update = item.last_update;
                mov.moneda_descrip = item.moneda_descrip;
                mov.moneda_nombre = item.moneda_nombre;
                mov.monto = item.monto;
                mov.monto_moneda = item.monto_moneda;
                mov.numero_operacion = item.numero_operacion;
                mov.order_id = item.order_id;
                _listaPago.Add(mov);
            }

            return _listaPago;
        }
        string FormatoTexto(string texto, int letras)
        {
            string left;
            string miTexto = texto.ToUpper().Trim();
            if (miTexto.Length > letras)
            {
                left = miTexto.Substring(0, letras);
            }
            else
            {
                left = miTexto;
            }

            return left;
        }
        private Boolean imprimirFactura()
        {
            lblProgreso.Text = "Imprimiendo";
            string configvalue1 = ConfigurationManager.AppSettings["puerto"];
            string c = "";
            Boolean bRet;

            MessageBox.Show("Nombre Cliente");
            string nombre = FormatoTexto(_oneCliente.nombre, 40);
            c = "iS*" + nombre;
            bRet = Globals.Impresora.SendCmd(c);
            if (bRet == false)
            {
                lblProgreso.Text = "Ocurrió un error imprimiendo el  nombre del cliente";
            }

            MessageBox.Show("RIF Cliente");
            string rif = FormatoTexto(_oneCliente.rif, 11);
            c = "iR*" + rif;
            bRet = Globals.Impresora.SendCmd(c);
            if (bRet == false)
            {
                lblProgreso.Text = "Ocurrió un error imprimiendo el rif del cliente";
            }

            MessageBox.Show("Direccion");
            string direccion = FormatoTexto(_oneCliente.direccion, 30);
            c = "i01DIRECCION: " + direccion;
            bRet = Globals.Impresora.SendCmd(c);
            if (bRet == false)
            {
                lblProgreso.Text = "Ocurrió un error imprimiendo la dirección del cliente";
            }

            MessageBox.Show("Tlf");
            string telefono = FormatoTexto(_oneCliente.telefono, 30);
            c = "i02TELEFONO: " + telefono;
            bRet = Globals.Impresora.SendCmd(c);
            if (bRet == false)
            {
                lblProgreso.Text = "Ocurrió un error imprimiendo el teléfono del cliente";
            }

            MessageBox.Show("NRO CONTROL");
            string numero = FormatoTexto(one.nro_control , 30);
            c = "i03N. CONTROL: " + numero;
            bRet = Globals.Impresora.SendCmd(c);
            if (bRet == false)
            {
                lblProgreso.Text = "Ocurrió un error imprimiendo el número de control";
            }

            MessageBox.Show("CONDICION DE VENTA");
            c = "i04" + "CONDICION VENTA: ** CONTADO **";
            bRet = Globals.Impresora.SendCmd(c);
            if (bRet == false)
            {
                lblProgreso.Text = "Ocurrió un error imprimiendo la condición de venta";
            }


            /********************** PRODUCTOS *************************************/

            for (int i = 0; i < (bList.Count); i++)
            {
                c = "";
                if (Convert.ToInt16(bList[i].valor_impuesto) == 0)
                {
                    c = " ";
                }

                if (Convert.ToInt16(bList[i].valor_impuesto) == Convert.ToInt16(Globals.TasaG))
                {
                    c = "!";
                }

                //MessageBox.Show(c);

                Double precioBase = Convert.ToDouble(bList[i].precio);
                Double valorIva = (Convert.ToDouble(bList[i].valor_impuesto) / 100) + 1;
                Double precioFinal = Convert.ToDouble(bList[i].precio);

                Double formatoPrecio = precioFinal * 100;
                Double formatoCantidad = Convert.ToInt64(bList[i].cantidad) * 1000;

                string precio = formatoPrecio.ToString("0000000000");
                string cantidad = formatoCantidad.ToString("00000000");
                string producto = FormatoTexto(bList[i].producto_nombre.ToString(), 40);
                Console.Write(producto);

                //MessageBox.Show(producto);

                c += precio + cantidad + producto;
                bRet = Globals.Impresora.SendCmd(c);
                if (bRet == false)
                {
                    lblProgreso.Text = "Ocurrió un error imprimiendo el producto " + c;
                }

            }
            //TOTALIZAR
            c = "3";
            bRet = Globals.Impresora.SendCmd(c);
            if (bRet == false)
            {
                lblProgreso.Text = "Ocurrió un error totalizando la factura";
            }
            //EFECTIVO
            c = "101";
            bRet = Globals.Impresora.SendCmd(c);
            if (bRet == false)
            {
                lblProgreso.Text = "Ocurrió un error cerrando el documento";
            }

            return true;
        }
        private Boolean imprimirNotaCredito()
        {
            lblProgreso.Text = "Imprimiendo";

            string c = "";
            Boolean bRet;

            //MessageBox.Show("Nombre Cliente");
            string nombre = FormatoTexto(_oneCliente.nombre, 40);
            c = "iS*" + nombre;
            bRet = Globals.Impresora.SendCmd(c);
            if (bRet == false)
            {
                lblProgreso.Text = "Ocurrió un error imprimiendo el  nombre del cliente";
            }

            //MessageBox.Show("Rif Cliente");
            string rif = FormatoTexto(_oneCliente.rif, 11);
            c = "iR*" + rif;
            bRet = Globals.Impresora.SendCmd(c);
            if (bRet == false)
            {
                lblProgreso.Text = "Ocurrió un error imprimiendo el rif del cliente";
            }

            string numero = "00000000";
            /*if (txtNumeroFactura.Text != null)
            {
                numero = txtNumeroFactura.Text;
            }*/
            c = "iF*" + numero;
            bRet = Globals.Impresora.SendCmd(c);
            if (bRet == false)
            {
                lblProgreso.Text = "Ocurrió un error imprimiendo el número de factura";
            }


            //MessageBox.Show("FECHA");
            string fecha = "01-01-01";
            if (dtFecha.Text != null)
            {
                fecha = dtFecha.Text;
            }
            c = "iD*" + fecha;
            bRet = Globals.Impresora.SendCmd(c);
            if (bRet == false)
            {
                lblProgreso.Text = "Ocurrió un error imprimiendo la fecha del documento";
            }


            string serial = "Z4A1234567";
            try
            {
                EstatusS5 = Globals.Impresora.GetS5PrinterData();
                serial = EstatusS5.RegisteredMachineNumber;
                // MessageBox.Show("Obtuve el serial de la maquina: " + serial);
            }
            catch (Exception)
            {
                serial = "Z4A1234567";
            }

            //MessageBox.Show("SERIAL");
            c = "iI*" + serial;
            bRet = Globals.Impresora.SendCmd(c);
            if (bRet == false)
            {
                lblProgreso.Text = "Ocurrió un error imprimiendo el serial";
            }



            /********************** PRODUCTOS *************************************/

            for (int i = 0; i < (bList.Count); i++)
            {

                //MessageBox.Show(bList[i].valor_impuesto.ToString());

                c = "";
                if (Convert.ToInt16(bList[i].valor_impuesto) == 0)
                {
                    c = "d0";
                }

                if (Convert.ToInt16(bList[i].valor_impuesto) == Convert.ToInt16(Globals.TasaG))
                {
                    c = "d1";
                }

                //MessageBox.Show("El valor del impuesto es: " + c);

                Double precioBase = Convert.ToDouble(bList[i].precio);
                Double valorIva = (Convert.ToDouble(bList[i].valor_impuesto) / 100) + 1;
                //Double precioFinal = precioBase / valorIva;
                Double precioFinal = precioBase;

                Double formatoPrecio = precioFinal * 100;
                Double formatoCantidad = Convert.ToInt64(bList[i].cantidad) * 1000;

                string precio = formatoPrecio.ToString("0000000000");
                string cantidad = formatoCantidad.ToString("00000000");
                string producto = FormatoTexto(bList[i].producto_nombre.ToString(), 40);
                Console.Write(producto);
                c += precio + cantidad + producto;
                //MessageBox.Show("El producto es: " + c);

                try
                {
                    bRet = Globals.Impresora.SendCmd(c);
                    if (bRet == false)
                    {
                        lblProgreso.Text = "Ocurrió un error imprimiendo el producto " + c;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }


            }

            //EFECTIVO
            //MessageBox.Show("FORMA DE PAGO");
            c = "101";
            bRet = Globals.Impresora.SendCmd(c);
            if (bRet == false)
            {
                lblProgreso.Text = "Ocurrió un error cerrando el documento";
            }


            /*Nota de Crédito*/
            //Boolean bRet;
            //bRet = Globals.Impresora.SendCmd("iR*21.122.012");
            ////MessageBox.Show("iR " + bRet.ToString());
            //bRet = Globals.Impresora.SendCmd("iS*Pedro Perez");
            ////MessageBox.Show("iS " + bRet.ToString());
            //bRet = Globals.Impresora.SendCmd("iF*00000000001");
            ////MessageBox.Show("iF " + bRet.ToString());
            //bRet = Globals.Impresora.SendCmd("iD*22/08/2016");
            ////MessageBox.Show("iD " + bRet.ToString());
            //bRet = Globals.Impresora.SendCmd("iI*Z1F1234567");
            ////MessageBox.Show("iI " + bRet.ToString());
            //bRet = Globals.Impresora.SendCmd("i00Direccion: Ppal Siempre Viva");
            ////MessageBox.Show("i00 " + bRet.ToString());
            //bRet = Globals.Impresora.SendCmd("i01Telefono: +101 (1234) 555-55-55");
            ////MessageBox.Show("i01 " + bRet.ToString());
            ////bRet = Globals.Impresora.SendCmd("i02CAJERO: 00001");
            ////MessageBox.Show("i02 " + bRet.ToString());
            //MessageBox.Show("Antes de entrar: " + bRet.ToString());
            //bRet = Globals.Impresora.SendCmd("d1000000050000001000Tax Producto Tasa General");
            //MessageBox.Show("d1 " + bRet.ToString());

            ////bRet = Globals.Impresora.SendCmd("d1000000050000001000Tax Producto Tasa General");
            ////MessageBox.Show("d1 " + bRet.ToString());
            ////bRet = Globals.Impresora.SendCmd("d2000000070000001000Tax Producto Tasa Reducida");
            ////MessageBox.Show("d2 " + bRet.ToString());
            ////bRet = Globals.Impresora.SendCmd("d3000000090000001000Tax Producto Tasa Adicional");
            ////MessageBox.Show("d3 " + bRet.ToString());
            //bRet = Globals.Impresora.SendCmd("101");
            //MessageBox.Show("101 " + bRet.ToString());



            //bRet = Globals.Impresora.SendCmd(" 000000030000001000Tax Free/Producto Exento");
            //bRet = Globals.Impresora.SendCmd("!000000050000001000Tax Rate 1/Producto Tasa General");
            //bRet = Globals.Impresora.SendCmd('\u0022' + "000000070000001000Tax Rate 2/ Producto Tasa Reducida");
            //bRet = Globals.Impresora.SendCmd("#000000090000001000Tax Rate 3/ Producto Tasa Adicional");
            //bRet = Globals.Impresora.SendCmd("3");
            //bRet = Globals.Impresora.SendCmd("101");




            //MessageBox.Show("RESPUESTA");
            //MessageBox.Show(bRet.ToString());
            return true;



        }
        private void imprimirOperacion()
        {
            double montoExento = (one.monto_exento) * factor;
            double montoBase = (one.base_imponible_ta + one.base_imponible_tg + one.base_imponible_tr) * factor;
            double montoIva = (one.monto_iva_ta+one.monto_iva_tg+one.monto_iva_tr)*factor;

            CrystalDecisions.Windows.Forms.CrystalReportViewer crView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            crVntOperacion repOperacion= new crVntOperacion();
            repOperacion.SetDataSource(_listaDetalle);
            repOperacion.SetParameterValue("empresaNombre", Globals.logEmpresa.nombre);
            repOperacion.SetParameterValue("empresaRif", Globals.logEmpresa.rif);
            repOperacion.SetParameterValue("titulo", lblTitle.Text);
            repOperacion.SetParameterValue("nroControl", one.nro_control);
            repOperacion.SetParameterValue("fecha", one.fecha);
            repOperacion.SetParameterValue("clienteNombre", _oneCliente.nombre);
            repOperacion.SetParameterValue("clienteRif", _oneCliente.rif);
            repOperacion.SetParameterValue("clienteDireccion", _oneCliente.direccion);
            repOperacion.SetParameterValue("clienteTelefono", _oneCliente.telefono);
            repOperacion.SetParameterValue("moneda", cmbCotizacion.Text);
            repOperacion.SetParameterValue("montoExento", montoExento);
            repOperacion.SetParameterValue("montoBase", montoBase);
            repOperacion.SetParameterValue("montoIva", montoIva);
            repOperacion.SetParameterValue("montoTotal", one.total_moneda);
            crView.ReportSource = repOperacion;

            Form f = new Reportes.frmReportViewer(crView);
            ConfigUI.LaunchChildForm(f, Globals.appParentWindow);
        }
        private void LockButons()
        {
            btnPrint.Visible = false;
            btnNullify.Visible = false;
            btnPay.Visible = false;
            btnSave.Enabled = false;
            btnSend.Enabled = false;
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
            foreach (InvMovimientoService.InvMovimiento item in bList)
            {
                items += 1;
                //one.total_moneda += item.monto_moneda;
                //one.total += item.monto;

                //item.monto_impuesto = (item.monto * item.valor_impuesto) / 100;
                //item.monto_impuesto_moneda = item.monto_impuesto * factor;

                Console.WriteLine("Monto: " + item.monto.ToString());
                switch (item.id_impuesto)
                {
                    case "11E8F23EDF0D15388FF600270E383B06": //EXENTO
                        one.monto_exento += item.monto;
                        break;
                    case "11E7E1D6570F9A40AC8A00E04C6F7E24": //GENERAL
                        one.base_imponible_tg += item.monto;
                        one.monto_iva_tg += item.monto_impuesto;
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

            for (int i = 0; i <= dgvList.RowCount - 1; i++)
            {
                dgvList[22, i].Value = (( (double)dgvList[16, i].Value - (double)dgvList[1,i].Value) / (double)dgvList[1, i].Value) * 100;
                Console.WriteLine(i.ToString() + " - " + dgvList.Columns[i].HeaderText);
            }

            one.total_moneda = one.total * factor;

            lblItems.Text = "(" + items.ToString() + ")";
            lblTotal.Text = "Total: " + one.total_moneda.ToString("N2", Globals.nfiVE);

        }
        private void ValidarBotones()
        {
            LockButons();

            if (_tipoOperacion.signo_caja != "N" && _listaDetalle.Count>0)
            {
                btnPay.Visible = true;
            }

            if (_oneCliente == null) return;
            if (bList.Count == 0) return;

            //if (btnPay.Visible) btnPay.Enabled = true;

            if (btnPay.Visible)
            {
                if (_listaInstrumentos.Count > 0)
                {
                    btnSave.Enabled = true;
                } else
                {
                    btnSave.Enabled = false;
                    return;
                }

            } else
            {
                btnSave.Enabled = true;
                btnSend.Enabled = true;
            }

            


            if (one.id == "0") return;
            btnPrint.Visible = true;
            btnNullify.Visible = true;
            btnSave.Enabled = false;
        }
        #endregion

        //CONSTRUCTORES
        public frmVntOperacionesDetail()
        {
            InitializeComponent();
        }

        public frmVntOperacionesDetail(VntOperacion _one)
        {
            InitializeComponent();

            //ONE
            if (_one == null) return;
            one = _one;
            CrearBindings();
            
            //LISTAS
            _tipoOperacion = srvOperacion.GetOne(one.id_tipo_operacion);
            if (_tipoOperacion == null) return;
            lblTitle.Text = _tipoOperacion.nombre;
            lblSubTitle.Text = one.nro_control;
            CargarListas();

            //CLIENTE
            if (one.id_cliente != "")
            {
                VntCliente cliente = srvCliente.GetOne(Globals.logEmpresa.id, one.id_cliente);
                if (cliente != null) AsignarCliente(cliente);
            }


            //DETALLE
            _listaDetalle = srvMovimiento.GetList(one.id);
            bList = new BindingList<InvMovimientoService.InvMovimiento>(_listaDetalle);

            //PAGO
            _listaInstrumentos = srvMovimientoCaja.GetList(one.id);

            Globals.ConfigurarComboMonedas(cmbCotizacion);

            bs.DataSource = bList;
            dgvList.DataSource = bs;
            Totalizar();
            ValidarBotones();
        }

        #region EVENTOS

        // BOTONES
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmInvProductosSelection fDialog = new frmInvProductosSelection();
            if (ConfigUI.LaunchDialogForm(fDialog) == DialogResult.OK)
            {
                _productoSeleccionado = fDialog.selectedProducto;

                _movimiento = new InvMovimientoService.InvMovimiento();

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
                _movimiento.monto_impuesto = (_productoSeleccionado.precio * _productoSeleccionado.impuesto_valor) / 100;
                _movimiento.monto_impuesto_moneda = _movimiento.monto_impuesto * factor;
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
                Console.WriteLine(_movimiento.costo.ToString() + ", " + _movimiento.precio.ToString() + ", " + _movimiento.monto.ToString());
                Totalizar();

                ValidarBotones();
            }



        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvList.RowCount > 0)
            {
                string item = dgvList[dgvList.CurrentCell.ColumnIndex, dgvList.CurrentCell.RowIndex].Value.ToString();
                if (item != null && dgvList.CurrentCell.ColumnIndex != 0)
                {
                    InvMovimientoService.InvMovimiento obj = (InvMovimientoService.InvMovimiento)dgvList.CurrentRow.DataBoundItem;
                    bList.Remove(obj);
                    Totalizar();
                }
            }

            btnDel.Visible = false;
            if (bList.Count > 0)
            {
                btnDel.Visible = true;
            }
            ValidarBotones();
        }
        private void btnNullify_Click(object sender, EventArgs e)
        {
            one.id_cliente = _oneCliente.id;
            one.id_cotizacion = cmbCotizacion.SelectedValue.ToString();
            one.id_usuario = Globals.logUser.id;


            ColOperacion _oneCola = Globals.ConvertirHeadCola(one);
            List<App.ColOperacionService.ColMovimiento> _detail = Globals.ConvertirDetalleCola(bList);


            //SAVE
            try
            {
                string res = srvCola.SetOne(_oneCola, _detail);
                if (res.Length > 1)
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Documento enviado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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
        private void btnPay_Click(object sender, EventArgs e)
        {
            frmCajMovimientoSelection fDialog = new frmCajMovimientoSelection(one.total, _listaInstrumentos, "ventas");
            if (ConfigUI.LaunchDialogForm(fDialog) == DialogResult.OK)
            {
                _listaInstrumentos = fDialog.instrumentosSeleccionados;
                ValidarBotones();
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (one.id_tipo_operacion == "11E8F22493F0CDBC8FF600270E383B06")
            {
                imprimirFactura();
            }
            else
            {
                imprimirOperacion();
            }
        }
        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            frmVntClientesSelection fDialog = new frmVntClientesSelection();
            if (ConfigUI.LaunchDialogForm(fDialog) == DialogResult.OK)
            {
                AsignarCliente(fDialog.selectedCliente);
                ValidarBotones();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (bList.Count > 0)
            {
                LockButons();

                //ASIGNACIONES
                one.id_cliente = _oneCliente.id;
                one.id_cotizacion = cmbCotizacion.SelectedValue.ToString();
                one.id_usuario = Globals.logUser.id;


                List<VntOperacionService.InvMovimiento> _detail = ConvertirDetalle(bList);
                List<VntOperacionService.CajMovimiento> _pago = ConvertirPago(_listaInstrumentos);

                try
                {
                    string res = srvVenta.SetOne(one, _detail, _pago);
                    if (res.Length > 1)
                    {
                        if (one.id_tipo_operacion == "11E8F22493F0CDBC8FF600270E383B06")
                        {
                            imprimirFactura();
                        }
                        else
                        {
                            imprimirOperacion();
                        }
                        MetroFramework.MetroMessageBox.Show(this.MdiParent, "Operación registrada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this.MdiParent, "No se guardó la operaación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception)
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Se produjeron errores intentando procesar la operación, por favor revise los valores e intente nuevamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnSave.Enabled = true;

                }


            }

        }


        // COMBOS
        private void cmbCotizacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            factor = Globals.cotizacion[cmbCotizacion.SelectedIndex].valor;
            //GetList();
            if (bList != null)
            {
                foreach (InvMovimientoService.InvMovimiento item in bList)
                {
                    item.costo_moneda = item.costo * factor;
                    item.precio_moneda = item.precio * factor;
                    item.monto_moneda = item.monto * factor;
                }
                dgvList.Refresh();
                Totalizar();
            }
        }

        // GRID
        private void dgvList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double valor;
            if (double.TryParse(dgvList.CurrentCell.Value.ToString(), out valor))
            {
                InvMovimientoService.InvMovimiento obj = (InvMovimientoService.InvMovimiento)dgvList.CurrentRow.DataBoundItem;

                if (dgvList.CurrentCell.ColumnIndex == 22)
                {
                    obj.precio = obj.costo * ((valor / 100) + 1);
                    obj.precio_moneda = obj.precio * factor;
                }

                obj.monto = obj.precio * obj.cantidad;
                obj.monto_moneda = obj.precio_moneda * obj.cantidad;
                obj.monto_impuesto = (obj.precio * obj.valor_impuesto) / 100;
                obj.monto_impuesto_moneda = obj.monto_impuesto * factor;
                Totalizar();
            }


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


        private void frmVntOperacionesDetail_Load(object sender, EventArgs e)
        {
            ConfigGrid();
        }



        #endregion

        private void btnNullify_Click_1(object sender, EventArgs e)
        {
            if (bList.Count > 0)
            {
                //ASIGNACIONES
                one.id_usuario = Globals.logUser.id;


                List<VntOperacionService.InvMovimiento> _detail = ConvertirDetalle(bList);
                string res = srvVenta.NullOne(one, _detail);
                if (res.Length > 1)
                {
                    if (one.id_tipo_operacion == "11E8F22493F0CDBC8FF600270E383B06")
                    {
                        imprimirFactura();
                    }
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Registro anulado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "No se anuló el registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}
