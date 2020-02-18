using App.CajMovimientoService;
using App.Common.Classes;
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
    public partial class frmVntClientesAbonos : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES
        private List<CajMovimiento> lista = new List<CajMovimiento>();
        private CajMovimientoClient srv = new CajMovimientoClient();
        #endregion

        #region METODOS

        private void ConfigGrid()
        {
            Console.WriteLine("ABONOS");
            for (int i = 0; i <= dgvList.Columns.Count - 1; i++)
            {
                dgvList.Columns[i].Visible = false;
                Console.WriteLine(i.ToString() + " - " + dgvList.Columns[i].HeaderText);
            }

            
            dgvList.Columns[4].DisplayIndex = 0;
            dgvList.Columns[13].DisplayIndex = 1;
            dgvList.Columns[2].DisplayIndex = 2;
            dgvList.Columns[19].DisplayIndex = 3;
            dgvList.Columns[15].DisplayIndex = 4;
            dgvList.Columns[3].DisplayIndex = 5;
            dgvList.Columns[18].DisplayIndex = 6;

            dgvList.Columns[4].HeaderText = "FECHA";
            dgvList.Columns[4].Visible = true;
            dgvList.Columns[4].DefaultCellStyle.Format = "dd/MM/yy";

            dgvList.Columns[13].HeaderText = "INSTRUMENTO";
            dgvList.Columns[13].Visible = true;
            dgvList.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvList.Columns[2].HeaderText = "Nº CUENTA";
            dgvList.Columns[2].Visible = true;
            dgvList.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvList.Columns[19].HeaderText = "Nº REFERENCIA";
            dgvList.Columns[19].Visible = true;
            dgvList.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvList.Columns[15].HeaderText = "MONEDA";
            dgvList.Columns[15].Visible = true;

            dgvList.Columns[3].HeaderText = "TASA";
            dgvList.Columns[3].Visible = true;
            dgvList.Columns[3].DefaultCellStyle.FormatProvider = Globals.nfiVE;
            dgvList.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvList.Columns[3].DefaultCellStyle.Format = "N2";

            dgvList.Columns[18].HeaderText = "MONTO";
            dgvList.Columns[18].Visible = true;
            dgvList.Columns[18].DefaultCellStyle.FormatProvider = Globals.nfiVE;
            dgvList.Columns[18].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvList.Columns[18].DefaultCellStyle.Format = "N2";

        }


        #endregion
        public frmVntClientesAbonos()
        {
            InitializeComponent();
        }

        public frmVntClientesAbonos(VntOperacionService.VntOperacion _one)
        {
            InitializeComponent();
            lblOperacionNombre.Text = _one.tipo_documento_nombre;
            lblOperacionNroControl.Text = _one.nro_control;

            lista = srv.GetList(_one.id);
            if (lista.Count > 0)
            {
                CajMovimiento obj = lista.Find(x => x.id_instrumento.Contains("11E93E7A9E776D889B0D00E04C6F7E24"));
                if (obj != null) lista.Remove(obj);
            }

            double totalAbonos = 0;
            foreach (CajMovimiento item in lista)
            {
                item.monto_moneda = item.monto * item.factor;
                totalAbonos+= item.monto;


            }

            dgvList.DataSource = lista;
        }

        #region EVENTOS
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void frmVntClientesAbonos_Load(object sender, EventArgs e)
        {
            ConfigGrid();
        }
    }

}
