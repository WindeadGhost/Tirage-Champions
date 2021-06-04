using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tirage_Champions.Properties;

namespace Tirage_Champions
{
    public partial class ManageList : Form
    {
        public ManageList()
        {
            InitializeComponent();
        }

        class ManageListClass
        {
            public static List<string> AvailableList = new List<string>(); //Création de la liste
        }

        private void ManageList_Load(object sender, EventArgs e)
        {
            ManageListClass.AvailableList.AddRange(Settings.Default["ChampionsNames"].ToString().Split(',')); //Ajout d'éléments dans la liste venant des options de l'application
            ManageListClass.AvailableList.Sort(); //On trie la liste dans l'ordre alphabétique

            RefreshList();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            if (ChampionsAvailable.SelectedItem != null && Selected.Items.Count < 12)
            {
                string addChampion = ChampionsAvailable.SelectedItem.ToString();

                if (!Settings.Default["ChampionsForHasard"].ToString().Contains(addChampion))
                {
                    Settings.Default["ChampionsForHasard"] += addChampion;
                    Settings.Default.Save();

                    RefreshList();
                }
            } else if (Selected.Items.Count >= 12)
            {
                MessageBox.Show("Vous ne pouvez sélectionner que 12 champions");
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (Selected.SelectedItem != null)
            {
                string removeChampion = Selected.SelectedItem.ToString(),
                    Hasard = Settings.Default["ChampionsForHasard"].ToString(),
                    Select = Settings.Default["ChampionsSelected"].ToString();

                Settings.Default["ChampionsForHasard"] = Hasard.Replace(removeChampion, "");
                Settings.Default["ChampionsSelected"] = Select.Replace(removeChampion, "");
                Settings.Default.Save();

                RefreshList();
            }
        }

        private void RefreshList()
        {
            ChampionsAvailable.Items.Clear();
            Selected.Items.Clear();

            foreach (string str in ManageListClass.AvailableList)
            {
                if (!Settings.Default["ChampionsForHasard"].ToString().Contains(str))
                    ChampionsAvailable.Items.Add(str);
                else
                    Selected.Items.Add(str);
            }
        }

        private void Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageList_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManageListClass.AvailableList.Clear();
        }
    }
}
