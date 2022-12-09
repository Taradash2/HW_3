Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
string n = Console.ReadLine();
int x = n.Length;

if (x == 5)
{
    if (n[0] == n[4] && n[1] == n[3])
    {
        Console.WriteLine($"{n} Полидром");
    }
    else 
    {
        Console.WriteLine($"{n} Не полидром");
    }

}
else
{
    Console.WriteLine($"{n} Не пятизначное число ");
}