namespace SkiArealManager.Modely
{
    public class Vlek
    {
        public int Id { get; set; }
        public string Nazev { get; set; }
        public int Kapacita { get; set; }
        public TypVleku Typ { get; set; }

        public Vlek(int id, string nazev, int kapacita, TypVleku typ)
        {
            Id = id;
            Nazev = nazev;
            Kapacita = kapacita;
            Typ = typ;
        }

        public Vlek() { }
        public override string ToString()
        {
            return $"{Id}, {Nazev}, kapacita: {Kapacita}, typ: {Typ}";
        }
    }
}
