Console.Clear();
Console.WriteLine("1 - Напишите цикл, который на вход принимает два числа (А и В) и возводит число А в натуральную степень В. ");
Console.WriteLine("2 - Напишите программу, которая принимает на вход число и выдает сумму цифр в числе");
Console.WriteLine("3 - напишите программу, которая задает массив из 8 элементов и выводит их на экран");
int NumberOfTask = Prompt("Введите номер задачи");
switch(NumberOfTask)
{
    case 1:
    Console.Clear();
    Task25();
    break;

    case 2:
    Console.Clear();
    Task27();
    break;

    case 3:
    Console.Clear();
    Task29();
    break;

    default:
    Console.WriteLine("Номер задачи введен неверно");
    break;
    
}

static int Prompt(string massage)//метод запроса числа
{
    Console.WriteLine(massage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}





static void Task25()
{   
/*Напишите цикл, который на вход принимает два числа (А и В) и 
возводит число А в натуральную степень В. К натуральным не относятся отрицательные числа, дроби и ноль.
*/
    Console.WriteLine("Input number a");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number b");
    int b = Convert.ToInt32(Console.ReadLine());
    if (b > 0)
    {Pow(a, b);
    Console.WriteLine($"{a}^{b}={Pow(a, b)}");
    }
    else
         Console.WriteLine("Number b isn't natural");

    static int Pow(int a, int b)
    {
        int result = a;
        for (int i = 1; i < b; i++)
        {
            result *= a; 
        }
        return result;        
    }
     
    Pow(a, b);
}

Task25();

static void Task27()
{ 
    // Напишите программу, которая принимает на вход число и выдает сумму цифр в числе
    // 452->11
    // 82->10
    // 9012->12
    
    int number = GetNumber();
    Console.WriteLine($"The sum of digits in a number {number} is ", Sum_digits);
    int GetNumber() 
    {
    Console.WriteLine("Input number:");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
    }
    

    int Sum_digits()
    {
        string y = Convert.ToString(number);
        int[] arr = new int[y.Length];
        int Sum = 0;
        for (int i = 0; i <y.Length; i++)
        {
                     
            Sum += y[i];
           
        }
        Console.WriteLine($"{Sum}");
        return Sum;
         
    }
   
    Sum_digits();

}
Task27();


static void Task29()
{
    
    // напишите программу, которая задает массив из 8 элементов
    //и выводит их на экран
    // 1,2,5,7.19->[1,2,5,7,19]
    int[] GetArray()
    {
        int[] arr = new int[8];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(8);
            
        }
        Console.WriteLine($"Array result is {String.Join("|", arr)}");
    return arr;
    }
    GetArray();
    
}
Task29();