using App.CajMovimientoService;
using App.CnfCotizacionService;
using App.Common.Classes;
using App.Core.Caja;
using App.InvMovimientoService;
using App.InvProductoService;
using App.SisListasService;
using App.SisOperacionService;
using App.VntOperacionService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPV
{
    public partial class frmDevolucion : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES
        //SERVICIOS
        private VntOperacionClient srvVenta = new VntOperacionClient();
        private SisListasClient srvListas = new SisListasClient();
        private SisOperacionClient srvOperacion = new SisOperacionClient();
        private InvMovimientoClient srvMovimiento = new InvMovimientoClient();
        private CajMovimientoClient srvMovimientoCaja = new CajMovimientoClient();
        private CnfCotizacionClient srvCotizacion = new CnfCotizacionClient();


        //LISTAS
        private List<CnfCotizacionDetalle> _listaCotizacion = new List<CnfCotizacionDetalle>();
        private List<SisOperacion> _listaOperaciones = new List<SisOperacion>();
        private List<App.InvMovimientoService.InvMovimiento> _listaDetalle = new List<App.InvMovimientoService.InvMovimiento>();
        private List<App.InvMovimientoService.InvMovimiento> _listaDetalleOriginal = new List<App.InvMovimientoService.InvMovimiento>();
        private List<App.InvMovimientoService.InvMovimiento> _listaDetalleRelacionados = new List<App.InvMovimientoService.InvMovimiento>();
        private List<App.CajMovimientoService.CajMovimiento> _listaInstrumentos = new List<App.CajMovimientoService.CajMovimiento>();

        //OBJETOS
        private SisOperacion _tipoOperacion = new SisOperacion();
        private CnfCotizacionDetalle _oneCotizacion = new CnfCotizacionDetalle();
        private App.InvMovimientoService.InvMovimiento _movimiento { get; set; }
        private InvProducto _productoSeleccionado { get; set; }
        private VntOperacion oneDocumentoOrigen { get; set; }
        private VntOperacion oneDevolucion { get; set; }
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
        private void ConfigGrid()
        {
            for (int i = 0; i <= dgvList.Columns.Count - 1; i++)
            {
                dgvList.Columns[i].Visible = false;
                Console.WriteLine(i.ToString() + " - " + dgvList.Columns[i].HeaderText);
            }

            dgvList.Columns[0].DisplayIndex = 7;
            dgvList.Columns[17].DisplayIndex = 0;
            dgvList.Columns[18].DisplayIndex = 1;
            dgvList.Columns[19].DisplayIndex = 2;
            dgvList.Columns[16].DisplayIndex = 3;

            dgvList.Columns[17].HeaderText = "CODIGO";
            dgvList.Columns[17].Visible = true;
            //dgvList.Columns[17].Width = 140;
            dgvList.Columns[17].ReadOnly = true;

            dgvList.Columns[18].HeaderText = "DESCRIPCION";
            dgvList.Columns[18].Visible = true;
            dgvList.Columns[18].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvList.Columns[18].ReadOnly = true;

            dgvList.Columns[19].HeaderText = "UNIDAD";
            dgvList.Columns[19].Visible = true;
            //dgvList.Columns[19].Width = 80;
            dgvList.Columns[19].ReadOnly = true;

            dgvList.Columns[16].HeaderText = "PRECIO";
            dgvList.Columns[16].Visible = true;
            dgvList.Columns[16].DefaultCellStyle.FormatProvider = Globals.nfiVE;
            dgvList.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvList.Columns[16].DefaultCellStyle.Format = "N2";
            dgvList.Columns[16].ReadOnly = true;
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
        private void InicializarDevolucion()
        {
            switch (oneDocumentoOrigen.id_tipo_operacion)
            {
                case "11E8F22493F0CDBC8FF600270E383B06": //FACTURA
                    oneDevolucion = srvVenta.GetOne(Globals.logEmpresa.id, "11E95C6B1693D4D2808B00E04C6F7E24", "0");
                    break;
                case "11E8F2249FB109E98FF600270E383B06": //NOTA DE ENTREGA
                    oneDevolucion = srvVenta.GetOne(Globals.logEmpresa.id, "11E95C6B30D59DAE808B00E04C6F7E24", "0");
                    break;
            }

            oneDevolucion.id_cliente = oneDocumentoOrigen.id_cliente;
            oneDevolucion.cliente_nombre = oneDocumentoOrigen.cliente_nombre;
            oneDevolucion.cliente_rif = oneDocumentoOrigen.cliente_rif;

            oneDevolucion.id_tipo_documento = oneDocumentoOrigen.id_tipo_operacion;
            oneDevolucion.nro_control_documento = oneDocumentoOrigen.nro_control;
            oneDevolucion.nro_documento = oneDocumentoOrigen.nro_control;
            oneDevolucion.fecha_documento = oneDocumentoOrigen.fecha;
            oneDevolucion.nro_factura_afectada = oneDocumentoOrigen.nro_control;
            oneDevolucion.id_cotizacion = oneDocumentoOrigen.id_cotizacion;
            oneDevolucion.id_doc_origen = oneDocumentoOrigen.id;

            //DETALLE
            _listaDetalleOriginal = srvMovimiento.GetList(oneDocumentoOrigen.id);
            _listaDetalleRelacionados = srvMovimiento.GetListByOrigen(oneDocumentoOrigen.id);

            foreach (App.InvMovimientoService.InvMovimiento item in _listaDetalleRelacionados)
            {
                App.InvMovimientoService.InvMovimiento obj = _listaDetalleOriginal.Find(x => x.id_producto.Contains(item.id_producto));
                obj.cantidad -= item.cantidad;
            }

            _listaDetalle = _listaDetalleOriginal;

            //PAGO
            _listaInstrumentos = srvMovimientoCaja.GetList(oneDocumentoOrigen.id);

        }

        private void SaveDevolucion()
        {

            _tipoOperacion = GetTipoOperacion(oneDevolucion.id_tipo_operacion);
            oneDevolucion.tipo_documento_nombre = _tipoOperacion.nombre;
            //_listaInstrumentos = fDialog.instrumentosSeleccionados;

            List<App.VntOperacionService.InvMovimiento> _detail = Globals.ConvertirDetalle(bList);
            List<App.VntOperacionService.CajMovimiento> _pago = Globals.ConvertirPago(_listaInstrumentos);

            //SAVE
            try
            {
                string res = srvVenta.SetOne(oneDevolucion, _detail, _pago);
                if (res.Length > 1)
                {
                    if (oneDevolucion.id_tipo_operacion == "11E8F22493F0CDBC8FF600270E383B06")
                    {
                        Globals.ImprimirNotaCreditoFiscal(oneDevolucion, _detail, lblProgreso);
                    }
                    else
                    {
                        //imprimirOperacion();
                        Globals.ImprimirTicketVenta(oneDevolucion, _detail, factor);
                    }
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Operación registrada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void SelKey(Keys tecla)
        {
            switch (tecla)
            {
                case Keys.F9:
                    //bool miRes = ValidarBotones();
                    //if (miRes)
                    //{
                        SelPago();
                    //}
                    break;
            }
        }
        private void SelPago()
        {
            AppPV.frmSelection.frmCajMovimientoSelection fDialog = new AppPV.frmSelection.frmCajMovimientoSelection(oneDevolucion, _listaInstrumentos, "devolucion");
            if (ConfigUI.LaunchDialogForm(fDialog) == DialogResult.OK)
            {
                _tipoOperacion = GetTipoOperacion(oneDevolucion.id_tipo_operacion);
                oneDevolucion.tipo_documento_nombre = _tipoOperacion.nombre;
                _listaInstrumentos = fDialog.instrumentosSeleccionados;


                foreach (App.InvMovimientoService.InvMovimiento item in bList)
                {
                    item.id = "0";
                    item.id_operacion = oneDevolucion.id;
                    item.id_tipo_operacion = oneDevolucion.id_tipo_operacion;
                    item.last_update = 0;
                    item.order_id = 0;
                }

                foreach (App.CajMovimientoService.CajMovimiento item in _listaInstrumentos)
                {
                    item.id = "0";
                    item.id_operacion = oneDevolucion.id;
                    item.id_tipo_operacion = oneDevolucion.id_tipo_operacion;
                    item.last_update = oneDevolucion.last_update;
                    item.order_id = oneDevolucion.order_id;
                }

                List<App.VntOperacionService.InvMovimiento> _detail = Globals.ConvertirDetalle(bList);
                List<App.VntOperacionService.CajMovimiento> _pago = Globals.ConvertirPago(_listaInstrumentos);

                //SAVE
                try
                {
                    string res = srvVenta.SetOne(oneDevolucion, _detail, _pago);
                    if (res.Length > 1)
                    {
                        if (oneDevolucion.id_tipo_operacion == "11E95C6B1693D4D2808B00E04C6F7E24")
                        {
                            Globals.ImprimirNotaCreditoFiscal(oneDevolucion, _detail, lblProgreso);
                        }
                        else
                        {
                            Globals.ImprimirTicketVenta(oneDevolucion, _detail, factor);
                        }
                        MetroFramework.MetroMessageBox.Show(this, "Operación registrada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                }

            }
        }
        private void Totalizar()
        {

            int items = 0;
            oneDevolucion.base_imponible_ta = 0;
            oneDevolucion.base_imponible_tg = 0;
            oneDevolucion.base_imponible_tr = 0;

            oneDevolucion.monto_exento = 0;
            oneDevolucion.monto_iva_ta = 0;
            oneDevolucion.monto_iva_tg = 0;
            oneDevolucion.monto_iva_tr = 0;

            oneDevolucion.total = 0;
            oneDevolucion.total_moneda = 0;
            foreach (App.InvMovimientoService.InvMovimiento item in bList)
            {
                items += 1;
                item.precio_moneda = item.precio * factor;
                item.monto = item.precio * item.cantidad;

                item.monto_moneda = item.monto * factor;


                oneDevolucion.total_moneda += item.monto_moneda;

                oneDevolucion.total += item.monto;
                Console.WriteLine("Monto: " + item.monto.ToString());
                switch (item.id_impuesto)
                {
                    case "11E8F23EDF0D15388FF600270E383B06": //EXENTO
                        oneDevolucion.monto_exento += item.monto;
                        break;
                    case "11E7E1D6570F9A40AC8A00E04C6F7E24": //GENERAL
                        oneDevolucion.base_imponible_tg += item.monto;
                        oneDevolucion.monto_iva_tg += item.monto_impuesto;
                        break;
                    case "11E8F23EEF10FE9E8FF600270E383B06": //REDUCIDA
                        oneDevolucion.base_imponible_tr += item.monto;
                        oneDevolucion.monto_iva_tr += item.monto_impuesto;
                        break;
                    case "11E8F23EF76C98758FF600270E383B06": //AMPLIADA
                        oneDevolucion.base_imponible_ta += item.monto;
                        oneDevolucion.monto_iva_ta += item.monto_impuesto;
                        break;
                }

            }


            lblItems.Text = "(" + items.ToString() + ")";
            lblTotal.Text = "Total: " + oneDevolucion.total_moneda.ToString("N2", Globals.nfiVE);

            if (bList.Count == 0) btnDel.Visible = false;
        }

        void frmPuntoVenta_KeyDown(object sender, KeyEventArgs e)
        {
            SelKey(e.KeyCode);
        }
        #endregion


        //CONSTRUCTOR
        public frmDevolucion()
        {
            InitializeComponent();
        }

        public frmDevolucion(VntOperacion _one)
        {
            InitializeComponent();

            _listaOperaciones = srvOperacion.GetList("11E7C39A0EACD9A08F1A00E04C6F7E24");

            oneDocumentoOrigen = _one;


            //COTIZACION
            CnfCotizacionClient srvCotizacion = new CnfCotizacionClient();
            List<CnfCotizacionDetalle> _cotizacion = srvCotizacion.GetListDetail(oneDocumentoOrigen.id_cotizacion);
            foreach (CnfCotizacionDetalle item in _cotizacion)
            {
                if (item.id_moneda == Globals.logEmpresa.moneda_defecto)
                {
                    factor = item.valor;
                }
            }

            //HEADER
            lblTitle.Text = "Devolución: " + oneDocumentoOrigen.tipo_documento_nombre;
            lblSubTitle.Text = oneDocumentoOrigen.nro_control; 

            lblClienteNombre.Text = oneDocumentoOrigen.cliente_nombre;
            lblClienteRif.Text = oneDocumentoOrigen.cliente_rif;

            InicializarDevolucion();

            bList = new BindingList<App.InvMovimientoService.InvMovimiento>(_listaDetalle);
            bs.DataSource = bList;
            dgvList.DataSource = bs;
            Totalizar();

            lblProgreso.Visible = false;

            this.KeyPreview = true;
            this.KeyDown +=
                new KeyEventHandler(frmPuntoVenta_KeyDown);
        }

        #region EVENTOS
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSel_Click(object sender, EventArgs e)
        {
            SelKey(Keys.F9);
        }


        private void dgvList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            App.InvMovimientoService.InvMovimiento obj = (App.InvMovimientoService.InvMovimiento)dgvList.CurrentRow.DataBoundItem;

            App.InvMovimientoService.InvMovimiento itemOriginal =  _listaDetalleOriginal.Find(x => x.id_producto.Contains(obj.id_producto));
            
            if (obj.cantidad > itemOriginal.cantidad)
            {
                obj.cantidad = itemOriginal.cantidad;
                obj.monto_moneda = obj.precio_moneda * obj.cantidad;
                obj.precio = obj.precio_moneda / factor;
                obj.monto = obj.precio * obj.cantidad;
            }
            else
            {
                obj.monto_moneda = obj.precio_moneda * obj.cantidad;
                obj.precio = obj.precio_moneda / factor;
                obj.monto = obj.precio * obj.cantidad;
            }
            
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

        #endregion

        private void frmDevolucion_Load(object sender, EventArgs e)
        {
            ConfigGrid();
        }
    }
}
