// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).

// Вариант 1
/*

Console.WriteLine("Введи число: ");

int number = int.Parse(Console.ReadLine()!);

int sqr = number * number;

Console.WriteLine(sqr);

Console.WriteLine($"Квадрат числа {number} = {sqr}");
*/

// Вариант 2
/*

int sqr1 = Convert.ToInt32(Math.Pow(number,2));
Console.WriteLine($"square number {number} = {sqr}");
*/

// Задача 1

/*
Console.Write("enter a number");
int N = int.Parse(Console.ReadLine()!);

int N2 = -N;
while(N2<=N)
{
    Console.Write($"{N2} ");
    N2++;
}
*/

// Задача 2
/*
Console.Write("Enter three-digit number");
int N = int.Parse(Console.ReadLine()!);

int S = N%10;

Console.Write($"Third number {S} ");
*/

// Задача 3
/*
Console.WriteLine("Enter a number");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter a number");
int B = int.Parse(Console.ReadLine()!);

if (A==B/A)
{
    Console.Write("Yes");
} 
else 
{
    Console.Write("No");
}
*/

// Задача 4
/*
Console.WriteLine("Enter numbers");
int P = int.Parse(Console.ReadLine()!);
if (P==1) Console.WriteLine("Monday");
if (P==2) Console.WriteLine("Tuesday");
if (P==3) Console.WriteLine("Wednesday");
if (P==4) Console.WriteLine("Thursday");
if (P==5) Console.WriteLine("Friday");
if (P==6) Console.WriteLine("Saturday");
if (P==7) Console.WriteLine("Sunday");
*/
 //Домашняя работа Задача 2
 /*
 Console.WriteLine("Enter the number");
 int A = int.Parse(Console.ReadLine()!);

 Console.WriteLine("Enter the number");
 int B = int.Parse(Console.ReadLine()!);

 if (A<B)
 {
    Console.Write (A);
 } 
 else

 { Console.Write (B);
 }
 */

 // Задача 4
 /*
 Console.WriteLine("Enter the number");
 int A = int.Parse(Console.ReadLine()!);

 Console.WriteLine("Enter the number");
 int B = int.Parse(Console.ReadLine()!);

 Console.WriteLine("Enter the number");
 int C = int.Parse(Console.ReadLine()!);

 int max = A;
if (B>max)
{
    max = B;
}
 if (max<C)
 {
    max = C;
 }
 Console.WriteLine($"Maximum number={max} ");
*/
 //Задача 6
/*
 Console.WriteLine("Enter a number");
 int a = int.Parse(Console.ReadLine()!);
 
 if (a%2==0)
 {
    Console.Write("Even number");
 }
 else
 {
    Console.Write("Odd number");
 }
 */
 // Задача 8
 /*
Console.WriteLine("Enter a number");
 int N = int.Parse(Console.ReadLine()!);

 int i = 1;
 while (i<=N)
 {
    if (i%2==0)
    {
        Console.Write($"{i} ");
    }
    i++;
 
 }
*/


 
    



 

 
 