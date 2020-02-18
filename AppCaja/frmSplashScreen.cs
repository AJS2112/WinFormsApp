using App.ColOperacionService;
using App.Common.Classes;
using App.SisEmpresaService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace AppCaja
{
    //[CallbackBehavior(UseSynchronizationContext =false)]
    //public partial class frmSplashScreen : MetroFramework.Forms.MetroForm, App.ColNotificacionService.IColNotificacionCallback
    public partial class frmSplashScreen : MetroFramework.Forms.MetroForm
    {
        private ColOperacionClient srvCola = new ColOperacionClient();
        private System.Timers.Timer aTimer = new System.Timers.Timer();
        BindingSource bs = new BindingSource();
        BindingList<ColOperacion> bList;

        public frmSplashScreen()
        {
            InitializeComponent();

            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 5000;
            aTimer.Enabled = true;
            Console.WriteLine("Hello World!");

            SisEmpresaClient srvEmpresa = new SisEmpresaClient();
            string idEmpresa = ConfigurationManager.AppSettings["id_empresa"];
            Globals.logEmpresa = srvEmpresa.GetOne(idEmpresa);

        }
    
        //public void DoNotificacion(bool actualizacionesPendientes)
        //{
        //    if (actualizacionesPendientes)
        //    {
        //        Console.WriteLine("Actualizo Lista");
        //    }

        //}


        private void button1_Click(object sender, EventArgs e)
        {
            //InstanceContext instanceContext = new InstanceContext(this);
            //App.ColNotificacionService.ColNotificacionClient cliente = new App.ColNotificacionService.ColNotificacionClient(instanceContext);
            //cliente.InnerChannel.OperationTimeout = TimeSpan.FromDays(1);
            //cliente.AskNotificacion();
        }

        public async Task<bool> CheckCola()
        {
            return await srvCola.ActualizarColaAsync();
        }



        private async void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Task<bool> TBool = CheckCola();
            bool hayActualizacion = await TBool;
            if (hayActualizacion)
            {
                Console.WriteLine("Hello Actualizacion!");
                bList = new BindingList<ColOperacion>(srvCola.GetList(Globals.logEmpresa.id, "11E7C39A0EACD9A08F1A00E04C6F7E24", 1));
            }

        }
    }
}
