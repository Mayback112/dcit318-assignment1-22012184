namespace TicketPriceCalculator;

public static class TicketCalculator
{
    public const int RegularPrice = 10;
    public const int DiscountPrice = 7;

    public static bool IsValidAge(string input, out int age)
    {
        if (!int.TryParse(input, out age))
        {
            return false;
        }

        if (age < 0)
        {
            return false;
        }

        return true;
    }

    public static int CalculatePrice(int age)
    {
        if (age <= 12 || age >= 65)
        {
            return DiscountPrice;
        }

        return RegularPrice;
    }
}
