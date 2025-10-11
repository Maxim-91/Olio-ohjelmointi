/* Harjoitus 6.
    Tehtävä 4. Toteuta moottoripyörä luokka (MotorCycle) luokka perii ajoneuvoluokan, ja siihen seuraavat ominaisuudet ja metodit
        a. Ylikirjoita StartEngine() metodi, metodi tulostaa “Moottoripyörä käynnistyy”
        b. Ylikirjoita Accelerate() metodi, metodi tulostaa “Moottoripyörä kiihtyy vauhdilla”
        c. Tee kuomitettu metodi Accelerate(bool wheelie), joka “tulostaa “Moottoripyörä kiihtyy keulien”, 
        jos wheelie muuttujan arvo on true */
public class MotorCycle : Vehicle
{
    public MotorCycle(string brand, int topSpeed) : base(brand, topSpeed) {}// Kutsu Vehicle-perusluokan konstruktoria
    
    public override void StartEngine()
    {
        Console.WriteLine("Moottoripyörä käynnistyy");
    }

    public override void Accelerate()
    {
        Console.WriteLine("Moottoripyörä kiihtyy vauhdilla");
    }

    public void Accelerate(bool wheelie)
    {
        if (wheelie)
        {
            Console.WriteLine("Moottoripyörä kiihtyy keulien");
        }        
    }
}