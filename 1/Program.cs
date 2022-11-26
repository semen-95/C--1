Console.WriteLine("Введите 2 числа и я великодушно скажу какое больше, а какое меньше");
int a, b;
Console.WriteLine("Ведите первое число");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите второе число");
b = Convert.ToInt32(Console.ReadLine());

bool dano0 = a > b;
bool dano1 = a == b;
bool dano2 = a < b;

if (dano0)
{
    Console.WriteLine($"Число а больше b");
}
else if (dano1)
{
    Console.WriteLine($"Число a равно b");
}
if (dano2)
{
    Console.WriteLine($"число а меньше b");
}