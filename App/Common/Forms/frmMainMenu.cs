using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Common.Classes;

namespace App.Common.Forms
{
    public partial class frmMainMenu : Form
    {
        List<string> permisos = new List<string>();
        public frmMainMenu()
        {
            InitializeComponent();
            Globals.appParentWindow = this;
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            toolStripStatusLblUsuario.Text = Globals.logUser.nombre;

            InicializarItems();
            ListarPermisosUsuario();
            ValidarPermisos();
            Form f = new frmDashboard();
            ConfigUI.LaunchChildForm(f, this);

        }

        private void ListarPermisosUsuario()
        {
            Console.WriteLine(Globals.logUser.permisos.Length.ToString());

            var str = Globals.logUser.permisos;
            var charsToRemove = new string[] { "[", "]", "\"" };
            foreach (var c in charsToRemove)
            {
                str = str.Replace(c, string.Empty);
            }


            string[] arregloPermisos = str.Split(',');

            
            foreach (var permiso in arregloPermisos)
            {
                //System.Console.WriteLine(permiso);
                permisos.Add(permiso);
            }

            //Console.WriteLine(str);
        }

        private void InicializarItems()
        {
            //INVENTARIO
            inventarioToolStripMenuItem.Visible = false;
            invCategoriasToolStripMenuItem.Visible = false;
            invProductosToolStripMenuItem.Visible = false;
            invOperacionesToolStripMenuItem.Visible = false;
            //COMPRAS
            comprasToolStripMenuItem.Visible = false;
            cmpProveedoresToolStripMenuItem.Visible = false;
            cmpOperacionesToolStripMenuItem.Visible = false;
            //VENTAS
            ventasToolStripMenuItem.Visible = false;
            vntClientesToolStripMenuItem.Visible = false;
            vntOperacionesToolStripMenuItem.Visible = false;
            //CAJA
            cajaToolStripMenuItem.Visible = false;
            cajOperacionesToolStripMenuItem.Visible = false;
            //REPORTES
            reportesToolStripMenuItem.Visible = false;
            repInventarioToolStripMenuItem.Visible = false;
            repComprasToolStripMenuItem.Visible = false;
            repVentasToolStripMenuItem.Visible = false;
            repCajaToolStripMenuItem.Visible = false;
            //CONFIGURACIONES
            configuracionesToolStripMenuItem.Visible = false;
            //cnfListasToolStripMenuItem.Visible = false;
            cnfCotizacionesToolStripMenuItem.Visible = false;
            cnfAjustesToolStripMenuItem.Visible = false;
            cnfCuentasBancariasToolStripMenuItem.Visible = false;
        }

