using App.Common.Classes;
using App.Common.Reports;
using App.Common.Reports.Inventario;
using App.InvProductoService;
using App.RepInventarioService;
using App.SisEmpresaService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Core.Reportes
{
    public partial class frmRepInventario : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES
        
        private InvProductoClient srvInvProducto = new InvProductoClient();
        private RepInventarioClient srvRepInventario = new RepInventarioClient();
        private List<RepInventario> listaMov = new List<RepInventario>();
        List<InvProducto> lista = new List<InvProducto>();
        private InvProducto one = new InvProducto();

        SisEmpresa miEmpresa = new SisEmpresa();
        double factor = 0;
        #endregion

        #region METODOS
        private void CargarListas()
        {
            lista = srvInvProducto.GetList(Globals.logEmpresa.id);
            filtrar(txtFiltro.Text);
            dgvList.Refresh();
        }

        private string crearFecha(DateTime _fecha )
        {
            DateTime fec = new DateTime(_fecha.Year, _fecha.Month, _fecha.Day, _fecha.Hour, _fecha.Minute, _fecha.Second);
            string miFecha = _fecha.Year.ToString() + "/" + _fecha.Month.ToString() +"/" +_fecha.Day.ToString();
            string miHora = _fecha.Hour.ToString() + ":" + _fecha.Minute.ToString() +":" +_fecha.Second.ToString();
            string fecha = miFecha + " " + miHora;
            //fec = DateTime.Now.ToString("yyyyMMdd hhMMss");
            fecha=fec.ToString("yy/M/d HH:mm:ss");

            return fecha;
        }

        private void ConfigGrid()
        {
            for (int i = 0; i <= dgvList.Columns.Count - 1; i++)
            {
                dgvList.Columns[i].Visible = false;
                //Console.WriteLine(i.ToString() + dgvList.Columns[i].HeaderText);
            }

            dgvList.Columns[4].DisplayIndex = 7;
            dgvList.Columns[12].DisplayIndex = 2;
            dgvList.Columns[18].DisplayIndex = 3;
            dgvList.Columns[17].DisplayIndex = 4;


            dgvList.Columns[0].HeaderText = "CATEGORIA";
            dgvList.Columns[0].Visible = true;

            dgvList.Columns[1].HeaderText = "CODIGO";
            dgvList.Columns[1].Visible = true;

            dgvList.Columns[12].HeaderText = "NOMBRE";
            dgvList.Columns[12].Visible = true;
            dgvList.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvList.Columns[18].HeaderText = "UNIDAD";
            dgvList.Columns[18].Visible = true;
        }

        private void filtrar(string filtro)
        {
            Console.WriteLine(filtro);
            dgvList.DataSource = lista.FindAll(o =>
                String.Join("", typeof(InvProducto).GetProperties().Select(f => f.GetValue(o))).ToLower().Contains(filtro.ToLower())).ToList();
        }
        private void SeleccionarReporte()
        {
            CrystalDecisions.Windows.Forms.CrystalReportViewer crView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();

            foreach (InvProducto item in lista)
            {
                item.costo_moneda = item.costo * factor;
                item.precio_moneda = item.precio * factor;
            }

            switch (cmbReporte.SelectedIndex)
            {
                case 0: //Listado de Productos"
                    crInvListadoExistencias repListaExistencias = new crInvListadoExistencias();
                    repListaExistencias.SetDataSource(lista);
                    repListaExistencias.SetParameterValue("empresaNombre", miEmpresa.nombre);
                    repListaExistencias.SetParameterValue("empresaRif", miEmpresa.rif);
                    crView.ReportSource = repListaExistencias;

                    break;

                case 1: //"Listado de Precios"
                    crInvListadoPrecios repListaPrecios = new crInvListadoPrecios();
                    repListaPrecios.SetDataSource(lista);
                    repListaPrecios.SetParameterValue("empresaNombre", miEmpresa.nombre);
                    repListaPrecios.SetParameterValue("empresaRif", miEmpresa.rif);
                    repListaPrecios.SetParameterValue("titulo", "LISTADO DE PRECIOS ("+ cmbCotizacion.Text + ")");
                    crView.ReportSource = repListaPrecios;

                    break;
                case 2: //"Resumen Movimientos"
                    listaMov = srvRepInventario.GetResumenMovimientos(miEmpresa.id, "", crearFecha(dtDesde.Value), crearFecha(dtHasta.Value));
                    crInvResumenMovimientos repResumenMovimientos = new crInvResumenMovimientos();
                    repResumenMovimientos.SetDataSource(listaMov);
                    repResumenMovimientos.SetParameterValue("empresaNombre", miEmpresa.nombre);
                    repResumenMovimientos.SetParameterValue("empresaRif", miEmpresa.rif);
                    repResumenMovimientos.SetParameterValue("intervaloFecha", dtDesde.Value.ToString("dd/MM/yyyy")  + " - "+ dtHasta.Value.ToString("dd/MM/yyyy"));
                    crView.ReportSource = repResumenMovimientos;

                    break;
                case 3: //Movimiento Detallado
                    listaMov = srvRepInventario.GetDetalleMovimientos(miEmpresa.id, one.id, crearFecha(dtDesde.Value), crearFecha(dtHasta.Value));
                    crInvMovimientosDetalle repDetalleMovimientos = new crInvMovimientosDetalle();
                    repDetalleMovimientos.SetDataSource(listaMov);
                    repDetalleMovimientos.SetParameterValue("empresaNombre", miEmpresa.nombre);
                    repDetalleMovimientos.SetParameterValue("empresaRif", miEmpresa.rif);
                    repDetalleMovimientos.SetParameterValue("intervaloFecha", dtDesde.Value.ToString("dd/MM/yyyy") + " - " + dtHasta.Value.ToString("dd/MM/yyyy"));
                    crView.ReportSource = repDetalleMovimientos;

                    break;
                case 4: //Inventario Monetario
                    crInvListadoMonetario repListaMonetario = new crInvListadoMonetario();
                    repListaMonetario.SetDataSource(lista);
                    repListaMonetario.SetParameterValue("empresaNombre", miEmpresa.nombre);
                    repListaMonetario.SetParameterValue("empresaRif", miEmpresa.rif);
                    repListaMonetario.SetParameterValue("titulo", "INVENTARIO MONETARIO (" + cmbCotizacion.Text + ")");
                    crView.ReportSource = repListaMonetario;

                    break;
            }

            Form f = new frmReportViewer(crView);
            ConfigUI.LaunchChildForm(f, Globals.appParentWindow);
        }


        #endregion

        public frmRepInventario()
        {
            InitializeComponent();
            miEmpresa = Globals.logEmpresa;
            Globals.ConfigurarComboMonedas(cmbCotizacion);
            dtDesde.Value=dtDesde.Value.AddMonths(-1);

            CargarListas();
            ConfigGrid();

            cmbReporte.SelectedIndex = 0;

        }

        #region EVENTOS
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvList.Visible = false;
            txtFiltro.Visible = false;
            switch (cmbReporte.SelectedIndex)
            {
                case 3: //Listado de Productos"
                    dgvList.Visible = true;
                    txtFiltro.Visible = true;
                    break;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SeleccionarReporte();
        }

        private void cmbCotizacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            factor = Globals.cotizacion[cmbCotizacion.SelectedIndex].valor;
        }

        private void dgvList_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            if (dgvList.SelectedRows.Count != 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvList.SelectedRows[0];
                    one = (InvProducto)row.DataBoundItem;
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                btnPrint.Visible = true;
            }
            else
            {
                btnPrint.Visible = false;
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            filtrar(txtFiltro.Text);
        }
        #endregion


    }
}
