namespace Harjoitus_III_Maksym_Kotlubaiev;

// Laitan luokka Vehicle omaan tiedostoon (opettajan suositus)
class Program
{
    static void Main(string[] args)
    {
        Vehicle car = new Vehicle(); // Tehtävä 2

        // Tehtävä 5
        car.Accelerate();
        car.Brake();

        // Tehtävä 10
        Console.WriteLine("Model: " + car.Model);
        Console.WriteLine("Manufacturer: " + car.Manufacturer);
    }
}
