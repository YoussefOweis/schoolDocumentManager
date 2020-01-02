using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
namespace examProject
{
    public partial class frmImpression : Form
    {
        ReportClass repo = new ReportClass();
        public frmImpression(ReportClass _repo)
        {
            repo = _repo;
            InitializeComponent();
        }

        private void frmImpression_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = repo;
        }
    }
}
