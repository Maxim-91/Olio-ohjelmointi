/* Harjoitus 4. Tehtävä 3. Luo Mammal (Nisäkäs) Luokka.
                            a. Luokalla on jäsenmuuttujana nimi.
                            b. Luokalla on oletus rakentaja, sekä rakentaja joka ottaa parametrina string muuttujan ja sijoittaa sen luokanjäsenmuuttuja nimelle arvoksi
                            c. Luo Luokalle metodi Eat()
                            d. Luo Luokalle metodit Sleep() */

public class Mammal
{
    public string name; // a. Luokalla on jäsenmuuttujana nimi.

    // b. Luokalla on oletus rakentaja, sekä rakentaja joka ottaa parametrina string muuttujan ja sijoittaa sen luokanjäsenmuuttuja nimelle arvoksi
    public Mammal()
    {
        name = "Unknown";
    }

    public Mammal(string name)
    {
        this.name = name;
    }

    // c. Luo Luokalle metodi Eat()
    public virtual void Eat() // It is virtual for override in class Dog
    {
        Console.WriteLine($"{name} is eating.");
    }

    // d. Luo Luokalle metodit Sleep()
    public void Sleep()
    {
        Console.WriteLine($"{name} is sleeping.");
    }
}