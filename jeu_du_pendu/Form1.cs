using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jeu_du_pendu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int nbEssai;
        string motATrouver;
        private void RemplissageCombo()
        {
            cbbChoixlettre.Items.Clear();
            for (int i = 65; i < 91; i++)
            {
                cbbChoixlettre.Items.Add((char)i);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RemplissageCombo();
            lblLettres.Text = "";
            cbbChoixlettre.Enabled = false;
            btnTest.Enabled = false;
            txtMotachercher.Text = "";
            lblResult.Text = "";
            nbEssai = 1;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string motAAfficher= "";
            motATrouver = txtMotachercher.Text;
            txtMotachercher.Text = "";
            for (int i = 0; i < motATrouver.Length; i++)
            {
                motAAfficher += "F";
                if (i < motATrouver.Length - 1)
                {
                    motAAfficher += " ";
                }
            }
            txtMotachercher.BackColor = Color.White;
            btnPlay.Text = "REJOUER";
            txtMotachercher.Text = motAAfficher;
            cbbChoixlettre.Focus();
            cbbChoixlettre.Enabled = true;
            btnTest.Enabled = true;
            txtMotachercher.Enabled = false;

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbChoixlettre.SelectedItem != null)
                {
                    lblLettres.Text += cbbChoixlettre.Text;
                    cbbChoixlettre.Items.Remove(cbbChoixlettre.SelectedItem);
                }
            }
            catch { }
            string dossier = "C:\\Users\\ctao\\Documents\\CNED\\sequence2\\seance1\\jeu_du_pendu\\jeu_du_pendu\\Resources\\";
            picPendu.Load(dossier + "pendu" + nbEssai + ".png");
            nbEssai++;
        }

        private void txtMotachercher_TextChanged(object sender, EventArgs e)
        {
            foreach (int lettre in txtMotachercher.Text)
            {
                if (!(lettre >= 65 && lettre <= 90))
                {
                    txtMotachercher.Text = "";
                }
            }
        }

        private void cbbChoixlettre_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTest.Focus();
        }
    }
}
