using App.CnfCuentaBancariaService;
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
    public partial class frmCnfCuentasBancariasDetail : MetroFramework.Forms.MetroForm
    {
        private List<SisListas> _listaBancos = new List<SisListas>();
        private SisListasClient srvListas = new SisListasClient();

        private CnfCuentaBancariaClient srv = new CnfCuentaBancariaClient();
        public CnfCuentaBancaria one { get; set; }

        public frmCnfCuentasBancariasDetail()
        {
            InitializeComponent();
        }

        public frmCnfCuentasBancariasDetail(CnfCuentaBancaria obj)
        {
            InitializeComponent();

            _listaBancos = srvListas.GetListByCampo("bancos");
            cmbBanco.DataSource = _listaBancos;
            cmbBanco.DisplayMember = "nombre";
            cmbBanco.ValueMember = "id";

            one = obj;
            cmbBanco.DataBindings.Add("SelectedValue", one, "id_banco");
            txtNumero.DataBindings.Add("Text", one, "numero", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            try
            {
                string _id = srv.SetOne(one);
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
    }
}
