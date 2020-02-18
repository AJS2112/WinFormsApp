using App.ColMovimientoService;
using App.ColOperacionService;
using App.VntClienteService;
using App.VntOperacionService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TfhkaNet.IF.VE;

namespace App.Common.Classes
{
    public class Globals
    {
        public static NumberFormatInfo nfiVE = new CultureInfo("es-VE", false).NumberFormat;
        public static Form appParentWindow;
        public static SisUsuariosService.SisUsuarios logUser;
        public static SisEmpresaService.SisEmpresa logEmpresa;
        public static double valorCotizacion = 0;
        public static List<CnfCotizacionService.CnfCotizacionDetalle> cotizacion;
        public static List<SisUsuariosService.SisUsuarios> listaUsuarios;
        public static int selectedCotizacion = 0;
        public static Tfhka Impresora;

        public static double TasaG = 16;
        public static double TasaR = 8;
        public static double TasaA = 31;

        #region FORMATOS
        private static void StringDoubleToFormat(object sender, ConvertEventArgs cevent)
        {
            double valor = (double)cevent.Value;
            cevent.Value = valor.ToString("N", nfiVE);
        }
        private static void StringFormatToDouble(object sender, ConvertEventArgs cevent)
        {
            // The method converts back to decimal type only. 
            if (cevent.DesiredType != typeof(string)) return;
        }
        private static string FillString(string cadena, int espacios)
        {
            string miStr = "";

            int miEspacio = espacios - cadena.Length;
            for (int i = 0; i <= miEspacio; i++)
            {
                miStr += " ";
            }
            miStr += cadena;
            return miStr;
        }
        private static string FormatoTexto(string texto, int letras)
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
        #endregion

        #region METODOS
        public static void CreateNumberBinding(MetroFramework.Controls.MetroTextBox txtBox, object one, string propiedad)
        {
            //// Creates the binding first. The OrderAmount is a Decimal type.
            Binding b = new Binding
               ("Text", one, propiedad,true,DataSourceUpdateMode.OnPropertyChanged);
            // Add the delegates to the event.
            b.Format += new ConvertEventHandler(StringDoubleToFormat);
            b.Parse += new ConvertEventHandler(StringFormatToDouble);
            txtBox.DataBindings.Add(b);
        }
        public static void ConfigurarComboMonedas(ComboBox cmbBox) {
            Console.WriteLine("Globals ConfiguerarMoneda: " + Globals.logEmpresa.moneda_defecto);
            cmbBox.DataSource = Globals.cotizacion;
            cmbBox.DisplayMember = "moneda_descrip";
            cmbBox.ValueMember = "id";
            cmbBox.DataBindings.Add("SelectedValue", Globals.logEmpresa, "moneda_defecto", true, DataSourceUpdateMode.OnPropertyChanged);
            if (Globals.logEmpresa.es_modo_fiscal)
            {
                cmbBox.Visible = false;
            }
        }


