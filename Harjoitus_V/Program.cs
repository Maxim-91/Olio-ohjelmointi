namespace Harjoitus_V_Maksym_Kotlubaiev;

class Program
{
    static void Main(string[] args)
    {
        /* Harjoitus 6.
            Tehtävä 5. Toteuta Main metodissa seuraavat asiat
                a. Luo oliot kilpa-auto ja moottoripyörä luokista
                b. Molemmat ajoneuvot käynnistetään
                c. Molemmat kiihdyttävät perus metodilla
                d. Molemmat kiihdyttävät ylikuormitellulla metodilla
                e. Tulostetaan ajoneuvon tiedot */
        RaceCar car = new RaceCar("Lamborghini", 320, true); // Example from internet: Lamborghini SC63, 320 km/h, turbo
        MotorCycle cycle = new MotorCycle("Dodge Tomahawk", 480); // Example from internet: Dodge Tomahawk, 480-600 km/h

        car.StartEngine();
        cycle.StartEngine();
        Console.WriteLine("");

        car.Accelerate();
        cycle.Accelerate();
        Console.WriteLine("");

        car.Accelerate(5); // Accelerate, for example, 5 seconds
        cycle.Accelerate(true); // Do a wheelie
        Console.WriteLine("");

        car.PrintInfo();
        cycle.PrintInfo();

        /* Harjoitus 7.
            Tehtävä 5. Toteuta Main metodissa seuraavat asiat
                a. Luo Ohjelmoija ja siivooja luokista oliot
                b. Tulosta kummankin työntekijän tiedot
                c. Kutsu Work() metodia molemmilla olioilla.
                d. Tarkista voiko työntekijä tehdä etätyötä:
                    i. Jos kyllä, kutsu StartRemoteWork() metodia
                    ii. Jos ei, tulosta etätyö ei mahdollista. */

        // a. Luo Ohjelmoija ja siivooja luokista oliot
        SoftwareDeveloper developer = new SoftwareDeveloper("Maksym", "Ohjelmoija", "C#", true);
        Janitor janitor = new Janitor("Dasha", "Siivooja", "Office");
        
        // b. Tulosta kummankin työntekijän tiedot
        Console.WriteLine("");
        developer.PrintInfo();
        janitor.PrintInfo();

        // c. Kutsu Work() metodia molemmilla olioilla.
        Console.WriteLine("");
        developer.Work();
        janitor.Work();

        // d. Tarkista voiko työntekijä tehdä etätyötä:
        Console.WriteLine("");
        if (developer.CanWorkRemotely()) developer.StartRemoteWork();        
        else Console.WriteLine("Etätyö ei mahdollista.");        
    }
}
