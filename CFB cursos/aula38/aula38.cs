using System;

public class Base{
    public Base(){
        Console.WriteLine("Construtor da classe base");
    }
    virtual public void info(){
        Console.WriteLine("Classe Base");
    }
}
public class Derivada1:Base{
    public Derivada1(){
        Console.WriteLine("Construtor da classe derivada 1");
    }
    override public void info(){
        Console.WriteLine("Derivada1");
    }
}
public class Derivada2:Derivada1{
    public Derivada2(){
        Console.WriteLine("Construtor da classe derivada 2");
    }
    override public void info(){
        Console.WriteLine("Derivada2");
    }
}
class Aula37 {
    static void Main(){
        Base Ref;

        Derivada1 derivada1 = new Derivada1();
        Derivada2 derivada2 = new Derivada2();
        Ref = derivada1;
        Ref.info();
        Ref = derivada2;
        Ref.info();

    }
}