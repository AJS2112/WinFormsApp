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
    public partial class frmCnfListasDetail : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES
        private List<SisListas> _listaCategorias = new List<SisListas>();
        private SisListasClient srv = new SisListasClient();
        private SisListas one { get; set; }
        #endregion
        public frmCnfListasDetail()
        {
            InitializeComponent();
        }

        public frmCnfListasDetail(SisListas obj)
        {
            InitializeComponent();
            one = obj;
            lblTitle.Text = obj.nombre;

            txtNombre.DataBindings.Add("Text", one, "nombre", true, DataSourceUpdateMode.OnPropertyChanged);

            //_listaCampos = srv.GetList(Globals.logEmpresa.id);
            //_listaCategorias.Insert(0, new InvCategoria { nombre = "PRINCIPAL", id = "00000000000000000000000000000000" });
            //cmbCategoria.DataSource = _listaCategorias;
            //cmbCategoria.DisplayMember = "nombre";
            //cmbCategoria.ValueMember = "id";
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
    }
}
