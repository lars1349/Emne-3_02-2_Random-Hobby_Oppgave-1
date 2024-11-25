namespace _2_2_Random_Hobby_Oppgave_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random arbitrary = new Random();
            while (true)
            {
                var RandomChoice = arbitrary.Next(0, 5);

                Console.WriteLine("What's your name?");
                string name = Console.ReadLine();

                Console.WriteLine($"Excellent {name}! Your new hobby is now: ");

                if (RandomChoice == 0)
                    Console.WriteLine("Fishing");
                else if (RandomChoice == 1)
                    Console.WriteLine("Influencer");
                else if (RandomChoice == 2)
                    Console.WriteLine("Basejumping");
                else if (RandomChoice == 3)
                    Console.WriteLine("Formula 1 Driver");
                else if (RandomChoice == 4)
                    Console.WriteLine("Beer Brewing");
            }
        }
    }
}
