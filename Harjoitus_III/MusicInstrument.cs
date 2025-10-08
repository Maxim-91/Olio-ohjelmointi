/* Harjoitus 4. Tehtävä 2
    Luokkarakenne/hierarkia seuraavista luokista:
    Soittimet -> MusicInstrument -> Piano
    Soittimet -> MusicInstrument -> Guitar -> AcousticGuitar, ElectricGuitar, BassGuitar */

public class MusicInstrument : Soittimet
{ 
    public string Manufacturer { get; set; }

    public MusicInstrument(string name, string manufacturer)
        : base(name)
    {
        Manufacturer = manufacturer;
    }

    public virtual void Tune()
    {
        Console.WriteLine($"{Name} by {Manufacturer} is being tuned.");
    }
}