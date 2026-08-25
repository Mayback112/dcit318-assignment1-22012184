public class TriangleIdentifier
{
    public string GetTriangleType(double a, double b, double c)
    {
        if (a == b && b == c)
        {
            return "Equilateral";
        }
        else if (a == b || a == c || b == c)
        {
            return "Isosceles";
        }
        else
        {
            return "Scalene";
        }
    }
}
