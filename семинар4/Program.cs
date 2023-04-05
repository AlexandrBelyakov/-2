// int GetSum(int n){
//     int sum = 0;
//     for (int i = 1; i <=n; i++) 
//         sum += i;
//     return sum;
// }


// Console.Clear();
// Console.Write("Введите число:  ");
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine($"Ссумма от 1 до {n} равна {GetSum(n)}");


// int CountNumbers(int n)
// {
//     int count = 0;
//     while (n > 0)
//     {
//         n /= 10;
//         count++;
//     }
//    return count;
// }


// Console.Clear();
// Console.Write("Введите число:  ");
// int s = int.Parse(Console.ReadLine());
// Console.WriteLine($"Колличество цифр = {CountNumbers(s)}");

// int GetMultiply(int n)
// {
//     int result = 1;
//     for(int i = 2; i <= n; i++)
//     {
//         result *= i;
//     }
//     return result;
// }



// Задача 25

// Console.Write("Введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int c = 1;
// if (b<1)
// Console.Write("Число B должно быть натуральным\n");
// else
// {
// while (b!=0)
// {
// c = c * a;
// b = b - 1;
// }
// Console.Write($"Число A в натуральной степени B равно {c}");
// }


// Задача 27

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int len = Length(a);
// Console.Write($"Сумма цифр в числе {a} равно: {Sum(a,len)}");

// // Подсчет количества символов в числе
// int Length(int a)
// {
// int index = 0;
// while (a > 0)
// {
// a /= 10;
// index++;
// }
// return index;
// }

// int Sum(int a, int len)
// {
// int sum = 0;
// for (int i = 1; i <= len; i++)
// {
// sum += a % 10;
// a /= 10;
// }
// return sum;
// }



// // Задача 29
// int[] randomArray = new int[8];

// for (int i = 0; i < 8; i++)
// {
// randomArray[i] = new Random().Next(1,99);
// Console.Write(randomArray[i] +  "");
// }
// 