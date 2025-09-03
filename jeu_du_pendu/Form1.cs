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

        // Variable global
        private int nbEssai;
        string motATrouver;
        int phase = 1;

        /// <summary>
        /// Procédure de remplissage du combo grace au code ascii de tout l'alphabet
        /// </summary>
        private void RemplissageCombo()
        { 
            cbbChoixlettre.Items.Clear();
            for (int i = 65; i < 91; i++)
            {
                cbbChoixlettre.Items.Add((char)i);
            }
        }

        /// <summary>
        /// Fonction pour vérifier le mot a trouver envoyé par le joueur 1
        /// </summary>
        /// <param name="mot">le mot qui est vérifié</param>
        /// <returns>retourne true si le mot est valide et false s'il ne l'est pas</returns>
        private bool VerifMotATrouver(string mot)
        {
            if (motATrouver != "")
            { 
                foreach (int lettre in mot)
                {
                    if (!(lettre >= 65 && lettre <= 90))
                    {
                        return false;
                    }
                }
                return true;
            }
            else { return false; }
        }

        /// <summary>
        /// Code émis lors du lancement de l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // On rempli le combo box qui contient toutes les lettres de l'alphabet
            RemplissageCombo();
            // Mise en place des textes
            lblLettres.Text = "";
            cbbChoixlettre.Text = "";
            txtMotachercher.Text = "";
            lblResult.Text = "";
            btnPlay.Text = "Jouer";

            // Mise en sécurité des éléments graphique
            txtMotachercher.Enabled = true;
            cbbChoixlettre.Enabled = false;
            btnTest.Enabled = false;
            
            // Focus sur l'entrée du mot pour le joueur 1
            txtMotachercher.Focus();

            // Initialisation du nombre d'essai à 0 et mise en place de l'image 0 du pendu
            nbEssai = 0;
            string dossier = "C:\\Users\\ctao\\Documents\\CNED\\sequence2\\seance1\\jeu_du_pendu\\jeu_du_pendu\\Resources\\";
            picPendu.Load(dossier + "pendu" + nbEssai + ".png");
        }

        /// <summary>
        /// Procédure de la phase 1 de l'application le joueur 1 qui choisi le mot
        /// </summary>
        private void Phase1()
        {
            // Récupération du mot est mise en majuscule
            motATrouver = txtMotachercher.Text.ToUpper();

            // Vérification du mot entré
            if (VerifMotATrouver(motATrouver))
            {
                // Vider la zone d'entré du mot du joueur 1
                txtMotachercher.Text = "";

                // Remplassement du mot par des underscores
                for (int i = 0; i < motATrouver.Length; i++)
                {
                    txtMotachercher.Text += "_";
                }

                // Variable de phase 2
                phase = 2;

                // Sécurisation des éléments graphique
                cbbChoixlettre.Enabled = true;
                btnTest.Enabled = true;
                txtMotachercher.Enabled = false;
                
                // Changement du texte du bouton jouer pour relancer à tout moment le jeu
                btnPlay.Text = "Rejouer";
            }
            else
            {
                // Si le mot n'est pas valide mise à 0 de la zone de texte
                txtMotachercher.Text = "";
            }
        }

        /// <summary>
        /// Procédure de lancement de la phase 2 le joueur 2 choisi une lettre pour trouver le mot
        /// </summary>
        private void Phase2()
        {
            // Récupération de n'importe quelle erreur lors du choix de la lettre
            try
            {
                // Focus sur le choix de la lettre pour le joueur 2
                cbbChoixlettre.Focus();
                
                // Variables
                string motCache = txtMotachercher.Text, newMot = "";
                bool lettrePresente = false;

                // Création d'une chaine de char pour accueillir le mot à trouver
                char[] newMotCharArray;
                newMotCharArray = motCache.ToCharArray();

                // Création d'une deuxième chaine de char pour récupérer l'entré de la lettre du joueur 2
                char[] lettres = cbbChoixlettre.Text.ToUpper().ToCharArray();
                char lettre = lettres[0];

                // Vérification si la lettre n'a pas déjà était utilisé
                if (!lblLettres.Text.Contains(lettre))
                {
                    // Boucle sur le mot pour vérifier lettre par lettre si le mot contient la lettre choisi
                    for (int i = 0; i < motATrouver.Length; i++)
                    { 
                        if (lettre == motATrouver[i])
                        {
                            newMotCharArray[i] = lettre;
                            lettrePresente = true;
                        }
                        // Création du nouveau mot à afficher pour le joueur 2 avec le ou les lettres qui remplacent les underscores
                        newMot += newMotCharArray[i].ToString();
                    }

                    // Si la lettre est présente
                    if (lettrePresente)
                    {
                        // Changement du mot
                        txtMotachercher.Text = newMot;
                    }
                    // Si la lettre n'est pas présente
                    else
                    {
                        // Changement de l'image du pendu
                        string dossier = "C:\\Users\\ctao\\Documents\\CNED\\sequence2\\seance1\\jeu_du_pendu\\jeu_du_pendu\\Resources\\";
                        picPendu.Load(dossier + "pendu" + (nbEssai + 1) + ".png");
                        // Ajout de 1 au nombre d'essai
                        nbEssai++;
                    }
                    // Ajout de la lettre dans l'affichage des lettres utilisées
                    lblLettres.Text += lettre;

                    // Suppression de la lettre utiliser dans le combo box pour ne pas être réutilisé
                    cbbChoixlettre.Items.Remove(cbbChoixlettre.SelectedItem);

                    // Focus mis sur le combobox
                    cbbChoixlettre.Focus();

                    // Vérification du nombre d'essai si tous les essais sont utilisé partie perdu
                    if (nbEssai > 9)
                    {
                        // Sécurisation des éléments graphique
                        txtMotachercher.Enabled = false;
                        cbbChoixlettre.Enabled = false;
                        btnTest.Enabled = false;
                        // Affichage du resultat de la partie
                        lblResult.Text = "Perdu !";
                    }
                    // Vérification si le mot est trouvé
                    if (motATrouver == newMot)
                    {
                        // Sécurisation des éléments graphique
                        txtMotachercher.Enabled = false;
                        cbbChoixlettre.Enabled = false;
                        btnTest.Enabled = false;
                        // Affichage du resultat de la partie
                        lblResult.Text = "Gagné !";
                    }

                }
                // Si la lettre à déjà était utilisé mise à 0 de la case combo box
                else { cbbChoixlettre.Text = ""; }

            }
            catch { }
        }

        /// <summary>
        /// Procédure d'appui du bouton jouer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            // Vérification de la phase
            if (phase == 1)
            {
                // Appel de la procédure de la phase 1 pour le joueur 1 une fois le mot à chercher entrée
                Phase1();
            }
            else
            {
                // Recommencement de la partie sur la phase 1
                Form1_Load(null, null);
                phase = 1;
            }
        }

        /// <summary>
        /// Procédure d'appui sur le bouton de test d'une lettre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTest_Click(object sender, EventArgs e)
        {
            // Appel de la procédure phase 2 pour l'action du joueur 2
            Phase2();
        }
        
        /// <summary>
        /// Procédure lors du choix d'une lettre dans le combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbChoixlettre_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mise du focus sur le bouton test
            btnTest.Focus();
        }

        /// <summary>
        /// Procédure pour vérifier si l'on appuie sur entrer pour augmenter l'ergonomie du jeu pour la phase 1 ( joueur 1 )
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMotachercher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Phase1();
            }
        }

        /// <summary>
        /// Procédure pour vérifier si l'on appuie sur entrer pour augmenter l'ergonomie du jeu pour la phase 2 ( joueur 2 )
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbChoixlettre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Phase2();
            }
        }
    }
}
