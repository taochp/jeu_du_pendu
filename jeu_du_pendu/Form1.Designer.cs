namespace jeu_du_pendu
{
    partial class Form1
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
            this.cbbChoixlettre = new System.Windows.Forms.ComboBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.lblLettres = new System.Windows.Forms.Label();
            this.picPendu = new System.Windows.Forms.PictureBox();
            this.txtMotachercher = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPendu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbChoixlettre
            // 
            this.cbbChoixlettre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChoixlettre.FormattingEnabled = true;
            this.cbbChoixlettre.Location = new System.Drawing.Point(10, 19);
            this.cbbChoixlettre.Name = "cbbChoixlettre";
            this.cbbChoixlettre.Size = new System.Drawing.Size(36, 28);
            this.cbbChoixlettre.TabIndex = 3;
            this.cbbChoixlettre.SelectedIndexChanged += new System.EventHandler(this.cbbChoixlettre_SelectedIndexChanged);
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(62, 19);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(82, 28);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "TESTER";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblLettres
            // 
            this.lblLettres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLettres.Location = new System.Drawing.Point(6, 62);
            this.lblLettres.Name = "lblLettres";
            this.lblLettres.Size = new System.Drawing.Size(213, 49);
            this.lblLettres.TabIndex = 6;
            this.lblLettres.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            // 
            // picPendu
            // 
            this.picPendu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPendu.Image = global::jeu_du_pendu.Properties.Resources.pendu0;
            this.picPendu.Location = new System.Drawing.Point(261, 12);
            this.picPendu.Name = "picPendu";
            this.picPendu.Size = new System.Drawing.Size(250, 250);
            this.picPendu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPendu.TabIndex = 7;
            this.picPendu.TabStop = false;
            // 
            // txtMotachercher
            // 
            this.txtMotachercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotachercher.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtMotachercher.Location = new System.Drawing.Point(16, 19);
            this.txtMotachercher.MaxLength = 15;
            this.txtMotachercher.Name = "txtMotachercher";
            this.txtMotachercher.Size = new System.Drawing.Size(203, 26);
            this.txtMotachercher.TabIndex = 0;
            this.txtMotachercher.Text = "GGGGGGGGGGGGGGG";
            this.txtMotachercher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMotachercher.TextChanged += new System.EventHandler(this.txtMotachercher_TextChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(133, 223);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(113, 39);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "JOUER";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMotachercher);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 58);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "mot à chercher";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLettres);
            this.groupBox2.Controls.Add(this.cbbChoixlettre);
            this.groupBox2.Controls.Add(this.btnTest);
            this.groupBox2.Location = new System.Drawing.Point(12, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 125);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "lettre testées";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(17, 228);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(90, 26);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "PERDU";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 269);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.picPendu);
            this.Name = "Form1";
            this.Text = "Jeu du pendu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPendu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbChoixlettre;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblLettres;
        private System.Windows.Forms.PictureBox picPendu;
        private System.Windows.Forms.TextBox txtMotachercher;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblResult;
    }
}

