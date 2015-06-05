namespace ProjetSudokuIHM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResoluer = new System.Windows.Forms.Button();
            this.cBChoixGrille = new System.Windows.Forms.ComboBox();
            this.btnFile = new System.Windows.Forms.Button();
            this.tBCheminFile = new System.Windows.Forms.TextBox();
            this.dGVGrille = new System.Windows.Forms.DataGridView();
            this.oFDChoixFile = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGrille)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnResoluer);
            this.panel1.Controls.Add(this.cBChoixGrille);
            this.panel1.Controls.Add(this.btnFile);
            this.panel1.Controls.Add(this.tBCheminFile);
            this.panel1.Location = new System.Drawing.Point(65, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 128);
            this.panel1.TabIndex = 0;
            // 
            // btnResoluer
            // 
            this.btnResoluer.Location = new System.Drawing.Point(608, 71);
            this.btnResoluer.Name = "btnResoluer";
            this.btnResoluer.Size = new System.Drawing.Size(144, 23);
            this.btnResoluer.TabIndex = 3;
            this.btnResoluer.Text = "Résoudre";
            this.btnResoluer.UseVisualStyleBackColor = true;
            this.btnResoluer.Click += new System.EventHandler(this.btnResoluer_Click);
            // 
            // cBChoixGrille
            // 
            this.cBChoixGrille.AllowDrop = true;
            this.cBChoixGrille.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cBChoixGrille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBChoixGrille.FormattingEnabled = true;
            this.cBChoixGrille.Location = new System.Drawing.Point(49, 77);
            this.cBChoixGrille.Name = "cBChoixGrille";
            this.cBChoixGrille.Size = new System.Drawing.Size(315, 21);
            this.cBChoixGrille.Sorted = true;
            this.cBChoixGrille.TabIndex = 2;
            this.cBChoixGrille.SelectedIndexChanged += new System.EventHandler(this.cBChoixGrille_SelectedIndexChanged);
            // 
            // btnFile
            // 
            this.btnFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFile.Location = new System.Drawing.Point(608, 24);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(144, 24);
            this.btnFile.TabIndex = 1;
            this.btnFile.Text = ".....";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // tBCheminFile
            // 
            this.tBCheminFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBCheminFile.Location = new System.Drawing.Point(49, 26);
            this.tBCheminFile.Name = "tBCheminFile";
            this.tBCheminFile.Size = new System.Drawing.Size(523, 20);
            this.tBCheminFile.TabIndex = 0;
            // 
            // dGVGrille
            // 
            this.dGVGrille.AllowUserToAddRows = false;
            this.dGVGrille.AllowUserToDeleteRows = false;
            this.dGVGrille.AllowUserToResizeColumns = false;
            this.dGVGrille.AllowUserToResizeRows = false;
            this.dGVGrille.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVGrille.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVGrille.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dGVGrille.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVGrille.ColumnHeadersHeight = 4;
            this.dGVGrille.ColumnHeadersVisible = false;
            this.dGVGrille.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dGVGrille.Location = new System.Drawing.Point(65, 219);
            this.dGVGrille.Margin = new System.Windows.Forms.Padding(1);
            this.dGVGrille.Name = "dGVGrille";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVGrille.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVGrille.RowHeadersVisible = false;
            this.dGVGrille.RowHeadersWidth = 4;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dGVGrille.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dGVGrille.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dGVGrille.Size = new System.Drawing.Size(804, 572);
            this.dGVGrille.TabIndex = 1;
            // 
            // oFDChoixFile
            // 
            this.oFDChoixFile.DefaultExt = "sud";
            this.oFDChoixFile.FileOk += new System.ComponentModel.CancelEventHandler(this.oFDChoixFile_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 803);
            this.Controls.Add(this.dGVGrille);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGrille)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dGVGrille;
        private System.Windows.Forms.ComboBox cBChoixGrille;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.TextBox tBCheminFile;
        private System.Windows.Forms.OpenFileDialog oFDChoixFile;
        private System.Windows.Forms.Button btnResoluer;
    }
}

