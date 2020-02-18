using App.Common.Classes;
using App.Core.Caja;
using App.VntClienteService;
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

namespace App.Core.Ventas
{
    public partial class frmVntClientesDeudas : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES
        private VntOperacionClient srv = new VntOperacionClient();

        private List<VntOperacion> _listaDocumentos = new List<VntOperacion>();
        private List<CajMovimientoService.CajMovimiento> _listaInstrumentos = new List<CajMovimientoService.CajMovimiento>();

        private VntOperacion one { get; set; }

        private string _idCliente="";
        double factor = 0;
        #endregion

        #region METODOS
        private void ConfigGrid()
        {
            for (int i = 0; i <= dgvList.Columns.Count - 1; i++)
            {
                dgvList.Columns[i].Visible = false;
                Console.WriteLine(i.ToString() + " - " + dgvList.Columns[i].HeaderText);
            }

            dgvList.Columns[12].DisplayIndex = 0;
            dgvList.Columns[47].DisplayIndex = 1;
            dgvList.Columns[35].DisplayIndex = 2;
            dgvList.Columns[49].DisplayIndex = 3;
            dgvList.Columns[10].DisplayIndex = 3;

            dgvList.Columns[12].HeaderText = "FECHA";
            dgvList.Columns[12].Visible = true;
            dgvList.Columns[12].DefaultCellStyle.Format = "dd/MM/yy";

            dgvList.Columns[47].HeaderText = "OPERACIÓN";
            dgvList.Columns[47].Visible = true;
            dgvList.Columns[47].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvList.Columns[35].HeaderText = "Nº CONTROL";
            dgvList.Columns[35].Visible = true;

            dgvList.Columns[49].HeaderText = "MONTO";
            dgvList.Columns[49].Visible = true;
            dgvList.Columns[49].DefaultCellStyle.FormatProvider = Globals.nfiVE;
            dgvList.Columns[49].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvList.Columns[49].DefaultCellStyle.Format = "N2";

            dgvList.Columns[11].HeaderText = "DEUDA";
            dgvList.Columns[11].Visible = true;
            dgvList.Columns[11].DefaultCellStyle.FormatProvider = Globals.nfiVE;
            dgvList.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvList.Columns[11].DefaultCellStyle.Format = "N2";

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
        private void GetList(string idCliente)
        {
            _listaDocumentos = srv.GetDeudasCliente(idCliente);
            dgvList.DataSource = _listaDocumentos;
            MultiplicarMoneda();
        }
        private void MultiplicarMoneda()
        {
            double totalDocumentos = 0;
            double totalDeudas = 0;
            foreach (VntOperacion item in _listaDocumentos)
            {
                item.total_moneda = item.total * factor;
                item.abono_moneda = item.abono * factor;
                item.deuda_moneda = item.deuda * factor;

                totalDocumentos += item.total_moneda;
                totalDeudas += item.deuda_moneda;

                Console.WriteLine("totalDocumentos: " + totalDocumentos.ToString());
                Console.WriteLine("totalDeudas: " + totalDeudas.ToString());


            }
            txtTotalDocumentos.Text = totalDocumentos.ToString("N2", Globals.nfiVE);
            txtTotalDeudas.Text = totalDeudas.ToString("N2", Globals.nfiVE);
            dgvList.Refresh();
        }
        #endregion

        //CONSTRUCTORES
        public frmVntClientesDeudas()
        {
            InitializeComponent();
        }

        public frmVntClientesDeudas(VntCliente _oneCliente)
        {
            InitializeComponent();
            Globals.ConfigurarComboMonedas(cmbCotizacion);

            lblClienteNombre.Text = _oneCliente.nombre;
            lblClienteRif.Text = _oneCliente.rif;
            _idCliente = _oneCliente.id;

            GetList(_idCliente);
            ConfigGrid();

        }

        #region EVENTOS
        private void btnAbonos_Click(object sender, EventArgs e)
        {
            VntOperacion _one = new VntOperacion();
            _one = srv.GetOne(Globals.logEmpresa.id, one.id_tipo_operacion, one.id);

            frmVntClientesAbonos fDetalle = new frmVntClientesAbonos(_one);
            ConfigUI.LaunchDialogForm(fDetalle);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            btnPagar.Enabled = false;

            VntOperacion _one = srv.GetOne(Globals.logEmpresa.id, one.id_tipo_operacion, one.id);

            frmCajMovimientoSelection fDialog = new frmCajMovimientoSelection(one.deuda, _listaInstrumentos, "abonos");
            if (ConfigUI.LaunchDialogForm(fDialog) == DialogResult.OK)
            {
                _listaInstrumentos = fDialog.instrumentosSeleccionados;
                List<CajMovimiento> _pago = ConvertirPago(_listaInstrumentos);

                try
                {
                    srv.SetAbono(_one, _pago);

                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Pago realizado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetList(_idCliente);
                    MultiplicarMoneda();
                }
                catch (Exception)
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Se produjeron errores intentando procesar el registro, por favor revise los valores e intente nuevamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnPagar.Enabled = true;
                }


            }
        }
        private void cmbCotizacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            factor = Globals.cotizacion[cmbCotizacion.SelectedIndex].valor;
            MultiplicarMoneda();
        }
        private void dgvList_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            if (dgvList.SelectedRows.Count != 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvList.SelectedRows[0];
                    one = (VntOperacion)row.DataBoundItem;

                    if (one.deuda!=one.total) btnAbonos.Visible = true;

                    if (one.deuda_moneda > 0) btnPagar.Visible = true;
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                btnPagar.Visible = false;
                btnAbonos.Visible = false;
            }
        }
        #endregion
    }
}
