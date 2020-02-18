using App.ColMovimientoService;
using App.ColOperacionService;
using App.Common.Classes;
using App.InvProductoService;
using App.SisListasService;
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

namespace AppCaja.Dialogs
{
    public partial class frmCajVistaPrevia : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES
        //SERVICIOS
        private ColOperacionClient srv = new ColOperacionClient();
        private SisListasClient srvListas = new SisListasClient();
        private SisOperacionClient srvOperacion = new SisOperacionClient();
        private ColMovimientoClient srvMovimiento = new ColMovimientoClient();
        private VntClienteClient srvCliente = new VntClienteClient();
        //private SisOperacionClient srvOperaciones = new SisOperacionClient();

        //LISTAS
        private List<SisOperacion> _listaOperaciones = new List<SisOperacion>();
        private List<SisListas> _listaTipoDocumentos = new List<SisListas>();
        private List<App.ColMovimientoService.ColMovimiento> _listaDetalle = new List<App.ColMovimientoService.ColMovimiento>();

        //OBJETOS
        private SisOperacion _tipoOperacion = new SisOperacion();
        private VntCliente _oneCliente { get; set; }
        private App.ColMovimientoService.ColMovimiento _movimiento { get; set; }
        private ColOperacion one { get; set; }
        private InvProducto _productoSeleccionado { get; set; }
        //BINDINGS
        BindingSource bs = new BindingSource();
        BindingList<App.ColMovimientoService.ColMovimiento> bList;


        double factor = 1;

        #endregion

        #region METODOS
        private void AsignarCliente(VntCliente _cliente)
        {
            _oneCliente = _cliente;
            lblClienteNombre.Text = _oneCliente.nombre;
            lblClienteRif.Text = _oneCliente.rif;
        }

        private void CrearBindings()
        {
            _listaOperaciones = srvOperacion.GetList("11E7C39A0EACD9A08F1A00E04C6F7E24");
            cmbTipoOperacion.DataSource = _listaOperaciones;
            cmbTipoOperacion.DisplayMember = "nombre";
            cmbTipoOperacion.ValueMember = "id";
        }


