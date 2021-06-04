using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tirage_Champions.Properties;

namespace Tirage_Champions
{
    public partial class Tirage : Form
    {
        public Tirage()
        {
            InitializeComponent();
        }

        class TirageClass //Création d'une classe dans laquelle nous avons une liste
        {
            public static List<string> ChampionsList = new List<string>(); //Création de la liste
            public static ManageList ML = new ManageList();
        }

        private void Tirage_Load(object sender, EventArgs e) //Au démarrage de l'application
        {
            TirageClass.ChampionsList.AddRange(Settings.Default["ChampionsNames"].ToString().Split(',')); //Ajout d'éléments dans la liste venant des options de l'application
            TirageClass.ChampionsList.Sort(); //On trie la liste dans l'ordre alphabétique

            RefreshForm();
        }

        private void selectAll_Click(object sender, EventArgs e) //Bouton sélectionner
        {
            foreach(Panel panel in championsBox.Controls.OfType<Panel>()) //Boucle "foreach" on récupère tout les panels
            {
                if (panel.BackColor == Color.FromArgb(255, 153, 171, 181)) //Si le BackColor du panel est par défaut on le met en bleu
                {
                    Label lbl = (Label)panel.Controls[0];
                    label_Click(lbl, null);
                }
            }
        }

        private void clearAll_Click(object sender, EventArgs e) //Tout déslectionner
        {
            foreach (Panel panel in championsBox.Controls.OfType<Panel>()) //Boucle "foreach" on récupère tout les panels
            {
                if (panel.BackColor != Color.FromArgb(255, 153, 171, 181)) //Si le BackColor du panel n'est pas celle par défaut on la met en défaut (gris)
                {
                    Label lbl = (Label)panel.Controls[0];
                    label_Click(lbl, null);
                }
            }
        }

        private void label_Click(object sender, EventArgs e) //Clique sur label
        {
            Label lbl = (Label)sender; //Cast du "sender"

            if (lbl.Parent.BackColor == Color.FromArgb(255, 153, 171, 181)) //Si le fond est gris on le met en bleu
            {
                lbl.Parent.BackColor = Color.FromArgb(255, 114, 137, 218);
                Settings.Default["ChampionsSelected"] += lbl.Text; //Et on ajoute le champion aux sélectionnés
            }
            else if (lbl.Parent.BackColor != Color.Transparent) //Si le fond est différent de transparent on le met par défaut (gris)
            {
                lbl.Parent.BackColor = Color.FromArgb(255, 153, 171, 181);
                Settings.Default["ChampionsSelected"] = Settings.Default["ChampionsSelected"].ToString().Replace(lbl.Text, ""); //Et on enlève le champion des sélectionnés
            }

            Settings.Default.Save(); //On sauvegarde la liste des sélectionnés
        }

        private void RandomChampion_Click(object sender, EventArgs e) //bouton Tirage champion
        {
            if (Settings.Default["ChampionsSelected"].ToString().Length > 3)
            {
                bool find = false; //Création d'une "bool" 

                Random r = new Random(); //Initialisation de la fonction "Random"
                int championIndex = 0; //Initialisation du résultat de "Random"

                while (!find) //Boucle "while" tant que find n'est pas égal à true
                {
                    championIndex = r.Next(0, TirageClass.ChampionsList.Count - 1); //Assignation de la valeur "Random"

                    if (Settings.Default["ChampionsSelected"].ToString().Contains(TirageClass.ChampionsList[championIndex]))
                        find = true;
                }

                championName.Text = TirageClass.ChampionsList[championIndex]; //Affichage du nom du champion trouvé
            } else
            {
                MessageBox.Show("Vous n'avez sélectionné aucun champion");
            }
            
        }

        private void editerLaListeDesChampionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TirageClass.ML.FormClosing += (s, ev) => RefreshForm();
            TirageClass.ML.ShowDialog();
        }

        public void RefreshForm()
        {
            int index = 0,
                elements = 0;

            foreach (string str in TirageClass.ChampionsList)
            {
                if (Settings.Default["ChampionsForHasard"].ToString().Contains(str))
                {
                    Label lbl = (Label)championsBox.Controls[elements].Controls[0]; //Récupération du panel
                    lbl.Text = TirageClass.ChampionsList[index]; //Ajout du texte
                    lbl.Enabled = true;
                    if (Settings.Default["ChampionsSelected"].ToString().Contains(TirageClass.ChampionsList[index])) //Si le champion était sélectionné la fois précédente on le sélectionne à nouveau
                        lbl.Parent.BackColor = Color.FromArgb(255, 114, 137, 218);
                    else //Sinon on lui assigne le BackColor par défaut
                        lbl.Parent.BackColor = Color.FromArgb(255, 153, 171, 181);

                    elements++;
                } else if (index < 12)
                {
                    Label lbl = (Label)championsBox.Controls[index].Controls[0]; //Récupération du panel
                    lbl.Text = "";
                    lbl.Parent.BackColor = Color.Transparent;
                    lbl.Enabled = false;
                }
                index++;

                if (elements > 11)
                    break;
            }

            Console.WriteLine("Form Closed?");
        }
    }
}
