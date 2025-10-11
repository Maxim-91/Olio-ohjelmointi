/* Harjoitus 7.
    Tehtävä 4. Toteuta luokka siivooja (Janitor), joka perii työntekijä luokan
        a. Ominaisuudet
            i. vastuualue (areaAssigned)
        b. Metodit
            i. Toteuta rakentaja metodi, joilla voidaan asettaa kaikki jäsenmuuttujien arvot
            ii. Toteuta Work() metodi, joka tulostaa “Siivotaan aluetta x”, korvaa x vastuualue jäsenmuuttujan arvolla. */
public class Janitor : Employee
{
    public string AreaAssigned { get; set; }

    public Janitor(string name, string position, string areaAssigned) : base(name, position) // Kutsu Employee-perusluokan konstruktoria
    {
        AreaAssigned = areaAssigned;
    }

    public override void Work()
    {
        Console.WriteLine($"Siivotaan aluetta {AreaAssigned}");
    }
}