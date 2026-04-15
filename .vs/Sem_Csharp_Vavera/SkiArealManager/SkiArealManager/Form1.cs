using SkiArealManager.Data;
using SkiArealManager.Modely;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SkiArealManager
{
    public partial class Form1 : Form
    {

        static SpravaDat spravaDat = new SpravaDat();
        private List<Sjezdovka> sjezdovky;


        public Form1()
        {
            InitializeComponent();

            cmbObtiznost.DataSource = Enum.GetValues(typeof(Obtiznost));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sjezdovky = defaultniSjezdovky();
            spravaDat.Uloz(sjezdovky);
            ListRefresh();
        }

        private void btnPridatSjezdovku_Click(object sender, EventArgs e)
        {
            
            int delka;

            if (!int.TryParse(txtDelkaSjezdovky.Text, out delka))
            {
                MessageBox.Show("Zadej platnou délku!");
                return;
            }

            int id;
            if (sjezdovky.Count > 0)
                id = sjezdovky[sjezdovky.Count - 1].Id + 1;
            else id = 1;

            Sjezdovka novaSjezdovka = new Sjezdovka(
                id,
                txtNazevSjezdovky.Text,
                (Obtiznost)cmbObtiznost.SelectedItem,
                int.Parse(txtDelkaSjezdovky.Text));


            sjezdovky.Add(novaSjezdovka);
            spravaDat.Uloz(sjezdovky);
            ListRefresh();

            MessageBox.Show("Sjezdovka přidána!");
        }

        private void btnOdebratSjezdovku_Click(object sender, EventArgs e)
        {
            if (listBoxSjezdovky.SelectedIndex == -1)
            {
                MessageBox.Show("Vyber sjezdovku!");
                return;
            }
            sjezdovky.RemoveAt(listBoxSjezdovky.SelectedIndex);
            spravaDat.Uloz(sjezdovky);

            ListRefresh();

            MessageBox.Show("Smazáno!");
        }

        private void listBoxSjezdovky_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSjezdovky.SelectedIndex == -1)
                return;

            var vybrana = sjezdovky[listBoxSjezdovky.SelectedIndex];

            txtNazevSjezdovky.Text = vybrana.Nazev;
            txtDelkaSjezdovky.Text = vybrana.Delka.ToString();
            cmbObtiznost.SelectedItem = vybrana.Obtiznost;
        }

        private void btnEditovatSjezdovku_Click(object sender, EventArgs e)
        {
            if (listBoxSjezdovky.SelectedIndex == -1)
            {
                MessageBox.Show("Vyber sjezdovku!");
                return;
            }

            int index = listBoxSjezdovky.SelectedIndex;

            int delka;
            if (!int.TryParse(txtDelkaSjezdovky.Text, out delka))
            {
                MessageBox.Show("Zadej platnou délku!");
                return;
            }
            sjezdovky[index].Nazev = txtNazevSjezdovky.Text;
            sjezdovky[index].Delka = delka;
            sjezdovky[index].Obtiznost = (Obtiznost)cmbObtiznost.SelectedItem;

            spravaDat.Uloz(sjezdovky);
            ListRefresh();

            MessageBox.Show("Upraveno!");
        }

        private void ListRefresh() {
            List<Sjezdovka> sjezdovky = spravaDat.Nacti();

            listBoxSjezdovky.Items.Clear();
            foreach (var s in sjezdovky)
            {
                listBoxSjezdovky.Items.Add(new Sjezdovka(s.Id, s.Nazev, s.Obtiznost, s.Delka));
            }

        }
        private List<Sjezdovka> defaultniSjezdovky() { 
        
            sjezdovky = new List<Sjezdovka>();
            Sjezdovka sjezdovkaTundrovka = new Sjezdovka(1, "Tundrovka", Obtiznost.Červená, 1800);


            Sjezdovka sjezdovkaDivoska = new Sjezdovka(2, "Divoška", Obtiznost.Černá, 1200);

            Sjezdovka sjezdovkaPolarka = new Sjezdovka(3, "Polárka", Obtiznost.Žlutá, 2150);

            sjezdovky.Add(sjezdovkaTundrovka);
            sjezdovky.Add(sjezdovkaDivoska);
            sjezdovky.Add(sjezdovkaPolarka);

            Vlek sedackaTundrovka = new Vlek();
            sedackaTundrovka.Id = 1;
            sedackaTundrovka.Nazev = "sedačková lanovka Tundrovka";
            sedackaTundrovka.Kapacita = 1500;

            sjezdovkaTundrovka.Vleky.Add(sedackaTundrovka);

            Vlek kotvaTundrovka = new Vlek();
            kotvaTundrovka.Id = 2;
            kotvaTundrovka.Nazev = "kotva Tundrovka";
            kotvaTundrovka.Kapacita = 100;

            sjezdovkaTundrovka.Vleky.Add(kotvaTundrovka);

            return sjezdovky;
        }
    }
}
