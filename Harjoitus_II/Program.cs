namespace Harjoitus_II_Maksym_Kotlubaiev;

class Program
{
    static void Main(string[] args)
    {
        DataTime(); // Tehtävä 1
        YmpyränPintaAlan(); // Tehtävä 2

        // Tehtävä 3
        Console.Write("Anna kokonaisluku:\n");
        string luku = Console.ReadLine();
        int number = Convert.ToInt32(luku);
        bool result = IsDivideByTwo(number);
        if (result) Console.WriteLine($"Luku {number} on jaollinen kahdella.\n");
        else Console.WriteLine($"Luku {number} ei ole jaollinen kahdella.\n");

        MultiplicationTable(); // Tehtävä 4

        // Tehtävä 5
        Console.WriteLine("\nKuinka monta Fibonacci-lukua haluat?:");
        string lukuF = Console.ReadLine();
        int nF = Convert.ToInt32(lukuF);

        List<int> luvutFibonacci;
        luvutFibonacci = Fibonacci(nF);
        Console.WriteLine($"\nFibonacci lukujono:\n{string.Join(" ", luvutFibonacci)}");

        // Tehtävä 6
        int count = ArvoLuvut();
        Console.WriteLine($"\nArvottujen lukujen joukosta 0-100, lukuja 0-50 on {count} kpl.\n");

        ArvausPeli(); // Tehtävä 7

        // Tehtävä Jokeri
        int[] jokeriNumerot = Jokeri();
        Console.WriteLine("Arpoo taulukkoon 10 lukua: " + string.Join(", ", jokeriNumerot));
    }

    // Tehtävä 1
    static void DataTime()
    {
        DateTime now = DateTime.Now;
        string formattedDate = now.ToString("dd.MM.yyyy HH:mm:ss");
        Console.WriteLine(formattedDate);
    }

    // Tehtävä 2
    static void YmpyränPintaAlan()
    {
        Console.Write("\nAnna ympyrän säde (cm):\n");
        string radius = Console.ReadLine();
        float r = Convert.ToSingle(radius);

        double area = Math.PI * Math.Pow(r, 2);

        Console.WriteLine($"Ympyrän pinta-ala on {area} cm2.\n");
    }

    // Tehtävä 3
    static bool IsDivideByTwo(int input)
    {
        if (input % 2 == 0) return true;
        else return false;
    }

    // Tehtävä 4
    static void MultiplicationTable()
    {
        Console.WriteLine("Anna kokonaisluku:");
        string luku = Console.ReadLine();
        int number = Convert.ToInt32(luku);

        for (int i = 1; i <= 10; i++)
        {
            int result = number * i;
            Console.WriteLine($"{number} x {i} = {result}");
        }
    }

    // Tehtävä 5
    static List<int> Fibonacci(int n)
    {
        List<int> luvut = new List<int>(); // List for storing the result

        int a = 0, b = 1, c = 0; // First two Fibonacci numbers

        // Creating the Fibonacci sequence
        for (int i = 0; i < n; i++)
        {
            luvut.Add(a);
            c = a + b;
            a = b;
            b = c;
        }

        return luvut; // Returning the list to Fibonacci(n)
    }

    // Tehtävä 6
    // I didn't quite understand this task, so I resorted to using the GPT chat to explain what need to do.
    static int ArvoLuvut()
    {
        Random rnd = new Random();
        int laskuri = 0;

        for (int i = 0; i < 100; i++)
        {
            int luku = rnd.Next(0, 101); // 0-100 mukaanlukien
            if (luku >= 0 && luku <= 50)
            {
                laskuri++;
            }
        }

        return laskuri;
    }

    // Tehtävä 7
    static void ArvausPeli()
    {
        Console.WriteLine("Yritä arvata koneen valitsema numero väliltä 1-200.\n0 = break");
        Random rnd = new Random();
        int number = rnd.Next(1, 201); // 1-200 mukaanlukien

        Console.Write("Anna numero (1-200):\n");
        string input = Console.ReadLine();
        int numberGamer = Convert.ToInt32(input);

        while (numberGamer != number)
        {
            if (number == 0) break; // exit from the loop

            else if (numberGamer < number) Console.WriteLine($"Arvottu luku on isompi, yritä uudestaan (luku > {numberGamer}).");
            else if (numberGamer > number) Console.WriteLine($"Arvottu luku on pienempi, yritä uudestaan (luku < {numberGamer}).");

            Console.Write("Anna numero:\n");
            input = Console.ReadLine();
            numberGamer = Convert.ToInt32(input);
        }
        Console.WriteLine($"Onneksi olkoon! Arvasit oikein, luku oli {number}.\n");
    }

    // Tehtävä Jokeri
    // The task for me is very similar to the task from EXTRA! Jokeri! from Harjoitus_I
     static int[] Jokeri()
    {
        var rand = new Random();
        int[] numbers = new int[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            int newNumber = rand.Next(0, 101); // Generate a number, for example, from 0 to 100

            if (!numbers.Contains(newNumber))
            {
                numbers[i] = newNumber;
            }
            else
            {
                i--; // If the number is already in the array, repeat this iteration
            }
        }

        Array.Sort(numbers); // Sort the numbers in ascending order
        return numbers;
    }
}
