using App.CnfCotizacionService;
using App.Common.Classes;
using App.RepDashboardService;
using App.SisEmpresaService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using TfhkaNet.IF.VE;

namespace App.Common.Forms
{
    public partial class frmDashboard : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES
        private bool Respuesta;
        private string puertoCOM;

        //SERVICIOS

        SisEmpresaClient srvEmpresa = new SisEmpresaClient();
        CnfCotizacionClient srvCotizacion = new CnfCotizacionClient();
        RepDashboardClient srvDashboard = new RepDashboardClient();

        //LISTAS
        private List<CnfCotizacionDetalle> _listaCotizacion = new List<CnfCotizacionDetalle>();
        private List<RepDashboard> _listaDashboardCaja = new List<RepDashboard>();
        private List<RepDashboard> _listaDashboardGeneral = new List<RepDashboard>();

        private double factor = 1;
        #endregion

        #region METODOS

        private void CargarListas()
        {
            _listaCotizacion = srvCotizacion.GetLast(Globals.logEmpresa.id);
            dgvListCotizacion.DataSource = _listaCotizacion;

            string fecha = DateTime.Now.ToString("yy/M/d HH:mm:ss");
            _listaDashboardCaja = srvDashboard.GetResumenCaja(Globals.logEmpresa.id, PrimerDiaMes(DateTime.Now), fecha);
            dgvListCaja.DataSource = _listaDashboardCaja;

            _listaDashboardGeneral = srvDashboard.GetResumenGeneral(Globals.logEmpresa.id, PrimerDiaMes(DateTime.Now), fecha);

        }
        private void CheckImpresoraFiscal()
        {
            Globals.Impresora = new Tfhka();
            S3PrinterData impresoraS3;

            if (leerConfiguraciones())
            {
                //INICIALIZAR IMPRESORA
                Boolean puerto = Globals.Impresora.OpenFpCtrl(puertoCOM);
                if (puerto)
                {
                    Respuesta = Globals.Impresora.CheckFPrinter();
                    if (Respuesta == true)
                    {
                        lblStatusPrinter.ForeColor = Color.Green;
                        lblStatusPrinter.Text = "Impresora en línea";

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
                        lblStatusPrinter.ForeColor = Color.Red;
                        lblStatusPrinter.Text = "Impresora sin conexión";
                    }
                }
                else
                {
                    lblStatusPrinter.ForeColor = Color.Red;
                    lblStatusPrinter.Text = "No pudo abrir puerto";
                }
            }
            else
            {
                //MessageBox.Show("No se pudieron leer las configuraciones");

                lblStatusPrinter.ForeColor = Color.Red;
                lblStatusPrinter.Text = "No se pudieron leer las configuraciones";
            }
        }

        private void ConfigGrid()
        {
            for (int i = 0; i <= dgvListCotizacion.Columns.Count - 1; i++)
            {
                dgvListCotizacion.Columns[i].Visible = false;
                //Console.WriteLine(i.ToString() + " - " + dgvList.Columns[i].HeaderText);
            }

            dgvListCotizacion.Columns[5].DisplayIndex = 4;
            dgvListCotizacion.Columns[8].DisplayIndex = 7;

            dgvListCotizacion.Columns[5].HeaderText = "MONEDA";
            dgvListCotizacion.Columns[5].Visible = true;
            //dgvListCotizacion.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvListCotizacion.Columns[4].HeaderText = "DESCRIPCION";
            dgvListCotizacion.Columns[4].Visible = true;


            dgvListCotizacion.Columns[7].HeaderText = "VALOR";
            dgvListCotizacion.Columns[7].Visible = true;
            dgvListCotizacion.Columns[7].DefaultCellStyle.FormatProvider = Globals.nfiVE;
            dgvListCotizacion.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvListCotizacion.Columns[7].DefaultCellStyle.Format = "N2";


            for (int i = 0; i <= dgvListCaja.Columns.Count - 1; i++)
            {
                dgvListCaja.Columns[i].Visible = false;
                Console.WriteLine(i.ToString() + " - " + dgvListCaja.Columns[i].HeaderText);
            }
            dgvListCaja.Columns[3].DisplayIndex = 1;

            dgvListCaja.Columns[0].HeaderText = "";
            dgvListCaja.Columns[0].Visible = true;
            dgvListCaja.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;


            dgvListCaja.Columns[3].HeaderText = "INMSTRUMENTO";
            dgvListCaja.Columns[3].Visible = true;
            dgvListCaja.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvListCaja.Columns[2].HeaderText = "ENTRADA";
            dgvListCaja.Columns[2].Visible = true;
            dgvListCaja.Columns[2].DefaultCellStyle.FormatProvider = Globals.nfiVE;
            dgvListCaja.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvListCaja.Columns[2].DefaultCellStyle.Format = "N2";

            dgvListCaja.Columns[5].HeaderText = "SALIDA";
            dgvListCaja.Columns[5].Visible = true;
            dgvListCaja.Columns[5].DefaultCellStyle.FormatProvider = Globals.nfiVE;
            dgvListCaja.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvListCaja.Columns[5].DefaultCellStyle.Format = "N2";

            dgvListCaja.Columns[7].HeaderText = "TOTALES";
            dgvListCaja.Columns[7].Visible = true;
            dgvListCaja.Columns[7].DefaultCellStyle.FormatProvider = Globals.nfiVE;
            dgvListCaja.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvListCaja.Columns[7].DefaultCellStyle.Format = "N2";
        }

