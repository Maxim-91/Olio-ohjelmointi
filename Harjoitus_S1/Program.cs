namespace Harjoitus_S1_Maksym_Kotlubaiev;
//Tehtävä 1: Kirjaston kirjat
class Program
{
    
    static void Main(string[] args)
    {
        /*Vaihe 3: Pääohjelman toteutus
        Pääohjelmassa käyttäjä voi lisätä kirjoja, poistaa kirjoja ISBN-numeron perusteella ja listata kaikki kirjat.*/

        Kirjasto kirjasto = new Kirjasto();
        
        // Lisään 3 kirjaa koodin testaamiseksi:
        kirjasto.LisaaKirja(new Kirja("Kirja 1", "Kirjoittaja A, Kirjoittaja B", "111-111"));
        kirjasto.LisaaKirja(new Kirja("Kirja 2", "Mikko", "222-222"));
        kirjasto.LisaaKirja(new Kirja("Kirja 3", "Juha, Johanna", "333"));

        while (true)
        {
            Console.Write("\nSyötä numero:\n1 = Lisätä kirjan,\n2 = Poistaa kirjan,\n3 = Näyttää kaikki kirjat,\n0 = Lopettaa ohjelman\n");
            string numero = Console.ReadLine();

            if (numero == "0") break;

            else if (numero == "1")
            {
                Console.Write("Nimi:\n");
                string name = Console.ReadLine();
                Console.Write("Kirjoittaja:\n");
                string writer = Console.ReadLine();
                Console.Write("ISBN:\n");
                string isbn = Console.ReadLine();
                kirjasto.LisaaKirja(new Kirja(name, writer, isbn));
            }

            else if (numero == "2")
            {
                Console.Write("Syötä poistettavan kirjan ISBN:\n");
                string isbn = Console.ReadLine();
                kirjasto.PoistaKirja(isbn);
            }

            else if (numero == "3")
            {
                Console.WriteLine("\nLuettelo kaikista kirjoista (Nimi, Kirjoittajat, ISBN):\n");
                kirjasto.ListaaKirjat();
            }

            else
            {
                Console.WriteLine("Virheellinen syöte, yritä uudelleen.");
            }
        }
            
    }

    /* Vaihe 1: Luo Kirja-luokka
    Kirja-luokka sisältää seuraavat ominaisuudet:
    • Ominaisuudet: Nimi, Kirjoittaja, ISBN.
    • Metodit: Konstruktorin avulla luodaan uusia kirjoja. */
    public class Kirja
    {
        public string Nimi { get; set; }
        public string Kirjoittaja { get; set; }
        public string ISBN { get; set; }

        public Kirja(string nimi, string kirjoittaja, string isbn)
        {
            Nimi = nimi;
            Kirjoittaja = kirjoittaja;
            ISBN = isbn;
        }
    }

    /* Vaihe 2: Luo Kirjasto-luokka
    Kirjasto-luokka vastaa kirjakokoelman hallinnasta. 
    Tähän luokkaan kuuluu lista Kirja-olioista ja metodeja kirjojen lisäämiseen, poistamiseen ja listaamiseen.*/
    public class Kirjasto
    {
        private List<Kirja> kirjat = new List<Kirja>();

        // Metodi kirjojen lisäämiseen
        public void LisaaKirja(Kirja kirja)
        {
            kirjat.Add(kirja);
        }

        // Metodi poistamiseen
        public void PoistaKirja(string isbn)
        {
            kirjat.RemoveAll(k => k.ISBN == isbn);
        }

        // Metodi listaamiseen
        public void ListaaKirjat()
        {
            foreach (var kirja in kirjat)
            {
                Console.WriteLine($"{kirja.Nimi}, {kirja.Kirjoittaja}, {kirja.ISBN}");
            }
        }
    }

}
