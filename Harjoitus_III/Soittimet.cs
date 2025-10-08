/* Harjoitus 4. Tehtävä 2
    Luokkarakenne/hierarkia seuraavista luokista:
    Soittimet -> MusicInstrument -> Piano
    Soittimet -> MusicInstrument -> Guitar -> AcousticGuitar, ElectricGuitar, BassGuitar */

public class Soittimet
{
    public string Name { get; set; }

    public Soittimet(string name)
    {
        Name = name;
    }

    public virtual void Play()
    {
        Console.WriteLine($"{Name} is playing.");
    }
}