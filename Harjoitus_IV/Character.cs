/* Harjoitus 5.
    Tehtävä 2. Toteuta hahmo luokka (Character), jolla on seuraavat ominaisuudet
        a. Nimi (name)
        b. Elämäpisteet (health)
        c. Voima (strength)
        d. Ase (equipmentWeapon) */
public class Character
{   
    public string Name { get; set; } // a. Nimi (name)
    public int Health { get; set; } // b. Elämäpisteet (health)
    public int Strength { get; set; } // c. Voima (strength)
    
    // The code triggered warning CS8618: Non-nullable property 'EquipmentWeapon'
    // corrected this triggered by adding "= new Weapon("None", 0);"
    public Weapon EquipmentWeapon { get; set; } = new Weapon("None", 0); // d. Ase (equipmentWeapon)

    /* Tehtävä 3. Toteuta Hahmo luokalle seuraavat metodit
        a. Attack(Character target), Tämä metodi hyökkää toiseen hahmoon 
            ja vähentää sen Health arvoa hyökkääjän Strengt ja aseen Damage muuttujan verran
        b. EquipWeapon(Weapon weapon), Asettaa aseen käyttöön
        c. PrintStats(), Tulostaa hahmon nimen, elinvoiman, voiman, ja käytössä olevan aseen */
    public Character(string name, int health, int strength)
    {
        Name = name;
        Health = health;
        Strength = strength;        
    }

    // a. Attack(Character target),
    // Tämä metodi hyökkää toiseen hahmoon 
    // ja vähentää sen Health arvoa hyökkääjän Strengt 
    // ja aseen Damage muuttujan verran
    public void Attack(Character target)
    {
        int totalDamage = Strength + EquipmentWeapon.Damage;
        target.Health -= totalDamage;
    }

    // b. EquipWeapon(Weapon weapon), Asettaa aseen käyttöön
    public void EquipWeapon(Weapon weapon)
    {
        EquipmentWeapon = weapon;
    }
    
    // c. PrintStats(), Tulostaa hahmon nimen, elinvoiman, voiman, ja käytössä olevan aseen
    public void PrintStats()
    {
        Console.WriteLine($"Hahmon nimi: {Name}\nElinvoima: {Health}\nVoima: {Strength}");
        EquipmentWeapon.PrintInfo();
    }
}