using System;
class TriangleTypeIdentifier
{
 static void Main()
 {
 while (true)
 {
 Console.WriteLine("Enter the lengths of three sides of a triangle (or enter -1 to exit):");
 Console.Write("Side 1: ");
 double side1 = double.Parse(Console.ReadLine());
 if (side1 == -1)
 {
 break;
 
}
 Console.Write("Side 2: ");
 double side2 = double.Parse(Console.ReadLine());
 Console.Write("Side 3: ");
 double side3 = double.Parse(Console.ReadLine());
 string triangleType;
 if (side1 == side2 && side2 == side3)
 {
 triangleType = "Equilateral";
 }
 else if (side1 == side2 || side1 == side3 || side2 == side3)
 {
 triangleType = "Isosceles";
 }
 else
 {
 triangleType = "Scalene";
 }
 Console.WriteLine($"The triangle is: {triangleType}\n");
 }
 }
}