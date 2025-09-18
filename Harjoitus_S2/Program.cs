namespace Harjoitus_S2_Maksym_Kotlubaiev;
// Tehtävä 2: Opiskelijat ja kurssien arvosanat
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        /*Vaihe 3: Pääohjelman toteutus
        Pääohjelmassa käyttäjä voi lisätä opiskelijoita, 
        lisätä kursseja opiskelijoille, 
        tarkastella opiskelijan kursseja ja 
        laskea opiskelijan keskiarvon.*/
        List<Opiskelija> opiskelijat = new List<Opiskelija>();
        
        // Lisätään 3 opiskelijaa testiksi:
        Opiskelija opiskelija1 = new Opiskelija("Maxim");
        opiskelija1.LisaaKurssi(new Kurssi("Olio-ohjelmointi", 5));
        opiskelija1.LisaaKurssi(new Kurssi("Peliohjelmointi", 5));
        opiskelijat.Add(opiskelija1);

        Opiskelija opiskelija2 = new Opiskelija("Mikko");
        opiskelija2.LisaaKurssi(new Kurssi("Peliohjelmointi", 4));
        opiskelija2.LisaaKurssi(new Kurssi("Ketterä järjestelmäkehitys", 2));
        opiskelijat.Add(opiskelija2);

        Opiskelija opiskelija3 = new Opiskelija("Johaanna");
        opiskelija3.LisaaKurssi(new Kurssi("Viestintä", 5));
        opiskelija3.LisaaKurssi(new Kurssi("Ketterä järjestelmäkehitys", 3));
        opiskelijat.Add(opiskelija3);

        while (true)
        {
            Console.Write("\nSyötä numero:\n1 = Lisätä opiskelija,\n2 = Lisätä kurssi opiskelijalle,\n3 = Näyttää opiskelijan kurssit,\n4 = Laskea opiskelijan keskiarvo,\n0 = Lopettaa ohjelman\n");
            string numero = Console.ReadLine();

            if (numero == "0") break;

            else if (numero == "1")
            {
                Console.Write("\nSyötä opiskelijan nimi:\n");
                string name = Console.ReadLine();
                opiskelijat.Add(new Opiskelija(name));
            }

            else if (numero == "2") // AI from Visual Studio Code suggested this code to me, checked it, everything works as it should
            {
                Console.Write("\nSyötä opiskelijan nimi:\n");
                string name = Console.ReadLine();
                Opiskelija opiskelija = opiskelijat.Find(o => o.Nimi == name);
                if (opiskelija != null)
                {
                    Console.Write("\nSyötä kurssin nimi:\n");
                    string kurssiNimi = Console.ReadLine();
                    Console.Write("Arvosana (0-5):\n");
                    int arvosana;
                    while (!int.TryParse(Console.ReadLine(), out arvosana) || arvosana < 0 || arvosana > 5)
                    {
                        Console.Write("Virheellinen syöte. Syötä arvosana (0-5):\n");
                    }
                    opiskelija.LisaaKurssi(new Kurssi(kurssiNimi, arvosana));
                }
                else
                {
                    Console.WriteLine("Opiskelijaa ei löydy.");
                }
            }

            else if (numero == "3") // AI from Visual Studio Code again suggested this code to me
            {
                Console.Write("\nSyötä opiskelijan nimi:\n");
                string name = Console.ReadLine();
                Opiskelija opiskelija = opiskelijat.Find(o => o.Nimi == name);
                if (opiskelija != null)
                {
                    Console.WriteLine($"\n{opiskelija.Nimi} kurssit ja arvosanat:");
                    foreach (var kurssi in opiskelija.Kurssit)
                    {
                        Console.WriteLine($"- {kurssi.Nimi}: {kurssi.Arvosana}");
                    }
                }
                else
                {
                    Console.WriteLine("Opiskelijaa ei löydy.");
                }
            }

            else if (numero == "4")
            {
                Console.Write("\nSyötä opiskelijan nimi:\n");
                string name = Console.ReadLine();
                Opiskelija opiskelija = opiskelijat.Find(o => o.Nimi == name);
                if (opiskelija != null)
                {
                    Console.WriteLine($"{opiskelija.Nimi} keskiarvo: {opiskelija.Keskiarvo()}");
                }
                else
                {
                    Console.WriteLine("Opiskelijaa ei löydy.");
                }
            }

            else
            {
                Console.WriteLine("Virheellinen syöte, yritä uudelleen.");
            }
        }
    }
}

/*Vaihe 1: Luo Kurssi-luokka
Kurssi-luokka edustaa yksittäistä kurssia. Siinä on seuraavat ominaisuudet:
Ominaisuudet: Nimi ja Arvosana.
Metodit: Konstruktorin avulla luodaan uusia kursseja.*/
class Kurssi
{
    public string Nimi { get; set; }
    public int Arvosana { get; set; }

    public Kurssi(string nimi, int arvosana)
    {
        Nimi = nimi;
        Arvosana = arvosana;
    }
}

/*Vaihe 2: Luo Opiskelija-luokka
Opiskelija-luokka edustaa yksittäistä opiskelijaa, 
olla on lista kursseista ja toimintoja kurssien lisäämiseen ja keskiarvon laskemiseen.*/
class Opiskelija
{
    public string Nimi { get; set; }
    public List<Kurssi> Kurssit { get; set; }

    public Opiskelija(string nimi)
    {
        Nimi = nimi;
        Kurssit = new List<Kurssi>();
    }

    // Toimintoja kurssien lisäämiseen
    public void LisaaKurssi(Kurssi kurssi)
    {
        Kurssit.Add(kurssi);
    }

    // Toimintoja keskiarvon laskemiseen
    public double Keskiarvo()
    {
        if (Kurssit.Count == 0) return 0; // If there are no courses, return 0
        else return Kurssit.Average(k => k.Arvosana); // Average calculates the arithmetic mean of the Kurssit
    }
}
