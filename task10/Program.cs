Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
while(num > 100)
{
    num = num / 10;
}
if (num < 100)
{
    num = num % 10;
}
Console.WriteLine(num);