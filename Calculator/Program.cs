//debugging next

float num1 = 0;
float num2 = 0;


//title screen
Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("-----------------");


//prompts first number
Console.WriteLine("Type first number of calculation, then press enter");
num1 = Convert.ToInt32(Console.ReadLine());

//second number
Console.WriteLine("Type second number of calculation, then press enter");
num1 = Convert.ToInt32(Console.ReadLine());

//user chooses type of calculation
Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.Write("Your option?");

//switch statment to hold math

switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
        break;
    case "s":
        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
        break;
    case "m":
        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
        break;
    case "d":
        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
        break;
}

Console.Write("Press any key to close the Calculator console app...");
Console.ReadKey();
// Declare variables and then initialize to zero.

