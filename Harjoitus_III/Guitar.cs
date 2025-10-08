/* Harjoitus 4. Tehtävä 2
    Luokkarakenne/hierarkia seuraavista luokista:
    Soittimet -> MusicInstrument -> Piano
    Soittimet -> MusicInstrument -> Guitar -> AcousticGuitar, ElectricGuitar, BassGuitar */

public class Guitar : MusicInstrument
{ 
    public Guitar(string name, string manufacturer)
        : base(name, manufacturer) { }

    public override void Play()
    {
        Console.WriteLine($"{Name} by {Manufacturer} is playing.");
    }
}