Console.Write("What was the round trip in miles?");
int milesForRoundTrip = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the miles per gallon of the vehicle?");
int milesPerGallon = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the price per gallon of gas?");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

//do the math

double gallonsNeeded = milesForRoundTrip / (double)milesPerGallon;

double fuelCost = gallonsNeeded * pricePerGallon;

// do the output.
System.Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
System.Console.WriteLine("Fuel Cost: " + fuelCost.ToString("C"));

