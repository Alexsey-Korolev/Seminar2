Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 100)
{
    Console.WriteLine("Третьей цифры нет.");
}
if(num >= 100)
{
    while(num > 1000)
    {
        num = num / 10;
    }
    if(num < 1000)
    {
        num = num % 10;
    }
    Console.WriteLine(num);    
}