        //CONVERTIR HEADERS
        public static ColOperacion ConvertirHeadCola(VntOperacion headVenta)
        {
            ColOperacion _head = new ColOperacion();

            _head.id = headVenta.id;
            _head.order_id = headVenta.order_id;
            _head.last_update = headVenta.last_update;
            _head.id_empresa = headVenta.id_empresa;
            _head.id_tipo_operacion = headVenta.id_tipo_operacion;
            _head.numero = headVenta.numero;
            _head.nro_control = headVenta.nro_control;
            _head.fecha = headVenta.fecha;
            _head.fecha_registro = headVenta.fecha_registro;
            _head.id_destino = headVenta.id_destino;
            _head.id_cliente = headVenta.id_cliente;
            _head.cliente_nombre = headVenta.cliente_nombre;
            _head.cliente_rif = headVenta.cliente_rif;

            _head.id_tipo_documento = headVenta.id_tipo_documento;
            _head.tipo_documento_nombre = headVenta.tipo_documento_nombre;
            _head.nro_control_documento = headVenta.nro_control_documento;
            _head.nro_documento = headVenta.nro_documento;
            _head.fecha_documento = headVenta.fecha_documento;
            _head.nro_factura_afectada = headVenta.nro_factura_afectada;
            _head.id_doc_origen = headVenta.id_doc_origen;
            _head.id_cotizacion = headVenta.id_cotizacion;

            _head.monto_exento = headVenta.monto_exento;
            _head.base_imponible_tg = headVenta.base_imponible_tg;
            _head.base_imponible_tr = headVenta.base_imponible_tr;
            _head.base_imponible_ta = headVenta.base_imponible_ta;
            _head.pct_alicuota_tg = headVenta.pct_alicuota_tg;
            _head.pct_alicuota_tr = headVenta.pct_alicuota_tr;
            _head.pct_alicuota_ta = headVenta.pct_alicuota_ta;
            _head.monto_iva_tg = headVenta.monto_iva_tg;
            _head.monto_iva_tr = headVenta.monto_iva_tr;
            _head.monto_iva_ta = headVenta.monto_iva_ta;
            _head.total = headVenta.total;

            _head.monto_exento_moneda = headVenta.monto_exento_moneda;
            _head.base_imponible_tg_moneda = headVenta.base_imponible_tg_moneda;
            _head.base_imponible_tr_moneda = headVenta.base_imponible_tr_moneda;
            _head.base_imponible_ta_moneda = headVenta.base_imponible_ta_moneda;
            _head.monto_iva_tg_moneda = headVenta.monto_iva_tg_moneda;
            _head.monto_iva_tr_moneda = headVenta.monto_iva_tr_moneda;
            _head.monto_iva_ta_moneda = headVenta.monto_iva_ta_moneda;
            _head.total_moneda = headVenta.total_moneda;

            _head.pct_descuento = headVenta.pct_descuento;
            _head.pct_adicional = headVenta.pct_adicional;
            _head.id_status = headVenta.id_status;
            _head.id_estado = headVenta.id_estado;
            _head.id_usuario = headVenta.id_usuario;
            _head.usuario_nombre = headVenta.usuario_nombre;
            _head.observacion = headVenta.observacion;

            return _head;
        }

        public static VntOperacion ConvertirHeadVenta(ColOperacion headVenta)
        {
            VntOperacion _head = new VntOperacion();

            _head.id = headVenta.id;
            _head.order_id = headVenta.order_id;
            _head.last_update = headVenta.last_update;
            _head.id_empresa = headVenta.id_empresa;
            _head.id_tipo_operacion = headVenta.id_tipo_operacion;
            _head.numero = headVenta.numero;
            _head.nro_control = headVenta.nro_control;
            _head.fecha = headVenta.fecha;
            _head.fecha_registro = headVenta.fecha_registro;
            _head.id_destino = headVenta.id_destino;
            _head.id_cliente = headVenta.id_cliente;
            _head.cliente_nombre = headVenta.cliente_nombre;
            _head.cliente_rif = headVenta.cliente_rif;

            _head.id_tipo_documento = headVenta.id_tipo_documento;
            _head.tipo_documento_nombre = headVenta.tipo_documento_nombre;
            _head.nro_control_documento = headVenta.nro_control_documento;
            _head.nro_documento = headVenta.nro_documento;
            _head.fecha_documento = headVenta.fecha_documento;
            _head.nro_factura_afectada = headVenta.nro_factura_afectada;
            _head.id_doc_origen = headVenta.id_doc_origen;
            _head.id_cotizacion = headVenta.id_cotizacion;

            _head.monto_exento = headVenta.monto_exento;
            _head.base_imponible_tg = headVenta.base_imponible_tg;
            _head.base_imponible_tr = headVenta.base_imponible_tr;
            _head.base_imponible_ta = headVenta.base_imponible_ta;
            _head.pct_alicuota_tg = headVenta.pct_alicuota_tg;
            _head.pct_alicuota_tr = headVenta.pct_alicuota_tr;
            _head.pct_alicuota_ta = headVenta.pct_alicuota_ta;
            _head.monto_iva_tg = headVenta.monto_iva_tg;
            _head.monto_iva_tr = headVenta.monto_iva_tr;
            _head.monto_iva_ta = headVenta.monto_iva_ta;
            _head.total = headVenta.total;

            _head.monto_exento_moneda = headVenta.monto_exento_moneda;
            _head.base_imponible_tg_moneda = headVenta.base_imponible_tg_moneda;
            _head.base_imponible_tr_moneda = headVenta.base_imponible_tr_moneda;
            _head.base_imponible_ta_moneda = headVenta.base_imponible_ta_moneda;
            _head.monto_iva_tg_moneda = headVenta.monto_iva_tg_moneda;
            _head.monto_iva_tr_moneda = headVenta.monto_iva_tr_moneda;
            _head.monto_iva_ta_moneda = headVenta.monto_iva_ta_moneda;
            _head.total_moneda = headVenta.total_moneda;

            _head.pct_descuento = headVenta.pct_descuento;
            _head.pct_adicional = headVenta.pct_adicional;
            _head.id_status = headVenta.id_status;
            _head.id_estado = headVenta.id_estado;
            _head.id_usuario = headVenta.id_usuario;
            _head.usuario_nombre = headVenta.usuario_nombre;
            _head.observacion = headVenta.observacion;

            return _head;
        }

