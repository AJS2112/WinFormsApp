using App.CmpOperacionService;
using App.CmpProveedorService;
using App.Common.Classes;
using App.Common.Reports;
using App.Common.Reports.Operaciones;
using App.Core.Inventario;
using App.InvMovimientoService;
using App.InvProductoService;
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

namespace App.Core.Compras
{
    public partial class frmCmpOperacionesDetail : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES
        //SERVICIOS
        private CmpOperacionClient srvCompra = new CmpOperacionClient();
        private SisListasClient srvListas = new SisListasClient();
        private SisOperacionClient srvOperacion = new SisOperacionClient();
        private InvMovimientoClient srvMovimiento = new InvMovimientoClient();
        private CmpProveedorClient srvProveedor = new CmpProveedorClient();

        //LISTAS
        private List<SisListas> _listaTipoDocumentos = new List<SisListas>();
        private List<InvMovimientoService.InvMovimiento> _listaDetalle = new List<InvMovimientoService.InvMovimiento>();

        //OBJETOS
        private SisOperacion _tipoOperacion = new SisOperacion();
        private CmpProveedor _oneProveedor { get; set; }
        private InvMovimientoService.InvMovimiento _movimiento { get; set; }
        private InvProducto _productoSeleccionado { get; set; }
        private CmpOperacion one { get; set; }

        //BINDINGS
        BindingSource bs = new BindingSource();
        BindingList<InvMovimientoService.InvMovimiento> bList;


        double factor = 1;

        #endregion

