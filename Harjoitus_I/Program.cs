// Harjoitus 1
namespace Harjoitus_I_Maksym_Kotlubaiev;

class Program
{
    // Global array to use in tasks 6-8
    static string[] words = null;

    static void Main(string[] args)
    {
        // Tehtävä 1
        string name = "Maksym Kotlubaiev";
        string studentNumber = "A2406528";
        Console.WriteLine("Opiskelijan nimi: " + name + "\n" + "Opiskelijatunnus: " + studentNumber + "\n");

        //UpperWord(); // Tehtävä 2    
        //LowerWord(); // Tehtävä 3    
        //MinusTen(); // Tehtävä 4
        //PlusFifty(); // Tehtävä 5

        SplitSentence(); // Tehtävä 6
        SentenceWordsNumber(); // Tehtävä 7
        CapitalFirstLetterOfWord(); // Tehtävä 8

        //NumberTenFinding(); // Tehtävä 9
        //Kertoma(); // Tehtävä 10

        UserChooseMethod(); // Tehtävä 11
        Jokeri(); // EXTRA!

    }

    // Tehtävä 2
    static void UpperWord()
    {
        string word = "Hello, World!\n";
        word = word.ToUpper();
        Console.WriteLine(word);
    }

    // Tehtävä 3
    static void LowerWord()
    {
        string word2 = "HELLO, World!\n";
        word2 = word2.ToLower();
        Console.WriteLine(word2);
    }

    // Tehtävä 4
    static void MinusTen()
    {
        Console.Write("Syötä kokonaisluku:\n");
        string luku = Console.ReadLine();
        int number = Convert.ToInt32(luku);
        number = number - 10;
        Console.WriteLine("Luvusta on vähennetty 10: " + number + "\n");
    }

    // Tehtävä 5
    static void PlusFifty()
    {
        Console.Write("Anna syntymävuotesi:\n");
        string birthYear = Console.ReadLine();
        int year = Convert.ToInt32(birthYear);
        int year50 = year + 50;
        Console.WriteLine("Vuonna " + year50 + " täytät 50 vuotta.\n");
    }

    // Tehtävä 6
    static void SplitSentence()
    {
        Console.Write("Syötä jokin lause:\n");
        string sentence = Console.ReadLine();
        words = sentence.Split(' '); // I use global array

        Console.WriteLine("Lauseen sanat ovat:");
        for (int i = 0; i < words.Length; i++)
        {
            Console.WriteLine(i + 1 + ". " + words[i]);
        }
    }

    // Tehtävä 7
    static void SentenceWordsNumber()
    {
        // string [] words from SplitSentence() method
        int numberOfWords = words.Length;
        Console.WriteLine("\nLauseessa on " + numberOfWords + " sanaa.\n");
    }

    // Tehtävä 8
    static void CapitalFirstLetterOfWord()
    {
        // string [] words from SplitSentence() method
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1); // Capitalize the first letter of each word
        }
        string result = string.Join(' ', words);
        Console.WriteLine("Lause isolla alkukirjaimella: " + result + "\n");
    }

    // Tehtävä 9
    static void NumberTenFinding()
    {
        int number = 0;

        while (number != 10)
        {
            Console.Write("Syötä luku:\n");
            string luku = Console.ReadLine();


            if (!int.TryParse(luku, out number)) // Check if string luku is not a valid integer
            {
                Console.WriteLine("Virheellinen syöte. Anna kokonaisluku.\n");
                continue;
            }

            if (number == 10)
            {
                Console.WriteLine("Luku 10 on löydetty!\n");
            }
            else
            {
                Console.WriteLine("Luku ei ole 10, yritä uudelleen.\n");
            }
        }
    }

    // Tehtävä 10
    static void Kertoma()
    {
        Console.Write("Syötä luku:\n");
        int n = Convert.ToInt32(Console.ReadLine());
        long result = 1; // long will store large factorial values

        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }

        Console.WriteLine($"{n}! = {result}\n");
    }

    // Tehtävä 11
    static void UserChooseMethod()
    {
        Console.WriteLine("\nValitse suoritettava toiminto:\n" +
        "Tehtävä 2. UpperWord\n" +
        "Tehtävä 3. LowerWord\n" +
        "Tehtävä 4. MinusTen\n" +
        "Tehtävä 5. PlusFifty\n" +
        "Tehtävä 9. NumberTenFinding\n" +
        "Tehtävä 10. Kertoma\n");

        Console.Write("Anna valintasi (2-5, 9 tai 10):\n");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "2":
                UpperWord();
                break;

            case "3":
                LowerWord();
                break;

            case "4":
                SplitSentence();
                break;

            case "5":
                Kertoma();
                break;

            case "9":
                Kertoma();
                break;

            case "10":
                Kertoma();
                break;

            default:
                Console.WriteLine("Virheellinen valinta.\n");
                break;
        }
    }

    // EXTRA!
    static void Jokeri()
    {
        var rand = new Random();
        int[] lotteryNumbers = new int[6];

        for (int i = 0; i < lotteryNumbers.Length; i++)
        {
            int newNumber = rand.Next(1, 41); // Generate a number between 1 and 40 

            if (!lotteryNumbers.Contains(newNumber))
            {
                lotteryNumbers[i] = newNumber;
            }
            else
            {
                i--; // If the number is already in the array, repeat this iteration
            }
        }
        
        Array.Sort(lotteryNumbers); // Sort the numbers in ascending order
        Console.WriteLine("Arvotut lottonumerot: " + string.Join(", ", lotteryNumbers) + "\n");
    }
}
