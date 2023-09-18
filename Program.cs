using System.Security;

Console.WriteLine("Hej och välkommen till hänga gubbe.");
Console.WriteLine("Var vänlig och välj vilket språk du vill välja ord ifrån.");
Console.WriteLine("Tryck 1 för svenska ord eller tryck 2 för engelska ord");

string[] ord = null;

var liv = 20;
var bokstav = "";
bool game = true;

while (ord == null)
{
var input = Console.ReadLine();

    if (input == "1")
    {
        Console.WriteLine("Du har valt svenska ord");
        ord = File.ReadAllLines("swe.txt");
        var r = new Random();
        var random = r.Next(0, ord.Length - 1);
        var word = ord[random];
        var index = 0;
        var currentGuess = "";

        while (index < word.Length)
        {
            currentGuess = "_" + currentGuess;
            index++;
        }
        bool hasWon = false;
        while (liv > 0 && !hasWon)
        {
            Console.WriteLine(currentGuess);
            Console.WriteLine("Vänligen gissa med en bokstav");
            var gissning = Console.ReadLine().ToLower();
            while (gissning.Length != 1 && gissning.Length != word.Length)
            {
                Console.WriteLine("Vänligen ange enbart en bokstav eller hela ordet");
                Console.ReadLine().ToLower();
                bokstav = bokstav + gissning;
            }
            if (gissning.Length == 1)
            {
                bool guessWasCorrect = false;
                Console.Clear();
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i].ToString().ToLower() == gissning)
                    {
                        guessWasCorrect = true;
                        Console.WriteLine(bokstav);
                        currentGuess = currentGuess.Remove(i, 1).Insert(i, gissning);
                    }
                }
                if (currentGuess == word)
                {
                    Console.WriteLine(bokstav);
                    hasWon = true;
                    game = true;
                }
                if (!guessWasCorrect)
                {
                    Console.WriteLine(bokstav);
                    liv--;
                    Console.WriteLine("Du har nu " + liv + " liv kvar");
                }
            }
            else if (gissning == word)
            {
                Console.Clear();
                hasWon = true;
                game = true;
            }
            else
            {
                liv = liv - 2;
                Console.WriteLine("Du har nu " + " liv kvar");
            }
        }
        if (hasWon)
        {
            Console.WriteLine("Du har vunnit med " + liv + " liv kvar");
            Console.WriteLine("Det rätta ordet var " + word);
        }
        else
        {
            Console.WriteLine("Du har förlorat, ordet var " + word);
            Console.WriteLine("Du har hittils gissat " + currentGuess);
        }
        game = false;
        Console.WriteLine("Vill du spela en gång till?");
    }

    else if (input == "2")
    {
        Console.WriteLine("Du har valt engelska ord");
        ord = File.ReadAllLines("eng.txt");
        var r = new Random();
        var random = r.Next(0, ord.Length - 1);
        var word = ord[random];
        var index = 0;
        var currentGuess = "";

        while (index < word.Length)
        {
            currentGuess = "_" + currentGuess;
            index++;
        }
        bool hasWon = false;
        while (liv > 0 && !hasWon)
        {
            Console.WriteLine(currentGuess);
            Console.WriteLine("Vänligen gissa med en bokstav");
            var gissning = Console.ReadLine().ToLower();
            while (gissning.Length != 1 && gissning.Length != word.Length)
            {
                Console.WriteLine("Vänligen ange enbart en bokstav eller hela ordet");
                Console.ReadLine().ToLower();
                bokstav = bokstav + gissning;
            }
            if (gissning.Length == 1)
            {
                bool guessWasCorrect = false;
                Console.Clear();
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i].ToString().ToLower() == gissning)
                    {
                        guessWasCorrect = true;
                        Console.WriteLine(bokstav);
                        currentGuess = currentGuess.Remove(i, 1).Insert(i, gissning);
                    }
                }
                if (currentGuess == word)
                {
                    Console.WriteLine(bokstav);
                    hasWon = true;
                    game = true;
                }
                if (!guessWasCorrect)
                {
                    Console.WriteLine(bokstav);
                    liv--;
                    Console.WriteLine("Du har nu " + liv + " liv kvar");
                }
            }
            else if (gissning == word)
            {
                Console.Clear();
                hasWon = true;
                game = true;
            }
            else
            {
                liv = liv - 2;
                Console.WriteLine("Du har nu " + " liv kvar");
            }
        }
        if (hasWon)
        {
            Console.WriteLine("Du har vunnit med " + liv + " liv kvar");
            Console.WriteLine("Det rätta ordet var " + word);
        }
        else
        {
            Console.WriteLine("Du har förlorat, ordet var " + word);
            Console.WriteLine("Du har hittils gissat " + currentGuess);
        }
        game = false;
        Console.WriteLine("Vill du spela en gång till?");
    }
    else
    {
        Console.WriteLine("Fel inmatning, välj antigen 1 eller 2.");
    }
    game = false;
}

//Gör en while runt om allt du redan har Och skapa en variabel som heter play eller något. 
//Sätt den till true och i slutet frågar du om man vill spela igen. Sätt den till true då så körs det om. 
//Vill man inte sätt false och man slipper.