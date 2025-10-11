/* Harjoitus 6.
    Tehtävä 1. Toteuta ajoneuvo luokka (Vehicle), jolla on seuraavat ominaisuudet
        a. valmistaja (brand)
        b. Huippunopeus (topSpeed) */
public class Vehicle
{
    public string Brand { get; set; }
    public int TopSpeed { get; set; }

    public Vehicle(string brand, int topSpeed)
    {
        Brand = brand;
        TopSpeed = topSpeed;
    }

    /* Harjoitus 6.
        Tehtävä 2. Toteuta ajoneuvo luokalle seuraavat metodit
            a. StartEngine(), Virtuaalinen metodi, joka tulostaa: “Ajoneuvo käynnistyy”
            b. Accelerate() - Virtuaalinen metodi, joka tulostaa: “Ajoneuvo kiihtyy”
            c. PrintInfo() - Tulostaa merkin ja huippunopeudem */
    // Виртуальные методы
    public virtual void StartEngine()
    {
        Console.WriteLine("Ajoneuvo käynnistyy");
    }

    public virtual void Accelerate()
    {
        Console.WriteLine("Ajoneuvo kiihtyy");
    }
    
    public void PrintInfo()
    {
        Console.WriteLine($"Tulostaa merkin: {Brand}\nHuippunopeudem: {TopSpeed} km/h");
    }        
}