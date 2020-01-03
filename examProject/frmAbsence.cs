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
    public partial class frmAbsence : Form
    {
        public frmAbsence()
        {
            InitializeComponent();
        }

        private void filliereBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filliereBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectExamDataSet);

        }

        private void frmAbsence_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'projectExamDataSet.Etudiant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.etudiantTableAdapter.Fill(this.projectExamDataSet.Etudiant);
            // TODO: cette ligne de code charge les données dans la table 'projectExamDataSet.Groupe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.groupeTableAdapter.Fill(this.projectExamDataSet.Groupe);
            // TODO: cette ligne de code charge les données dans la table 'projectExamDataSet.Filliere'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.filliereTableAdapter.Fill(this.projectExamDataSet.Filliere);

        }

        private void nomFilliereLabel_Click(object sender, EventArgs e)
        {

        }

        private void nomFilliereComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAbsence_Click(object sender, EventArgs e)
        {
            absentReport absent = new absentReport();
            absent.SetDataSource(projectExamDataSet);
            //absent.SetParameterValue("path", Path);
            string filtre = "";
            if (nomGroupeComboBox != null && nomGroupeComboBox.SelectedValue != null)
            {
                string idGroupe = nomGroupeComboBox.SelectedValue.ToString();
                filtre = "{Etudiant.idGroupe} = " + idGroupe;
                frmImpression print = new frmImpression(absent, filtre);
                print.ShowDialog();
            }
            else
            {
              MessageBox.Show("Veuliez selectionner un groupe!");
            }
        }
    }
}
