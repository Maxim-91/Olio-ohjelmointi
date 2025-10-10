/* Harjoitus 4. Tehtävä 2
    Luokkarakenne/hierarkia seuraavista luokista:
    MusicInstrument -> Piano
    MusicInstrument -> Guitar -> AcousticGuitar, ElectricGuitar, BassGuitar */

public class AcousticGuitar : Guitar
{ 
    public override void Play()
    {
        Console.WriteLine("Soitetaan akustisella kitaralla.");
    }
}