        //CONVERTIR LISTAS
        public static List<InvMovimiento> ConvertirDetalle(BindingList<App.InvMovimientoService.InvMovimiento> listaBinding)
        {
            List<App.VntOperacionService.InvMovimiento> _listaDetalle = new List<App.VntOperacionService.InvMovimiento>();

            foreach (App.InvMovimientoService.InvMovimiento item in listaBinding)
            {
                App.VntOperacionService.InvMovimiento mov = new App.VntOperacionService.InvMovimiento();
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

        public static List<App.ColOperacionService.ColMovimiento> ConvertirDetalleCola(BindingList<App.InvMovimientoService.InvMovimiento> listaBinding)
        {
            List<App.ColOperacionService.ColMovimiento> _listaDetalle = new List<App.ColOperacionService.ColMovimiento>();

            foreach (App.InvMovimientoService.InvMovimiento item in listaBinding)
            {
                App.ColOperacionService.ColMovimiento mov = new App.ColOperacionService.ColMovimiento();
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

        public static List<InvMovimiento> ConvertirDetalleVenta(List<App.ColMovimientoService.ColMovimiento> listaDetalle)
        {
            List<InvMovimiento> _listaDetalle = new List<InvMovimiento>();

            foreach (App.ColMovimientoService.ColMovimiento item in listaDetalle)
            {
                InvMovimiento mov = new InvMovimiento();
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

        public static List<CajMovimiento> ConvertirPago(List<App.CajMovimientoService.CajMovimiento> lista)
        {
            List<App.VntOperacionService.CajMovimiento> _listaPago = new List<App.VntOperacionService.CajMovimiento>();

            foreach (App.CajMovimientoService.CajMovimiento item in lista)
            {
                App.VntOperacionService.CajMovimiento mov = new App.VntOperacionService.CajMovimiento();

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
        #endregion

        #region IMPRESIONES
        //FISCAL
        //DOCUMENTOS FISCALES
        public static Boolean ImprimirFacturaFiscal(VntCliente _oneCliente, VntOperacion one, List<App.VntOperacionService.InvMovimiento> _listaDetalle, Label lblProgreso)
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

            //MessageBox.Show("RIF Cliente");
            string rif = FormatoTexto(_oneCliente.rif, 11);
            c = "iR*" + rif;
            bRet = Globals.Impresora.SendCmd(c);
            if (bRet == false)
            {
                lblProgreso.Text = "Ocurrió un error imprimiendo el rif del cliente";
            }

            //MessageBox.Show("Direccion");
            string direccion = FormatoTexto(_oneCliente.direccion, 30);
            c = "i01DIRECCION: " + direccion;
            bRet = Globals.Impresora.SendCmd(c);
            if (bRet == false)
            {
                lblProgreso.Text = "Ocurrió un error imprimiendo la dirección del cliente";
            }

            //MessageBox.Show("Tlf");
            string telefono = FormatoTexto(_oneCliente.telefono, 30);
            c = "i02TELEFONO: " + telefono;
            bRet = Globals.Impresora.SendCmd(c);
            if (bRet == false)
            {
                lblProgreso.Text = "Ocurrió un error imprimiendo el teléfono del cliente";
            }

            //MessageBox.Show("NRO CONTROL");
            string numero = FormatoTexto(one.nro_control, 30);
            c = "i03N. CONTROL: " + numero;
            bRet = Globals.Impresora.SendCmd(c);
            if (bRet == false)
            {
                lblProgreso.Text = "Ocurrió un error imprimiendo el número de control";
            }

            //MessageBox.Show("CONDICION DE VENTA");
            c = "i04" + "CONDICION VENTA: ** CONTADO **";
            bRet = Globals.Impresora.SendCmd(c);
            if (bRet == false)
            {
                lblProgreso.Text = "Ocurrió un error imprimiendo la condición de venta";
            }


            /********************** PRODUCTOS *************************************/

            for (int i = 0; i < (_listaDetalle.Count); i++)
            {
                c = "";
                if (Convert.ToInt16(_listaDetalle[i].valor_impuesto) == 0)
                {
                    c = " ";
                }

                if (Convert.ToInt16(_listaDetalle[i].valor_impuesto) == Convert.ToInt16(Globals.TasaG))
                {
                    c = "!";
                }

                //MessageBox.Show(c);

                Double precioBase = Convert.ToDouble(_listaDetalle[i].precio_moneda);
                Double valorIva = (Convert.ToDouble(_listaDetalle[i].valor_impuesto) / 100) + 1;
                Double precioFinal = Convert.ToDouble(_listaDetalle[i].precio_moneda);

                Double formatoPrecio = precioFinal * 100;
                Double formatoCantidad = Convert.ToInt64(_listaDetalle[i].cantidad) * 1000;

                string precio = formatoPrecio.ToString("0000000000");
                string cantidad = formatoCantidad.ToString("00000000");
                string producto = FormatoTexto(_listaDetalle[i].producto_nombre.ToString(), 40);
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
        public static Boolean ImprimirNotaCreditoFiscal(VntOperacion one, List<App.VntOperacionService.InvMovimiento> _listaDetalle, Label lblProgreso)
        {
            lblProgreso.Text = "Imprimiendo";

            string c = "";
            Boolean bRet;

            //MessageBox.Show("Nombre Cliente");
            string nombre = FormatoTexto(one.cliente_nombre, 40);
            c = "iS*" + nombre;
            bRet = Globals.Impresora.SendCmd(c);
            if (bRet == false)
            {
                lblProgreso.Text = "Ocurrió un error imprimiendo el  nombre del cliente";
            }

            //MessageBox.Show("Rif Cliente");
            string rif = FormatoTexto(one.cliente_rif, 11);
            c = "iR*" + rif;
            bRet = Globals.Impresora.SendCmd(c);
            if (bRet == false)
            {
                lblProgreso.Text = "Ocurrió un error imprimiendo el rif del cliente";
            }

            string numero = "00000000";
            if (one.nro_factura_afectada != null)
            {
                numero = one.nro_factura_afectada;
            }
            c = "iF*" + numero;
            bRet = Globals.Impresora.SendCmd(c);
            if (bRet == false)
            {
                lblProgreso.Text = "Ocurrió un error imprimiendo el número de factura";
            }


            //MessageBox.Show("FECHA");
            string fecha = "01-01-01";
            if (one.fecha_documento != null)
            {
                fecha = one.fecha_documento.ToString();
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
                //EstatusS5 = Globals.Impresora.GetS5PrinterData();
                //serial = EstatusS5.RegisteredMachineNumber;
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

            for (int i = 0; i < (_listaDetalle.Count); i++)
            {

                //MessageBox.Show(_listaDetalle[i].valor_impuesto.ToString());

                c = "";
                if (Convert.ToInt16(_listaDetalle[i].valor_impuesto) == 0)
                {
                    c = "d0";
                }

                if (Convert.ToInt16(_listaDetalle[i].valor_impuesto) == Convert.ToInt16(Globals.TasaG))
                {
                    c = "d1";
                }

                //MessageBox.Show("El valor del impuesto es: " + c);

                Double precioBase = Convert.ToDouble(_listaDetalle[i].precio);
                Double valorIva = (Convert.ToDouble(_listaDetalle[i].valor_impuesto) / 100) + 1;
                //Double precioFinal = precioBase / valorIva;
                Double precioFinal = precioBase;

                Double formatoPrecio = precioFinal * 100;
                Double formatoCantidad = Convert.ToInt64(_listaDetalle[i].cantidad) * 1000;

                string precio = formatoPrecio.ToString("0000000000");
                string cantidad = formatoCantidad.ToString("00000000");
                string producto = FormatoTexto(_listaDetalle[i].producto_nombre.ToString(), 40);
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

        //GENERIC PRINTER
        public static void ImprimirTicketVenta(VntOperacion one, List<App.VntOperacionService.InvMovimiento> _listaDetalle, double factor)
        {
            PrintDocument printDocument = new PrintDocument();
            //printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CrearTicket); //add an event handler that will do the printing
            printDocument.PrintPage += delegate (object sender, System.Drawing.Printing.PrintPageEventArgs e)
            {
                double montoExento = (one.monto_exento) * factor;
                double montoBase = (one.base_imponible_ta + one.base_imponible_tg + one.base_imponible_tr) * factor;
                double montoIva = (one.monto_iva_ta + one.monto_iva_tg + one.monto_iva_tr) * factor;

                Graphics graphic = e.Graphics;

                int startX = 0;
                int startY = 10;
                int offset = 280;

                //HEADER
                graphic.DrawString(Globals.logEmpresa.rif, new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
                graphic.DrawString(Globals.logEmpresa.nombre, new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY + 20);
                graphic.DrawString(Globals.logEmpresa.direccion, new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY + 40);
                graphic.DrawString("TUCUPITA - EDO. DELTA AMACURO", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY + 60);
                graphic.DrawString("TLF: " + Globals.logEmpresa.telefono, new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY + 80);

                graphic.DrawString(" ", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY + 100);
                string Cliente = "";
                if (one.cliente_nombre.Length < 31)
                {
                    Cliente = one.cliente_nombre;
                }
                else
                {
                    Cliente = one.cliente_nombre.Substring(0, 31);
                }

                graphic.DrawString("CLIENTE: " + Cliente, new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY + 120);
                graphic.DrawString("RIF: " + one.cliente_rif, new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY + 140);
                graphic.DrawString("REF: *01556901", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY + 160);
                graphic.DrawString("USU: VENTAS VEN: 01", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY + 180);


                graphic.DrawString(one.tipo_documento_nombre + ": " + one.nro_control, new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY + 200);
                graphic.DrawString("FECHA: " + one.fecha, new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY + 220);
                graphic.DrawString("----------------------------------------", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY + 240);




                //DETAIL
                foreach (App.VntOperacionService.InvMovimiento item in _listaDetalle)
                {
                    string linea = "";
                    if (item.cantidad > 1)
                    {
                        linea = item.cantidad.ToString("N2") + " " + item.producto_unidad + " x Bs. " + item.precio_moneda.ToString("N2");
                        graphic.DrawString(linea, new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY + offset);
                        offset += 20;
                    }

                    int espacios = 26 - item.producto_nombre.Length;

                    string elProd = "";
                    if (espacios > 0)
                    {
                        elProd = item.producto_nombre;

                        for (int i = 0; i <= espacios; i++)
                        {
                            elProd += " ";
                        }
                    }
                    else
                    {
                        elProd = item.producto_nombre.Substring(0, 26);
                    }

                    string elMonto = "Bs " + item.monto_moneda.ToString("N2");

                    graphic.DrawString(elProd + " " + elMonto, new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY + offset);
                    offset += 20;
                    graphic.DrawString("----------------------------------------", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY + offset);
                }

                //FOOTER
                int miMargen = 0;
                string miTexto = "";

                offset += 20;
                miTexto = "EXENTO Bs: " + FillString(montoExento.ToString("N2"), 13);
                miMargen = 39 - miTexto.Length;
                graphic.DrawString("".PadRight(40 - miTexto.Length) + miTexto, new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY + offset);

                offset += 20;
                miTexto = "BASE IMPONIBLE Bs: " + FillString(montoBase.ToString("N2"), 13);
                miMargen = 39 - miTexto.Length;
                graphic.DrawString("".PadRight(40 - miTexto.Length) + miTexto, new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY + offset);

                offset += 20;
                miTexto = "TOTAL IVA Bs: " + FillString(montoIva.ToString("N2"), 13);
                miMargen = 39 - miTexto.Length;
                graphic.DrawString("".PadRight(40 - miTexto.Length) + miTexto, new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY + offset);

                offset += 20;
                miTexto = "TOTAL Bs: " + FillString(one.total_moneda.ToString("N2"), 13);
                miMargen = 39 - miTexto.Length;
                graphic.DrawString("".PadRight(40 - miTexto.Length) + miTexto, new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY + offset);

                offset = offset + 40;
                graphic.DrawString("        GRACIAS POR SU COMPRA!", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + 40;

                graphic.DrawString(" ", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + 20;
                graphic.DrawString(" ", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + 20;
                graphic.DrawString(" ", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + 20;
                graphic.DrawString(" ", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY + offset);
            };
            try
            {
                printDocument.Print();
            }
            catch (Exception ex)
            {

                throw new Exception("Ocurrió un error al intentar imprimir, ",ex);
            }
            printDocument.Print();
        }
        #endregion
    }
}
