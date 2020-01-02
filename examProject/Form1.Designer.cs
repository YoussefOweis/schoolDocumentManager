namespace examProject
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBadge = new System.Windows.Forms.Button();
            this.btnConvocation = new System.Windows.Forms.Button();
            this.btnAbsence = new System.Windows.Forms.Button();
            this.logoOfppt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoOfppt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBadge
            // 
            this.btnBadge.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBadge.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBadge.FlatAppearance.BorderSize = 0;
            this.btnBadge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBadge.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBadge.Location = new System.Drawing.Point(22, 89);
            this.btnBadge.Name = "btnBadge";
            this.btnBadge.Padding = new System.Windows.Forms.Padding(10);
            this.btnBadge.Size = new System.Drawing.Size(153, 68);
            this.btnBadge.TabIndex = 0;
            this.btnBadge.Text = "Impression de Badge";
            this.btnBadge.UseVisualStyleBackColor = false;
            this.btnBadge.Click += new System.EventHandler(this.btnBadge_Click);
            // 
            // btnConvocation
            // 
            this.btnConvocation.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnConvocation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConvocation.FlatAppearance.BorderSize = 0;
            this.btnConvocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvocation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConvocation.Location = new System.Drawing.Point(22, 163);
            this.btnConvocation.Name = "btnConvocation";
            this.btnConvocation.Padding = new System.Windows.Forms.Padding(10);
            this.btnConvocation.Size = new System.Drawing.Size(153, 68);
            this.btnConvocation.TabIndex = 1;
            this.btnConvocation.Text = "Impression de Convocation";
            this.btnConvocation.UseVisualStyleBackColor = false;
            this.btnConvocation.Click += new System.EventHandler(this.btnConvocation_Click);
            // 
            // btnAbsence
            // 
            this.btnAbsence.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAbsence.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAbsence.FlatAppearance.BorderSize = 0;
            this.btnAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbsence.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAbsence.Location = new System.Drawing.Point(22, 237);
            this.btnAbsence.Name = "btnAbsence";
            this.btnAbsence.Padding = new System.Windows.Forms.Padding(10);
            this.btnAbsence.Size = new System.Drawing.Size(153, 68);
            this.btnAbsence.TabIndex = 2;
            this.btnAbsence.Text = "Impression de Feuilles d\'absence";
            this.btnAbsence.UseVisualStyleBackColor = false;
            this.btnAbsence.Click += new System.EventHandler(this.btnAbsence_Click);
            // 
            // logoOfppt
            // 
            this.logoOfppt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoOfppt.Image = global::examProject.Properties.Resources.ofppt;
            this.logoOfppt.Location = new System.Drawing.Point(12, 12);
            this.logoOfppt.Name = "logoOfppt";
            this.logoOfppt.Size = new System.Drawing.Size(173, 67);
            this.logoOfppt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoOfppt.TabIndex = 3;
            this.logoOfppt.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 317);
            this.Controls.Add(this.logoOfppt);
            this.Controls.Add(this.btnAbsence);
            this.Controls.Add(this.btnConvocation);
            this.Controls.Add(this.btnBadge);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.logoOfppt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBadge;
        private System.Windows.Forms.Button btnConvocation;
        private System.Windows.Forms.Button btnAbsence;
        private System.Windows.Forms.PictureBox logoOfppt;
    }
}

