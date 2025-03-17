
while (true)
{

    Console.WriteLine("Type ROCK, PAPER or SCISSORS:");
    String input = Console.ReadLine();
    if (Enum.TryParse(input, out RPS enumValue))
    {
        Random random = new Random();
        RPS rPS = (RPS)random.Next(0, 3);
        Console.WriteLine("Computer chose " + rPS.ToString());

        if (rPS == enumValue)
        {
            Console.WriteLine("Game Draw");
        }
        else if (rPS == enumValue + 1 || rPS == enumValue - 2)
        {
            Console.WriteLine("Computer Wins");
        }
        else
        {
            Console.WriteLine("You Win!");
        }
    }
    else
    {
        Console.WriteLine("Invalid Input!!!");
    }

    Console.WriteLine("DO you want to plat again(Y/N)");
    string choice = Console.ReadLine();
    if (choice != "Y") break;
}

enum RPS
{
    ROCK, PAPER, SCISSORS
} 
