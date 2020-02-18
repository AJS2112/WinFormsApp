using App.CnfCotizacionService;
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

namespace App.Core.Configuraciones
{
    public partial class frmCnfCotizacionesList : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES
        private CnfCotizacionClient srv = new CnfCotizacionClient();
        private List<CnfCotizacion> lista = new List<CnfCotizacion>();
        private CnfCotizacion one = new CnfCotizacion();
        #endregion

        #region METODOS
        private void GetList()
        {
            lista = srv.GetList(Globals.logEmpresa.id);
            dgvList.DataSource = lista;
        }

        private void ConfigGrid()
        {
            for (int i = 0; i <= dgvList.Columns.Count - 1; i++)
            {
                dgvList.Columns[i].Visible = false;
                //Console.WriteLine(i.ToString() + " - " +dgvList.Columns[i].HeaderText);
            }


            dgvList.Columns[5].DisplayIndex = 0;
            dgvList.Columns[5].HeaderText = "Nº CONTROL";
            dgvList.Columns[5].Visible = true;
            

            dgvList.Columns[0].HeaderText = "FECHA";
            dgvList.Columns[0].Visible = true;
            dgvList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

        }

        private void filtrar(string filtro)
        {
            dgvList.DataSource = lista.FindAll(o =>
                String.Join("", typeof(CnfCotizacion).GetProperties().Select(f => f.GetValue(o))).ToLower().Contains(filtro.ToLower())).ToList();
            lblSubTitle.Text = dgvList.RowCount.ToString() + " registros";
        }

        #endregion

        //CONSTRUCTOR
        public frmCnfCotizacionesList()
        {
            InitializeComponent();
            GetList();
            filtrar(txtFiltro.Text);
            btnEdit.Visible = false;
        }

        #region EVENTOS
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CnfCotizacion _one = new CnfCotizacion();
            _one = srv.GetOne(Globals.logEmpresa.id, "0");

            frmCnfCotizacionesDetail fDetalle = new frmCnfCotizacionesDetail(_one);
            if (ConfigUI.LaunchDialogForm(fDetalle) == DialogResult.OK)
            {
                GetList();
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Registro agregado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            CnfCotizacion _one = new CnfCotizacion();
            _one = srv.GetOne(Globals.logEmpresa.id, one.id);

            frmCnfCotizacionesDetail fDetalle = new frmCnfCotizacionesDetail(_one);
            if (ConfigUI.LaunchDialogForm(fDetalle) == DialogResult.OK)
            {
                GetList();

                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Registro editado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvList_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            if (dgvList.SelectedRows.Count != 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvList.SelectedRows[0];
                    one = (CnfCotizacion)row.DataBoundItem;
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                btnEdit.Visible = true;
            }
            else
            {
                btnEdit.Visible = false;
            }
        }

        private void frmCnfCotizacionesList_Load(object sender, EventArgs e)
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
