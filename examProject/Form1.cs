using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbsence_Click(object sender, EventArgs e)
        {
            frmAbsence absence = new frmAbsence();
            absence.ShowDialog();
        }

        private void btnBadge_Click(object sender, EventArgs e)
        {
            frmBadge badge = new frmBadge();
            badge.ShowDialog();
        }

        private void btnConvocation_Click(object sender, EventArgs e)
        {
            frmConvocation convocation = new frmConvocation();
            convocation.ShowDialog();
        }
    }
}
