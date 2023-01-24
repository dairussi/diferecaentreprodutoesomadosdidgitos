using System;

class Program
{

    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        int p = 1, s = 0;
        while (n > 0)
        {
            int l = n % 10;
            s = s + l;
            p = p * l;
            n = n / 10;
        }

        Console.WriteLine(p - s);
    }
}
