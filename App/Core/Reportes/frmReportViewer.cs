using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Core.Reportes
{
    public partial class frmReportViewer : MetroFramework.Forms.MetroForm
    {
       
        public frmReportViewer()
        {
            InitializeComponent();
        }

        public frmReportViewer(CrystalDecisions.Windows.Forms.CrystalReportViewer reporte)
        {
            InitializeComponent();
            crViewer.ReportSource = reporte.ReportSource;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
