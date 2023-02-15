int num = new Random().Next(100, 1000);
int result = num % 100 - num % 10;
Console.WriteLine($"{num} -> {result / 10}");