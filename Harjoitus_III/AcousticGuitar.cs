/* Harjoitus 4. Tehtävä 2
    Luokkarakenne/hierarkia seuraavista luokista:
    Soittimet -> MusicInstrument -> Piano
    Soittimet -> MusicInstrument -> Guitar -> AcousticGuitar, ElectricGuitar, BassGuitar */

public class AcousticGuitar : Guitar
{ 
    public AcousticGuitar(string manufacturer) : base("Acoustic Guitar", manufacturer) { }
}