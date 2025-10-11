/* Harjoitus 7.
    Tehtävä 3. Toteuta luokka Ohjelmoija (SoftwareDeveloper), joka perii työntekijä luokan, ja toteuttaa IRemoteWorkable rajapinnan
        a. Ominaisuudet
            i. Ohjelmointikieli (programmingLanguage)
            ii. onkoKannettava (hasLaptop)
        b. Metodit
            i. Toteuta rakentaja metodi, joilla voidaan asettaa kaikki jäsenmuuttujien arvot
            ii. Toteuta Work() metodi, metodi tulostaa “Nyt koodataan x”, korvaa x ohjelmoijan ohjelmointikielellä
            iii. Toteuta StartRemoteWork() metodi, metodi tulostaa “Etätyö käyntiin”
            iv. Toteuta CanWorkRemotely() metodi, Palauttaa true, jos hasLaptop == true */
public class SoftwareDeveloper : Employee, Employee.IRemoteWorkable
{   
    public string ProgrammingLanguage { get; set; }
    public bool HasLaptop { get; set; }

    public SoftwareDeveloper(string name, string position, string programmingLanguage, bool hasLaptop) : base(name, position) // Kutsu Employee-perusluokan konstruktoria
    {
        ProgrammingLanguage = programmingLanguage;
        HasLaptop = hasLaptop;
    }

    public override void Work()
    {
        Console.WriteLine($"Nyt koodataan {ProgrammingLanguage}");
    }

    public void StartRemoteWork()
    {
        Console.WriteLine("Etätyö käyntiin");
    }

    public bool CanWorkRemotely()
    {
        if (HasLaptop == true) return true;
        else return false;
    }
}