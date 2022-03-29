using System;

class Veiculo{//classe base
    public int velAtual;
    private int velMax;
    protected bool ligado;

    public Veiculo(int velMax){
        velAtual = 0;
        this.velMax = velMax;
        ligado = false;
    }
    public bool getLigado(){
        return ligado;
    }
    public int getvelMax(){
        return velMax;
    }
}

class Carro:Veiculo{
    public string nome;
    public Carro(string nome, int velMax):base(velMax){
        this.nome = nome;
        ligado = true;
    }
}

class Aula36{
    static void Main(){
        Carro carro = new Carro("Fusca", 80);

        Console.WriteLine("Carro: {0}", carro.nome);
        Console.WriteLine("Velocidade máxima: {0}", carro.getvelMax());
        Console.WriteLine("Velocidade atual: {0}", carro.velAtual);
        Console.WriteLine("Ligado: {0}", carro.getLigado());
    }
}