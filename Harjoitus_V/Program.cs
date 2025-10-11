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
    }
}
