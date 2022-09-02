using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CreateurGroupe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Console.WriteLine(lsboxNomEleve.Items.Count);
            if (!String.IsNullOrWhiteSpace(tboxNomEleve.Text) && !String.IsNullOrEmpty(tboxNomEleve.Text))
            {
                int i;
                for (i = 0; i < lsboxNomEleve.Items.Count; i++)
                {
                    if (lsboxNomEleve.Items.Contains(tboxNomEleve.Text))
                    {
                        lsboxNomEleve.Items.Remove(tboxNomEleve.Text);
                    }
                }
                lsboxNomEleve.Items.Add(tboxNomEleve.Text);
                tboxNomEleve.Text = "";
            }
            else
            {
                MessageBox.Show("Aucun nom d'élève n'a été inséré!", "GDG - Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void BtnRegGroupe_Click(object sender, EventArgs e)
        {
            lsBoxGroupe.Items.Clear();

            Random rnd = new Random();

            int nbEleves = lsboxNomEleve.Items.Count;
            int nbGroupes = (int)udNbGroupe.Value;

            int ElevesParGrps = nbEleves / nbGroupes;

            Console.WriteLine(ElevesParGrps);

            Console.WriteLine(nbEleves + ", " + nbGroupes);

            for (int i = 0; i < nbGroupes; i++)
            {
                lsBoxGroupe.Items.Add("Groupe - " + (i + 1));
                for (int j = 0; j < ElevesParGrps; j++)
                {
                    int EleveChoisi = rnd.Next(0, nbEleves);
                    if (!lsBoxGroupe.Items.Contains(lsboxNomEleve.Items[EleveChoisi]))
                    {
                        lsBoxGroupe.Items.Add(lsboxNomEleve.Items[EleveChoisi]);
                    }
                    else
                    {
                        j--;
                    }
                }
            }

            for (int l = 0; l < nbEleves; l++)
            {
                if (!lsBoxGroupe.Items.Contains(lsboxNomEleve.Items[nbEleves - 1]))
                {
                    lsBoxGroupe.Items.Add(lsboxNomEleve.Items[nbEleves - 1]);
                }
            }
        }

        private void btnRetirer_Click(object sender, EventArgs e)
        {
            if ((lsboxNomEleve.SelectedIndex == -1))
            {
                MessageBox.Show("Aucun nom d'élève n'est selectionné!", "GDG - Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lsboxNomEleve.Items.Remove(lsboxNomEleve.SelectedItem);
            }
        }

        private void btnRetirerTout_Click(object sender, EventArgs e)
        {
            if (lsboxNomEleve.Items.Count > 0)
            {
                lsboxNomEleve.Items.Clear();
                lsBoxGroupe.Items.Clear();
            }
            else
            {
                MessageBox.Show("Il faut y avoir plus qu'un élève dans la boite!", "GDG - Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImporter_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Parcourir les fichiers de configuration";
            ofd.InitialDirectory = Path.Combine(Application.StartupPath);
            ofd.Filter = "fichier TXT (*.txt)|*.txt";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lsboxNomEleve.Items.Clear();
                lsBoxGroupe.Items.Clear();

                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(ofd.OpenFile()))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        lsboxNomEleve.Items.Add(line);
                    }
                }

                MessageBox.Show("Configuration importé avec succèes!", "GDG - Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            if (lsboxNomEleve.Items.Count > 0)
            {
                using (TextWriter TW = new StreamWriter("ListeEleves.txt"))
                {
                    int i;
                    for (i = 0; i < lsboxNomEleve.Items.Count; i++)
                    {
                        TW.WriteLine(lsboxNomEleve.Items[i].ToString());
                    }
                }

                if(lsboxNomEleve.Items.Count > 0)
                {
                    MessageBox.Show("Configuration sauvegarder avec succèes!", "GDG - Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vérifier bien qu'il y a des élèves dans la boite (Liste des élèves)!", "GDG - Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("© Copyright 2022 | Nicolas Carrière", "GDG - Crédits",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAide_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://tinyurl.com/mreuhd4a");
        }
    }
}
