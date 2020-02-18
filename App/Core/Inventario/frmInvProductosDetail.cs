using App.Common.Classes;
using App.InvCategoriaService;
using App.InvProductoService;
using App.SisImpuestoService;
using App.SisListasService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Core.Inventario
{
    public partial class frmInvProductosDetail : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES
        private List<InvCategoria> _listaCategorias = new List<InvCategoria>();
        private List<SisListas> _listaUnidades = new List<SisListas>();
        private List<SisImpuesto> _listaImpuestos = new List<SisImpuesto>();

        private InvCategoriaClient srvCategoria = new InvCategoriaClient();
        private SisImpuestoClient srvImpuesto = new SisImpuestoClient();
        private SisListasClient srvListas = new SisListasClient();
        private InvProductoClient srv = new InvProductoClient();

        private InvProducto one = new InvProducto();

        double factor = 0;
        #endregion

        #region METODOS
        private void CalcularPrecio()
        {
            one.costo = (one.costo_moneda/ factor);
            one.precio = one.costo * ((one.pct_utilidad / 100) + 1);
            one.precio_moneda = one.precio * factor;
        }
        private void CalcularPctUtil()
        {
            one.costo = (one.costo_moneda / factor);
            one.precio= (one.precio_moneda / factor);
            one.pct_utilidad = ((one.precio - one.costo) / one.costo) * 100;
        }
        
        private void CargarListas()
        {
            Console.WriteLine("InvProductosDetail");
            Console.WriteLine("Globals.logEmpresa.monedas: "+Globals.logEmpresa.monedas);
            _listaCategorias = srvCategoria.GetList(Globals.logEmpresa.id);
            _listaCategorias.Insert(0, new InvCategoria { nombre = "PRINCIPAL", id = "00000000000000000000000000000000" });
            cmbCategoria.DataSource = _listaCategorias;
            cmbCategoria.DisplayMember = "nombre";
            cmbCategoria.ValueMember = "id";

            _listaUnidades = srvListas.GetListByCampo("unidades");
            cmbUnidad.DataSource = _listaUnidades;
            cmbUnidad.DisplayMember = "nombre";
            cmbUnidad.ValueMember = "id";

            _listaImpuestos = srvImpuesto.GetList("11E7A7016E303D9D9B0700270E383B06");
            cmbImpuesto.DataSource = _listaImpuestos;
            cmbImpuesto.DisplayMember = "valor";
            cmbImpuesto.ValueMember = "id";
        }
        private void CrearBindings()
        {
            cmbCategoria.DataBindings.Add("SelectedValue", one, "id_categoria", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbUnidad.DataBindings.Add("SelectedValue", one, "id_unidad", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbImpuesto.DataBindings.Add("SelectedValue", one, "id_impuesto", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbImpuesto.DataBindings.Add("Text", one, "impuesto_valor", true, DataSourceUpdateMode.OnPropertyChanged);

            txtNombre.DataBindings.Add("Text", one, "nombre", true, DataSourceUpdateMode.OnPropertyChanged);
            txtCodigo.DataBindings.Add("Text", one, "codigo", true, DataSourceUpdateMode.OnPropertyChanged);
            checkInactivo.DataBindings.Add("Checked", one, "es_inactivo", true, DataSourceUpdateMode.OnPropertyChanged);

            Globals.CreateNumberBinding(txtExistencia, one, "existencia");
            Globals.CreateNumberBinding(txtUtilidad, one, "pct_utilidad");
            Globals.CreateNumberBinding(txtCostoMoneda, one, "costo_moneda");
            Globals.CreateNumberBinding(txtPrecioMoneda, one, "precio_moneda");
            Globals.CreateNumberBinding(txtPctComision, one, "pct_comision");
        }
        #endregion

        //CONSTRUCTOR
        public frmInvProductosDetail()
        {
            InitializeComponent();
        }

        public frmInvProductosDetail(InvProducto obj)
        {
            InitializeComponent();
            CargarListas();
            one = obj;
            lblTitle.Text = obj.nombre;
            Globals.ConfigurarComboMonedas(cmbCotizacion);
            CrearBindings();
        }

        #region EVENTOS
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string _id = srv.SetOne(one);
            if (_id.Length > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "No se guardó el registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cmbCotizacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCotizacion.SelectedIndex > -1)
            {
                factor = Globals.cotizacion[cmbCotizacion.SelectedIndex].valor;
                one.costo_moneda = one.costo * factor;
                one.precio_moneda = one.precio * factor;
            }
        }

        private void cmbImpuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularPrecio();
        }

        // GENERAL KEYDOWN //
        private void General_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        // TEXT VALIDATED //
        private void txtCosto_Validated(object sender, EventArgs e)
        {
            CalcularPrecio();
        }
        private void txtCostoMoneda_Validated(object sender, EventArgs e)
        {
            CalcularPrecio();
        }
        private void txtUtilidad_Validated(object sender, EventArgs e)
        {
            CalcularPrecio();
        }
        private void txtPrecio_Validated(object sender, EventArgs e)
        {
            CalcularPctUtil();
        }
        private void txtPrecioMoneda_Validated(object sender, EventArgs e)
        {
            CalcularPctUtil();
        }


        #endregion
    }
}
