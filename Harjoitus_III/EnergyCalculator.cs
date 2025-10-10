/* Harjoitus 4. Tehtävä 5. Luo EnergyCalculator Luokka
                            a. Luo Staattinen luokkametodi, joka laskee kuinka monta kaloria energiaa parametrina syötetty possun lihan määrä sisältää 
                            ja palauttaa sen paluuarvona */

public static class EnergyCalculator
{
    public static int CalculateCalories(int grams)
    {
        // According to the internet, 100 grams of pork contains from 142 to 489 kcal, depending on its fat content.
        //For example, let's say it's 316 kcal per 100 grams, than:
        float value = (grams * 316) / 100;
        int rounded = (int)Math.Round(value); // Converting float to int with rounding
        return rounded;
    }
}