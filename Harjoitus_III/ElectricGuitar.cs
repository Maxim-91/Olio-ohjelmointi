/* Harjoitus 4. Tehtävä 2
    Luokkarakenne/hierarkia seuraavista luokista:
    Soittimet -> MusicInstrument -> Piano
    Soittimet -> MusicInstrument -> Guitar -> AcousticGuitar, ElectricGuitar, BassGuitar */

public class ElectricGuitar : Guitar
{ 
    public override void Play()
    {
        Console.WriteLine("Soitetaan sähkökitaralla.");
    }
}