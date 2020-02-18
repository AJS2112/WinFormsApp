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
    public partial class frmCnfListasList : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES
        private List<SisListas> lista = new List<SisListas>();
        private SisListas one = new SisListas();
        private SisListasClient srv = new SisListasClient();
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
            }


            dgvList.Columns[7].DisplayIndex = 0;
            dgvList.Columns[12].DisplayIndex = 1;
            dgvList.Columns[13].DisplayIndex = 2;
            dgvList.Columns[0].DisplayIndex = 3;
            dgvList.Columns[8].DisplayIndex = 4;

            dgvList.Columns[7].HeaderText = "NOMBRE";
            dgvList.Columns[7].Visible = true;
            dgvList.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvList.Columns[12].HeaderText = "RIF";
            dgvList.Columns[12].Visible = true;

            dgvList.Columns[13].HeaderText = "TELEFONO";
            dgvList.Columns[13].Visible = true;

        }

        private void filtrar(string filtro)
        {
            Console.WriteLine(filtro);
            dgvList.DataSource = lista.FindAll(o =>
                String.Join("", typeof(SisListas).GetProperties().Select(f => f.GetValue(o))).ToLower().Contains(filtro.ToLower())).ToList();
        }

        #endregion
        public frmCnfListasList()
        {
            InitializeComponent();
        }

        #region EVENTOS
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvList_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            if (dgvList.SelectedRows.Count != 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvList.SelectedRows[0];
                    one = (SisListas)row.DataBoundItem;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SisListas _one = new SisListas();
            _one = srv.GetOne(Globals.logEmpresa.id, one.id);

            frmCnfListasDetail fDetalle = new frmCnfListasDetail(_one);
            if (ConfigUI.LaunchDialogForm(fDetalle) == DialogResult.OK)
            {
                GetList();

                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Registro editado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SisListas _one = new SisListas();
            _one = srv.GetOne(Globals.logEmpresa.id, "0");

            frmCnfListasDetail fDetalle = new frmCnfListasDetail(_one);
            if (ConfigUI.LaunchDialogForm(fDetalle) == DialogResult.OK)
            {
                GetList();
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Registro agregado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            filtrar(txtFiltro.Text);
        }
        #endregion
    }
}
