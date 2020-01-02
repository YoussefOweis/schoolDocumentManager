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
    public partial class frmBadge : Form
    {
        public frmBadge()
        {
            InitializeComponent();
        }

        private void filliereBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filliereBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectExamDataSet);

        }

        private void frmBadge_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'projectExamDataSet.Etudiant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.etudiantTableAdapter.Fill(this.projectExamDataSet.Etudiant);
            // TODO: cette ligne de code charge les données dans la table 'projectExamDataSet.Groupe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.groupeTableAdapter.Fill(this.projectExamDataSet.Groupe);
            // TODO: cette ligne de code charge les données dans la table 'projectExamDataSet.Filliere'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.filliereTableAdapter.Fill(this.projectExamDataSet.Filliere);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void singlePrint_Click(object sender, EventArgs e)
        {
            badgeReport badge = new badgeReport();
            badge.SetDataSource(projectExamDataSet);
            frmImpression print = new frmImpression(badge);
            print.ShowDialog();
            /*StagiaireRapport rp = new StagiaireRapport();
            rp.SetDataSource(ismoStagiaireDataSet);

            string filtre = "";
            if (textBox1.Text != "")
                filtre = "{STAGIAIRE.NOMSTAGIAIRE} like '*" + textBox1.Text.Replace("'", "''");
            frmImprission o = new frmImprission(rp, filtre);
            o.ShowDialog();*/
        }
    }
}
