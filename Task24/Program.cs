// Напишите программу, которая на вход принимает число (А) и выдает сумму чисел от 1 до А
// 7->28
// 4->10
// 8->36

int number = GetNumber();
Console.WriteLine("Sum is {0}", Sum(number));

int GetNumber() 
{
    Console.WriteLine("Input number:");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Sum(int a)
{
    int result = 0;
    for (int i = 1; i <= a; i++)
    {
        Console.Write(i + " ");
        result +=i;
    }
    return result;
}

