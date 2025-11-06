using System.Collections;
Console.WriteLine("Enter two numbers");
int a = int.Parse(Console.ReadLine() ?? "0");
int b = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Enter a for addition, s for subtraktion, m for multiplication and d for diviosn");
char rechen = char.Parse(Console.ReadLine() ?? "0");
int result;
switch (rechen)
{

        case 'a':
                result = a + b;
                Console.WriteLine(result);
                break;
        case 's':
                result = a - b;
                Console.WriteLine(result);
                break;
        case 'm':
                result = a * b;
                Console.WriteLine(result);
                break;
        case 'd':
                result = a / b;
                Console.WriteLine(result);
                break;

}

Console.WriteLine("Bitte geben Sie Ihren Noten ein, die Durchschnitt zu finden");
double first = double.Parse(Console.ReadLine() ?? "0");
double second = double.Parse(Console.ReadLine() ?? "0");
double third = double.Parse(Console.ReadLine() ?? "0");

double ergibness = (first + second + third) / 3;

if (ergibness >=4)
{
        Console.WriteLine("Bestanden");
}
else if (ergibness<4)
{
        Console.WriteLine("Nicht Bestanden");
}

else
{
        Console.WriteLine("Etwas Anderes");
}