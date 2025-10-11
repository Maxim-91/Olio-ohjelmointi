/* Harjoitus 6.
    Tehtävä 3. Toteuta kilpa-auto luokka (RaceCar) luokka perii ajoneuvoluokan, ja siihen seuraavat ominaisuudet ja metodit
        a. onkoTurbo (isTurbo)
        b. Ylikirjoita StartEngine() metodi, metodi tulostaa “Kilpa-auto käynnistyy”
        c. Ylikirjoita Accelerate() metodi, metodi tulostaa “Kilpa-auto kiihtyy vauhdilla”
        d. Tee kuomitettu metodi Accelerate(int seconds), joka tulostaa “Kilpa-auto kiihtyy x sekuntti”, 
        korvaa x metodissa saadulla parametrillä */
public class RaceCar : Vehicle
{
    public bool IsTurbo { get; set; }
    public RaceCar(string brand, int topSpeed, bool isTurbo) : base(brand, topSpeed) // Kutsu Vehicle-perusluokan konstruktoria
    {
        IsTurbo = isTurbo;
    }

    public override void StartEngine()
    {
        Console.WriteLine("Kilpa-auto käynnistyy");
    }

    public override void Accelerate()
    {
        Console.WriteLine("Kilpa-auto kiihtyy vauhdilla");
    }

    public void Accelerate(int seconds)
    {
        Console.WriteLine($"Kilpa-auto kiihtyy {seconds} sekuntti");
    }
}