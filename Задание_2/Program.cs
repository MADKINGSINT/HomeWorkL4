// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12



Console.Write("введите число:    ");
 string WritedNumber = (Console.ReadLine());

 int a = int.Parse(WritedNumber);
            int sum = 0;
            while (a > 0)
            {
 
                sum = sum + a % 10;
                a = a /10 ;
 
            }
 Console.WriteLine(sum);