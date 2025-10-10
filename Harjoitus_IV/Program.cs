namespace Harjoitus_IV_Maksym_Kotlubaiev;

class Program
{
    static void Main(string[] args)
    {
        /* Harjoitus 5.
            Tehtävä 4. Toteuta Main metodissa seuraavat asiat
                a. Luot kaksi hahmoa (esim. Varas ja Soturi)
                b. Luot kaksi asetta (esim. Nuija ja Miekka)
                c. Asetat Hahmoille käyttöön aseet
                d. Hahmot hyökkäävät toistensa kimppuun vuorotellen (yhden kerran)
                e. Tulosta hahmojen tilat ennen ja jälkeen hyökkäysten */

        // a. Luot kaksi hahmoa (esim. Varas ja Soturi)
        Character varas = new Character("Varas", 100, 15);
        Character soturi = new Character("Soturi", 100, 20);
        
        //b. Luot kaksi asetta (esim. Nuija ja Miekka)
        Weapon nuija = new Weapon("Nuija", 10);
        Weapon miekka = new Weapon("Miekka", 25);

        // c. Asetat Hahmoille käyttöön aseet.
        varas.EquipWeapon(nuija);
        soturi.EquipWeapon(miekka);

        // d. Hahmot hyökkäävät toistensa kimppuun vuorotellen (yhden kerran)
        // e. Tulosta hahmojen tilat ennen ja jälkeen hyökkäysten
        Console.WriteLine("Initial parameters at startup:");
        varas.PrintStats();
        Console.WriteLine("");
        soturi.PrintStats();

        Console.WriteLine("\nVaras attacks Soturi:");
        varas.Attack(soturi);
        soturi.PrintStats();

        Console.WriteLine("\nSoturi attacks Varas:");
        soturi.Attack(varas);
        varas.PrintStats();        
    }
}
