using App.Common.Classes;
using App.InvProductoService;
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

namespace AppPV
{
    public partial class frmInvProductoSelection : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES
        private InvProductoClient srv = new InvProductoClient();
        private List<InvProducto> lista = new List<InvProducto>();
        public InvProducto selectedProducto = new InvProducto();
        double factor = 1;
        #endregion

        #region METODOS
        private void GetList()
        {
            try
            {
                lista = srv.GetListPV(Globals.logEmpresa.id);
                foreach (InvProducto item in lista)
                {
                    item.costo_moneda = item.costo * factor;
                    item.precio_moneda = item.precio * factor;
                }
                filtrar(txtFiltro.Text);
                dgvList.Refresh();
            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, "Se produjeron errores al cargar la lista: "+ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void ConfigGrid()
        {
            for (int i = 0; i <= dgvList.Columns.Count - 1; i++)
            {
                dgvList.Columns[i].Visible = false;
                Console.WriteLine(i.ToString() + dgvList.Columns[i].HeaderText);
            }

            dgvList.Columns[2].DisplayIndex = 0;
            dgvList.Columns[8].DisplayIndex = 7;
            dgvList.Columns[17].DisplayIndex = 2;
            dgvList.Columns[24].DisplayIndex = 3;
            dgvList.Columns[23].DisplayIndex = 4;


            //dgvList.Columns[0].HeaderText = "CATEGORIA";
            //dgvList.Columns[0].Visible = true;

            dgvList.Columns[2].HeaderText = "CODIGO";
            dgvList.Columns[2].Visible = true;

            dgvList.Columns[17].HeaderText = "NOMBRE";
            dgvList.Columns[17].Visible = true;
            dgvList.Columns[17].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvList.Columns[24].HeaderText = "UNIDAD";
            dgvList.Columns[24].Visible = true;

            dgvList.Columns[23].HeaderText = "PRECIO";
            dgvList.Columns[23].Visible = true;
            dgvList.Columns[23].DefaultCellStyle.FormatProvider = Globals.nfiVE;
            dgvList.Columns[23].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvList.Columns[23].DefaultCellStyle.Format = "N2";


            dgvList.Columns[8].HeaderText = "EXISTENCIA";
            dgvList.Columns[8].Visible = true;
            dgvList.Columns[8].DefaultCellStyle.FormatProvider = Globals.nfiVE;
            dgvList.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvList.Columns[8].DefaultCellStyle.Format = "N2";
        }

        private void filtrar(string filtro)
        {
            dgvList.DataSource = lista.FindAll(o =>
                String.Join("", typeof(InvProducto).GetProperties().Select(f => f.GetValue(o))).ToLower().Contains(filtro.ToLower())).ToList();
            lblSubTitle.Text = dgvList.RowCount.ToString() + " registros";
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

        //CONSTRUCTOR
        public frmInvProductoSelection()
        {
            InitializeComponent();
            factor = Globals.valorCotizacion;
            GetList();
            this.KeyPreview = true;
            this.KeyDown +=
                new KeyEventHandler(frmInvProductoSelection_KeyDown);
        }

        #region EVENTOS
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSel_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Seleccion: " + selectedProducto.nombre);
            this.DialogResult = DialogResult.OK;
        }
        private void dgvList_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            if (dgvList.SelectedRows.Count != 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvList.SelectedRows[0];
                    selectedProducto = (InvProducto)row.DataBoundItem;
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void frmInvProductoSelection_KeyDown(object sender, KeyEventArgs e)
        {
            SelKey(e.KeyCode);
        }

        private void frmInvProductoSelection_Load(object sender, EventArgs e)
        {
            ConfigGrid();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            filtrar(txtFiltro.Text);
        }


        #endregion
    }
}
