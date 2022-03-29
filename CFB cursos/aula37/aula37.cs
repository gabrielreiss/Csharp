using System;

public class Base{
    public Base(){
        Console.WriteLine("Construtor da classe base");
    }
}
public class Derivada1:Base{
    public Derivada1(){
        Console.WriteLine("Construtor da classe derivada 1");
    }
}
public class Derivada2:Derivada1{
    public Derivada2(){
        Console.WriteLine("Construtor da classe derivada 2");
    }
}
class Aula37 {
    static void Main(){
        Derivada2 derivada2 = new Derivada2();
    }
}