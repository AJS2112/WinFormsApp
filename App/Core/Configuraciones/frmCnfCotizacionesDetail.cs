using App.CnfCotizacionService;
using App.Common.Classes;
using App.SisListasService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Core.Configuraciones
{
    public partial class frmCnfCotizacionesDetail : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES
        //SERVICIOS
        private CnfCotizacionClient srv = new CnfCotizacionClient();
        private SisListasClient srvMoneda = new SisListasClient();

        //LISTAS
        private List<SisListas> _listaMonedas = new List<SisListas>();
        private List<CnfCotizacionDetalle> _listaDetalle = new List<CnfCotizacionDetalle>();

        //REGISTROS
        private CnfCotizacion one { get; set; }
        private SisListas _moneda = new SisListas();


        //BINDINGS
        BindingSource bs = new BindingSource();
        BindingList<CnfCotizacionDetalle> bList ;
        #endregion

        #region METODOS
        private void CrearBindings()
        {
            Console.WriteLine("Globals.logEmpresa.monedas: " + Globals.logEmpresa.monedas);
            _listaMonedas = srvMoneda.GetList(Globals.logEmpresa.monedas);
            if (_listaMonedas.Count > 0)
            {
                SisListas obj = _listaMonedas.Find(x => x.id.Contains("11E8F819279E29CC9E9100270E383B06"));
                if (obj!=null) _listaMonedas.Remove(obj);
            }

            cmbMonedas.DataSource = _listaMonedas;
            cmbMonedas.DisplayMember = "nombre";
            cmbMonedas.ValueMember = "id";

            lblSubTitle.Text = one.nro_control;
            txtFecha.Text = one.fecha.ToString();
        }

        private void ConfigGrid()
        {
            for (int i = 0; i <= dgvList.Columns.Count - 1; i++)
            {
                dgvList.Columns[i].Visible = false;
                //Console.WriteLine(i.ToString() + " - " + dgvList.Columns[i].HeaderText);
            }

            dgvList.Columns[5].DisplayIndex = 4;
            dgvList.Columns[8].DisplayIndex = 7;

            dgvList.Columns[5].HeaderText = "MONEDA";
            dgvList.Columns[5].Visible = true;

            dgvList.Columns[4].HeaderText = "DESCRIPCION";
            dgvList.Columns[4].Visible = true;

            /*dgvList.Columns[9].HeaderText = "VALOR ANTERIOR";
            dgvList.Columns[9].Visible = true;
            dgvList.Columns[9].DefaultCellStyle.FormatProvider = Globals.nfiVE;
            dgvList.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvList.Columns[9].DefaultCellStyle.Format = "N2";*/

            dgvList.Columns[7].HeaderText = "VALOR";
            dgvList.Columns[7].Visible = true;
            dgvList.Columns[7].DefaultCellStyle.FormatProvider = Globals.nfiVE;
            dgvList.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvList.Columns[7].DefaultCellStyle.Format = "N2";

        }
        #endregion

        public frmCnfCotizacionesDetail()
        {
            InitializeComponent();
        }

        public frmCnfCotizacionesDetail(CnfCotizacion obj)
        {
            InitializeComponent();
            one = obj;
            //lblTitle.Text = obj.nombre;
            CrearBindings();

            //DETALLE
            _listaDetalle = srv.GetListDetail(one.id);
            bList = new BindingList<CnfCotizacionDetalle>(_listaDetalle);

            bs.DataSource = bList;
            dgvList.DataSource = bs;
            ConfigGrid();

            if (bList.Count>0)
            {
                btnAdd.Visible = false;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            try
            {
                _listaDetalle = bList.ToList();

                string _id = srv.SetOne(one, _listaDetalle);
                if (_id.Length > 0)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "No se guardó el registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnSave.Enabled = true;

                }

            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Se produjeron errores intentando procesar el registro, por favor revise los valores e intente nuevamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSave.Enabled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            CnfCotizacionDetalle obj = bList.SingleOrDefault(p => p.id_moneda == _moneda.id);
            if (obj == null)
            {
                bList.Insert(0, new CnfCotizacionDetalle
                {
                    id = "0",
                    id_cotizacion = one.id,
                    id_moneda = _moneda.id,
                    last_update = 0,
                    moneda_descrip = _moneda.descrip,
                    moneda_nombre = _moneda.nombre,
                    order_id = 0,
                    valor = Convert.ToDouble(txtValorActual.Text),
                    valor_anterior = 0
                });
            } else
            {
                MessageBox.Show("La moneda seleccionada ya se encuentra en la lista");
            }
            
            txtValorActual.Text = "0,00";

            bntDel.Visible = false;
            btnSave.Visible = false;
            if (bList.Count > 0) {
                bntDel.Visible = true;
                btnSave.Visible = true;
            } 

        }

        private void cmbMonedas_SelectedValueChanged(object sender, EventArgs e)
        {
            _moneda = (SisListas)cmbMonedas.SelectedItem;
        }

        private void bntDel_Click(object sender, EventArgs e)
        {
            if (dgvList.RowCount > 0)
            {
                string item = dgvList[dgvList.CurrentCell.ColumnIndex, dgvList.CurrentCell.RowIndex].Value.ToString();
                if (item != null && dgvList.CurrentCell.ColumnIndex != 0)
                {
                    CnfCotizacionDetalle obj = (CnfCotizacionDetalle)dgvList.CurrentRow.DataBoundItem;
                    bList.Remove(obj);
                    //lblTotal.Text = Totalizar().ToString("N2", Globals.nfiVE);
                }
            }

            btnSave.Visible = false;
            bntDel.Visible = false;
            if (bList.Count > 0)
            {
                bntDel.Visible = true;
                btnSave.Visible = true;
            }
        }
    }
}
