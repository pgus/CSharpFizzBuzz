// See https://aka.ms/new-console-template for more information

int length = 100;

for (int i = 0; i < length; i++)
{
    static bool is5(int x) => x % 5 == 0;
    static bool is3(int x) => x % 3 == 0;

    string line = i switch
    {
        var x when is5(x) && is3(x) => "FizzBuzz",
        var x when is5(x) => "Fizz",
        var x when is3(x) => "Buzz",
        _ => i.ToString()
    };
    Console.WriteLine(line);
}
Console.WriteLine("End of local function version");



//Alternative solution with Tuple
Console.ReadLine();
Console.Clear();

for (int i = 0; i < length; i++)
{
    string line = (i % 3, i % 5) switch
    {
        (0, 0) => "FizzBuzz",
        (0, _) => "Fizz",
        (_, 0) => "Buzz",
        _ => i.ToString()
    };

    Console.WriteLine(line);
}
Console.WriteLine("End of tuple solution");
