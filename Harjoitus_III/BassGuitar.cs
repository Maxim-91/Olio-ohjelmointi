/* Harjoitus 4. Tehtävä 2
    Luokkarakenne/hierarkia seuraavista luokista:
    Soittimet -> MusicInstrument -> Piano
    Soittimet -> MusicInstrument -> Guitar -> AcousticGuitar, ElectricGuitar, BassGuitar */

public class BassGuitar : Guitar
{
    public BassGuitar(string manufacturer) : base("Bass Guitar", manufacturer) { }
}