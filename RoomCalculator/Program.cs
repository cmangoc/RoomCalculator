Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
Console.WriteLine();

//Takes all inputs and converts to doubles
Console.WriteLine("Enter Length: ");
double length = double.Parse(Console.ReadLine());
Console.WriteLine("Enter Width: ");
double width = double.Parse(Console.ReadLine());
Console.WriteLine("Enter Height: ");
double height = double.Parse(Console.ReadLine());
Console.WriteLine();

//all calculations are handled
double area = length * width;
double perimeter = 2 * (length + width);
double volume = area * height;
double sArea = 2 * (length * width) + 2 * (width * height) + 2 * (length * height);

//answers are provided
Console.WriteLine($"Area: {area}");
Console.WriteLine($"Perimeter: {perimeter}");
Console.WriteLine($"Volume: {volume}");
Console.WriteLine($"Surface Area: {sArea}");
Console.WriteLine();

//finds what group of room is
if(area <= 250) 
{
    Console.WriteLine("This is a small-sized room.");
}
else if(area < 650)
{
    Console.WriteLine("This is a medium-sized room.");
}
else
{
    Console.WriteLine("This is a large-sized room.");
}
Console.WriteLine();

Console.WriteLine("Thank you for using the Room Detail Generator!");