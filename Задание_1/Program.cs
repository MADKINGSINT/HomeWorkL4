// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16
Console.Write("введите число A:  ");
int A =Convert.ToInt32(Console.ReadLine());
Console.Write("введите число B:  ");
int B =Convert.ToInt32(Console.ReadLine());

void GetStepen()
{
   double result = Math.Pow(Convert.ToDouble(A), Convert.ToDouble(B));
    Console.WriteLine(result);
}
GetStepen();