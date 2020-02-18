using App.Common.Classes;
using App.InvCategoriaService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Core.Inventario
{
    public partial class frmInvCategoriasDetail : MetroFramework.Forms.MetroForm
    {
        private List<InvCategoria> _listaCategorias = new List<InvCategoria>();
        private InvCategoriaClient srv = new InvCategoriaClient();
        public InvCategoria one { get; set; }
        public frmInvCategoriasDetail()
        {
            InitializeComponent();
        }

        public frmInvCategoriasDetail(InvCategoria obj)
        {
            InitializeComponent();

            Console.WriteLine("Globals.logUser.nombre: ", Globals.logUser.nombre);
            Console.WriteLine("");
            Console.WriteLine("Globals.logEmpresa.monedas: ", Globals.logEmpresa.monedas);

            _listaCategorias = srv.GetList(Globals.logEmpresa.id);
            _listaCategorias.Insert(0, new InvCategoria { nombre = "PRINCIPAL", id = "00000000000000000000000000000000" });
            cmbCategoria.DataSource = _listaCategorias;
            cmbCategoria.DisplayMember = "nombre";
            cmbCategoria.ValueMember = "id";

            one = obj;
            lblTitle.Text = obj.nombre;
            cmbCategoria.DataBindings.Add("SelectedValue", one, "id_padre");
            txtNombre.DataBindings.Add("Text", one, "nombre", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDescripcion.DataBindings.Add("Text", one, "descrip", true, DataSourceUpdateMode.OnPropertyChanged);
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
