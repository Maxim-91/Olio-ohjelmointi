/* Harjoitus 4. Tehtävä 2
    Luokkarakenne/hierarkia seuraavista luokista:
    Soittimet -> MusicInstrument -> Piano
    Soittimet -> MusicInstrument -> Guitar -> AcousticGuitar, ElectricGuitar, BassGuitar */

public class Piano : MusicInstrument
{
    public Piano(string manufacturer)
        : base("Piano", manufacturer) { }

    public override void Play()
    {
        Console.WriteLine($"Piano by {Manufacturer} is playing.");
    }
}