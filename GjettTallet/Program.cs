namespace GjettTallet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckIfCorrect(GenerateRandomNumber());

            static int GenerateRandomNumber()
            {
            Random rand = new Random();
            int randomNumber = rand.Next(0, 100);
                return randomNumber;
            }

            static void CheckIfCorrect(int randomNumber)
            {
                Console.WriteLine("Gjett tallet:");
                int numberGuess = Convert.ToInt16(Console.ReadLine());

                if (numberGuess == randomNumber)
                {
                    Console.WriteLine("Riktig!");
                    Console.WriteLine("Har du lyst å spille på nytt? (\"ja\" eller \"nei\")");
                    var userResponse = Console.ReadLine().ToLower();
                    if (userResponse == "ja")
                    {
                        CheckIfCorrect(GenerateRandomNumber());
                    }
                    else if (userResponse == "nei")
                    {
                        Console.WriteLine("OK, takk for at du spilte!");
                    } else 
                    {
                        Console.WriteLine("Dette er ikke et valid svar.\nVennligst svar \"ja\" eller \"nei\"");
                    };
                }
                else
                {
                    if (numberGuess < randomNumber)
                    {
                        Console.WriteLine("For lavt...");
                        CheckIfCorrect(randomNumber);
                        numberGuess = Convert.ToInt16(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("For høyt...");
                        CheckIfCorrect(randomNumber);
                        numberGuess = Convert.ToInt16(Console.ReadLine());
                    }
                }
            }
        }
    }
}