        private void ConfigGrid()
        {
            for (int i = 0; i <= dgvList.Columns.Count - 1; i++)
            {
                dgvList.Columns[i].Visible = false;
                //Console.WriteLine(i.ToString() + " - " + dgvList.Columns[i].HeaderText);
            }

            //dgvList.Columns[0].DisplayIndex = 7;
            dgvList.Columns[17].DisplayIndex = 0;
            dgvList.Columns[18].DisplayIndex = 1;
            dgvList.Columns[19].DisplayIndex = 2;
            dgvList.Columns[16].DisplayIndex = 3;

            dgvList.Columns[17].HeaderText = "CODIGO";
            //dgvList.Columns[17].Visible = true;
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

        private void Totalizar()
        {
            factor = Globals.valorCotizacion;
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

            foreach (App.ColMovimientoService.ColMovimiento item in bList)
            {
                items += 1;
                item.precio_moneda = item.precio * factor;
                item.monto = item.precio * item.cantidad;
                item.monto_moneda = item.monto * factor;
                item.monto_impuesto = (item.monto * item.valor_impuesto) / 100;
                item.monto_impuesto_moneda = item.monto_impuesto * factor;


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

            one.total_moneda = one.total * factor;


            lblItems.Text = "(" + items.ToString() + ")";
            lblTotal.Text = "Total: " + one.total_moneda.ToString("N2", Globals.nfiVE);


            //int items = 0;
            ///*one.base_imponible_ta = 0;
            //one.base_imponible_tg = 0;
            //one.base_imponible_tr = 0;

            //one.monto_exento = 0;
            //one.monto_iva_ta = 0;
            //one.monto_iva_tg = 0;
            //one.monto_iva_tr = 0;*/

            //one.total = 0;
            //one.total_moneda = one.total* Globals.valorCotizacion;
            
            //foreach (App.ColMovimientoService.ColMovimiento item in bList)
            //{
            //    items += 1;
                
            //    item.precio_moneda = item.precio * Globals.valorCotizacion;
            //    item.monto_moneda = item.monto * Globals.valorCotizacion;

                
            //    one.total += item.monto;
            //}

            //one.total_moneda = one.total * Globals.valorCotizacion;

            //Console.WriteLine("Globals.valorCotizacion: "+Globals.valorCotizacion);
            //lblItems.Text = "(" + items.ToString() + ")";
            //lblTotal.Text = "Total: " + one.total_moneda.ToString("N2", Globals.nfiVE);

            if (bList.Count > 0)
            {
                btnDel.Visible = true;
                btnSave.Visible = true;
            } else
            {
                btnDel.Visible = false;
                btnSave.Visible = false;
            }

        }

        #endregion

        public frmCajVistaPrevia()
        {
            InitializeComponent();
        }

        public frmCajVistaPrevia(ColOperacion _one)
        {
            InitializeComponent();

            CrearBindings();

            //ONE
            if (_one == null) return;
            one = _one;
            Console.WriteLine("LoadTipoOperacion: " + one.id_tipo_operacion);
            cmbTipoOperacion.DataBindings.Add("SelectedValue", one, "id_tipo_operacion", true, DataSourceUpdateMode.OnPropertyChanged);

            
            //LISTAS
            _tipoOperacion = srvOperacion.GetOne(one.id_tipo_operacion);
            if (_tipoOperacion == null) return;

            //CLIENTE
            if (one.id_cliente != "")
            {
                VntCliente cliente = srvCliente.GetOne(Globals.logEmpresa.id, one.id_cliente);
                if (cliente != null) AsignarCliente(cliente);
            }


            //DETALLE
            _listaDetalle = srvMovimiento.GetList(one.id);
            bList = new BindingList<App.ColMovimientoService.ColMovimiento>(_listaDetalle);

            bs.DataSource = bList;
            dgvList.DataSource = bs;

            //TOTAL
            Totalizar();
        }

        private void frmCajVistaPrevia_Load(object sender, EventArgs e)
        {
            ConfigGrid();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _listaDetalle = srvMovimiento.GetList(one.id);
            bList = new BindingList<App.ColMovimientoService.ColMovimiento>(_listaDetalle);
            Totalizar();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmInvProductosSelection fDialog = new frmInvProductosSelection();
            if (ConfigUI.LaunchDialogForm(fDialog) == DialogResult.OK)
            {
                _productoSeleccionado = fDialog.selectedProducto;

                _movimiento = new App.ColMovimientoService.ColMovimiento();

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
                _movimiento.monto_impuesto = 0;
                _movimiento.monto_impuesto_moneda = 0;
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
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvList.RowCount > 0)
            {
                try
                {
                    string item = dgvList[dgvList.CurrentCell.ColumnIndex, dgvList.CurrentCell.RowIndex].Value.ToString();
                    if (item != null && dgvList.CurrentCell.ColumnIndex != 0)
                    {
                        App.ColMovimientoService.ColMovimiento obj = (App.ColMovimientoService.ColMovimiento)dgvList.CurrentRow.DataBoundItem;
                        bList.Remove(obj);
                        Totalizar();
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Seleccione un elemento de la lista");
                }
            }

            btnDel.Visible = false;
            if (bList.Count > 0)
            {
                btnDel.Visible = true;
            }
        }

        private void btnNullify_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult resDel = MetroFramework.MetroMessageBox.Show(this.MdiParent, "¿Desea rechazar el documento seleccionado?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resDel == DialogResult.Yes)
            {
                //SAVE
                try
                {
                    string res = srv.UpdateOne(one, 3);
                    if (res.Length > 1)
                    {
                        MetroFramework.MetroMessageBox.Show(this.MdiParent, "Operación rechazada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //SAVE
            try
            {
                one.id_cliente = _oneCliente.id;
                one.id_cotizacion = Globals.cotizacion[0].id_cotizacion;
                one.id_usuario = Globals.logUser.id;
                Console.WriteLine("SaveTipoOperacion: " + one.id_tipo_operacion);
                List<App.ColOperacionService.ColMovimiento> _listaDetalle = new List<App.ColOperacionService.ColMovimiento>();

                foreach (App.ColMovimientoService.ColMovimiento item in bList)
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

                string res = srv.SetOne(one, _listaDetalle);
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

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            frmVntClientesSelection fDialog = new frmVntClientesSelection();
            if (ConfigUI.LaunchDialogForm(fDialog) == DialogResult.OK)
            {
                AsignarCliente(fDialog.selectedCliente);
            }
        }
    }
}
