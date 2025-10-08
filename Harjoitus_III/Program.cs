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

        // Harjoitus 4. Tehtävä 3. Luo Mammal (Nisäkäs) Luokka
        Mammal mammal1 = new Mammal("Poro / Reindeer");
        Console.WriteLine("");
        mammal1.Eat();
        mammal1.Sleep();

        // Harjoitus 4. Tehtävä 4. Luo Dog (Koira) Luokka, joka periytyy Mammal Luokasta        
        Dog dog1 = new Dog("Husky bob");
        Console.WriteLine("");           
        dog1.Eat();
        dog1.Eat(25);
        dog1.Sleep();
    }
}
