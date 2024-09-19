// See https://aka.ms/new-console-template for more information

string input = "123";
try
{
    int result = Int32.Parse(input);
    Console.WriteLine(result);
}
catch(FormatException) 
{
    Console.WriteLine($"Unable to parse {input}");
}
try
{
    if (input is float)
    {
        Console.WriteLine("True");
    }
    else
    {
        Console.WriteLine("False");
    }
}
catch 
{
    return;
}

float vystup;
Console.WriteLine("Napište první čislo");
float jedna = float.Parse(Console.ReadLine());
Console.WriteLine("Napište druhé čislo");
float dva = float.Parse(Console.ReadLine());
vystup = jedna + dva;
Console.WriteLine(vystup);  
