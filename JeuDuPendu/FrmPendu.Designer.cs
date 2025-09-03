namespace JeuDuPendu
{
    partial class frmPendu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMot = new System.Windows.Forms.TextBox();
            this.lblResultat = new System.Windows.Forms.Label();
            this.btnRejouer = new System.Windows.Forms.Button();
            this.imgPendu = new System.Windows.Forms.PictureBox();
            this.tlpTest = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPendu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMot);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "mot à chercher";
            // 
            // txtMot
            // 
            this.txtMot.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMot.Location = new System.Drawing.Point(6, 19);
            this.txtMot.MaxLength = 15;
            this.txtMot.Name = "txtMot";
            this.txtMot.Size = new System.Drawing.Size(249, 39);
            this.txtMot.TabIndex = 0;
            this.txtMot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMot_KeyPress);
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.Location = new System.Drawing.Point(12, 230);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(0, 31);
            this.lblResultat.TabIndex = 4;
            // 
            // btnRejouer
            // 
            this.btnRejouer.Image = global::JeuDuPendu.Properties.Resources.playagain;
            this.btnRejouer.Location = new System.Drawing.Point(248, 216);
            this.btnRejouer.Name = "btnRejouer";
            this.btnRejouer.Size = new System.Drawing.Size(46, 46);
            this.btnRejouer.TabIndex = 2;
            this.btnRejouer.UseVisualStyleBackColor = true;
            this.btnRejouer.Click += new System.EventHandler(this.btnRejouer_Click);
            // 
            // imgPendu
            // 
            this.imgPendu.Image = global::JeuDuPendu.Properties.Resources.pendu0;
            this.imgPendu.Location = new System.Drawing.Point(304, 12);
            this.imgPendu.Name = "imgPendu";
            this.imgPendu.Size = new System.Drawing.Size(250, 250);
            this.imgPendu.TabIndex = 1;
            this.imgPendu.TabStop = false;
            // 
            // tlpTest
            // 
            this.tlpTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpTest.ColumnCount = 9;
            this.tlpTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTest.Location = new System.Drawing.Point(18, 92);
            this.tlpTest.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTest.Name = "tlpTest";
            this.tlpTest.RowCount = 3;
            this.tlpTest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTest.Size = new System.Drawing.Size(276, 118);
            this.tlpTest.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lettres";
            // 
            // frmPendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 271);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tlpTest);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.btnRejouer);
            this.Controls.Add(this.imgPendu);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPendu";
            this.Text = "Jeu du Pendu";
            this.Load += new System.EventHandler(this.frmPendu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPendu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMot;
        private System.Windows.Forms.PictureBox imgPendu;
        private System.Windows.Forms.Button btnRejouer;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.TableLayoutPanel tlpTest;
        private System.Windows.Forms.Label label1;
    }
}

