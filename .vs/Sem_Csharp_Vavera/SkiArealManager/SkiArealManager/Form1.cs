using SkiArealManager.Data;
using SkiArealManager.Modely;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace SkiArealManager
{
    public partial class Form1 : Form
    {

        static SpravaDat spravaDat = new SpravaDat();
        private List<Sjezdovka> sjezdovky;
        private List<Vlek> vleky;
        private int nejvyssiIdSjezdovek = 1;
        private int nejvyssiIdVleku = 1;
        bool PracujuSeSjezdovkou = true; //false = vlek


        public Form1()
        {
            InitializeComponent();

            cmbVyber.DataSource = Enum.GetValues(typeof(Obtiznost));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("sjezdovky.json")) {
            sjezdovky = defaultniSjezdovky();
            spravaDat.Uloz(sjezdovky);
            }
            sjezdovky = spravaDat.Nacti();
            foreach (var s in sjezdovky)
            {
                nejvyssiIdSjezdovek = Math.Max(nejvyssiIdSjezdovek, s.Id);
            }
            foreach (var s in sjezdovky)
            {
                if (s.Vleky.Count > 0)
                {
                    nejvyssiIdVleku = Math.Max(nejvyssiIdVleku, s.Vleky[s.Vleky.Count - 1].Id);
                }
            }
            ListRefresh();
        }

        private void btnPridat_Click(object sender, EventArgs e)
        {
            if (PracujuSeSjezdovkou)
                PridatSjezdovku();
            else
                PridatVlek();
            
        }

        private void btnOdebrat_Click(object sender, EventArgs e)
        {
            if (PracujuSeSjezdovkou)
                OdebratSjezdovku();
            else
                OdebratVlek();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex == -1)
                return;

            if (PracujuSeSjezdovkou)
            {
                var vybrana = sjezdovky[listBox.SelectedIndex];

                txtNazev.Text = vybrana.Nazev;
                txtPocet.Text = vybrana.Delka.ToString();
                cmbVyber.SelectedItem = vybrana.Obtiznost;
            }
            else {
                var vybrana = vleky[listBox.SelectedIndex];

                txtNazev.Text = vybrana.Nazev;
                txtPocet.Text = vybrana.Kapacita.ToString();
                cmbVyber.SelectedItem = vybrana.Typ;
            }
        }

        private void btnEditovat_Click(object sender, EventArgs e)
        {
            if (PracujuSeSjezdovkou)
                EditovatSjezdovku();
            else
                EditovatVlek();
            txtNazev.Text = "";
            txtPocet.Text = "";
        }

        private void UpravNaVleky()
        {
            PracujuSeSjezdovkou = false;
            Sjezdovka sjezdovka = sjezdovky[listBox.SelectedIndex];

            lblInfoSjezdovkyIdNazev.Text = $"{sjezdovka.Id}, {sjezdovka.Nazev}";
            lblInfoSjezdovkyObtiznost.Text = "Obtížnost: " + sjezdovka.Obtiznost.ToString();
            lblInfoSjezdovkyDelka.Text = $"Délka: {sjezdovka.Delka.ToString()} metrů";
            lblInfoSjezdovkyIdNazev.Visible = true;
            lblInfoSjezdovkyObtiznost.Visible = true;
            lblInfoSjezdovkyDelka.Visible = true;
            btnZpet.Visible = true;

            txtNazev.Text = "";
            txtPocet.Text = "";
            lblZvolte.Text = "Zvolte typ:";
            cmbVyber.DataSource = Enum.GetValues(typeof(TypVleku));
            lblZadejtePocet.Text = "Zadejte kapacitu:";
            lblPocet.Text = "osob/hodinu";

            btnPridat.Text = "Přidat Vlek";
            btnOdebrat.Text = "Odebrat Vlek";
            btnEditovat.Text = "Editovat Vlek";
            listBox.Items.Clear();

            vleky = sjezdovka.Vleky;

            foreach(Vlek v in vleky)
            {
                listBox.Items.Add(v);
            }

            listBox.SelectedIndex = -1;
        }

        private void UpravNaSjezdovky() 
        {
            PracujuSeSjezdovkou = true;
            btnZpet.Visible = false;
            lblInfoSjezdovkyIdNazev.Visible = false;
            lblInfoSjezdovkyObtiznost.Visible = false;
            lblInfoSjezdovkyDelka.Visible = false;

            btnPridat.Text = "Přidat Sjezdovku";
            btnOdebrat.Text = "Odebrat Sjezdovku";
            btnEditovat.Text = "Editovat Sjezdovku";
            cmbVyber.DataSource = Enum.GetValues(typeof(Obtiznost));
            lblPocet.Text = "metrů";

            listBox.Items.Clear();

            foreach (Sjezdovka s in sjezdovky)
            {
                listBox.Items.Add(s);
            }
            vleky = null;
            listBox.SelectedIndex = -1;
            txtNazev.Text = "";
            txtPocet.Text = "";
        }

        private void ListRefresh() {
            listBox.Items.Clear();
            if (PracujuSeSjezdovkou)
            {
                foreach (var s in sjezdovky)
                {
                    listBox.Items.Add(s);
                }
            }
            else {
                foreach (var v in vleky)
                {
                    listBox.Items.Add(v);
                }
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

            Vlek sedackaDivTund = new Vlek(1, "TundrovkaTwoTap", 1500, TypVleku.Čtyřsedačka);
            sjezdovkaTundrovka.Vleky.Add(sedackaDivTund);

            Vlek kotvaTundrovka = new Vlek(2, "TundrovkaDeathHook", 500, TypVleku.Kotva);
            sjezdovkaTundrovka.Vleky.Add(kotvaTundrovka);

            Vlek sedackaPolarka = new Vlek(3, "PolarkaTwoTap", 1900, TypVleku.Šestisedačka);
            sjezdovkaPolarka.Vleky.Add(sedackaPolarka);

            Vlek pomaPolarka = new Vlek(4, "PolarkaPoma", 200, TypVleku.Poma);
            sjezdovkaPolarka.Vleky.Add(pomaPolarka);

            return sjezdovky;
        }

        private void polozkaDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox.SelectedIndex == -1 || PracujuSeSjezdovkou == false)
                return;
            else
            UpravNaVleky();
            
        }

        private void btnZpet_Click(object sender, EventArgs e)
        {
            UpravNaSjezdovky();
        }

        private void PridatSjezdovku()
        {
            int delka;

            if (!int.TryParse(txtPocet.Text, out delka))
            {
                MessageBox.Show("Zadej platnou délku!");
                return;
            }   else if (delka < 200 || delka > 15000)
            {
                MessageBox.Show("Umíš si to představit, jak by ta sjezdovka vypadala? Zadej hodnotu od 200 do 15 000");
                return;
            }
            

            Sjezdovka novaSjezdovka = new Sjezdovka(
                ++nejvyssiIdSjezdovek,
                txtNazev.Text,
                (Obtiznost)cmbVyber.SelectedItem,
                int.Parse(txtPocet.Text));


            sjezdovky.Add(novaSjezdovka);
            spravaDat.Uloz(sjezdovky);
            ListRefresh();

            MessageBox.Show("Přidáno!");
        }

        private void PridatVlek()
        {
            int kapacita;

            if (!int.TryParse(txtPocet.Text, out kapacita))
            {
                MessageBox.Show("Zadej platnou celočíselnou kapacitu vleku osob za hodinu!");
                return;
            }
            else if (kapacita < 100 || kapacita > 5000)
            {
                MessageBox.Show("Realizace takového vleku není reálná. Málo osob za hodinu = Málo peněz za vysoké náklady, a převézt víc než 5 000 osob za hodinu není reálné. \n Zadej hodnotu od 100 do 5 000");
                return;
            }

            Vlek novyVlek = new Vlek(
                ++nejvyssiIdVleku,
                txtNazev.Text,
                int.Parse(txtPocet.Text),
                (TypVleku)cmbVyber.SelectedItem);


            vleky.Add(novyVlek);
            spravaDat.Uloz(sjezdovky);
            ListRefresh();

            MessageBox.Show("Přidáno!");
        }

        private void OdebratSjezdovku()
        {
            if (listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Vyber sjezdovku, prosím pěkně!");
                return;
            }
            sjezdovky.RemoveAt(listBox.SelectedIndex);
            spravaDat.Uloz(sjezdovky);

            ListRefresh();
            MessageBox.Show("Smazáno!");
        }

        private void OdebratVlek()
        {
            if (listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Vyber vlek, prosím pěkně!");
                return;
            }
            vleky.RemoveAt(listBox.SelectedIndex);
            spravaDat.Uloz(sjezdovky);

            ListRefresh();
            MessageBox.Show("Smazáno!");
        }

        private void EditovatSjezdovku()
        {
            if (listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Vyber sjezdovku!");
                return;
            }
            int index = listBox.SelectedIndex;
            int delka;
            if (!int.TryParse(txtPocet.Text, out delka))
            {
                MessageBox.Show("Zadej platnou délku!");
                return;
            }
            else if (delka < 200 || delka > 15000)
            {
                MessageBox.Show("Sjezdovka s takovouhle délkou ti způsobí finanční krizi, min 200 m, max 15 km");
                return;
            }
            sjezdovky[index].Nazev = txtNazev.Text;
            sjezdovky[index].Delka = delka;
            sjezdovky[index].Obtiznost = (Obtiznost)cmbVyber.SelectedItem;
            spravaDat.Uloz(sjezdovky);
            ListRefresh(); MessageBox.Show("Upraveno!");
        }

        private void EditovatVlek()
        {
            if (listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Vyber vlek!");
                return;
            }

            int kapacita;

            if (!int.TryParse(txtPocet.Text, out kapacita))
            {
                MessageBox.Show("Zadej platnou celočíselnou kapacitu vleku osob za hodinu!");
                return;
            }
            else if (kapacita < 100 || kapacita > 5000)
            {
                MessageBox.Show("Realizace takového vleku není reálná. Málo osob za hodinu = Málo peněz za vysoké náklady, a převézt víc než 5 000 osob za hodinu není reálné. \n Zadej hodnotu od 100 do 5 000");
                return;
            }

            int index = listBox.SelectedIndex;

            vleky[index].Nazev = txtNazev.Text;
            vleky[index].Kapacita = kapacita;
            vleky[index].Typ = (TypVleku)cmbVyber.SelectedItem;
            spravaDat.Uloz(sjezdovky);
            ListRefresh(); MessageBox.Show("Upraveno!");

        }
    }
}
