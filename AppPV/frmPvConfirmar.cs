using App.ColOperacionService;
using App.Common.Classes;
using App.SisUsuariosService;
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

namespace AppPV
{
    public partial class frmPvConfirmar : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES
        private SisUsuariosClient srvUsuarios = new SisUsuariosClient();
        private List<SisUsuarios> listaUsuarios = new List<SisUsuarios>();
        public SisUsuarios selectedUsuario = new SisUsuarios();

        private VntOperacion one = new VntOperacion();

        #endregion

        #region METODOS

        private void ConfigGrid()
        {
            for (int i = 0; i <= dgvList.Columns.Count - 1; i++)
            {
                dgvList.Columns[i].Visible = false;
                //Console.WriteLine(i.ToString() + " - " + dgvList.Columns[i].HeaderText);
            }

            dgvList.Columns[0].DisplayIndex = 7;
            dgvList.Columns[17].DisplayIndex = 0;
            dgvList.Columns[18].DisplayIndex = 1;
            dgvList.Columns[19].DisplayIndex = 2;
            dgvList.Columns[16].DisplayIndex = 3;


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
            dgvList.Columns[13].ReadOnly = true;
            //dgvList.Columns[0].Width = 90;

            dgvList.Columns[13].HeaderText = "MONTO";
            dgvList.Columns[13].Visible = true;
            dgvList.Columns[13].DefaultCellStyle.FormatProvider = Globals.nfiVE;
            dgvList.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvList.Columns[13].DefaultCellStyle.Format = "N2";
            //dgvList.Columns[13].Width = 134;
            dgvList.Columns[13].ReadOnly = true;

        }
        private void SelKey(Keys tecla)
        {
            switch (tecla)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                
                case Keys.F9:
                    this.DialogResult = DialogResult.OK;
                    break;
            }
        }

        #endregion
        public frmPvConfirmar()
        {
            InitializeComponent();
        }

        public frmPvConfirmar(VntOperacion _one, BindingList<App.InvMovimientoService.InvMovimiento> bListDetalle)
        {
            //factor = Globals.valorCotizacion;

            //_padre = padre;
            //idTipoOperacion = _one.id_tipo_operacion;


            InitializeComponent();

            cmbUsuarios.DataSource = Globals.listaUsuarios;
            cmbUsuarios.DisplayMember = "numero";
            cmbUsuarios.ValueMember = "id";

            lblClienteNombre.Text = _one.cliente_nombre;
            lblClienteRif.Text = _one.cliente_rif;
            txtTotalDocumento.Text = (_one.total_moneda).ToString("N2", Globals.nfiVE);

            dgvList.DataSource = bListDetalle;

            /*this.KeyPreview = true;
            this.KeyDown +=
                new KeyEventHandler(frmPvConfirmar_KeyDown);*/
        }

        #region EVENTOS


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSel_Click(object sender, EventArgs e)
        {
            selectedUsuario = (SisUsuarios)cmbUsuarios.SelectedItem;
            this.DialogResult = DialogResult.OK;
        }


        #endregion

        private void frmPvConfirmar_Load(object sender, EventArgs e)
        {
            ConfigGrid();
        }
    }
}
