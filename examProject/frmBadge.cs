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
            string Path = Application.StartupPath;
            badgeReport badge = new badgeReport();
            badge.SetDataSource(projectExamDataSet);
            badge.SetParameterValue("path", Path);
            string filtre = "";
            if (etudiantDataGridView != null && etudiantDataGridView.DataSource != null && etudiantDataGridView.CurrentRow != null)
            {
                string idEtudiant = etudiantDataGridView.CurrentRow.Cells[0].Value.ToString();
                filtre = "{Etudiant.idEtudiant} = " + idEtudiant;
                frmImpression print = new frmImpression(badge, filtre);
                print.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veuliez selectionner un etudiant!");
            }
        }

        private void btnAllPrint_Click(object sender, EventArgs e)
        {
            string Path = Application.StartupPath;
            badgeReport badge = new badgeReport();
            badge.SetDataSource(projectExamDataSet);
            badge.SetParameterValue("path", Path);
            string filtre = "";
            if (groupeComboBox != null && groupeComboBox.SelectedValue != null)
            {
                string idGroupe = groupeComboBox.SelectedValue.ToString();
                filtre = "{Etudiant.idGroupe} = " + idGroupe;
                frmImpression print = new frmImpression(badge, filtre);
                print.ShowDialog();
            } else
            {
                MessageBox.Show("Veuliez selectionner un groupe!");
            }

        }
    }
}
