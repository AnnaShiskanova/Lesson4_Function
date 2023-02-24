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

