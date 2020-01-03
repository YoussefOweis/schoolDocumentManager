namespace examProject
{
    partial class frmBadge
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
            this.projectExamDataSet = new examProject.projectExamDataSet();
            this.filliereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filliereTableAdapter = new examProject.projectExamDataSetTableAdapters.FilliereTableAdapter();
            this.tableAdapterManager = new examProject.projectExamDataSetTableAdapters.TableAdapterManager();
            this.filliereComboBox = new System.Windows.Forms.ComboBox();
            this.groupeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupeTableAdapter = new examProject.projectExamDataSetTableAdapters.GroupeTableAdapter();
            this.groupeComboBox = new System.Windows.Forms.ComboBox();
            this.etudiantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.etudiantTableAdapter = new examProject.projectExamDataSetTableAdapters.EtudiantTableAdapter();
            this.etudiantDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFilliere = new System.Windows.Forms.Label();
            this.lblGroupe = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSinglePrint = new System.Windows.Forms.Button();
            this.btnAllPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.projectExamDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filliereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.tableAdapterManager.EtudiantTableAdapter = null;
            this.tableAdapterManager.FilliereTableAdapter = this.filliereTableAdapter;
            this.tableAdapterManager.GroupeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = examProject.projectExamDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // filliereComboBox
            // 
            this.filliereComboBox.DataSource = this.filliereBindingSource;
            this.filliereComboBox.DisplayMember = "nomFilliere";
            this.filliereComboBox.FormattingEnabled = true;
            this.filliereComboBox.Location = new System.Drawing.Point(116, 140);
            this.filliereComboBox.Name = "filliereComboBox";
            this.filliereComboBox.Size = new System.Drawing.Size(337, 21);
            this.filliereComboBox.TabIndex = 1;
            this.filliereComboBox.ValueMember = "idFilliere";
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
            // groupeComboBox
            // 
            this.groupeComboBox.DataSource = this.groupeBindingSource;
            this.groupeComboBox.DisplayMember = "nomGroupe";
            this.groupeComboBox.FormattingEnabled = true;
            this.groupeComboBox.Location = new System.Drawing.Point(116, 172);
            this.groupeComboBox.Name = "groupeComboBox";
            this.groupeComboBox.Size = new System.Drawing.Size(337, 21);
            this.groupeComboBox.TabIndex = 2;
            this.groupeComboBox.ValueMember = "idGroupe";
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
            this.etudiantDataGridView.Location = new System.Drawing.Point(12, 210);
            this.etudiantDataGridView.Name = "etudiantDataGridView";
            this.etudiantDataGridView.Size = new System.Drawing.Size(454, 220);
            this.etudiantDataGridView.TabIndex = 3;
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
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prenom";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dateNaissance";
            this.dataGridViewTextBoxColumn4.HeaderText = "dateNaissance";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // lblFilliere
            // 
            this.lblFilliere.AutoSize = true;
            this.lblFilliere.Location = new System.Drawing.Point(9, 143);
            this.lblFilliere.Name = "lblFilliere";
            this.lblFilliere.Size = new System.Drawing.Size(90, 13);
            this.lblFilliere.TabIndex = 4;
            this.lblFilliere.Text = "Liste des Filières :";
            this.lblFilliere.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblGroupe
            // 
            this.lblGroupe.AutoSize = true;
            this.lblGroupe.Location = new System.Drawing.Point(9, 175);
            this.lblGroupe.Name = "lblGroupe";
            this.lblGroupe.Size = new System.Drawing.Size(98, 13);
            this.lblGroupe.TabIndex = 5;
            this.lblGroupe.Text = "Liste des Groupes :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::examProject.Properties.Resources.ofppt;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnSinglePrint
            // 
            this.btnSinglePrint.Location = new System.Drawing.Point(315, 445);
            this.btnSinglePrint.Name = "btnSinglePrint";
            this.btnSinglePrint.Size = new System.Drawing.Size(151, 23);
            this.btnSinglePrint.TabIndex = 7;
            this.btnSinglePrint.Text = "Imprimer un etudiant badge ";
            this.btnSinglePrint.UseVisualStyleBackColor = true;
            this.btnSinglePrint.Click += new System.EventHandler(this.singlePrint_Click);
            // 
            // btnAllPrint
            // 
            this.btnAllPrint.Location = new System.Drawing.Point(12, 445);
            this.btnAllPrint.Name = "btnAllPrint";
            this.btnAllPrint.Size = new System.Drawing.Size(151, 23);
            this.btnAllPrint.TabIndex = 8;
            this.btnAllPrint.Text = "Imprimer tous les badges";
            this.btnAllPrint.UseVisualStyleBackColor = true;
            this.btnAllPrint.Click += new System.EventHandler(this.btnAllPrint_Click);
            // 
            // frmBadge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 480);
            this.Controls.Add(this.btnAllPrint);
            this.Controls.Add(this.btnSinglePrint);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblGroupe);
            this.Controls.Add(this.lblFilliere);
            this.Controls.Add(this.etudiantDataGridView);
            this.Controls.Add(this.groupeComboBox);
            this.Controls.Add(this.filliereComboBox);
            this.Name = "frmBadge";
            this.Text = "frmBadge";
            this.Load += new System.EventHandler(this.frmBadge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectExamDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filliereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private projectExamDataSet projectExamDataSet;
        private System.Windows.Forms.BindingSource filliereBindingSource;
        private projectExamDataSetTableAdapters.FilliereTableAdapter filliereTableAdapter;
        private projectExamDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox filliereComboBox;
        private System.Windows.Forms.BindingSource groupeBindingSource;
        private projectExamDataSetTableAdapters.GroupeTableAdapter groupeTableAdapter;
        private System.Windows.Forms.ComboBox groupeComboBox;
        private System.Windows.Forms.BindingSource etudiantBindingSource;
        private projectExamDataSetTableAdapters.EtudiantTableAdapter etudiantTableAdapter;
        private System.Windows.Forms.DataGridView etudiantDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label lblFilliere;
        private System.Windows.Forms.Label lblGroupe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSinglePrint;
        private System.Windows.Forms.Button btnAllPrint;
    }
}