Console.Clear();
Console.Write("Введите Х: ");
int X = int.Parse(Console.ReadLine());

Console.Write("Введите Y: ");
int Y = int.Parse(Console.ReadLine());

if(X > 0 && Y > 0){
    Console.Write("1");
}else if(X < 0 && Y > 0){
    Console.Write("2");
}else if(X < 0 && Y < 0){
    Console.Write("3");
}else if(X > 0 && Y < 0){
    Console.Write("4");
}else if(X == 0 && Y == 0)
    Console.WriteLine("На оси");