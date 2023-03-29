Console.Clear();
int num = new Random().Next(10, 2000);
int result2 = (num / 100 ) ;
int num2 = num;

    if (result2 != 0)
    {
        while(num2 > 1000)
        {
            num2 = num2 /10;
            
        }
        

        Console.WriteLine($"{num} -> {(num2 % 100) %10}");

    }
    else 
    {
    Console.WriteLine($"{num} Третьего числа нет");
    }