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
        string filtre;
        ReportClass repo = new ReportClass();
        public frmImpression(ReportClass _repo,string _filtre = "")
        {
            repo = _repo;
            filtre = _filtre;
            InitializeComponent();
        }

        private void frmImpression_Load(object sender, EventArgs e)
        { 
            crystalReportViewer1.ReportSource = repo;
            if (filtre != "")
                crystalReportViewer1.SelectionFormula = filtre;
        }
    }
}
