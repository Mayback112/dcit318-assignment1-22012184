using System;

TriangleIdentifier identifier = new TriangleIdentifier();

bool running = true;

while (running)
{
    double sideA = 0;
    double sideB = 0;
    double sideC = 0;

    bool validA = false;
    while (!validA)
    {
        Console.Write("Enter the length of side A: ");
        string? inputA = Console.ReadLine();

        if (double.TryParse(inputA, out sideA))
        {
            if (sideA > 0)
            {
                validA = true;
            }
            else
            {
                Console.WriteLine("Error: a side length must be greater than 0. Please try again.");
            }
        }
        else
        {
            Console.WriteLine("Error: please enter a valid number. Try again.");
        }
    }

    bool validB = false;
    while (!validB)
    {
        Console.Write("Enter the length of side B: ");
        string? inputB = Console.ReadLine();

        if (double.TryParse(inputB, out sideB))
        {
            if (sideB > 0)
            {
                validB = true;
            }
            else
            {
                Console.WriteLine("Error: a side length must be greater than 0. Please try again.");
            }
        }
        else
        {
            Console.WriteLine("Error: please enter a valid number. Try again.");
        }
    }

    bool validC = false;
    while (!validC)
    {
        Console.Write("Enter the length of side C: ");
        string? inputC = Console.ReadLine();

        if (double.TryParse(inputC, out sideC))
        {
            if (sideC > 0)
            {
                validC = true;
            }
            else
            {
                Console.WriteLine("Error: a side length must be greater than 0. Please try again.");
            }
        }
        else
        {
            Console.WriteLine("Error: please enter a valid number. Try again.");
        }
    }

    string triangleType = identifier.GetTriangleType(sideA, sideB, sideC);

    Console.WriteLine("This is a " + triangleType + " triangle.");

    Console.Write("Would you like to check another triangle? (yes/no): ");
    string? again = Console.ReadLine();

    if (again != "yes")
    {
        running = false;
        Console.WriteLine("Goodbye!");
    }
}
