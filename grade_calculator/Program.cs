GradeCalculator calculator = new GradeCalculator();

bool running = true;

while (running)
{
    double grade = 0;
    bool isValidNumber = false;

    while (!isValidNumber)
    {
        Console.Write("Enter a numerical grade (0-100): ");

        string? input = Console.ReadLine();

        if (double.TryParse(input, out grade))
        {
            if (grade >= 0 && grade <= 100)
            {
                isValidNumber = true;
            }
            else
            {
                Console.WriteLine("Error: Grade must be between 0 and 100. Please try again.");
            }
        }
        else
        {
            Console.WriteLine("Error: please enter a valid number. Try again.");
        }
    }

    string letter = calculator.GetLetterGrade(grade);

    Console.WriteLine("Your grade is: " + letter);

    Console.Write("Do you want to enter another grade? (yes/no): ");
    string? again = Console.ReadLine();

    if (again != "yes")
    {
        running = false;
        Console.WriteLine("Goodbye!");
    }
}
