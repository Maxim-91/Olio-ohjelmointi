namespace Harjoitus_III_Maksym_Kotlubaiev;

// Laitan luokka Vehicle omaan tiedostoon (opettajan suositus)
class Program
{
    static void Main(string[] args)
    {
        Vehicle car = new Vehicle(); // Tehtävä 2

        // Harjoitus 3. Tehtävä 5
        car.Accelerate();
        car.Brake();

        // Harjoitus 3. Tehtävä 10
        Console.WriteLine("Model: " + car.Model);
        Console.WriteLine("Manufacturer: " + car.Manufacturer + "\n");


        /* Harjoitus 4
            Tehtävä 1. Toteuta luokka “Person”, ei periydy mistään luokasta.
                        a. Luokalla on jäsenmuuttujina nimi, syntymävuosi ja ikä
                        b. Luo rakentajametodi, joka ottaa parametrina nimen ja syntymävuoden, laskee syntymävuoden iän perusteella.
                        c. Tee erilliset metodit, jotka palauttavat iän ja nimen. */
        Person person1 = new Person("Maksym", 1991);
        Console.WriteLine("Name: " + person1.GetName());
        Console.WriteLine("Age: " + person1.GetAge() + "\n");


        /* Harjoitus 4
            Tehtävä 2. Toteuta luokkarakenne/hierarkia seuraavista luokista 
            (Soittimista), MusicInstrument, Piano, Guitar, AcusticGuitar, ElecticGuitar ja BassGuitar. 
            Mieti mitä oleellisia ominaisuuksia ja toiminnallisuuksia luokilla/soittimilla on. 
            Toteuta olio-ohjelmoinnin mukaisesti. */

        /*  Luokkarakenne/hierarkia seuraavista luokista:
            Soittimet -> MusicInstrument -> Piano
            Soittimet -> MusicInstrument -> Guitar -> AcousticGuitar, ElectricGuitar, BassGuitar 
            
            Luokat sisältävät olennaiset ominaisuudet (Name, Manufacturer, Strings, Keys) ja metodit (Play, Tune). 
            Periytymistä, kapselointia ja polymorfismia (virtual/override) hyödynnettiin. 
            Ohjelmassa luodaan oliot ja kutsutaan metodeja demonstroiden toiminnallisuudet. */

        Piano piano = new Piano("Yamaha");
        AcousticGuitar acoustic = new AcousticGuitar("Fender");
        ElectricGuitar electric = new ElectricGuitar("Gibson");
        BassGuitar bass = new BassGuitar("Ibanez");

        piano.Play();
        acoustic.Play();
        electric.Play();
        bass.Play();

        piano.Tune();
        electric.Tune();


        /* Harjoitus 4
            Tehtävä 6. Ohjelman Main metodissa
                        a. Luo Dog luokasta olio.
                        b. Luo Dog luokasta olio, välitä rakentajan parametrina nimi i. Kutsu luodun olion Eat() metodia, 
                            ja välitä parametrina energia määrä jonka 100 grammaa possun lihaa sisältää. 
                            Käytä hyväksesi edellisessä kohdassa luomaasi toiminnallisuutta
                        c. Luo Mammal luokasta olio */


        // Harjoitus 4. Tehtävä 4. Luo Dog (Koira) Luokka, joka periytyy Mammal Luokasta   
        // and Harjoitus 4. Tehtävä 6. a. Luo Dog luokasta olio.
        // and b. Luo Dog luokasta olio, välitä rakentajan parametrina nimi i       
        Dog dog1 = new Dog("i");

        // Kutsu luodun olion Eat() metodia, ja välitä parametrina energia määrä jonka 100 grammaa possun lihaa sisältää. 
        // Käytä hyväksesi edellisessä kohdassa luomaasi toiminnallisuutta
        int kcal100gPork = EnergyCalculator.CalculateCalories(100);
        Console.WriteLine("");
        dog1.Eat(kcal100gPork);
        dog1.Sleep();

        // c. Luo Mammal luokasta olio        
        Mammal mammal1 = new Mammal("Poro / Reindeer");
        Console.WriteLine("");
        mammal1.Eat();
        mammal1.Sleep();
    }
}
