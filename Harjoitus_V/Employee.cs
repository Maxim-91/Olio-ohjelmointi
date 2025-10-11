/* Harjoitus 7.
    Tehtävä 1. Toteuta Abstrakti luokka työntekijä (Employee)
        a. Ominaisuudet
            i. Nimi (name)
            ii. Paikka (position)
        b. Metodit
            i. Abstrakti metodi: Work()
            ii. Toteuta metodi: PrintInfo(), joka tulostaa työntekijän nimen ja paikan */
public abstract class Employee
{
    public string Name { get; set; }
    public string Position { get; set; }

    public Employee(string name, string position)
    {
        Name = name;
        Position = position;
    }

    public abstract void Work();

    public void PrintInfo()
    {
        Console.WriteLine($"Työntekijän nimi: {Name}\nPaikka: {Position}");
    }

    /* Harjoitus 7.
        Tehtävä 2. Määrittele rajapinta IRemoteWorkable
            a. Metodit
                i. StartRemoteWork()
                ii. CanWorkRemotely(), joka palauttaa bool paluuarvon. */
    public interface IRemoteWorkable
    {
        void StartRemoteWork();
        bool CanWorkRemotely();
    }
}