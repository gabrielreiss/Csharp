using System;

class URI{
    static void Main(string[] args){
        float a, b;

        a = float.Parse(Console.ReadLine());
        b = float.Parse(Console.ReadLine());

        double prod = (a*3.5 + b*7.5) / 11;

        Console.WriteLine("MEDIA = "+ prod.ToString("F5"));
    }
}