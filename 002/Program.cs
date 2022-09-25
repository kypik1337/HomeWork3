Console.WriteLine("Add x number: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Add y number: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Add x2 number: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Add y2 number: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Add x3 number: ");
int x3 = int.Parse(Console.ReadLine());
Console.WriteLine("Add y3 number: ");
int y3 = int.Parse(Console.ReadLine());

double result = Math.Sqrt (Math.Pow(x2 - x,2) + Math.Pow(y2 - y,2) + Math.Pow(x3 - y3,2));
Console.WriteLine($"result = {result:f1}"); 