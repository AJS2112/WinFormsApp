using App.Common.Classes;
using App.SisEmpresaService;
using App.SisUsuariosService;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AppPV
{
    public partial class frmSplashScreen : MetroFramework.Forms.MetroForm
    {
        #region VARIABLES 

        #endregion
        public frmSplashScreen()
        {
            InitializeComponent();
            try
            {
                SisEmpresaClient srvEmpresa = new SisEmpresaClient();
                SisUsuariosClient srvUsuarios = new SisUsuariosClient();
                string idEmpresa = ConfigurationManager.AppSettings["id_empresa"];
                Globals.logEmpresa = srvEmpresa.GetOne(idEmpresa);

                List<SisUsuarios> listado= srvUsuarios.GetList(idEmpresa);
                Globals.listaUsuarios = listado.Where(o => o.es_inactivo == false).ToList();
                Globals.listaUsuarios = Globals.listaUsuarios.OrderBy(o => o.numero).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Iniciando el Servicio: " + ex.Message);
                Application.Exit();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain myForm = new frmMain();
            myForm.Show();
            this.Hide();
        }

        private void frmSplashScreen_Shown(object sender, EventArgs e)
        {
            frmMain myForm = new frmMain();
            myForm.Show();
            this.Hide();
        }
    }
}
