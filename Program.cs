//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("imput first number");
int First_num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("imput second number");
int Second_num = Convert.ToInt32(Console.ReadLine());
if (First_num > Second_num)
{
Console.WriteLine($"max= {First_num}, min = {Second_num}");
}
else
{
Console.WriteLine($"max= {Second_num}, min = {First_num}");
}

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("imput first number");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("imput second number");
int second = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("imput third number");
int third = Convert.ToInt32(Console.ReadLine());
        

            if (first > second)
            {
                if (first > third)
                {
                    Console.WriteLine("{0} - наибольшее число", first);
                }
                else
                {
                    Console.WriteLine("{0} - наибольшее число", third);
                }
            }
            else
            {
                if (second > third)
                {
                    Console.WriteLine("{0} - наибольшее число", second);
                }
                else
                {
                    Console.WriteLine("{0} - наибольшее число", third);
                }
            }
        
    
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("imput your number");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine("Число чётное"); 
}
else
    {
    Console.WriteLine("Число нечётное");
    }

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("imput your number");
int num8 = Convert.ToInt32(Console.ReadLine());
int num1 = 1;
while (num1 < num8)
{
    if (num1 % 2 == 0)
    {
        Console.Write($"{num1},");
    }
num1 = num1 + 1;
}
