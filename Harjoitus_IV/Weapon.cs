/* Harjoitus 5.
    Tehtävä 1. Toteuta Ase luokka (Weapon), ja siihen seuraavat ominaisuudet ja metodit
        a. Nimi (name)
        b. Vahinkopisteet (damage)
        c. PrintInfo() metodi, joka tulostaa aseen nimen ja vahingon määrän. */

public class Weapon
{
    public string Name { get; set; } // a. Nimi (name)
    public int Damage { get; set; } // b. Vahinkopisteet (damage)

    public Weapon(string name, int damage)
    {
        Name = name;
        Damage = damage;
    }

    public void PrintInfo() // c. PrintInfo() metodi, joka tulostaa aseen nimen ja vahingon määrän
    {
        Console.WriteLine($"Asen nimi: {Name}, vahingon määrä: {Damage}");
    }
}        