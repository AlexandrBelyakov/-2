﻿Console.WriteLine("Введите переменную");
int quater = int.Parse(Console.ReadLine());

switch (quater)
{
    case 1:{
        Console.WriteLine ("x>0 y>0");
        break;
    }
    case 2:{
        Console.WriteLine ("x<0 y>0");
        break;
    }
    case 3:{
        Console.WriteLine ("x<0 y<0");
        break;
    }
    case 4:{
        Console.WriteLine ("x>0 y<0");
        break;
    }
    default:{
        Console.WriteLine("Введена неправильная четверть");
        break;
    }

}
// 