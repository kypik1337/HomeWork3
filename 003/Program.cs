Console.WriteLine("add N number");
int num = int.Parse(Console.ReadLine());
for(int Nik = 1; Nik <= num; Nik++ )
    {
        int result = (int)Math.Pow(Nik,3);
        Console.WriteLine($"your number: {result}");
    }