using App.Common.Classes;
using App.SisEmpresaService;
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
    public partial class frmAjustesDetail : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES
        //SERVICIOS
        private SisListasClient srvListas = new SisListasClient();
        private SisEmpresaClient srvEmpresas = new SisEmpresaClient();

        //LISTAS
        private List<SisListas> _listaMonedas = new List<SisListas>();
        private List<SisListas> _listaInstrumentos = new List<SisListas>();

        //OBJETOS
        private SisEmpresa one = new SisEmpresa();

        #endregion

        #region METODOS
        private void CargarListas()
        {
            one = srvEmpresas.GetOne( Globals.logEmpresa.id);

            _listaMonedas = srvListas.GetListByCampo("monedas");
            lstMonedas.DataSource = _listaMonedas;
            lstMonedas.DisplayMember = "nombre";
            lstMonedas.ValueMember = "id";

            cmbMonedaDefecto.DataSource = _listaMonedas;
            cmbMonedaDefecto.DisplayMember = "nombre";
            cmbMonedaDefecto.ValueMember = "id";
            cmbMonedaDefecto.DataBindings.Add("SelectedValue", one, "moneda_defecto", true, DataSourceUpdateMode.OnPropertyChanged);

            _listaInstrumentos = srvListas.GetListByCampo("instrumento_pago");
            lstInstrumentos.DataSource = _listaInstrumentos;
            lstInstrumentos.DisplayMember = "nombre";
            lstInstrumentos.ValueMember = "id";

            lstMonedas.ClearSelected();
            lstInstrumentos.ClearSelected();

            SetSeleccion(Globals.logEmpresa.monedas, lstMonedas);
            SetSeleccion(Globals.logEmpresa.instrumentos_pago, lstInstrumentos);

        }

        private string  GetSeleccion(ListBox.SelectedObjectCollection lista)
        {
            string seleccion = "[";
            int i =1;
            foreach (SisListas item in lista)
            {
                seleccion += "\"" + item.id + "\"" ;
                if(i<lista.Count) seleccion +=  ",";
                i += 1;
            }
            seleccion += "]";
            return seleccion;
        }

        private void SetSeleccion(string arreglo, ListBox lista)
        {
            string str = arreglo;
            var charsToRemove = new string[] { "[", "]", "\"" };
            foreach (var c in charsToRemove)
            {
                str = str.Replace(c, string.Empty);
            }


            string[] miArreglo = str.Split(',');
            foreach (var moneda in miArreglo)
            {
                lista.SelectedValue = moneda;
            }

        }


        #endregion
        public frmAjustesDetail()
        {
            InitializeComponent();
            CargarListas();
        }

        #region EVENTOS
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string misMonedas = GetSeleccion(lstMonedas.SelectedItems);
            string misInstrumentos = GetSeleccion(lstInstrumentos.SelectedItems);

            one.monedas = misMonedas;
            one.instrumentos_pago = misInstrumentos;

            srvEmpresas.SetOne(one);
            MetroFramework.MetroMessageBox.Show(this.MdiParent, "La aplicación se cerrará para que los cambios tengan efecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();

        }
        #endregion


    }
}