        #region METODOS
        private void AsignarProveedor(CmpProveedor _proveedor)
        {
            _oneProveedor= _proveedor;
            lblProveedorNombre.DataBindings.Add("Text", _oneProveedor, "nombre", true, DataSourceUpdateMode.OnPropertyChanged);
            lblProveedorRif.DataBindings.Add("Text", _oneProveedor, "rif", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void CargarListas()
        {
            _listaTipoDocumentos = srvListas.GetListByCampo("tipo_documento");
            cmbTipoDocumento.DataSource = _listaTipoDocumentos;
            cmbTipoDocumento.DisplayMember = "nombre";
            cmbTipoDocumento.ValueMember = "id";
        }
        private void CrearBindings()
        {
            dtFecha.DataBindings.Add("Value", one, "fecha_documento", true, DataSourceUpdateMode.OnPropertyChanged);
            txtNroDocumento.DataBindings.Add("Text", one, "nro_documento", true, DataSourceUpdateMode.OnPropertyChanged);
            txtNroControl.DataBindings.Add("Text", one, "nro_control_documento", true, DataSourceUpdateMode.OnPropertyChanged);
            txtNroFacturaAfectada.DataBindings.Add("Text", one, "nro_factura_afectada", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void ConfigGrid()
        {
            for (int i = 0; i <= dgvList.Columns.Count - 1; i++)
            {
                dgvList.Columns[i].Visible = false;
                //Console.WriteLine(i.ToString() + " - " +dgvList.Columns[i].HeaderText);
            }

            dgvList.Columns[0].DisplayIndex = 7;
            dgvList.Columns[17].DisplayIndex = 0;
            dgvList.Columns[18].DisplayIndex = 1;
            dgvList.Columns[19].DisplayIndex = 2;
            dgvList.Columns[2].DisplayIndex = 3;
 
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

            dgvList.Columns[2].HeaderText = "COSTO";
            dgvList.Columns[2].Visible = true;
            dgvList.Columns[2].DefaultCellStyle.FormatProvider = Globals.nfiVE;
            dgvList.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvList.Columns[2].DefaultCellStyle.Format = "N2";
            //dgvList.Columns[2].Width = 90;

            dgvList.Columns[0].HeaderText = "CANTIDAD";
            dgvList.Columns[0].Visible = true;
            dgvList.Columns[0].DefaultCellStyle.FormatProvider = Globals.nfiVE;
            dgvList.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvList.Columns[0].DefaultCellStyle.Format = "N2";
            //dgvList.Columns[0].Width = 90;

            dgvList.Columns[13].HeaderText = "MONTO Bs";
            dgvList.Columns[13].Visible = true;
            dgvList.Columns[13].DefaultCellStyle.FormatProvider = Globals.nfiVE;
            dgvList.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvList.Columns[13].DefaultCellStyle.Format = "N2";
            //dgvList.Columns[13].Width = 134;
            dgvList.Columns[13].ReadOnly = true;

        }

        private List<CmpOperacionService.InvMovimiento> ConvertirDetalle(BindingList<InvMovimientoService.InvMovimiento> listaBinding)
        {
            List<CmpOperacionService.InvMovimiento> _listaDetalle = new List<CmpOperacionService.InvMovimiento>();

            foreach (InvMovimientoService.InvMovimiento item in listaBinding)
            {
                CmpOperacionService.InvMovimiento mov = new CmpOperacionService.InvMovimiento();
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

                _listaDetalle.Add(mov);
            }

            return _listaDetalle;
        }

        private void ImprimirOperacion()
        {
            CrystalDecisions.Windows.Forms.CrystalReportViewer crView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            crCmpOperacion repOperacion = new crCmpOperacion();
            repOperacion.SetDataSource(_listaDetalle);
            repOperacion.SetParameterValue("empresaNombre", Globals.logEmpresa.nombre);
            repOperacion.SetParameterValue("empresaRif", Globals.logEmpresa.rif);
            repOperacion.SetParameterValue("titulo", lblTitle.Text);
            repOperacion.SetParameterValue("nroControl", one.nro_control);
            repOperacion.SetParameterValue("fecha", one.fecha);
            repOperacion.SetParameterValue("proveedorNombre", _oneProveedor.nombre);
            repOperacion.SetParameterValue("proveedorRif", _oneProveedor.rif);
            crView.ReportSource = repOperacion;

            Form f = new Reportes.frmReportViewer(crView);
            ConfigUI.LaunchChildForm(f, Globals.appParentWindow);
        }

        private void LockButons()
        {
            btnPrint.Visible = false;
            btnNullify.Visible = false;
            btnSave.Enabled = false;
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
                one.total_moneda += item.monto_moneda;
                one.total += item.monto;

                switch (item.id_impuesto)
                {
                    case "11E8F23EDF0D15388FF600270E383B06": //EXENTO
                        one.monto_exento +=item.monto;
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

            }


            lblItems.Text = "(" + items.ToString()+ ")";
            lblTotal.Text = "Total: " + one.total_moneda.ToString("N2", Globals.nfiVE);

            Console.WriteLine("Total: "+one.total.ToString());
        }

        private void ValidarBotones()
        {
            btnPrint.Visible = false;
            btnNullify.Visible = false;
            btnSave.Enabled = false;

            if (_oneProveedor == null) return;
            if (bList.Count == 0) return;
            btnSave.Enabled = true;

            if (one.id == "0") return;
            btnPrint.Visible = true;
            btnNullify.Visible = true;

        }
        #endregion

        // CONSTRUCTORES //
        public frmCmpOperacionesDetail()
        {
            InitializeComponent();
        }

        public frmCmpOperacionesDetail(CmpOperacion _one)
        {
            InitializeComponent();
            //ONE
            if (_one == null) return;
            one = _one;
            CrearBindings();
            _tipoOperacion = srvOperacion.GetOne(one.id_tipo_operacion);
            if (_tipoOperacion == null) return;
            lblTitle.Text = _tipoOperacion.nombre;
            lblSubTitle.Text = one.nro_control;
            CargarListas();
            Globals.ConfigurarComboMonedas(cmbCotizacion);

            CmpProveedor proveedor = srvProveedor.GetOne(Globals.logEmpresa.id, one.id_proveedor);
            if (proveedor != null) AsignarProveedor(proveedor);

            //DETALLE
            _listaDetalle = srvMovimiento.GetList(one.id);
            bList = new BindingList<InvMovimientoService.InvMovimiento>(_listaDetalle);

            bs.DataSource = bList;
            dgvList.DataSource = bs;
            ConfigGrid();
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
                _movimiento.monto = _productoSeleccionado.costo;
                _movimiento.monto_impuesto = 0;
                _movimiento.monto_impuesto_moneda = 0;
                _movimiento.monto_moneda = _productoSeleccionado.costo_moneda;
                _movimiento.order_id = 0;
                _movimiento.precio = _productoSeleccionado.precio;
                _movimiento.precio_moneda = _productoSeleccionado.precio_moneda;
                _movimiento.producto_codigo = _productoSeleccionado.codigo;
                _movimiento.producto_nombre = _productoSeleccionado.nombre;
                _movimiento.producto_unidad = _productoSeleccionado.unidad_nombre;
                _movimiento.valor_impuesto = _productoSeleccionado.impuesto_valor;
                bList.Add(_movimiento);
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
            if (bList.Count > 0)
            {
                //ASIGNACIONES
                one.id_usuario = Globals.logUser.id;


                List<CmpOperacionService.InvMovimiento> _detail = ConvertirDetalle(bList);
                string res = srvCompra.NullOne(one, _detail);
                if (res.Length > 1)
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Registro anulado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "No se anuló el registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            ImprimirOperacion();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (bList.Count > 0)
            {
                LockButons();

                //ASIGNACIONES
                one.id_proveedor = _oneProveedor.id;
                one.id_tipo_documento = cmbTipoDocumento.SelectedValue.ToString();
                one.id_cotizacion = cmbCotizacion.SelectedValue.ToString();
                one.id_usuario = Globals.logUser.id;

                List<CmpOperacionService.InvMovimiento> _detail = ConvertirDetalle(bList);

                try
                {
                    string res = srvCompra.SetOne(one, _detail);
                    if (res.Length > 1)
                    {
                        ImprimirOperacion();
                        MetroFramework.MetroMessageBox.Show(this.MdiParent, "Registro guardado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this.MdiParent, "No se guardó el registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ValidarBotones();
                    }
                }
                catch (Exception)
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Se produjeron errores intentando procesar la operación, por favor revise los valores e intente nuevamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ValidarBotones();
                }


            }

        }
        private void btnSeleccionarProveedor_Click(object sender, EventArgs e)
        {
            frmCmpProvedoresSelection fDialog = new frmCmpProvedoresSelection();
            if (ConfigUI.LaunchDialogForm(fDialog) == DialogResult.OK)
            {
                AsignarProveedor(fDialog.selectedProveedor);
                ValidarBotones();
            }
        }
        
        // COMBOS
        private void cmbTipoDocumento_SelectedValueChanged(object sender, EventArgs e)
        {
            lblTipoDocumento.Visible = false;
            cmbTipoDocumento.Visible = false;

            lblNroDocumento.Visible = false;
            txtNroDocumento.Visible = false;

            lblNroControl.Visible = false;
            txtNroControl.Visible = false;

            lblNroFacturaAfectada.Visible = false;
            txtNroFacturaAfectada.Visible = false;

            if (_tipoOperacion.signo_inventario != "N")
            {
                lblTipoDocumento.Visible = true;
                cmbTipoDocumento.Visible = true;

                lblNroDocumento.Visible = true;
                txtNroDocumento.Visible = true;

                lblNroControl.Visible = true;
                txtNroControl.Visible = true;

                if (cmbTipoDocumento.SelectedValue.ToString() != "11E88BE7AA7287129A1500270E383B06")
                {
                    lblNroFacturaAfectada.Visible = true;
                    txtNroFacturaAfectada.Visible = true;
                }
            }
        }
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
            InvMovimientoService.InvMovimiento obj = (InvMovimientoService.InvMovimiento)dgvList.CurrentRow.DataBoundItem;

            obj.monto_moneda = obj.costo_moneda * obj.cantidad;
            obj.costo = obj.costo_moneda / factor;
            obj.monto = obj.costo * obj.cantidad;

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


    }
}
