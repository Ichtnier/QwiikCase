using System;

public enum TriangleType
{
    Equilateral,
    Isosceles,
    Scalene,
    Invalid
}

public class TriangleClassifier
{
    public static TriangleType ClassifyTriangle(int side1, int side2, int side3)
    {
        if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            return TriangleType.Invalid;

        if (side1 == side2 && side2 == side3)
            return TriangleType.Equilateral;
        else if (side1 == side2 || side1 == side3 || side2 == side3)
            return TriangleType.Isosceles;
        else
            return TriangleType.Scalene;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the lengths of the three sides of the triangle:");

        Console.Write("Side 1: ");
        int side1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Side 2: ");
        int side2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Side 3: ");
        int side3 = Convert.ToInt32(Console.ReadLine());

        TriangleType triangleType = ClassifyTriangle(side1, side2, side3);

        Console.WriteLine("The triangle is: " + triangleType.ToString());
    }
}
