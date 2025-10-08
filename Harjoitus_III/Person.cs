public class Person // Tehtävä 1
{
    // a. Luokalla on jäsenmuuttujina nimi, syntymävuosi ja ikä
    private string name; // nimi
    private int birthYear; // syntymävuosi
    private int age; // ikä

    // b. Luo rakentajametodi, joka ottaa parametrina nimen ja syntymävuoden, laskee syntymävuoden iän perusteella.
    public Person(string name, int birthYear)
    {
        this.name = name;
        this.birthYear = birthYear;
        
        // Lasketaan ikä syntymävuoden perusteella
        int currentYear = DateTime.Now.Year;
        age = currentYear - birthYear;
    }

    // c. Tee erilliset metodit, jotka palauttavat iän ja nimen.
    public string GetName()
    {
        return name;
    }

    public int GetAge()
    {
        return age;
    }
}