/* Harjoitus 4. Tehtävä 4. Luo Dog (Koira) Luokka, joka periytyy Mammal Luokasta
                            a. Luokalla on jäsenmuuttuja, joka kuvaa koiran energia määrää
                            b. Luokalla on oletus rakentaja, sekä rakentaja jonka avulla voidaan asettaa koiralle nimi. Dog luokan rakentajat kutsuvat yliluokan rakentajaa. (base)
                            c. Ylikirjoita Eat() metodi, ylikirjoitetussa metodissa kutsutaan yliluokan toteutusta
                            d. Luo kuormitettu Eat() metodi, joka ottaa parametrina syötävän energia määrän ja lisää sen koiran energiaan. */
public class Dog : Mammal
{
    private  int energy; // a. Luokalla on jäsenmuuttuja, joka kuvaa koiran energia määrää

    // b. Luokalla on oletus rakentaja, sekä rakentaja jonka avulla voidaan asettaa koiralle nimi. Dog luokan rakentajat kutsuvat yliluokan rakentajaa. (base)
    public Dog() : base()
    {
        energy = 100; // for example, energy 100%
    }

    public Dog(string name) : base(name)
    {
        energy = 100; // for example, energy 100%
    }

    // c. Ylikirjoita Eat() metodi, ylikirjoitetussa metodissa kutsutaan yliluokan toteutusta
    public override void Eat()
    {
        base.Eat(); // Eat metodi from class Mammal 
        Console.WriteLine($"The dog {name} is eating, energy level: {energy}.");
    }

    // d. Luo kuormitettu Eat() metodi, joka ottaa parametrina syötävän energia määrän ja lisää sen koiran energiaan
    public void Eat(int foodEnergy)
    {
        energy += foodEnergy;
        Console.WriteLine($"The dog {name} get energy +{foodEnergy}, energy level: {energy}.");
    }
}