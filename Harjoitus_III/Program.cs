namespace Harjoitus_III_Maksym_Kotlubaiev;

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


class Vehicle // Tehtävä 1
{
    private string model; // Tehtävä 6
    private string manufacturer; // Tehtävä 7    

    // Tehtävä 3
    public void Accelerate()
    {
        Console.WriteLine("Accelerate");
    }

    // Tehtävä 4
    public void Brake()
    {
        Console.WriteLine("Brake");
    }

    // Tehtävä 8
    public Vehicle()
    {
        model = "Default Model";
        manufacturer = "Default Manufacturer";
    }

    // Tehtävä 9
    public string Model
    {
        get { return model; }
    }

    public string Manufacturer
    {
        get { return manufacturer; }
    }
}