        private void ValidarPermisos()
        {
            //INVENTARIO
            if (permisos.Contains("11E7A9015A806FF88A4800E04C6F7E24")) inventarioToolStripMenuItem.Visible = true;
            if (permisos.Contains("11E7A9133D4BE6968A4800E04C6F7E24")) invCategoriasToolStripMenuItem.Visible = true;
            if (permisos.Contains("11E7A961DC7E09FE9B0700270E383B06")) invProductosToolStripMenuItem.Visible = true;
            if (permisos.Contains("11E7A9015A806FF88A4800E04C6F7E24")) invOperacionesToolStripMenuItem.Visible = true;
            //COMPRAS
            if (permisos.Contains("11E82B7F7BB7CEBD853500270E383B06")) comprasToolStripMenuItem.Visible = true;
            if (permisos.Contains("11E82B7F89D7107B853500270E383B06")) cmpProveedoresToolStripMenuItem.Visible = true;
            if (permisos.Contains("11E82BD96FC3D06B941900270E383B06")) cmpOperacionesToolStripMenuItem.Visible = true;
            //VENTAS
            if (permisos.Contains("11E7A7131C59B43E9B0700270E383B06")) ventasToolStripMenuItem.Visible = true;
            if (permisos.Contains("11E8F164855C2EE68FF600270E383B06")) vntClientesToolStripMenuItem.Visible = true;
            if (permisos.Contains("11E8F1648C275D9F8FF600270E383B06")) vntOperacionesToolStripMenuItem.Visible = true;
            //CAJA
            if (permisos.Contains("11E8F82411287ECC9E9100270E383B06")) cajaToolStripMenuItem.Visible = true;
            if (permisos.Contains("11E8F8242C7266329E9100270E383B06")) cajOperacionesToolStripMenuItem.Visible = true;
            //REPORTES
            if (permisos.Contains("11E8FA23FA579807AC3D00270E383B06")) reportesToolStripMenuItem.Visible = true;
            if (permisos.Contains("11E8FA241C659045AC3D00270E383B06")) repInventarioToolStripMenuItem.Visible = true;
            if (permisos.Contains("11E8FA24232D3E53AC3D00270E383B06")) repComprasToolStripMenuItem.Visible = true;
            if (permisos.Contains("11E8FA242A19CA15AC3D00270E383B06")) repVentasToolStripMenuItem.Visible = true;
            if (permisos.Contains("11E8FA24307BA59AAC3D00270E383B06")) repCajaToolStripMenuItem.Visible = true;
            //CONFIGURACIONES
            if (permisos.Contains("11E7A51F8CBA85598A4800E04C6F7E24")) configuracionesToolStripMenuItem.Visible = true;
            //if (permisos.Contains("11E7A78A256FE0EF8A4800E04C6F7E24")) cnfListasToolStripMenuItem.Visible = true;
            if (permisos.Contains("11E7AA9C23373F23847D00E04C6F7E24")) cnfCotizacionesToolStripMenuItem.Visible = true;
            if (permisos.Contains("11E8F813ACFCF4CA9E9100270E383B06")) cnfCuentasBancariasToolStripMenuItem.Visible = true;
            if (permisos.Contains("11E8F7923603CF8FB23400270E383B06")) cnfAjustesToolStripMenuItem.Visible = true;
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void invCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Core.Inventario.frmInvCategoriasList();
            ConfigUI.LaunchChildForm(f, this);
        }

        private void invProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Core.Inventario.frmInvProductosList();
            ConfigUI.LaunchChildForm(f, this);
        }

        private void cmpProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Core.Compras.frmCmpProveedoresList();
            ConfigUI.LaunchChildForm(f, this);
        }

        private void cmpOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Core.Compras.frmCmpOperacionesList();
            ConfigUI.LaunchChildForm(f, this);
        }


        private void cnfCotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Core.Configuraciones.frmCnfCotizacionesList();
            ConfigUI.LaunchChildForm(f, this);
        }

        private void vntClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Core.Ventas.frmVntClientesList();
            ConfigUI.LaunchChildForm(f, this);
        }

        private void vntOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Core.Ventas.frmVntOperacionesList();
            ConfigUI.LaunchChildForm(f, this);
        }

        private void cajOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Core.Caja.frmCajOperacionesList();
            ConfigUI.LaunchChildForm(f, this);
        }

        private void cnfAjustesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Core.Configuraciones.frmAjustesDetail();
            ConfigUI.LaunchChildForm(f, this);
        }

        private void cnfCuentasBancariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Core.Configuraciones.frmCnfCuentasBancariasList();
            ConfigUI.LaunchChildForm(f, this);
        }

        private void invOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Core.Inventario.frmInvOperacionesList();
            ConfigUI.LaunchChildForm(f, this);
        }

        private void repInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Core.Reportes.frmRepInventario();
            ConfigUI.LaunchChildForm(f, this);
        }

        private void repComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Core.Reportes.frmRepCompra();
            ConfigUI.LaunchChildForm(f, this);
        }

        private void repVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Core.Reportes.frmRepVenta();
            ConfigUI.LaunchChildForm(f, this);
        }

        private void repCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Core.Reportes.frmRepCaja();
            ConfigUI.LaunchChildForm(f, this);
        }
    }
}
