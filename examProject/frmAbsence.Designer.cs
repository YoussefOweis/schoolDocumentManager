namespace examProject
{
    partial class frmAbsence
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomFilliereLabel;
            System.Windows.Forms.Label lblGroupe;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.projectExamDataSet = new examProject.projectExamDataSet();
            this.filliereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filliereTableAdapter = new examProject.projectExamDataSetTableAdapters.FilliereTableAdapter();
            this.tableAdapterManager = new examProject.projectExamDataSetTableAdapters.TableAdapterManager();
            this.nomFilliereComboBox = new System.Windows.Forms.ComboBox();
            this.groupeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupeTableAdapter = new examProject.projectExamDataSetTableAdapters.GroupeTableAdapter();
            this.nomGroupeComboBox = new System.Windows.Forms.ComboBox();
            this.etudiantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.etudiantTableAdapter = new examProject.projectExamDataSetTableAdapters.EtudiantTableAdapter();
            this.etudiantDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAbsence = new System.Windows.Forms.Button();
            nomFilliereLabel = new System.Windows.Forms.Label();
            lblGroupe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectExamDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filliereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::examProject.Properties.Resources.ofppt;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // projectExamDataSet
            // 
            this.projectExamDataSet.DataSetName = "projectExamDataSet";
            this.projectExamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filliereBindingSource
            // 
            this.filliereBindingSource.DataMember = "Filliere";
            this.filliereBindingSource.DataSource = this.projectExamDataSet;
            // 
            // filliereTableAdapter
            // 
            this.filliereTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EtudiantTableAdapter = this.etudiantTableAdapter;
            this.tableAdapterManager.FilliereTableAdapter = this.filliereTableAdapter;
            this.tableAdapterManager.GroupeTableAdapter = this.groupeTableAdapter;
            this.tableAdapterManager.UpdateOrder = examProject.projectExamDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nomFilliereLabel
            // 
            nomFilliereLabel.AutoSize = true;
            nomFilliereLabel.Location = new System.Drawing.Point(9, 152);
            nomFilliereLabel.Name = "nomFilliereLabel";
            nomFilliereLabel.Size = new System.Drawing.Size(90, 13);
            nomFilliereLabel.TabIndex = 8;
            nomFilliereLabel.Text = "Liste des Filières :";
            nomFilliereLabel.Click += new System.EventHandler(this.nomFilliereLabel_Click);
            // 
            // nomFilliereComboBox
            // 
            this.nomFilliereComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filliereBindingSource, "nomFilliere", true));
            this.nomFilliereComboBox.DataSource = this.filliereBindingSource;
            this.nomFilliereComboBox.DisplayMember = "nomFilliere";
            this.nomFilliereComboBox.FormattingEnabled = true;
            this.nomFilliereComboBox.Location = new System.Drawing.Point(114, 149);
            this.nomFilliereComboBox.Name = "nomFilliereComboBox";
            this.nomFilliereComboBox.Size = new System.Drawing.Size(352, 21);
            this.nomFilliereComboBox.TabIndex = 9;
            this.nomFilliereComboBox.ValueMember = "idFilliere";
            this.nomFilliereComboBox.SelectedIndexChanged += new System.EventHandler(this.nomFilliereComboBox_SelectedIndexChanged);
            // 
            // groupeBindingSource
            // 
            this.groupeBindingSource.DataMember = "fk_Groupe_Filliere";
            this.groupeBindingSource.DataSource = this.filliereBindingSource;
            // 
            // groupeTableAdapter
            // 
            this.groupeTableAdapter.ClearBeforeFill = true;
            // 
            // lblGroupe
            // 
            lblGroupe.AutoSize = true;
            lblGroupe.Location = new System.Drawing.Point(10, 179);
            lblGroupe.Name = "lblGroupe";
            lblGroupe.Size = new System.Drawing.Size(98, 13);
            lblGroupe.TabIndex = 9;
            lblGroupe.Text = "Liste des Groupes :";
            // 
            // nomGroupeComboBox
            // 
            this.nomGroupeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupeBindingSource, "nomGroupe", true));
            this.nomGroupeComboBox.DataSource = this.groupeBindingSource;
            this.nomGroupeComboBox.DisplayMember = "nomGroupe";
            this.nomGroupeComboBox.FormattingEnabled = true;
            this.nomGroupeComboBox.Location = new System.Drawing.Point(114, 176);
            this.nomGroupeComboBox.Name = "nomGroupeComboBox";
            this.nomGroupeComboBox.Size = new System.Drawing.Size(352, 21);
            this.nomGroupeComboBox.TabIndex = 10;
            this.nomGroupeComboBox.ValueMember = "idGroupe";
            // 
            // etudiantBindingSource
            // 
            this.etudiantBindingSource.DataMember = "fk_Etudiant_Groupe";
            this.etudiantBindingSource.DataSource = this.groupeBindingSource;
            // 
            // etudiantTableAdapter
            // 
            this.etudiantTableAdapter.ClearBeforeFill = true;
            // 
            // etudiantDataGridView
            // 
            this.etudiantDataGridView.AutoGenerateColumns = false;
            this.etudiantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.etudiantDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.etudiantDataGridView.DataSource = this.etudiantBindingSource;
            this.etudiantDataGridView.Location = new System.Drawing.Point(12, 203);
            this.etudiantDataGridView.Name = "etudiantDataGridView";
            this.etudiantDataGridView.Size = new System.Drawing.Size(454, 229);
            this.etudiantDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idEtudiant";
            this.dataGridViewTextBoxColumn1.HeaderText = "idEtudiant";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prenom";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dateNaissance";
            this.dataGridViewTextBoxColumn4.HeaderText = "dateNaissance";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // btnAbsence
            // 
            this.btnAbsence.Location = new System.Drawing.Point(159, 455);
            this.btnAbsence.Name = "btnAbsence";
            this.btnAbsence.Size = new System.Drawing.Size(153, 23);
            this.btnAbsence.TabIndex = 11;
            this.btnAbsence.Text = "Imprimer la feuille d\'absence";
            this.btnAbsence.UseVisualStyleBackColor = true;
            this.btnAbsence.Click += new System.EventHandler(this.btnAbsence_Click);
            // 
            // frmAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 490);
            this.Controls.Add(this.btnAbsence);
            this.Controls.Add(this.etudiantDataGridView);
            this.Controls.Add(lblGroupe);
            this.Controls.Add(this.nomGroupeComboBox);
            this.Controls.Add(nomFilliereLabel);
            this.Controls.Add(this.nomFilliereComboBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmAbsence";
            this.Text = "frmAbsence";
            this.Load += new System.EventHandler(this.frmAbsence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectExamDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filliereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private projectExamDataSet projectExamDataSet;
        private System.Windows.Forms.BindingSource filliereBindingSource;
        private projectExamDataSetTableAdapters.FilliereTableAdapter filliereTableAdapter;
        private projectExamDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox nomFilliereComboBox;
        private projectExamDataSetTableAdapters.GroupeTableAdapter groupeTableAdapter;
        private System.Windows.Forms.BindingSource groupeBindingSource;
        private projectExamDataSetTableAdapters.EtudiantTableAdapter etudiantTableAdapter;
        private System.Windows.Forms.ComboBox nomGroupeComboBox;
        private System.Windows.Forms.BindingSource etudiantBindingSource;
        private System.Windows.Forms.DataGridView etudiantDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnAbsence;
    }
}