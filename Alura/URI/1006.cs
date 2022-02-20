using System;

class URI{
    static void Main(string[] args){
        float a, b, c;

        a = float.Parse(Console.ReadLine());
        b = float.Parse(Console.ReadLine());
        c = float.Parse(Console.ReadLine());

        double prod = (a*2 + b*3 + c*5) / 10;

        Console.WriteLine("MEDIA = "+ prod.ToString("F1"));
    }
}