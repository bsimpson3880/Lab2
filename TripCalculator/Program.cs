using System.Data.SqlTypes;
using System.Reflection.Metadata;
using System.Security;
System.Console.WriteLine();
System.Console.WriteLine("=== Part 1: Road Trip ===");

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

System.Console.WriteLine();
System.Console.WriteLine("=== Part 2: Pizza Party ===");

Console.Write("How many people are going to the pizza party?");
int peopleGoing = Convert.ToInt32(Console.ReadLine());

Console.Write("How many pizzas do we need?");
int numberOfPizzas = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the price per pizza?");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

const double slicesPerPizza = 8;

//do the math

double totalSlices = numberOfPizzas * slicesPerPizza;

double slicesPerPerson = totalSlices / peopleGoing;

double pizzaCost = numberOfPizzas * pricePerPizza;

// do the output.
System.Console.WriteLine("Total Slices: " + totalSlices);
System.Console.WriteLine("Slices Per Person: " + slicesPerPerson);
System.Console.WriteLine("Cost of Pizzas: " + pizzaCost.ToString("C"));

System.Console.WriteLine();
System.Console.WriteLine("=== Part 3: The Paycheck ===");

Console.Write("What are the hours worked this week?");
double hoursWorked = Convert.ToInt32(Console.ReadLine());

Console.Write("What is your hourly rate of pay?");
double hourlyRateOfPay = Convert.ToDouble(Console.ReadLine());

const double taxRate = 0.18;

//do the math

double grossPay = hoursWorked * hourlyRateOfPay;

double taxWithheld = grossPay * taxRate;

double takeHomePay = grossPay - taxWithheld;

//do the output.
System.Console.WriteLine("Gross Pay: " + grossPay.ToString("C"));
System.Console.WriteLine("Tax Withheld: " + taxWithheld.ToString("C"));
System.Console.WriteLine("Money You Take Home: " + takeHomePay.ToString("C"));

double tripTotal = fuelCost + pizzaCost;

double costPerPerson = tripTotal / peopleGoing;

double takeHomePayPerHour = takeHomePay / hoursWorked;

double hoursYouMustWork = costPerPerson / takeHomePayPerHour;

//do the output.
System.Console.WriteLine();
System.Console.WriteLine("=== Part 4: The Whole Trip ===");
System.Console.WriteLine("Trip Total: " + tripTotal.ToString("C"));
System.Console.WriteLine("Cost Per Person: " + costPerPerson.ToString("C"));
System.Console.WriteLine("Take Home Pay Per Hour: " + takeHomePayPerHour.ToString("C"));
System.Console.WriteLine("Hours You Must Work: " + hoursYouMustWork.ToString("F2"));

System.Console.WriteLine();
System.Console.WriteLine("=== Part 1: Road Trip ===");
