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

namespace AppCaja
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Globals.appParentWindow = this;
            try
            {
                this.Text = Globals.logEmpresa.nombre;
                Form f = new frmCaja();
                ConfigUI.LaunchChildForm(f, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