        private void ConfigurarResumen()
        {
            foreach(RepDashboard item in _listaDashboardGeneral)
            {
                switch (item.nombre)
                {
                    case "inventario":
                        //INVENTARIO
                        lblInventario.Text = "Inventario Neto";
                        lblInventarioMonto.Text = item.total_moneda.ToString("N2", Globals.nfiVE);
                        lblInventarioCantidad.Text = "Productos en Stock: " + item.cantidad.ToString();
                        break;
                    case "ventas":
                        //VENTAS
                        lblVentas.Text = "Ventas del Mes";
                        lblVentasMonto.Text = item.total_moneda.ToString("N2", Globals.nfiVE);
                        lblVentasCantidad.Text = "Ventas Emitidas: " + item.cantidad.ToString();
                        break;
                    case "compras":
                        //COMPRAS
                        lblCompras.Text = "Compras del Mes";
                        lblComprasMonto.Text = item.total_moneda.ToString("N2", Globals.nfiVE);
                        lblComprasCantidad.Text = "Compras Realizadas: " + item.cantidad.ToString();
                        break;
                }
            }

        }

        private string PrimerDiaMes(DateTime _fecha) {
            string miFecha = _fecha.Year.ToString() + "/" + _fecha.Month.ToString() + "/" + "1";
            string miHora = _fecha.Hour.ToString() + ":" + _fecha.Minute.ToString() + ":" + _fecha.Second.ToString();
            string _miFecha = miFecha + " " + miHora;
            return _miFecha;
        }
        Boolean leerConfiguraciones()
        {
            string directorio = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string archivo = "@"+directorio+@"\config.txt";
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

        #endregion


        public frmDashboard()
        {
            InitializeComponent();
            //CheckImpresoraFiscal();

            //EMPRESA
            Globals.logEmpresa = srvEmpresa.GetOne(Globals.logUser.id_empresa);

            Console.WriteLine("EMPRESA");
            string s = new JavaScriptSerializer().Serialize(Globals.logEmpresa);
            Console.WriteLine(s);

            string miMoneda = Globals.logEmpresa.moneda_defecto;
            if (Globals.logEmpresa.es_modo_fiscal)
            {
                miMoneda = "11E93A6F6D57549E838500E04C6F7E24";

                lblCotizacion.Visible = false;
                dgvListCotizacion.Visible = false;
            }

            string id_cotizacion = "";
            lblEmpresa.Text = Globals.logEmpresa.nombre;
            lblRIF.Text = Globals.logEmpresa.rif;
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            CargarListas();
            ConfigurarResumen();

            //COTIZACION
            //List<CnfCotizacionDetalle> cotizacion = srvCotizacion.GetLast(Globals.logEmpresa.id);
            Globals.cotizacion = _listaCotizacion;
            Globals.ConfigurarComboMonedas(cmbCotizacion);

            foreach(CnfCotizacionDetalle item in _listaCotizacion)
            {
                if (item.id_moneda == miMoneda)
                {
                    id_cotizacion = item.id;
                }
            }

            cmbCotizacion.SelectedValue = id_cotizacion;
        }

 
        
        private void cmbCotizacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Globals.selectedCotizacion = cmbCotizacion.SelectedIndex;
            Globals.logEmpresa.moneda_defecto = Globals.cotizacion[Globals.selectedCotizacion].id;
            factor = Globals.cotizacion[cmbCotizacion.SelectedIndex].valor;

            foreach (RepDashboard item in _listaDashboardCaja)
            {
                item.entrada_moneda = item.entrada * factor;
                item.salida_moneda = item.salida * factor;
                item.total_moneda = item.total * factor;
            }
            dgvListCaja.DataSource = _listaDashboardCaja;
            dgvListCaja.Refresh();

            foreach (RepDashboard item in _listaDashboardGeneral)
            {
                item.entrada_moneda = item.entrada * factor;
                item.salida_moneda = item.salida * factor;
                item.total_moneda = item.total * factor;
            }
            ConfigurarResumen();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            ConfigGrid();
        }
    }
}
