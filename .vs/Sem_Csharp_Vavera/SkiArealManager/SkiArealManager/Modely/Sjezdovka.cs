using System.Collections.Generic;

namespace SkiArealManager.Modely
{
    public class Sjezdovka
    {
        public int Id { get; set; }

        public string Nazev { get; set; }

        public Obtiznost Obtiznost { get; set; }

        public int Delka { get; set; }

        public List<Vlek> Vleky { get; set; } = new List<Vlek>();

        public Sjezdovka(int id, string nazev, Obtiznost obtiznost, int delka)
        {
            Id = id;
            Nazev = nazev;
            Obtiznost = obtiznost;
            Delka = delka;
        }

        public Sjezdovka() { }

        public override string ToString()
        {
            return $"{Id}, {Nazev}, obtížnost: {Obtiznost}, délka: {Delka} metrů";
        }
    }
}
