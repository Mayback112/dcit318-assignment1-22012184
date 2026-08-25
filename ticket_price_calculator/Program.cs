using TicketPriceCalculator;

do
{
    int age;

    while (true)
    {
        Console.Write("Please enter your age: ");
        string input = Console.ReadLine()!;

        if (!TicketCalculator.IsValidAge(input, out age))
        {
            Console.WriteLine("That is not a valid age. Please enter a realistic, non-negative number.");
            continue;
        }

        break;
    }

    int ticketPrice = TicketCalculator.CalculatePrice(age);

    Console.WriteLine("Your ticket price is: GHC" + ticketPrice);

    Console.Write("Would you like to calculate another ticket price? (yes/no): ");
    string? answer = Console.ReadLine();

    if (answer == null || answer.Trim().ToLower() != "yes")
    {
        break;
    }

} while (true);

Console.WriteLine("Thank you for using the ticket calculator!");
