int ReadInt(string message) 
{
    Console.Write($"{message} >"); 
    int value = Convert.ToInt32(Console.ReadLine()); 
    return value;
}

int num = ReadInt("Сегодня рабочий день? Ввидите его цифру от 1 до 7: ");


if(num <=5){
Console.WriteLine($"Да");
} 
    else if(num >5)
    {
    Console.WriteLine($"Нет");
    }
    // 